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

namespace ComputerCenter.Classes.Screens
{
    public partial class EmployeeAccount : BaseAccount
    {
        private Employee employee;
        public EmployeeAccount(Employee user)
        {
            InitializeComponent();
            employee = user;
            LoadData();
        }

        private void LoadData()
        {
            name_label.Text = employee.FirstName;
        }

        private void open_products_Click(object sender, EventArgs e)
        {
            Form productForm = new ProductScreen();
            productForm.Show();
        }
    }
}
