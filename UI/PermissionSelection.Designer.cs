namespace UI
{
    partial class PermissionSelection
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
            shopkeeperBtn = new Button();
            manager = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // shopkeeperBtn
            // 
            shopkeeperBtn.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            shopkeeperBtn.ForeColor = Color.Navy;
            shopkeeperBtn.Location = new Point(617, 275);
            shopkeeperBtn.Name = "shopkeeperBtn";
            shopkeeperBtn.Size = new Size(400, 300);
            shopkeeperBtn.TabIndex = 0;
            shopkeeperBtn.Text = "קופאי";
            shopkeeperBtn.UseVisualStyleBackColor = true;
            shopkeeperBtn.Click += shopkeeperBtn_Click;
            // 
            // manager
            // 
            manager.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold);
            manager.ForeColor = Color.Navy;
            manager.Location = new Point(201, 275);
            manager.Name = "manager";
            manager.Size = new Size(400, 300);
            manager.TabIndex = 1;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += manager_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.יפה_נוף;
            button1.Location = new Point(231, 50);
            button1.Name = "button1";
            button1.Size = new Size(759, 219);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // PermissionSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.יפה_נוף;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1232, 843);
            Controls.Add(button1);
            Controls.Add(manager);
            Controls.Add(shopkeeperBtn);
            DoubleBuffered = true;
            Name = "PermissionSelection";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "יפה נוף";
            ResumeLayout(false);
        }

        #endregion

        private Button shopkeeperBtn;
        private Button manager;
        private Button button1;
    }
}