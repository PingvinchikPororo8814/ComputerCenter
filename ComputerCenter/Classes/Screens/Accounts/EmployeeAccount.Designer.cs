namespace ComputerCenter.Classes.Screens
{
    partial class EmployeeAccount
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
            open_products = new Button();
            SuspendLayout();
            // 
            // open_products
            // 
            open_products.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            open_products.Location = new Point(435, 325);
            open_products.Name = "open_products";
            open_products.Size = new Size(84, 35);
            open_products.TabIndex = 2;
            open_products.Text = "Products";
            open_products.UseVisualStyleBackColor = true;
            open_products.Click += open_products_Click;
            // 
            // EmployeeAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 372);
            Controls.Add(open_products);
            Name = "EmployeeAccount";
            Text = "EmployeeAccount";
            Controls.SetChildIndex(name_label, 0);
            Controls.SetChildIndex(open_products, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button open_products;
    }
}