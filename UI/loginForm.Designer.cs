namespace UI
{
    partial class loginForm
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
            customerIdLogin = new TextBox();
            label1 = new Label();
            checkCustomerBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // customerIdLogin
            // 
            customerIdLogin.Location = new Point(313, 180);
            customerIdLogin.Name = "customerIdLogin";
            customerIdLogin.Size = new Size(197, 27);
            customerIdLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 123);
            label1.Name = "label1";
            label1.Size = new Size(216, 31);
            label1.TabIndex = 1;
            label1.Text = "נא הכנס מזהה לקוח";
            // 
            // checkCustomerBtn
            // 
            checkCustomerBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkCustomerBtn.Location = new Point(354, 236);
            checkCustomerBtn.Name = "checkCustomerBtn";
            checkCustomerBtn.Size = new Size(121, 57);
            checkCustomerBtn.TabIndex = 2;
            checkCustomerBtn.Text = "הבא";
            checkCustomerBtn.UseVisualStyleBackColor = true;
            checkCustomerBtn.Click += checkCustomerBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(281, 44);
            label2.Name = "label2";
            label2.Size = new Size(229, 41);
            label2.TabIndex = 3;
            label2.Text = " שלום לך קופאי";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(checkCustomerBtn);
            Controls.Add(label1);
            Controls.Add(customerIdLogin);
            Name = "loginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "זיהוי לקוחות לעריכת חשבון";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customerIdLogin;
        private Label label1;
        private Button checkCustomerBtn;
        private Label label2;
    }
}