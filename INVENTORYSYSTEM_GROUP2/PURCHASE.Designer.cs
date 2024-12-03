namespace INVENTORYSYSTEM_GROUP2
{
    partial class PURCHASE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_ProductList = new System.Windows.Forms.Label();
            this.cb_sort = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_prodname = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_units = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lv_products = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgv_transaction = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_grandtotal = new System.Windows.Forms.TextBox();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.tb_change = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_Units = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.textbox_category = new System.Windows.Forms.TextBox();
            this.lbl_ProductDetails = new System.Windows.Forms.Label();
            this.lbl_TransactionDetails = new System.Windows.Forms.Label();
            this.lbl_SaveTransaction = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblEnterAmount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btn_increment = new System.Windows.Forms.Button();
            this.btn_decrement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProductList
            // 
            this.lbl_ProductList.AutoSize = true;
            this.lbl_ProductList.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductList.Location = new System.Drawing.Point(34, 41);
            this.lbl_ProductList.Name = "lbl_ProductList";
            this.lbl_ProductList.Size = new System.Drawing.Size(148, 21);
            this.lbl_ProductList.TabIndex = 1;
            this.lbl_ProductList.Text = "PRODUCT LIST:";
            // 
            // cb_sort
            // 
            this.cb_sort.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.cb_sort.FormattingEnabled = true;
            this.cb_sort.Location = new System.Drawing.Point(413, 86);
            this.cb_sort.Name = "cb_sort";
            this.cb_sort.Size = new System.Drawing.Size(122, 29);
            this.cb_sort.TabIndex = 3;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(38, 86);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(157, 22);
            this.tb_search.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(201, 86);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 24);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_prodname
            // 
            this.tb_prodname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_prodname.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_prodname.Location = new System.Drawing.Point(732, 91);
            this.tb_prodname.Name = "tb_prodname";
            this.tb_prodname.ReadOnly = true;
            this.tb_prodname.Size = new System.Drawing.Size(138, 21);
            this.tb_prodname.TabIndex = 7;
            this.tb_prodname.TabStop = false;
            this.tb_prodname.TextChanged += new System.EventHandler(this.tb_prodname_TextChanged);
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(288, 86);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(119, 29);
            this.cb_category.TabIndex = 8;
            // 
            // tb_price
            // 
            this.tb_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_price.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_price.Location = new System.Drawing.Point(732, 168);
            this.tb_price.Multiline = true;
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(138, 31);
            this.tb_price.TabIndex = 9;
            this.tb_price.TabStop = false;
            // 
            // tb_units
            // 
            this.tb_units.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_units.Location = new System.Drawing.Point(642, 205);
            this.tb_units.Multiline = true;
            this.tb_units.Name = "tb_units";
            this.tb_units.ReadOnly = true;
            this.tb_units.Size = new System.Drawing.Size(43, 30);
            this.tb_units.TabIndex = 10;
            this.tb_units.TabStop = false;
            this.tb_units.TextChanged += new System.EventHandler(this.tb_units_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_add.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(564, 260);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(159, 43);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_remove.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(721, 260);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(149, 43);
            this.btn_remove.TabIndex = 12;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lv_products
            // 
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.lv_products.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(38, 118);
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(497, 185);
            this.lv_products.TabIndex = 13;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            this.lv_products.SelectedIndexChanged += new System.EventHandler(this.lv_products_SelectedIndexChanged_1);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 35;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "NAME";
            this.ColumnHeader2.Width = 134;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "CATEGORY";
            this.ColumnHeader3.Width = 120;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "STOCK";
            this.ColumnHeader4.Width = 90;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "PRICE";
            this.ColumnHeader5.Width = 121;
            // 
            // dgv_transaction
            // 
            this.dgv_transaction.AllowUserToAddRows = false;
            this.dgv_transaction.AllowUserToDeleteRows = false;
            this.dgv_transaction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_transaction.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_transaction.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_transaction.Location = new System.Drawing.Point(38, 397);
            this.dgv_transaction.Name = "dgv_transaction";
            this.dgv_transaction.ReadOnly = true;
            this.dgv_transaction.RowHeadersWidth = 51;
            this.dgv_transaction.RowTemplate.Height = 24;
            this.dgv_transaction.Size = new System.Drawing.Size(497, 208);
            this.dgv_transaction.TabIndex = 14;
            this.dgv_transaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaction_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PRODUCT NAME";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRICE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "UNIT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TOTAL PRICE";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // tb_grandtotal
            // 
            this.tb_grandtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_grandtotal.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_grandtotal.Location = new System.Drawing.Point(732, 412);
            this.tb_grandtotal.Multiline = true;
            this.tb_grandtotal.Name = "tb_grandtotal";
            this.tb_grandtotal.ReadOnly = true;
            this.tb_grandtotal.Size = new System.Drawing.Size(138, 33);
            this.tb_grandtotal.TabIndex = 15;
            this.tb_grandtotal.TabStop = false;
            // 
            // tb_amount
            // 
            this.tb_amount.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_amount.Location = new System.Drawing.Point(732, 451);
            this.tb_amount.Multiline = true;
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(138, 36);
            this.tb_amount.TabIndex = 16;
            this.tb_amount.TextChanged += new System.EventHandler(this.tb_amount_TextChanged);
            // 
            // tb_change
            // 
            this.tb_change.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_change.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_change.Location = new System.Drawing.Point(732, 494);
            this.tb_change.Multiline = true;
            this.tb_change.Name = "tb_change";
            this.tb_change.ReadOnly = true;
            this.tb_change.Size = new System.Drawing.Size(138, 32);
            this.tb_change.TabIndex = 17;
            this.tb_change.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_save.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(564, 562);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(306, 43);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "ADD TRANSACTION";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_productName.Location = new System.Drawing.Point(560, 91);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(166, 21);
            this.lbl_productName.TabIndex = 19;
            this.lbl_productName.Text = "PRODUCT NAME:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_price.Location = new System.Drawing.Point(560, 168);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(66, 21);
            this.lbl_price.TabIndex = 20;
            this.lbl_price.Text = "PRICE:";
            // 
            // lbl_Units
            // 
            this.lbl_Units.AutoSize = true;
            this.lbl_Units.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Units.Location = new System.Drawing.Point(560, 208);
            this.lbl_Units.Name = "lbl_Units";
            this.lbl_Units.Size = new System.Drawing.Size(76, 21);
            this.lbl_Units.TabIndex = 21;
            this.lbl_Units.Text = "UNIT/S:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_category.Location = new System.Drawing.Point(560, 130);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(121, 21);
            this.lbl_category.TabIndex = 22;
            this.lbl_category.Text = "CATEGORY: ";
            // 
            // textbox_category
            // 
            this.textbox_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_category.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.textbox_category.Location = new System.Drawing.Point(732, 131);
            this.textbox_category.Multiline = true;
            this.textbox_category.Name = "textbox_category";
            this.textbox_category.ReadOnly = true;
            this.textbox_category.Size = new System.Drawing.Size(138, 31);
            this.textbox_category.TabIndex = 23;
            this.textbox_category.TabStop = false;
            this.textbox_category.TextChanged += new System.EventHandler(this.textbox_category_TextChanged);
            // 
            // lbl_ProductDetails
            // 
            this.lbl_ProductDetails.AutoSize = true;
            this.lbl_ProductDetails.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductDetails.Location = new System.Drawing.Point(560, 41);
            this.lbl_ProductDetails.Name = "lbl_ProductDetails";
            this.lbl_ProductDetails.Size = new System.Drawing.Size(185, 21);
            this.lbl_ProductDetails.TabIndex = 24;
            this.lbl_ProductDetails.Text = "PRODUCT DETAILS:";
            // 
            // lbl_TransactionDetails
            // 
            this.lbl_TransactionDetails.AutoSize = true;
            this.lbl_TransactionDetails.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_TransactionDetails.Location = new System.Drawing.Point(34, 357);
            this.lbl_TransactionDetails.Name = "lbl_TransactionDetails";
            this.lbl_TransactionDetails.Size = new System.Drawing.Size(228, 21);
            this.lbl_TransactionDetails.TabIndex = 25;
            this.lbl_TransactionDetails.Text = "TRANSACTION DETAILS:";
            // 
            // lbl_SaveTransaction
            // 
            this.lbl_SaveTransaction.AutoSize = true;
            this.lbl_SaveTransaction.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_SaveTransaction.Location = new System.Drawing.Point(560, 357);
            this.lbl_SaveTransaction.Name = "lbl_SaveTransaction";
            this.lbl_SaveTransaction.Size = new System.Drawing.Size(199, 21);
            this.lbl_SaveTransaction.TabIndex = 26;
            this.lbl_SaveTransaction.Text = "SAVE TRANSACTION:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.Location = new System.Drawing.Point(560, 412);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(149, 21);
            this.lblGrandTotal.TabIndex = 27;
            this.lblGrandTotal.Text = "GRAND TOTAL:";
            // 
            // lblEnterAmount
            // 
            this.lblEnterAmount.AutoSize = true;
            this.lblEnterAmount.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEnterAmount.Location = new System.Drawing.Point(560, 451);
            this.lblEnterAmount.Name = "lblEnterAmount";
            this.lblEnterAmount.Size = new System.Drawing.Size(166, 21);
            this.lblEnterAmount.TabIndex = 28;
            this.lblEnterAmount.Text = "ENTER AMOUNT:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblChange.Location = new System.Drawing.Point(560, 493);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(92, 21);
            this.lblChange.TabIndex = 29;
            this.lblChange.Text = "CHANGE:";
            // 
            // btn_increment
            // 
            this.btn_increment.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_increment.Location = new System.Drawing.Point(721, 205);
            this.btn_increment.Name = "btn_increment";
            this.btn_increment.Size = new System.Drawing.Size(34, 30);
            this.btn_increment.TabIndex = 30;
            this.btn_increment.Text = "+";
            this.btn_increment.UseVisualStyleBackColor = true;
            this.btn_increment.Click += new System.EventHandler(this.btn_increment_Click);
            // 
            // btn_decrement
            // 
            this.btn_decrement.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_decrement.Location = new System.Drawing.Point(691, 205);
            this.btn_decrement.Name = "btn_decrement";
            this.btn_decrement.Size = new System.Drawing.Size(32, 30);
            this.btn_decrement.TabIndex = 31;
            this.btn_decrement.Text = "-";
            this.btn_decrement.UseVisualStyleBackColor = true;
            this.btn_decrement.Click += new System.EventHandler(this.btn_decrement_Click);
            // 
            // PURCHASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 706);
            this.Controls.Add(this.btn_decrement);
            this.Controls.Add(this.btn_increment);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblEnterAmount);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lbl_SaveTransaction);
            this.Controls.Add(this.lbl_TransactionDetails);
            this.Controls.Add(this.lbl_ProductDetails);
            this.Controls.Add(this.textbox_category);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_Units);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_change);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.tb_grandtotal);
            this.Controls.Add(this.dgv_transaction);
            this.Controls.Add(this.lv_products);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_units);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.tb_prodname);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.cb_sort);
            this.Controls.Add(this.lbl_ProductList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PURCHASE";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PURCHASE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductList;
        private System.Windows.Forms.ComboBox cb_sort;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_prodname;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_units;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.ColumnHeader ColumnHeader5;
        private System.Windows.Forms.DataGridView dgv_transaction;
        private System.Windows.Forms.TextBox tb_grandtotal;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox tb_change;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_Units;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox textbox_category;
        private System.Windows.Forms.Label lbl_ProductDetails;
        private System.Windows.Forms.Label lbl_TransactionDetails;
        private System.Windows.Forms.Label lbl_SaveTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblEnterAmount;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btn_increment;
        private System.Windows.Forms.Button btn_decrement;
    }
}