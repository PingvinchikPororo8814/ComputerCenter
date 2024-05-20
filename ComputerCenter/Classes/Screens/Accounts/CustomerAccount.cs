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
using static ComputerCenter.Forms.Utils.UtilMaster;
using static ComputerCenter.Forms.Utils.DataBase;

namespace ComputerCenter.Classes.Screens
{
    public partial class CustomerAccount : BaseAccount
    {
        private Customer customer;

        public CustomerAccount(Customer user)
        {
            InitializeComponent();
            customer = user;
            LoadData();
        }

        public void LoadData()
        {
            name_label.Text = customer.FirstName;

            LoadOrders();
        }

        private void LoadOrders()
        {
            orders_list.Items.Clear();

            List<Order> orders = DataBase.GetOrders();

            foreach (Order order in orders)
            {
                if (order.CustomerUUID == customer.UserUUID)
                {
                    OrderDetail detail = GetOrderDetail(order.Id);
                    Product product = GetProduct(detail.ProductId);

                    if (detail == null || product == null)
                    {
                        continue;
                    }

                    ListViewItem item = new ListViewItem(order.Id.ToString());
                    item.SubItems.Add(product.Name);
                    item.SubItems.Add(order.TotalPrice.ToString());
                    item.SubItems.Add(order.OrderDate.ToString("dd.MM.yyyy"));

                    item.Tag = order;

                    orders_list.Items.Add(item);
                }
            }
        }

        private void products_list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = orders_list.Columns[e.ColumnIndex].Width;
        }

        private void orders_list_ItemActivate(object sender, EventArgs e)
        {
            ShowSuccess("Test");
        }

        private void create_order_Click(object sender, EventArgs e)
        {
            Form new_order = new CreateOrderScreen(customer);
            new_order.Show();
        }

        private void CustomerAccount_Activated(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
