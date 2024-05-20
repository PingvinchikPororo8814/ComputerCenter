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
using static ComputerCenter.Forms.Utils.UtilMaster;
using static ComputerCenter.Forms.Utils.DataBase;
using System.Xml.Linq;

namespace ComputerCenter.Classes.Screens
{
    public partial class CreateOrderScreen : BaseScreen
    {
        private Customer customer;

        public CreateOrderScreen(Customer user)
        {
            InitializeComponent();
            customer = user;
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            string product_name = name_box.Text;
            string q = quantity_box.Text;
            int quantity;

            if (!int.TryParse(q, out quantity))
            {
                ShowError("The quantity should be int");
                return;
            }

            Product product = GetProduct(product_name);

            if (product == null)
            {
                ShowError($"Product {product_name} is out of stock");
                return;
            }

            if (product.Quantity < quantity)
            {
                ShowError($"There are only {product.Quantity} products available {product_name}");
                return;
            }

            decimal price = (decimal)product.Price * quantity;

            DialogResult result = MessageBox.Show($"Are you sure you want to order product {product_name} at {price}$ for {quantity} pieces?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AddOrder(customer.UserUUID, DateTime.Now, price, product.Id, quantity, (int)price);

                product.Quantity -= quantity;
                UpdateProduct(product);
                
                Close();
                ShowSuccess($"You have successfully ordered {quantity} {product_name} for {price}$");
            }
        }
    }
}
