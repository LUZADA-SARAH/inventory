using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORYSYSTEM_GROUP2
{
    public partial class PURCHASE : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Sarah Luzada\\Music\\HA\\inventory-main\\INVENTORYSYSTEM_GROUP2\\INVENTORYSYSTEM_GROUP2\\InventoryDB.mdf\";Integrated Security=True";
        private string transactionId;

        public PURCHASE()
        {
            InitializeComponent();
        }

        private void PURCHASE_Load(object sender, EventArgs e)
        {
            GenerateNewTransactionId();
            LoadProductsToListView();

            // category ComboBox
            cb_category.Items.Add("ALL");
            cb_category.Items.Add("CPU");
            cb_category.Items.Add("GPU");
            cb_category.Items.Add("MOTHERBOARD");
            cb_category.Items.Add("RAM");

            // sort ComboBox
            cb_sort.Items.Add("ID");
            cb_sort.Items.Add("STOCK");
            cb_sort.Items.Add("PRODUCT NAME");
            cb_sort.Items.Add("PRICE");

            cb_category.SelectedIndex = 0;  
            cb_sort.SelectedIndex = 0;      

            cb_category.SelectedIndexChanged += cb_category_SelectedIndexChanged;
            cb_sort.SelectedIndexChanged += cb_sort_SelectedIndexChanged;
            btn_search.Click += btn_search_Click;

            // ListView 
            lv_products.View = View.Details;
            lv_products.FullRowSelect = true;
            lv_products.Columns.Add("ID", 50);
            lv_products.Columns.Add("Product Name", 150);
            lv_products.Columns.Add("Category", 100);
            lv_products.Columns.Add("Stock", 50);
            lv_products.Columns.Add("Price", 100);

            lv_products.SelectedIndexChanged += lv_products_SelectedIndexChanged;
            InitializeTransactionDataGridView();  

            dgv_transaction.DefaultCellStyle.Font = new Font("Perpetua Titling MT", 10.2f, FontStyle.Bold);
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cb_category.SelectedItem.ToString();
            LoadProductsToListView(selectedCategory);  // Pass the selected category to filter products
        }

        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortBy = cb_sort.SelectedItem.ToString();
            LoadProductsToListView(sortBy);  
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void GenerateNewTransactionId()
        {
            transactionId = Guid.NewGuid().ToString();
        }

        private void LoadProductsToListView(string filterCategory = "ALL", string sortBy = "ID", string searchTerm = "")
        {
            lv_products.Items.Clear();

            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT Id, Name, Category, Stock, Price FROM Products";

                    if (filterCategory != "ALL")
                    {
                        query += " WHERE Category = @Category";
                    }

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += string.IsNullOrEmpty(filterCategory) || filterCategory == "ALL"
                            ? " WHERE Name LIKE @SearchTerm"
                            : " AND Name LIKE @SearchTerm";
                    }

                    query += " ORDER BY " + sortBy;

                    SqlCommand command = new SqlCommand(query, connection);

                    if (filterCategory != "ALL")
                    {
                        command.Parameters.AddWithValue("@Category", filterCategory);
                    }

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Category"].ToString());
                        item.SubItems.Add(reader["Stock"].ToString());
                        item.SubItems.Add(Convert.ToDecimal(reader["Price"]).ToString("₱0.00"));
                        lv_products.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading products: {ex.Message}");
                }
            }
        }


        private int selectedProductId;

        private void lv_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                var selectedItem = lv_products.SelectedItems[0];
                selectedProductId = int.Parse(selectedItem.SubItems[0].Text); // Product ID
                tb_prodname.Text = selectedItem.SubItems[1].Text;            // Product Name
                textbox_category.Text = selectedItem.SubItems[2].Text;       // Category
                tb_price.Text = selectedItem.SubItems[4].Text;               // Price 
            }
            else
            {
                ClearInputs(); 
            }

            tb_units.Enabled = true; 

        }

        private void SetupTransactionDataGridView()
        {
            dgv_transaction.Columns.Add("ProductName", "Product Name");
            dgv_transaction.Columns.Add("Category", "Category");
            dgv_transaction.Columns.Add("Units", "Units");
            dgv_transaction.Columns.Add("Price", "Price");
            dgv_transaction.Columns.Add("TotalPrice", "Total Price");
        }

        private void ClearInputs()
        {
            tb_prodname.Text = string.Empty;
            textbox_category.Text = string.Empty;
            cb_category.SelectedIndex = 0; 
            tb_price.Text = string.Empty;
            tb_units.Text = string.Empty;
        }


        private void SaveTransactionToDatabase()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    using (var sqlTransaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string identityInsertOn = "SET IDENTITY_INSERT Transactions ON;";
                            using (SqlCommand cmd = new SqlCommand(identityInsertOn, connection, sqlTransaction))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Identity enabled successfully.");

                            foreach (DataGridViewRow row in dgv_transaction.Rows)
                            {
                                if (row.IsNewRow) continue;

                                int transactionId = int.Parse(row.Cells["TransactionId"].Value.ToString());
                                int productId = int.Parse(row.Cells["ProductId"].Value.ToString());
                                int units = int.Parse(row.Cells["Units"].Value.ToString());
                                decimal totalPrice = decimal.Parse(row.Cells["TotalPrice"].Value.ToString());

                                string insertQuery = @"INSERT INTO Transactions (TransactionId, ProductId, Units, TotalPrice, TransactionDate)
                                               VALUES (@TransactionId, @ProductId, @Units, @TotalPrice, @TransactionDate)";

                                using (SqlCommand cmd = new SqlCommand(insertQuery, connection, sqlTransaction))
                                {
                                    cmd.Parameters.AddWithValue("@TransactionId", transactionId);
                                    cmd.Parameters.AddWithValue("@ProductId", productId);
                                    cmd.Parameters.AddWithValue("@Units", units);
                                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                                    cmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            string identityInsertOff = "SET IDENTITY_INSERT Transactions OFF;";
                            using (SqlCommand cmd = new SqlCommand(identityInsertOff, connection, sqlTransaction))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            sqlTransaction.Commit();
                            MessageBox.Show("Transaction saved successfully.");
                        }
                        catch (Exception ex)
                        {
                            sqlTransaction.Rollback();
                            MessageBox.Show($"Error saving transaction: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening connection: {ex.Message}");
                }
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchTerm = tb_search.Text.Trim();
            string selectedCategory = cb_category.SelectedItem.ToString();
            string sortBy = cb_sort.SelectedItem.ToString();

            LoadProductsToListView(selectedCategory, sortBy, searchTerm);  
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_prodname.Text) || string.IsNullOrEmpty(tb_units.Text) || string.IsNullOrEmpty(tb_price.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int units;
            if (!int.TryParse(tb_units.Text, out units) || units <= 0)
            {
                MessageBox.Show("Please enter a valid number of units.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(tb_price.Text.Trim('₱'), out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            decimal totalPrice = units * price;

            dgv_transaction.Rows.Add(
                selectedProductId,          // Product ID (hidden column)
                tb_prodname.Text,           // Product Name
                units,                      // Units
                price.ToString("₱0.00"),    // Price 
                totalPrice.ToString("₱0.00") // Total Price 
            );

            SaveTransactionToDatabase(selectedProductId, units, totalPrice);

            RecalculateGrandTotal();

            ClearInputs();
        }


        private void SaveTransactionToDatabase(int productId, int units, decimal totalPrice)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string insertQuery = @"INSERT INTO Transactions (TransactionId, ProductId, Units, TotalPrice, TransactionDate)
                                   VALUES (@TransactionId, @ProductId, @Units, @TotalPrice, @TransactionDate)";

                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@TransactionId", transactionId);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@Units", units);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving transaction: {ex.Message}");
                }
            }
        }

        private void RecalculateGrandTotal()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgv_transaction.Rows)
            {
                if (row.IsNewRow) continue;

                totalAmount += decimal.Parse(row.Cells["TotalPrice"].Value.ToString().Trim('₱').Replace(",", ""));
            }

            tb_grandtotal.Text = "₱" + totalAmount.ToString("N2");

            decimal amountPaid = 0;
            if (decimal.TryParse(tb_amount.Text.Trim('₱').Replace(",", "").Trim(), out amountPaid))
            {
                UpdateChange(amountPaid, totalAmount);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)

        {
            if (dgv_transaction.SelectedRows.Count > 0)
            {
                dgv_transaction.Rows.RemoveAt(dgv_transaction.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }
        }

        private void InitializeDataGridView()
        {
            dgv_transaction.Columns.Clear();

            dgv_transaction.Columns.Add("productName", "Product Name");
            dgv_transaction.Columns.Add("category", "Category");
            dgv_transaction.Columns.Add("stock", "Stock");
            dgv_transaction.Columns.Add("price", "Price");
            dgv_transaction.Columns.Add("totalPrice", "Total Price");

            dgv_transaction.Columns[0].Width = 150;
            dgv_transaction.Columns[1].Width = 120;
            dgv_transaction.Columns[2].Width = 80;
            dgv_transaction.Columns[3].Width = 100;
            dgv_transaction.Columns[4].Width = 100;
        }


        private void dgv_transaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeTransactionDataGridView()
        {
            dgv_transaction.Columns.Clear(); 

            dgv_transaction.Columns.Add("ProductId", "Product ID");      // Hidden Column
            dgv_transaction.Columns.Add("ProductName", "Product Name");  // Product Name
            dgv_transaction.Columns.Add("Units", "Units");               // Units
            dgv_transaction.Columns.Add("Price", "Price");               // Price
            dgv_transaction.Columns.Add("TotalPrice", "Total Price");    // Total Price

            dgv_transaction.Columns["ProductId"].Visible = false;
        }


        private void tb_units_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_category_TextChanged(object sender, EventArgs e)
        {

        }

        private void lv_products_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tb_prodname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_increment_Click(object sender, EventArgs e)
        {
            int units;
            if (int.TryParse(tb_units.Text, out units))
            {
                int stock = 10;  

                if (units < stock)
                {
                    tb_units.Text = (units + 1).ToString();
                }
                else
                {
                    MessageBox.Show("You cannot exceed the available stock.");
                }
            }
            else
            {
                tb_units.Text = "1"; 
            }
        }

        private void btn_decrement_Click(object sender, EventArgs e)
        {
            int units;
            if (int.TryParse(tb_units.Text, out units))
            {
                if (units > 1)
                {
                    tb_units.Text = (units - 1).ToString();
                }
            }
            else
            {
                tb_units.Text = "1";
            }
        }



        private void tb_amount_TextChanged(object sender, EventArgs e)
        {
            string cleanedAmount = tb_amount.Text.Trim('₱').Replace(",", "").Trim();

            decimal amountPaid;
            decimal grandTotal;

            bool isAmountValid = decimal.TryParse(cleanedAmount, out amountPaid);
            bool isGrandTotalValid = decimal.TryParse(tb_grandtotal.Text.Trim('₱').Replace(",", "").Trim(), out grandTotal);

            if (!isAmountValid)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (!isGrandTotalValid)
            {
                MessageBox.Show("Grand total is not valid.");
                return;
            }

            if (amountPaid < grandTotal)
            {
                MessageBox.Show("Amount cannot be less than the Grand Total.");
                tb_amount.Text = "₱" + grandTotal.ToString("N2"); 
            }
            else
            {
                UpdateChange(amountPaid, grandTotal);
            }
        }

        private void UpdateChange(decimal amountPaid, decimal grandTotal)
        {
            decimal change = amountPaid - grandTotal;
            tb_change.Text = "₱" + change.ToString("N2");
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_prodname.Text) || string.IsNullOrEmpty(cb_category.Text) || string.IsNullOrEmpty(tb_price.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(tb_price.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            int stock = 10; 

            decimal totalPrice = stock * price;

            dgv_transaction.Rows.Add(tb_prodname.Text,
                                     cb_category.Text,
                                     stock,
                                     "₱" + price.ToString("n2"),
                                     "₱" + totalPrice.ToString("n2"));

            ClearInputs();
        }

    }
}