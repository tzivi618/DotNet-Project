namespace UI
{
    partial class OrdersForm
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
            chooseProducts = new ComboBox();
            addToOrderBtn = new Button();
            quantityForSaleUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            allProductInOrderTbl = new DataGridView();
            prodId = new DataGridViewTextBoxColumn();
            prodName = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            BasePrice = new DataGridViewTextBoxColumn();
            FinalPrice = new DataGridViewTextBoxColumn();
            productPrice = new DataGridViewTextBoxColumn();
            payOrderBtn = new Button();
            helloCustomer = new Label();
            totalPriceToDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)quantityForSaleUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allProductInOrderTbl).BeginInit();
            SuspendLayout();
            // 
            // chooseProducts
            // 
            chooseProducts.FormattingEnabled = true;
            chooseProducts.Location = new Point(221, 158);
            chooseProducts.Margin = new Padding(3, 4, 3, 4);
            chooseProducts.Name = "chooseProducts";
            chooseProducts.RightToLeft = RightToLeft.Yes;
            chooseProducts.Size = new Size(200, 28);
            chooseProducts.TabIndex = 0;
            // 
            // addToOrderBtn
            // 
            addToOrderBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToOrderBtn.Location = new Point(130, 270);
            addToOrderBtn.Margin = new Padding(3, 4, 3, 4);
            addToOrderBtn.Name = "addToOrderBtn";
            addToOrderBtn.Size = new Size(291, 53);
            addToOrderBtn.TabIndex = 2;
            addToOrderBtn.Text = "הוסף לעגלה";
            addToOrderBtn.UseVisualStyleBackColor = true;
            addToOrderBtn.Click += button1_Click;
            // 
            // quantityForSaleUpDown
            // 
            quantityForSaleUpDown.Location = new Point(221, 206);
            quantityForSaleUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            quantityForSaleUpDown.Name = "quantityForSaleUpDown";
            quantityForSaleUpDown.RightToLeft = RightToLeft.Yes;
            quantityForSaleUpDown.Size = new Size(200, 27);
            quantityForSaleUpDown.TabIndex = 3;
            quantityForSaleUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 161);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 4;
            label1.Text = "בחר מוצר";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 208);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "כמות";
            // 
            // allProductInOrderTbl
            // 
            allProductInOrderTbl.BackgroundColor = SystemColors.ButtonHighlight;
            allProductInOrderTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allProductInOrderTbl.Columns.AddRange(new DataGridViewColumn[] { prodId, prodName, quantity, BasePrice, FinalPrice });
            allProductInOrderTbl.Enabled = false;
            allProductInOrderTbl.GridColor = Color.Black;
            allProductInOrderTbl.Location = new Point(506, 36);
            allProductInOrderTbl.Name = "allProductInOrderTbl";
            allProductInOrderTbl.RightToLeft = RightToLeft.Yes;
            allProductInOrderTbl.RowHeadersWidth = 51;
            allProductInOrderTbl.Size = new Size(679, 599);
            allProductInOrderTbl.TabIndex = 6;
            // 
            // prodId
            // 
            prodId.HeaderText = "מזהה מוצר";
            prodId.MinimumWidth = 6;
            prodId.Name = "prodId";
            prodId.ToolTipText = "טיפ";
            prodId.Width = 125;
            // 
            // prodName
            // 
            prodName.HeaderText = "שם מוצר";
            prodName.MinimumWidth = 6;
            prodName.Name = "prodName";
            prodName.Width = 125;
            // 
            // quantity
            // 
            quantity.HeaderText = "כמות";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Width = 125;
            // 
            // BasePrice
            // 
            BasePrice.HeaderText = "מחיר בסיסי ליחידה";
            BasePrice.MinimumWidth = 6;
            BasePrice.Name = "BasePrice";
            BasePrice.Width = 125;
            // 
            // FinalPrice
            // 
            FinalPrice.HeaderText = "מחיר סופי";
            FinalPrice.MinimumWidth = 6;
            FinalPrice.Name = "FinalPrice";
            FinalPrice.Width = 125;
            // 
            // productPrice
            // 
            productPrice.HeaderText = "מחיר";
            productPrice.MinimumWidth = 6;
            productPrice.Name = "productPrice";
            productPrice.ReadOnly = true;
            productPrice.Visible = false;
            productPrice.Width = 125;
            // 
            // payOrderBtn
            // 
            payOrderBtn.BackColor = Color.LightSteelBlue;
            payOrderBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payOrderBtn.Location = new Point(897, 731);
            payOrderBtn.Name = "payOrderBtn";
            payOrderBtn.Size = new Size(288, 74);
            payOrderBtn.TabIndex = 7;
            payOrderBtn.Text = "לסיום ההזמנה ותשלום";
            payOrderBtn.UseVisualStyleBackColor = false;
            payOrderBtn.Click += payOrderBtn_Click;
            // 
            // helloCustomer
            // 
            helloCustomer.AutoSize = true;
            helloCustomer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helloCustomer.ForeColor = Color.Navy;
            helloCustomer.Location = new Point(130, 75);
            helloCustomer.Name = "helloCustomer";
            helloCustomer.Size = new Size(104, 41);
            helloCustomer.TabIndex = 9;
            helloCustomer.Text = "label3";
            // 
            // totalPriceToDisplay
            // 
            totalPriceToDisplay.AutoSize = true;
            totalPriceToDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            totalPriceToDisplay.Location = new Point(506, 660);
            totalPriceToDisplay.Name = "totalPriceToDisplay";
            totalPriceToDisplay.Size = new Size(70, 28);
            totalPriceToDisplay.TabIndex = 10;
            totalPriceToDisplay.Text = "label3";
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 843);
            Controls.Add(totalPriceToDisplay);
            Controls.Add(helloCustomer);
            Controls.Add(payOrderBtn);
            Controls.Add(allProductInOrderTbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quantityForSaleUpDown);
            Controls.Add(addToOrderBtn);
            Controls.Add(chooseProducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdersForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ביצוע הזמנה";
            ((System.ComponentModel.ISupportInitialize)quantityForSaleUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)allProductInOrderTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox chooseProducts;
        private Button addToOrderBtn;
        private NumericUpDown quantityForSaleUpDown;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
        private DataGridView allProductInOrderTbl;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn prodId;
        private DataGridViewTextBoxColumn prodName;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn BasePrice;
        private DataGridViewTextBoxColumn FinalPrice;
        private Button payOrderBtn;
        private Label helloCustomer;
        private Label totalPriceToDisplay;
    }
}