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
    public partial class VIEWPRODLIST : Form
    {
        private Database db;
        private string filter_category = "ALL";
        private string filter_sort = "Id";
        private bool isAsc = true;
        private string filter_search = "";

        public VIEWPRODLIST()
        {
            InitializeComponent();
            db = new Database();
            LoadProductsToListView();
        }

        private void EDITPRODLIST_Load(object sender, EventArgs e)
        {

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

                    if (filter_category != "ALL")
                    {
                        query += " WHERE Category = @Category";
                    }

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += filter_category != "ALL" ? " AND Name LIKE @SearchTerm" : " WHERE Name LIKE @SearchTerm";
                    }

                    query += $" ORDER BY {GetSortColumn()}";

                    query += isAsc ? " ASC" : " DESC";

                    SqlCommand command = new SqlCommand(query, connection);

                    if (filter_category != "ALL")
                        command.Parameters.AddWithValue("@Category", filter_category);

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
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["Price"])));
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
            switch (filter_sort)
            {
                case "ID": return "Id";
                case "PRODUCT NAME": return "Name";
                case "STOCK": return "Stock";
                case "PRICE": return "Price";
                default: return "Id";
            }
        }

        private void cb_viewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_category = viewCategory.SelectedItem.ToString();
            LoadProductsToListView(filter_search);
        }

        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_sort = sort.SelectedItem.ToString();
            LoadProductsToListView(filter_search);
        }

        private void btn_asc_Click(object sender, EventArgs e)
        {
            isAsc = true;
            LoadProductsToListView(filter_search);
        }

        private void btn_dsc_Click(object sender, EventArgs e)
        {
            isAsc = false;
            LoadProductsToListView(filter_search);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            filter_search = Search.Text.Trim();
            LoadProductsToListView(filter_search);
        }
    }
}
