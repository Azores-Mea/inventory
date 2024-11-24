namespace INVENTORYSYSTEM_GROUP2
{
    partial class PRODUCTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRODUCTS));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_prodname = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lv_products = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewCategory = new System.Windows.Forms.ComboBox();
            this.sort = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.btn_asc = new System.Windows.Forms.PictureBox();
            this.btn_dsc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dsc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Navy;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(79, 76);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(185, 48);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Navy;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(79, 141);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(185, 48);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Navy;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(79, 206);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(185, 48);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_prodname
            // 
            this.tb_prodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_prodname.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prodname.Location = new System.Drawing.Point(531, 85);
            this.tb_prodname.Name = "tb_prodname";
            this.tb_prodname.Size = new System.Drawing.Size(297, 28);
            this.tb_prodname.TabIndex = 8;
            // 
            // tb_stock
            // 
            this.tb_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_stock.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock.Location = new System.Drawing.Point(531, 131);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(147, 28);
            this.tb_stock.TabIndex = 9;
            this.tb_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stock_KeyPress);
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "CPU",
            "GPU",
            "MOTHERBOARD",
            "GPU",
            "RAM"});
            this.cb_category.Location = new System.Drawing.Point(531, 179);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(198, 29);
            this.cb_category.TabIndex = 10;
            this.cb_category.Text = "SELECT CATEGORY";
            // 
            // tb_price
            // 
            this.tb_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_price.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(531, 226);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(117, 28);
            this.tb_price.TabIndex = 13;
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // lv_products
            // 
            this.lv_products.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ProductName,
            this.category,
            this.stock,
            this.status,
            this.priority,
            this.price});
            this.lv_products.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_products.FullRowSelect = true;
            this.lv_products.GridLines = true;
            this.lv_products.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(38, 362);
            this.lv_products.MultiSelect = false;
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(816, 250);
            this.lv_products.TabIndex = 0;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "IDNo.";
            this.ID.Width = 70;
            // 
            // ProductName
            // 
            this.ProductName.Text = "PRODUCT NAME";
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductName.Width = 200;
            // 
            // category
            // 
            this.category.Text = "CATEGORY";
            this.category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.category.Width = 150;
            // 
            // stock
            // 
            this.stock.Text = "STOCK";
            this.stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stock.Width = 80;
            // 
            // status
            // 
            this.status.Text = "STATUS";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.Width = 120;
            // 
            // priority
            // 
            this.priority.Text = "PRIORITY";
            this.priority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priority.Width = 110;
            // 
            // price
            // 
            this.price.Text = "PRICE";
            this.price.Width = 80;
            // 
            // viewCategory
            // 
            this.viewCategory.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCategory.FormattingEnabled = true;
            this.viewCategory.Items.AddRange(new object[] {
            "ALL",
            "CPU",
            "GPU",
            "MOTHERBOARD",
            "GPU",
            "RAM"});
            this.viewCategory.Location = new System.Drawing.Point(38, 327);
            this.viewCategory.Name = "viewCategory";
            this.viewCategory.Size = new System.Drawing.Size(209, 29);
            this.viewCategory.TabIndex = 1;
            this.viewCategory.Text = "ALL";
            this.viewCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.viewCategory.Click += new System.EventHandler(this.cb_viewCategory_SelectedIndexChanged);
            // 
            // sort
            // 
            this.sort.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.FormattingEnabled = true;
            this.sort.Items.AddRange(new object[] {
            "STOCK",
            "PRODUCT NAME",
            "PRICE"});
            this.sort.Location = new System.Drawing.Point(684, 328);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(170, 29);
            this.sort.TabIndex = 2;
            this.sort.Text = "PRODUCT NAME";
            this.sort.Click += new System.EventHandler(this.cb_sort_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(271, 328);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(217, 28);
            this.Search.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "PRODUCT NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "SET INITIAL STOCK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "SELECT CATEGORY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "PRICE:";
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(494, 330);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(27, 24);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 18;
            this.btn_search.TabStop = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_asc
            // 
            this.btn_asc.Image = ((System.Drawing.Image)(resources.GetObject("btn_asc.Image")));
            this.btn_asc.Location = new System.Drawing.Point(622, 330);
            this.btn_asc.Name = "btn_asc";
            this.btn_asc.Size = new System.Drawing.Size(27, 24);
            this.btn_asc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_asc.TabIndex = 19;
            this.btn_asc.TabStop = false;
            this.btn_asc.Click += new System.EventHandler(this.btn_asc_Click);
            // 
            // btn_dsc
            // 
            this.btn_dsc.Image = ((System.Drawing.Image)(resources.GetObject("btn_dsc.Image")));
            this.btn_dsc.Location = new System.Drawing.Point(651, 330);
            this.btn_dsc.Name = "btn_dsc";
            this.btn_dsc.Size = new System.Drawing.Size(27, 24);
            this.btn_dsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dsc.TabIndex = 20;
            this.btn_dsc.TabStop = false;
            this.btn_dsc.Click += new System.EventHandler(this.btn_dsc_Click);
            // 
            // PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 706);
            this.Controls.Add(this.btn_dsc);
            this.Controls.Add(this.btn_asc);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.viewCategory);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.lv_products);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.tb_prodname);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PRODUCTS";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_prodname;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ComboBox viewCategory;
        private System.Windows.Forms.ComboBox sort;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_search;
        private System.Windows.Forms.PictureBox btn_asc;
        private System.Windows.Forms.PictureBox btn_dsc;
    }
}