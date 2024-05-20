using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCenter.Forms.Screens
{
    public partial class BaseScreen : Form
    {
        public BaseScreen()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            string iconPath = $"{Application.StartupPath}\\Resources\\Images\\icon.ico";
            if (File.Exists(iconPath))
            {
                this.Icon = new Icon(iconPath);
            }

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void BaseScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();
            Form[] visibleForms = openForms.Where(form => form.Visible).ToArray();
            if (visibleForms.Length == 1)
            {
                Application.Exit();
            }
        }
    }
}
