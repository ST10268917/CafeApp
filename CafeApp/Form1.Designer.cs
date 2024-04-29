namespace CafeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            items = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            quantity = new TextBox();
            addItemButton = new Button();
            displayReceiptButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(319, 30);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "CAFE APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 260);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Item:";
            // 
            // items
            // 
            items.FormattingEnabled = true;
            items.Items.AddRange(new object[] { "Burger", "Pizza", "Iced Coffee", "Tea", "Chocolate" });
            items.Location = new Point(382, 252);
            items.Name = "items";
            items.Size = new Size(151, 28);
            items.TabIndex = 2;
            items.Items.Insert(0, "Select an item");
            items.SelectedIndex = 0;
            items.SelectedIndexChanged += items_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 71);
            label3.Name = "label3";
            label3.Size = new Size(146, 160);
            label3.TabIndex = 3;
            label3.Text = "Price List:\r\n\r\nBurger: R25.00\r\nPizza: R10.00\r\nIced Coffee: R12.00\r\nTea: R7.00\r\nChocolate: R9.00\r\n\r\n";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 317);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            // 
            // quantity
            // 
            quantity.Location = new Point(382, 317);
            quantity.Name = "quantity";
            quantity.PlaceholderText = "Enter  a value";
            quantity.Size = new Size(125, 27);
            quantity.TabIndex = 5;
            // 
            // addItemButton
            // 
            addItemButton.BackColor = Color.PaleGreen;
            addItemButton.Location = new Point(359, 400);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(118, 40);
            addItemButton.TabIndex = 6;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += addItemButton_Click;
            // 
            // displayReceiptButton
            // 
            displayReceiptButton.BackColor = Color.LightSalmon;
            displayReceiptButton.Location = new Point(612, 457);
            displayReceiptButton.Name = "displayReceiptButton";
            displayReceiptButton.Size = new Size(146, 40);
            displayReceiptButton.TabIndex = 7;
            displayReceiptButton.Text = " Display Receipt";
            displayReceiptButton.UseVisualStyleBackColor = false;
            displayReceiptButton.Click += displayReceipt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(displayReceiptButton);
            Controls.Add(addItemButton);
            Controls.Add(quantity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(items);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox items;
        private Label label3;
        private Label label4;
        private TextBox quantity;
        private Button addItemButton;
        private Button displayReceiptButton;
    }
}
