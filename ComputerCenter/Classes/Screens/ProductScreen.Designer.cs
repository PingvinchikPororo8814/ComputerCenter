namespace ComputerCenter.Classes.Screens
{
    partial class ProductScreen
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
            products_list = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            price = new ColumnHeader();
            quantity = new ColumnHeader();
            description = new ColumnHeader();
            delete_product_button = new Button();
            add_product_button = new Button();
            category = new ColumnHeader();
            SuspendLayout();
            // 
            // products_list
            // 
            products_list.BackColor = Color.Gray;
            products_list.BorderStyle = BorderStyle.FixedSingle;
            products_list.Columns.AddRange(new ColumnHeader[] { id, name, price, quantity, category, description });
            products_list.ForeColor = Color.White;
            products_list.FullRowSelect = true;
            products_list.GridLines = true;
            products_list.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            products_list.Location = new Point(12, 12);
            products_list.Name = "products_list";
            products_list.ShowItemToolTips = true;
            products_list.Size = new Size(706, 426);
            products_list.TabIndex = 47;
            products_list.UseCompatibleStateImageBehavior = false;
            products_list.View = View.Details;
            products_list.ColumnWidthChanging += products_list_ColumnWidthChanging;
            // 
            // id
            // 
            id.Tag = "";
            id.Text = "Id";
            id.Width = 40;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 100;
            // 
            // price
            // 
            price.Text = "Price";
            price.Width = 75;
            // 
            // quantity
            // 
            quantity.Text = "Quantity";
            // 
            // description
            // 
            description.DisplayIndex = 4;
            description.Text = "Description";
            description.Width = 330;
            // 
            // delete_product_button
            // 
            delete_product_button.BackColor = SystemColors.ControlDarkDark;
            delete_product_button.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            delete_product_button.ForeColor = SystemColors.ButtonFace;
            delete_product_button.Location = new Point(771, 403);
            delete_product_button.Name = "delete_product_button";
            delete_product_button.Size = new Size(128, 35);
            delete_product_button.TabIndex = 48;
            delete_product_button.Text = "Delete product(s)";
            delete_product_button.UseVisualStyleBackColor = false;
            delete_product_button.Click += delete_product_button_Click;
            // 
            // add_product_button
            // 
            add_product_button.BackColor = SystemColors.ControlDarkDark;
            add_product_button.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            add_product_button.ForeColor = SystemColors.ButtonFace;
            add_product_button.Location = new Point(771, 343);
            add_product_button.Name = "add_product_button";
            add_product_button.Size = new Size(128, 35);
            add_product_button.TabIndex = 49;
            add_product_button.Text = "Add product";
            add_product_button.UseVisualStyleBackColor = false;
            add_product_button.Click += add_product_button_Click;
            // 
            // category
            // 
            category.Text = "Category";
            category.Width = 100;
            // 
            // ProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 450);
            Controls.Add(add_product_button);
            Controls.Add(delete_product_button);
            Controls.Add(products_list);
            Name = "ProductScreen";
            Text = "ProductScreen";
            Activated += ProductScreen_Activated;
            ResumeLayout(false);
        }

        #endregion

        private ListView products_list;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader price;
        private ColumnHeader quantity;
        private ColumnHeader description;
        private Button delete_product_button;
        private Button add_product_button;
        private ColumnHeader category;
    }
}