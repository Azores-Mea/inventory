namespace INVENTORYSYSTEM_GROUP2
{
    partial class InventorySystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventorySystem));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.prodMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productMenu = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_product = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_editprod = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_sales = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.prodMenuTransition = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.prodMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gold;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.exit);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1268, 43);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1189, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.maxmin_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1226, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 22);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTORY SYSTEM";
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.prodMenu);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Location = new System.Drawing.Point(0, 43);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(198, 706);
            this.sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 142);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(195, 92);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADMIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.Location = new System.Drawing.Point(0, 183);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 56);
            this.panel2.TabIndex = 3;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_dashboard.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Image")));
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(-7, -47);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(400, 146);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "          DASHBOARD";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // prodMenu
            // 
            this.prodMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.prodMenu.Controls.Add(this.panel3);
            this.prodMenu.Controls.Add(this.panel8);
            this.prodMenu.Controls.Add(this.panel9);
            this.prodMenu.Location = new System.Drawing.Point(3, 242);
            this.prodMenu.Name = "prodMenu";
            this.prodMenu.Size = new System.Drawing.Size(281, 56);
            this.prodMenu.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productMenu);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 56);
            this.panel3.TabIndex = 4;
            // 
            // productMenu
            // 
            this.productMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.productMenu.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMenu.ForeColor = System.Drawing.Color.White;
            this.productMenu.Image = ((System.Drawing.Image)(resources.GetObject("productMenu.Image")));
            this.productMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productMenu.Location = new System.Drawing.Point(-7, -47);
            this.productMenu.Name = "productMenu";
            this.productMenu.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.productMenu.Size = new System.Drawing.Size(400, 146);
            this.productMenu.TabIndex = 2;
            this.productMenu.Text = "          PRODUCT";
            this.productMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productMenu.UseVisualStyleBackColor = false;
            this.productMenu.Click += new System.EventHandler(this.productMenu_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_product);
            this.panel8.Location = new System.Drawing.Point(0, 56);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(281, 56);
            this.panel8.TabIndex = 5;
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_product.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.ForeColor = System.Drawing.Color.White;
            this.btn_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Image")));
            this.btn_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.Location = new System.Drawing.Point(-7, -47);
            this.btn_product.Name = "btn_product";
            this.btn_product.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btn_product.Size = new System.Drawing.Size(400, 146);
            this.btn_product.TabIndex = 2;
            this.btn_product.Text = "          VIEW LIST";
            this.btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_editprod);
            this.panel9.Location = new System.Drawing.Point(0, 112);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(281, 56);
            this.panel9.TabIndex = 6;
            // 
            // btn_editprod
            // 
            this.btn_editprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_editprod.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editprod.ForeColor = System.Drawing.Color.White;
            this.btn_editprod.Image = ((System.Drawing.Image)(resources.GetObject("btn_editprod.Image")));
            this.btn_editprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editprod.Location = new System.Drawing.Point(-7, -47);
            this.btn_editprod.Name = "btn_editprod";
            this.btn_editprod.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btn_editprod.Size = new System.Drawing.Size(400, 146);
            this.btn_editprod.TabIndex = 2;
            this.btn_editprod.Text = "          EDIT LIST";
            this.btn_editprod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editprod.UseVisualStyleBackColor = false;
            this.btn_editprod.Click += new System.EventHandler(this.btn_editprod_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.btn_purchase);
            this.panel4.Location = new System.Drawing.Point(0, 311);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 56);
            this.panel4.TabIndex = 5;
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_purchase.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.White;
            this.btn_purchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchase.Image")));
            this.btn_purchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchase.Location = new System.Drawing.Point(-7, -47);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btn_purchase.Size = new System.Drawing.Size(400, 146);
            this.btn_purchase.TabIndex = 2;
            this.btn_purchase.Text = "          PURCHASE";
            this.btn_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel5.Controls.Add(this.btn_sales);
            this.panel5.Location = new System.Drawing.Point(0, 377);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 56);
            this.panel5.TabIndex = 6;
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_sales.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.Image = ((System.Drawing.Image)(resources.GetObject("btn_sales.Image")));
            this.btn_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales.Location = new System.Drawing.Point(-7, -47);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btn_sales.Size = new System.Drawing.Size(400, 146);
            this.btn_sales.TabIndex = 2;
            this.btn_sales.Text = "          SALES";
            this.btn_sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel6.Controls.Add(this.btn_inventory);
            this.panel6.Location = new System.Drawing.Point(0, 443);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 56);
            this.panel6.TabIndex = 7;
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_inventory.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_inventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventory.Image")));
            this.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventory.Location = new System.Drawing.Point(-7, -47);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btn_inventory.Size = new System.Drawing.Size(400, 146);
            this.btn_inventory.TabIndex = 2;
            this.btn_inventory.Text = "          INVENTORY";
            this.btn_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventory.UseVisualStyleBackColor = false;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.panel7.Controls.Add(this.btn_logout);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 599);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 56);
            this.panel7.TabIndex = 8;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(61)))));
            this.btn_logout.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(-7, -47);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btn_logout.Size = new System.Drawing.Size(400, 146);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "          LOGOUT";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Location = new System.Drawing.Point(197, 43);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1071, 706);
            this.contentPanel.TabIndex = 3;
            // 
            // prodMenuTransition
            // 
            this.prodMenuTransition.Interval = 10;
            this.prodMenuTransition.Tick += new System.EventHandler(this.prodMenuTransition_Tick);
            // 
            // InventorySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 749);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventorySystem";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.prodMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button productMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.FlowLayoutPanel prodMenu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_editprod;
        private System.Windows.Forms.Timer prodMenuTransition;
        private System.Windows.Forms.Panel panel1;
    }
}

