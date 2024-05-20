using ComputerCenter.Forms.Screens;
using ComputerCenter.Forms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ComputerCenter.Forms.Utils.DataBase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ComputerCenter.Forms.Utils.UtilMaster;

namespace ComputerCenter.Classes.Screens
{
    public partial class ProductScreen : BaseScreen
    {
        public ProductScreen()
        {
            InitializeComponent();
            loadProducts();
        }

        public void loadProducts()
        {
            products_list.Items.Clear();

            List<Product> products = GetProducts();

            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Quantity.ToString());
                item.SubItems.Add(GetCategoryName(product.CategoryID));
                item.SubItems.Add(product.Description);
                item.Tag = product;

                products_list.Items.Add(item);
            }
        }

        private void products_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = products_list.Columns[e.ColumnIndex].Width;
        }

        private void add_product_button_Click(object sender, EventArgs e)
        {
            Form form = new AddProductScreen();
            form.Show();
        }

        private void ProductScreen_Activated(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void delete_product_button_Click(object sender, EventArgs e)
        {
            List<ListViewItem> selectedItems = new List<ListViewItem>();
            string names = "";
            foreach (ListViewItem item in products_list.SelectedItems)
            {
                selectedItems.Add(item);
                names += item.SubItems[1].Text + "\n";
            }

            if (string.IsNullOrEmpty(names))
            {
                ShowError("You must choose at least one product");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure that you want to delete these products:\n{names}", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in selectedItems)
                {
                    DeleteProduct(int.Parse(item.SubItems[0].Text));
                }

                loadProducts();
                ShowSuccess($"You have successfully deleted product(s)\n{names}");
            }
        }
    }
}
