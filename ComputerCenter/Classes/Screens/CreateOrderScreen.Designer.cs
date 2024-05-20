namespace ComputerCenter.Classes.Screens
{
    partial class CreateOrderScreen
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
            name_box = new TextBox();
            name_label = new Label();
            quantity_box = new TextBox();
            quantity_label = new Label();
            order_button = new Button();
            SuspendLayout();
            // 
            // name_box
            // 
            name_box.BackColor = SystemColors.ScrollBar;
            name_box.Location = new Point(96, 9);
            name_box.Name = "name_box";
            name_box.Size = new Size(136, 23);
            name_box.TabIndex = 3;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name_label.Location = new Point(37, 9);
            name_label.Name = "name_label";
            name_label.Size = new Size(53, 23);
            name_label.TabIndex = 2;
            name_label.Text = "Name";
            // 
            // quantity_box
            // 
            quantity_box.BackColor = SystemColors.ScrollBar;
            quantity_box.Location = new Point(96, 50);
            quantity_box.Name = "quantity_box";
            quantity_box.Size = new Size(136, 23);
            quantity_box.TabIndex = 9;
            // 
            // quantity_label
            // 
            quantity_label.AutoSize = true;
            quantity_label.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            quantity_label.Location = new Point(12, 47);
            quantity_label.Name = "quantity_label";
            quantity_label.Size = new Size(78, 23);
            quantity_label.TabIndex = 8;
            quantity_label.Text = "Quantity";
            // 
            // order_button
            // 
            order_button.BackColor = SystemColors.ActiveBorder;
            order_button.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            order_button.Location = new Point(63, 92);
            order_button.Name = "order_button";
            order_button.Size = new Size(128, 38);
            order_button.TabIndex = 10;
            order_button.Text = "Order now";
            order_button.UseVisualStyleBackColor = false;
            order_button.Click += order_button_Click;
            // 
            // CreateOrderScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 142);
            Controls.Add(order_button);
            Controls.Add(quantity_box);
            Controls.Add(quantity_label);
            Controls.Add(name_box);
            Controls.Add(name_label);
            Name = "CreateOrderScreen";
            Text = "CreateOrderScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_box;
        private Label name_label;
        private TextBox quantity_box;
        private Label quantity_label;
        private Button order_button;
    }
}