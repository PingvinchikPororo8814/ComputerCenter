using ComputerCenter.Forms.Utils;
using static ComputerCenter.Forms.Utils.DataBase;
using static ComputerCenter.Forms.Utils.UtilMaster;

namespace ComputerCenter.Forms.Screens
{
    public partial class LoginScreen : BaseScreen
    {
        private Image HIDE = Properties.Resources.hide;
        private Image VIEW = Properties.Resources.view;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void log_in_button_Click(object sender, EventArgs e)
        {
            string userLogin = login_box.Text;
            string password = password_box.Text;

            if (string.IsNullOrEmpty(userLogin))
            {
                ShowError("The login field cannot be empty");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                ShowError("The password field cannot be empty");
                return;
            }

            User user = GetUser(userLogin);
            if (user == null)
            {
                ShowError("Invalid login");
                return;
            }

            if (user.Password != EncryptPass(password))
            {
                ShowError("Invalid password");
                return;
            }

            if (user.Type == "employee")
            {
                Form employeeForm = new Classes.Screens.EmployeeAccount((Employee) user);
                employeeForm.Show();
            } else
            {
                Form customerForm = new Classes.Screens.CustomerAccount((Customer) user);
                customerForm.Show();
            }

            Hide();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            Form form = new Classes.Screens.RegisterScreen();
            form.Show();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (hide.Image == HIDE)
            {
                hide.Image = VIEW;
            }
            else
            {
                hide.Image = HIDE;
            }
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;
        }

        private void register_button_Click_1(object sender, EventArgs e)
        {
            Form register_form = new Classes.Screens.RegisterScreen();
            register_form.Show();
        }
    }
}
