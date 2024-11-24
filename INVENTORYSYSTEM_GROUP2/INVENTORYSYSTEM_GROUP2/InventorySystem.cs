using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace INVENTORYSYSTEM_GROUP2
{
    public partial class InventorySystem : Form
    {
        private bool isMaximized = false;

        DASHBOARD dashboard;
        PRODUCTS products;
        PURCHASE purchase;
        SALES sales;
        INVENTORY inventory;

        private Button activeButton;

        public InventorySystem()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            UpdateContentArea();
            ActivateButton(btn_dashboard);
            ShowForm(ref dashboard);
            label1.Text = "INVENTORY SYSTEM - DASHBOARD";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxmin_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void UpdateContentArea()
        {
            sidebar.Width = 200;
            sidebar.Height = this.ClientSize.Height;

            contentPanel.Left = sidebar.Width;
            contentPanel.Width = this.ClientSize.Width - sidebar.Width;
            contentPanel.Height = this.ClientSize.Height;

            foreach (Control control in contentPanel.Controls)
            {
                control.Left = (contentPanel.Width - control.Width) / 2;
                control.Top = (contentPanel.Height - control.Height) / 2;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateContentArea();
        }

        private void ShowForm<T>(ref T formInstance) where T : Form, new()
        {
            contentPanel.Controls.Clear();

            if (formInstance == null || formInstance.IsDisposed)
            {
                formInstance = new T();
                formInstance.FormBorderStyle = FormBorderStyle.None;
                formInstance.TopLevel = false;
                formInstance.Dock = DockStyle.None;
                formInstance.AutoSize = true;
            }
            contentPanel.Controls.Add(formInstance);
            formInstance.Show();

            formInstance.Left = (contentPanel.Width - formInstance.Width) / 2;
            formInstance.Top = (contentPanel.Height - formInstance.Height) / 2;
            formInstance.BringToFront();
        }

        private void ActivateButton(Button button)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.Navy;
                activeButton.ForeColor = Color.White;
            }

            activeButton = button;
            activeButton.BackColor = Color.Gold;
            activeButton.ForeColor = Color.Black;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            ShowForm(ref dashboard);
            label1.Text = "INVENTORY SYSTEM - DASHBOARD";
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            ShowForm(ref products);
            label1.Text = "INVENTORY SYSTEM - PRODUCT";
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            ShowForm(ref purchase);
            label1.Text = "INVENTORY SYSTEM - PURCHASE";
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            ShowForm(ref sales);
            label1.Text = "INVENTORY SYSTEM - SALES";
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
            ShowForm(ref inventory);
            label1.Text = "INVENTORY SYSTEM - INVENTORY";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }
    }
}
