using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace INVENTORYSYSTEM_GROUP2
{
    public partial class PRODUCTS : Form
    {
        private Database db;
        private string currentCategoryFilter = "ALL";
        private string currentSortColumn = "Id"; 
        private bool isAscending = true;

        public PRODUCTS()
        {
            InitializeComponent();
            db = new Database();
            LoadProductsToListView();

            btn_edit.Enabled = false;
            btn_remove.Enabled = false;
            btn_add.Enabled = true;

            lv_products.SelectedIndexChanged += Lv_products_SelectedIndexChanged;
        }

        private void Lv_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                var selectedItem = lv_products.SelectedItems[0];
                tb_prodname.Text = selectedItem.SubItems[1].Text;
                cb_category.Text = selectedItem.SubItems[2].Text;
                tb_stock.Text = selectedItem.SubItems[3].Text;
                tb_price.Text = selectedItem.SubItems[6].Text;

                btn_edit.Enabled = true;
                btn_remove.Enabled = true;
                btn_add.Enabled = false;
            }
            else
            {
                ClearInputs();

                btn_edit.Enabled = false;
                btn_remove.Enabled = false;
                btn_add.Enabled = true;
            }
        }

        private void ClearInputs()
        {
            tb_prodname.Text = string.Empty;
            cb_category.SelectedIndex = -1;
            tb_stock.Text = string.Empty;
            tb_price.Text = string.Empty;
        }
        private void LoadProductsToListView(string searchTerm = "")
        {
            lv_products.Items.Clear();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT Id, Name, Category, Stock, Status, Priority, Price 
                                     FROM Products";

                    if (currentCategoryFilter != "ALL")
                    {
                        query += " WHERE Category = @Category";
                    }

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += currentCategoryFilter != "ALL" ? " AND Name LIKE @SearchTerm" : " WHERE Name LIKE @SearchTerm";
                    }

                    query += $" ORDER BY {GetSortColumn()}";

                    query += isAscending ? " ASC" : " DESC";

                    SqlCommand command = new SqlCommand(query, connection);

                    if (currentCategoryFilter != "ALL")
                        command.Parameters.AddWithValue("@Category", currentCategoryFilter);

                    if (!string.IsNullOrEmpty(searchTerm))
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Category"].ToString());
                        item.SubItems.Add(reader["Stock"].ToString());
                        item.SubItems.Add(reader["Status"].ToString());
                        item.SubItems.Add(reader["Priority"].ToString());
                        item.SubItems.Add(reader["Price"].ToString());
                        lv_products.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private string GetSortColumn()
        {
            switch (currentSortColumn)
            {
                case "Id": return "Id";
                case "Name": return "Name";
                case "Stock": return "Stock";
                case "Price": return "Price";
                default: return "Id";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    var query = "INSERT INTO Products (Name, Category, Stock, Price) " +
                                "VALUES (@Name, @Category, @Stock, @Price)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", tb_prodname.Text);
                        command.Parameters.AddWithValue("@Category", cb_category.Text);
                        command.Parameters.AddWithValue("@Stock", int.Parse(tb_stock.Text));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(tb_price.Text));
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Product added successfully.");
                    LoadProductsToListView();
                    ClearInputs();

                    btn_edit.Enabled = false;
                    btn_remove.Enabled = false;
                    btn_add.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                var id = lv_products.SelectedItems[0].SubItems[0].Text;
                using (var connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        var query = "DELETE FROM Products WHERE Id = @Id";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Product removed successfully.");
                        LoadProductsToListView();
                        ClearInputs();

                        btn_edit.Enabled = false;
                        btn_remove.Enabled = false;
                        btn_add.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lv_products.SelectedItems.Count > 0)
            {
                var id = lv_products.SelectedItems[0].SubItems[0].Text;
                using (var connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        var query = "UPDATE Products SET Name = @Name, Category = @Category, Stock = @Stock, Price = @Price WHERE Id = @Id";
                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@Name", tb_prodname.Text);
                            command.Parameters.AddWithValue("@Category", cb_category.Text);
                            command.Parameters.AddWithValue("@Stock", int.Parse(tb_stock.Text));
                            command.Parameters.AddWithValue("@Price", decimal.Parse(tb_price.Text));
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Product updated successfully.");
                        LoadProductsToListView();
                        ClearInputs();

                        btn_edit.Enabled = false;
                        btn_remove.Enabled = false;
                        btn_add.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void cb_viewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCategoryFilter = viewCategory.SelectedItem.ToString();
            LoadProductsToListView();
        }

        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSortColumn = sort.SelectedItem.ToString();
            LoadProductsToListView();
        }

        private void btn_asc_Click(object sender, EventArgs e)
        {
            isAscending = true;
            LoadProductsToListView();
        }

        private void btn_dsc_Click(object sender, EventArgs e)
        {
            isAscending = false;
            LoadProductsToListView();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchTerm = Search.Text.Trim();
            LoadProductsToListView(searchTerm);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tb_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
