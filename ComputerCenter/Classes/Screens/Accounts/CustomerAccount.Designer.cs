namespace ComputerCenter.Classes.Screens
{
    partial class CustomerAccount
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
            orders_list = new ListView();
            id = new ColumnHeader();
            product = new ColumnHeader();
            price = new ColumnHeader();
            date = new ColumnHeader();
            create_order = new Button();
            SuspendLayout();
            // 
            // orders_list
            // 
            orders_list.BackColor = Color.Gray;
            orders_list.BorderStyle = BorderStyle.FixedSingle;
            orders_list.Columns.AddRange(new ColumnHeader[] { id, product, price, date });
            orders_list.ForeColor = Color.White;
            orders_list.FullRowSelect = true;
            orders_list.GridLines = true;
            orders_list.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            orders_list.Location = new Point(135, 12);
            orders_list.Name = "orders_list";
            orders_list.ShowItemToolTips = true;
            orders_list.Size = new Size(415, 255);
            orders_list.TabIndex = 48;
            orders_list.UseCompatibleStateImageBehavior = false;
            orders_list.View = View.Details;
            orders_list.ColumnWidthChanging += products_list_ColumnWidthChanging;
            orders_list.ItemActivate += orders_list_ItemActivate;
            // 
            // id
            // 
            id.Tag = "";
            id.Text = "Id";
            id.Width = 40;
            // 
            // product
            // 
            product.Text = "Product";
            product.Width = 200;
            // 
            // price
            // 
            price.Text = "Price";
            price.Width = 75;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 100;
            // 
            // create_order
            // 
            create_order.AutoSize = true;
            create_order.BackColor = SystemColors.ActiveCaption;
            create_order.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            create_order.Location = new Point(12, 307);
            create_order.Name = "create_order";
            create_order.Size = new Size(127, 51);
            create_order.TabIndex = 49;
            create_order.Text = "Create Order";
            create_order.UseVisualStyleBackColor = false;
            create_order.Click += create_order_Click;
            // 
            // CustomerAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 370);
            Controls.Add(create_order);
            Controls.Add(orders_list);
            Name = "CustomerAccount";
            Text = "CustomerAccount";
            Activated += CustomerAccount_Activated;
            Controls.SetChildIndex(name_label, 0);
            Controls.SetChildIndex(orders_list, 0);
            Controls.SetChildIndex(create_order, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView orders_list;
        private ColumnHeader id;
        private ColumnHeader product;
        private ColumnHeader price;
        private ColumnHeader date;
        private Button create_order;
    }
}