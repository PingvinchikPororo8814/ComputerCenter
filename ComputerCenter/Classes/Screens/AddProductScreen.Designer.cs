namespace ComputerCenter.Classes.Screens
{
    partial class AddProductScreen
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
            name_label = new Label();
            name_box = new TextBox();
            description_box = new TextBox();
            description_label = new Label();
            price_box = new TextBox();
            price_label = new Label();
            quantity_box = new TextBox();
            quantity_label = new Label();
            add_button = new Button();
            category_box = new TextBox();
            category_label = new Label();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name_label.Location = new Point(55, 9);
            name_label.Name = "name_label";
            name_label.Size = new Size(53, 23);
            name_label.TabIndex = 0;
            name_label.Text = "Name";
            // 
            // name_box
            // 
            name_box.BackColor = SystemColors.ScrollBar;
            name_box.Location = new Point(114, 12);
            name_box.Name = "name_box";
            name_box.Size = new Size(136, 23);
            name_box.TabIndex = 1;
            // 
            // description_box
            // 
            description_box.BackColor = SystemColors.ScrollBar;
            description_box.Location = new Point(114, 153);
            description_box.Name = "description_box";
            description_box.Size = new Size(329, 23);
            description_box.TabIndex = 3;
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            description_label.Location = new Point(12, 150);
            description_label.Name = "description_label";
            description_label.Size = new Size(96, 23);
            description_label.TabIndex = 2;
            description_label.Text = "Description";
            // 
            // price_box
            // 
            price_box.BackColor = SystemColors.ScrollBar;
            price_box.Location = new Point(114, 56);
            price_box.Name = "price_box";
            price_box.Size = new Size(136, 23);
            price_box.TabIndex = 5;
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            price_label.Location = new Point(60, 56);
            price_label.Name = "price_label";
            price_label.Size = new Size(48, 23);
            price_label.TabIndex = 4;
            price_label.Text = "Price";
            // 
            // quantity_box
            // 
            quantity_box.BackColor = SystemColors.ScrollBar;
            quantity_box.Location = new Point(114, 95);
            quantity_box.Name = "quantity_box";
            quantity_box.Size = new Size(136, 23);
            quantity_box.TabIndex = 7;
            // 
            // quantity_label
            // 
            quantity_label.AutoSize = true;
            quantity_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            quantity_label.Location = new Point(30, 95);
            quantity_label.Name = "quantity_label";
            quantity_label.Size = new Size(78, 23);
            quantity_label.TabIndex = 6;
            quantity_label.Text = "Quantity";
            // 
            // add_button
            // 
            add_button.BackColor = SystemColors.ActiveBorder;
            add_button.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            add_button.Location = new Point(114, 241);
            add_button.Name = "add_button";
            add_button.Size = new Size(136, 38);
            add_button.TabIndex = 8;
            add_button.Text = "Add Product";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // category_box
            // 
            category_box.BackColor = SystemColors.ScrollBar;
            category_box.Location = new Point(114, 124);
            category_box.Name = "category_box";
            category_box.Size = new Size(136, 23);
            category_box.TabIndex = 10;
            // 
            // category_label
            // 
            category_label.AutoSize = true;
            category_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            category_label.Location = new Point(28, 121);
            category_label.Name = "category_label";
            category_label.Size = new Size(80, 23);
            category_label.TabIndex = 9;
            category_label.Text = "Category";
            // 
            // AddProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 320);
            Controls.Add(category_box);
            Controls.Add(category_label);
            Controls.Add(add_button);
            Controls.Add(quantity_box);
            Controls.Add(quantity_label);
            Controls.Add(price_box);
            Controls.Add(price_label);
            Controls.Add(description_box);
            Controls.Add(description_label);
            Controls.Add(name_box);
            Controls.Add(name_label);
            Name = "AddProductScreen";
            Text = "AddProductScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private TextBox name_box;
        private TextBox description_box;
        private Label description_label;
        private TextBox price_box;
        private Label price_label;
        private TextBox quantity_box;
        private Label quantity_label;
        private Button add_button;
        private TextBox category_box;
        private Label category_label;
    }
}