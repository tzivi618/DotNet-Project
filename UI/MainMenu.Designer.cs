namespace UI
{
    partial class MainMenu
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
            customersButton = new Button();
            salesButton = new Button();
            productsButton = new Button();
            CleanOldLogDirectories = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // customersButton
            // 
            customersButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            customersButton.ForeColor = Color.Navy;
            customersButton.Location = new Point(153, 408);
            customersButton.Margin = new Padding(3, 4, 3, 4);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(300, 200);
            customersButton.TabIndex = 0;
            customersButton.Text = "לקוחות";
            customersButton.UseVisualStyleBackColor = true;
            customersButton.Click += customersButton_Click_1;
            // 
            // salesButton
            // 
            salesButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            salesButton.ForeColor = Color.Navy;
            salesButton.Location = new Point(765, 408);
            salesButton.Margin = new Padding(3, 4, 3, 4);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(300, 200);
            salesButton.TabIndex = 1;
            salesButton.Text = "מבצעים";
            salesButton.UseVisualStyleBackColor = true;
            salesButton.Click += salesButton_Click;
            // 
            // productsButton
            // 
            productsButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            productsButton.ForeColor = Color.Navy;
            productsButton.Location = new Point(459, 408);
            productsButton.Margin = new Padding(3, 4, 3, 4);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(300, 200);
            productsButton.TabIndex = 2;
            productsButton.Text = "מוצרים";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // CleanOldLogDirectories
            // 
            CleanOldLogDirectories.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CleanOldLogDirectories.ForeColor = Color.Teal;
            CleanOldLogDirectories.Location = new Point(1093, 39);
            CleanOldLogDirectories.Name = "CleanOldLogDirectories";
            CleanOldLogDirectories.Size = new Size(112, 107);
            CleanOldLogDirectories.TabIndex = 3;
            CleanOldLogDirectories.Text = "ניקוי הלוגים";
            CleanOldLogDirectories.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.יפה_נוף;
            button1.Location = new Point(246, 123);
            button1.Name = "button1";
            button1.Size = new Size(759, 219);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(444, 30);
            label1.Name = "label1";
            label1.Size = new Size(326, 62);
            label1.TabIndex = 5;
            label1.Text = "שלום לך מנהל";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 843);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(CleanOldLogDirectories);
            Controls.Add(productsButton);
            Controls.Add(salesButton);
            Controls.Add(customersButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "תפריט מנהל";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button customersButton;
        private Button salesButton;
        private Button productsButton;
        private Button CleanOldLogDirectories;
        private Button button1;
        private Label label1;
    }
}