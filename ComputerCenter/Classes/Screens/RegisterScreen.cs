using ComputerCenter.Forms.Screens;
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
using Microsoft.VisualBasic.Logging;

namespace ComputerCenter.Classes.Screens
{
    public partial class RegisterScreen : BaseScreen
    {
        private Image HIDE = Properties.Resources.hide;
        private Image VIEW = Properties.Resources.view;

        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = login_box.Text;
            string password = password_box.Text;
            string name = CapitalizeFirstLetter(name_box.Text);
            string surname = CapitalizeFirstLetter(surname_box.Text);
            string address = address_box.Text;
            string phone = phone_box.Text;
            string email = email_box.Text;

            if (!checkVoid())
            {
                return;
            }

            if (GetUser(login) != null)
            {
                ShowError("This login already exists");
                return;
            }

            RegisterUser(login, password, "customer", name, surname, address, phone, email);

            this.Close();
            ShowSuccess($"Congratulations, {name}, you have successfully registered!");
        }

        private bool checkVoid()
        {
            string login = login_box.Text;
            string password = password_box.Text;
            string repeat_pass = repeat_box.Text;

            if (4 > login.Length || login.Length > 16)
            {
                ShowError("Login length from 4 to 16 characters");
                return false;
            }

            if (password.Length < 6)
            {
                ShowError("Password must be at least 6 characters long");
                return false;
            }

            if (password != repeat_pass)
            {
                ShowError("Passwords do not match");
                return false;
            }

            if (string.IsNullOrEmpty(name_box.Text))
            {
                ShowError("You have not entered a name");
                return false;
            }

            if (string.IsNullOrEmpty(surname_box.Text))
            {
                ShowError("You have not entered a surname");
                return false;
            }

            if (string.IsNullOrEmpty(email_box.Text))
            {
                ShowError("You have not entered an email");
                return false;
            }

            if (string.IsNullOrEmpty(phone_box.Text))
            {
                ShowError("You have not entered an phone number");
                return false;
            }

            if (string.IsNullOrEmpty(address_box.Text))
            {
                ShowError("You have not entered an address");
                return false;
            }


            return true;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (hide1.Image == HIDE)
            {
                hide1.Image = VIEW;
            }
            else
            {
                hide1.Image = HIDE;
            }
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            if (hide2.Image == HIDE)
            {
                hide2.Image = VIEW;
            }
            else
            {
                hide2.Image = HIDE;
            }
            repeat_box.UseSystemPasswordChar = !repeat_box.UseSystemPasswordChar;
        }
    }
}
