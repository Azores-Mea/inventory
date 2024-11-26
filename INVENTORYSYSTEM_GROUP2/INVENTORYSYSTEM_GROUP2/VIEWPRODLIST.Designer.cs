namespace INVENTORYSYSTEM_GROUP2
{
    partial class VIEWPRODLIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEWPRODLIST));
            this.btn_dsc = new System.Windows.Forms.PictureBox();
            this.btn_asc = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.sort = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.viewCategory = new System.Windows.Forms.ComboBox();
            this.lv_products = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.btn_dsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dsc
            // 
            this.btn_dsc.Image = ((System.Drawing.Image)(resources.GetObject("btn_dsc.Image")));
            this.btn_dsc.Location = new System.Drawing.Point(780, 12);
            this.btn_dsc.Name = "btn_dsc";
            this.btn_dsc.Size = new System.Drawing.Size(27, 24);
            this.btn_dsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dsc.TabIndex = 34;
            this.btn_dsc.TabStop = false;
            this.btn_dsc.Click += new System.EventHandler(this.btn_dsc_Click);
            // 
            // btn_asc
            // 
            this.btn_asc.Image = ((System.Drawing.Image)(resources.GetObject("btn_asc.Image")));
            this.btn_asc.Location = new System.Drawing.Point(751, 12);
            this.btn_asc.Name = "btn_asc";
            this.btn_asc.Size = new System.Drawing.Size(27, 24);
            this.btn_asc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_asc.TabIndex = 33;
            this.btn_asc.TabStop = false;
            this.btn_asc.Click += new System.EventHandler(this.btn_asc_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(509, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(27, 24);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 32;
            this.btn_search.TabStop = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // sort
            // 
            this.sort.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.FormattingEnabled = true;
            this.sort.Items.AddRange(new object[] {
            "ID",
            "STOCK",
            "PRODUCT NAME",
            "PRICE"});
            this.sort.Location = new System.Drawing.Point(813, 10);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(205, 29);
            this.sort.TabIndex = 30;
            this.sort.Text = "ID";
            this.sort.SelectedIndexChanged += new System.EventHandler(this.cb_sort_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(286, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(217, 28);
            this.Search.TabIndex = 31;
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
            this.viewCategory.Location = new System.Drawing.Point(53, 12);
            this.viewCategory.Name = "viewCategory";
            this.viewCategory.Size = new System.Drawing.Size(209, 29);
            this.viewCategory.TabIndex = 29;
            this.viewCategory.Text = "ALL";
            this.viewCategory.SelectedIndexChanged += new System.EventHandler(this.cb_viewCategory_SelectedIndexChanged);
            // 
            // lv_products
            // 
            this.lv_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_products.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_products.FullRowSelect = true;
            this.lv_products.GridLines = true;
            this.lv_products.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(53, 47);
            this.lv_products.MultiSelect = false;
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(965, 607);
            this.lv_products.TabIndex = 35;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PRODUCT NAME";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CATEGORY";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STOCK";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "STATUS";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "PRIORITY";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PRICE";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 150;
            // 
            // VIEWPRODLIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 706);
            this.Controls.Add(this.lv_products);
            this.Controls.Add(this.btn_dsc);
            this.Controls.Add(this.btn_asc);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.viewCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VIEWPRODLIST";
            this.Text = "EDITPRODLIST";
            this.Load += new System.EventHandler(this.EDITPRODLIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_dsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_dsc;
        private System.Windows.Forms.PictureBox btn_asc;
        private System.Windows.Forms.PictureBox btn_search;
        private System.Windows.Forms.ComboBox sort;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.ComboBox viewCategory;
        private System.Windows.Forms.ListView lv_products;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}