namespace ComputerCenter.Forms.Screens
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_box = new TextBox();
            login_label = new Label();
            password_label = new Label();
            password_box = new TextBox();
            log_in_button = new Button();
            hide = new Label();
            register_button = new Button();
            SuspendLayout();
            // 
            // login_box
            // 
            login_box.BackColor = SystemColors.ScrollBar;
            login_box.Location = new Point(153, 104);
            login_box.Name = "login_box";
            login_box.Size = new Size(164, 23);
            login_box.TabIndex = 0;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_label.Location = new Point(99, 104);
            login_label.Name = "login_label";
            login_label.Size = new Size(48, 23);
            login_label.TabIndex = 1;
            login_label.Text = "Login";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            password_label.Location = new Point(67, 157);
            password_label.Name = "password_label";
            password_label.Size = new Size(80, 23);
            password_label.TabIndex = 3;
            password_label.Text = "Password";
            // 
            // password_box
            // 
            password_box.BackColor = SystemColors.ScrollBar;
            password_box.Location = new Point(153, 157);
            password_box.Name = "password_box";
            password_box.Size = new Size(164, 23);
            password_box.TabIndex = 2;
            password_box.UseSystemPasswordChar = true;
            // 
            // log_in_button
            // 
            log_in_button.BackColor = SystemColors.ActiveCaption;
            log_in_button.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            log_in_button.Location = new Point(182, 211);
            log_in_button.Name = "log_in_button";
            log_in_button.Size = new Size(97, 34);
            log_in_button.TabIndex = 4;
            log_in_button.Text = "Log in";
            log_in_button.UseVisualStyleBackColor = false;
            log_in_button.Click += log_in_button_Click;
            // 
            // hide
            // 
            hide.AutoSize = true;
            hide.BackColor = SystemColors.ScrollBar;
            hide.Image = Properties.Resources.view;
            hide.Location = new Point(296, 161);
            hide.MaximumSize = new Size(16, 16);
            hide.MinimumSize = new Size(16, 16);
            hide.Name = "hide";
            hide.Size = new Size(16, 16);
            hide.TabIndex = 5;
            hide.Click += hide_Click;
            // 
            // register_button
            // 
            register_button.BackColor = SystemColors.ActiveCaption;
            register_button.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            register_button.Location = new Point(182, 262);
            register_button.Name = "register_button";
            register_button.Size = new Size(97, 34);
            register_button.TabIndex = 6;
            register_button.Text = "Sign up";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click_1;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 308);
            Controls.Add(register_button);
            Controls.Add(hide);
            Controls.Add(log_in_button);
            Controls.Add(password_label);
            Controls.Add(password_box);
            Controls.Add(login_label);
            Controls.Add(login_box);
            Name = "LoginScreen";
            Text = "LoginScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_box;
        private Label login_label;
        private Label password_label;
        private TextBox password_box;
        private Button log_in_button;
        private Label hide;
        private Button register_button;
    }
}