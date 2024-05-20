namespace ComputerCenter.Classes.Screens
{
    partial class RegisterScreen
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
            label1 = new Label();
            login_box = new TextBox();
            password_box = new TextBox();
            label2 = new Label();
            repeat_box = new TextBox();
            label3 = new Label();
            button1 = new Button();
            hide2 = new Label();
            hide1 = new Label();
            name_box = new TextBox();
            name_label = new Label();
            email_box = new TextBox();
            email_label = new Label();
            surname_box = new TextBox();
            surname_label = new Label();
            address_box = new TextBox();
            address_label = new Label();
            phone_box = new TextBox();
            phone_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // login_box
            // 
            login_box.BackColor = SystemColors.ScrollBar;
            login_box.Location = new Point(152, 9);
            login_box.Name = "login_box";
            login_box.Size = new Size(144, 23);
            login_box.TabIndex = 1;
            // 
            // password_box
            // 
            password_box.BackColor = SystemColors.ScrollBar;
            password_box.Location = new Point(152, 106);
            password_box.Name = "password_box";
            password_box.Size = new Size(144, 23);
            password_box.TabIndex = 3;
            password_box.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 106);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // repeat_box
            // 
            repeat_box.BackColor = SystemColors.ScrollBar;
            repeat_box.Location = new Point(152, 151);
            repeat_box.Name = "repeat_box";
            repeat_box.Size = new Size(144, 23);
            repeat_box.TabIndex = 5;
            repeat_box.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 151);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 4;
            label3.Text = "Repeat Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(298, 209);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // hide2
            // 
            hide2.AutoSize = true;
            hide2.BackColor = SystemColors.ScrollBar;
            hide2.Image = Properties.Resources.view;
            hide2.Location = new Point(274, 155);
            hide2.MaximumSize = new Size(16, 16);
            hide2.MinimumSize = new Size(16, 16);
            hide2.Name = "hide2";
            hide2.Size = new Size(16, 16);
            hide2.TabIndex = 7;
            hide2.Click += hide2_Click;
            // 
            // hide1
            // 
            hide1.AutoSize = true;
            hide1.BackColor = SystemColors.ScrollBar;
            hide1.Image = Properties.Resources.view;
            hide1.Location = new Point(274, 111);
            hide1.MaximumSize = new Size(16, 16);
            hide1.MinimumSize = new Size(16, 16);
            hide1.Name = "hide1";
            hide1.Size = new Size(16, 16);
            hide1.TabIndex = 8;
            hide1.Click += hide_Click;
            // 
            // name_box
            // 
            name_box.BackColor = SystemColors.ScrollBar;
            name_box.Location = new Point(152, 58);
            name_box.Name = "name_box";
            name_box.Size = new Size(144, 23);
            name_box.TabIndex = 10;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name_label.Location = new Point(93, 55);
            name_label.Name = "name_label";
            name_label.Size = new Size(53, 23);
            name_label.TabIndex = 9;
            name_label.Text = "Name";
            // 
            // email_box
            // 
            email_box.BackColor = SystemColors.ScrollBar;
            email_box.Location = new Point(414, 9);
            email_box.Name = "email_box";
            email_box.Size = new Size(231, 23);
            email_box.TabIndex = 12;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            email_label.Location = new Point(359, 9);
            email_label.Name = "email_label";
            email_label.Size = new Size(49, 23);
            email_label.TabIndex = 11;
            email_label.Text = "Email";
            // 
            // surname_box
            // 
            surname_box.BackColor = SystemColors.ScrollBar;
            surname_box.Location = new Point(414, 61);
            surname_box.Name = "surname_box";
            surname_box.Size = new Size(231, 23);
            surname_box.TabIndex = 14;
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            surname_label.Location = new Point(333, 58);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(75, 23);
            surname_label.TabIndex = 13;
            surname_label.Text = "Surname";
            // 
            // address_box
            // 
            address_box.BackColor = SystemColors.ScrollBar;
            address_box.Location = new Point(414, 107);
            address_box.Name = "address_box";
            address_box.Size = new Size(231, 23);
            address_box.TabIndex = 16;
            // 
            // address_label
            // 
            address_label.AutoSize = true;
            address_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            address_label.Location = new Point(335, 104);
            address_label.Name = "address_label";
            address_label.Size = new Size(73, 23);
            address_label.TabIndex = 15;
            address_label.Text = "Address";
            // 
            // phone_box
            // 
            phone_box.BackColor = SystemColors.ScrollBar;
            phone_box.Location = new Point(414, 151);
            phone_box.Name = "phone_box";
            phone_box.Size = new Size(231, 23);
            phone_box.TabIndex = 18;
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phone_label.Location = new Point(355, 148);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(53, 23);
            phone_label.TabIndex = 17;
            phone_label.Text = "Phone";
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 276);
            Controls.Add(phone_box);
            Controls.Add(phone_label);
            Controls.Add(address_box);
            Controls.Add(address_label);
            Controls.Add(surname_box);
            Controls.Add(surname_label);
            Controls.Add(email_box);
            Controls.Add(email_label);
            Controls.Add(name_box);
            Controls.Add(name_label);
            Controls.Add(hide1);
            Controls.Add(hide2);
            Controls.Add(button1);
            Controls.Add(repeat_box);
            Controls.Add(label3);
            Controls.Add(password_box);
            Controls.Add(label2);
            Controls.Add(login_box);
            Controls.Add(label1);
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox login_box;
        private TextBox password_box;
        private Label label2;
        private TextBox repeat_box;
        private Label label3;
        private Button button1;
        private Label hide2;
        private Label hide1;
        private TextBox name_box;
        private Label name_label;
        private TextBox email_box;
        private Label email_label;
        private TextBox surname_box;
        private Label surname_label;
        private TextBox address_box;
        private Label address_label;
        private TextBox phone_box;
        private Label phone_label;
    }
}