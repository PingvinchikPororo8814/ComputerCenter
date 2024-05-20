using ComputerCenter.Forms.Screens;
using ComputerCenter.Forms.Utils;
using static ComputerCenter.Forms.Utils.UtilMaster;

namespace ComputerCenter.Classes.Screens
{
    public partial class AddProductScreen : BaseScreen
    {
        public AddProductScreen()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string description = string.IsNullOrEmpty(description_box.Text) ? "" : description_box.Text;
            string q = string.IsNullOrEmpty(quantity_box.Text) ? "0" : quantity_box.Text;
            string p = string.IsNullOrEmpty(price_box.Text) ? "0" : price_box.Text;
            string c = string.IsNullOrEmpty(category_box.Text) ? "0" : category_box.Text;

            int quantity;
            int categoryId;
            decimal price;

            if (string.IsNullOrEmpty(name))
            {
                ShowError("To save, enter a name");
                return;
            }

            if (!int.TryParse(q, out quantity))
            {
                ShowError("The quantity should be int");
                return;
            }

            if (!decimal.TryParse(p, out price))
            {
                ShowError("The quantity should be decimal");
                return;
            }

            if (!DataBase.IsCategoryExist(c))
            {
                ShowError($"Category {c} isn't exit");
                return;
            }

            categoryId = DataBase.GetCategoryId(c);
            if (categoryId == -1)
            {
                ShowError($"Category {c} isn't exit");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure that you want to add a product:\nName: {name}\nDescription: {description}\nPrice: {p}\r\nQuantity: {q}\r\nCategory: {c}", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataBase.AddProduct(name, description, price, quantity, categoryId);
                ShowSuccess($"You have successfully added product {name}");
                Close();
            }
        }
    }
}
