
namespace UI
{
    partial class SaleForm
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
            tabControlSale = new TabControl();
            tabAdd = new TabPage();
            addSaleBtn = new Button();
            label7 = new Label();
            TotalPriceSale = new NumericUpDown();
            label6 = new Label();
            checkIsAllCustomer = new CheckBox();
            label5 = new Label();
            EndDateCheck = new DateTimePicker();
            label4 = new Label();
            StartDateCheck = new DateTimePicker();
            label3 = new Label();
            QuentityForSale = new NumericUpDown();
            label2 = new Label();
            prodIdInput = new TextBox();
            tabUpdate = new TabPage();
            saveCustomerUpdate = new Button();
            label9 = new Label();
            totalPriceForSale = new NumericUpDown();
            label10 = new Label();
            isAllCustomer = new CheckBox();
            label11 = new Label();
            endDate = new DateTimePicker();
            label12 = new Label();
            startDate = new DateTimePicker();
            label13 = new Label();
            quantityForSale = new NumericUpDown();
            label14 = new Label();
            prodId = new TextBox();
            updateBtn = new Button();
            label8 = new Label();
            idInputToUpdate = new TextBox();
            tabDelete = new TabPage();
            idBottonToDelete = new Button();
            label16 = new Label();
            idInputToDelete = new TextBox();
            deleteBtn = new Button();
            saleDetialsToDelete = new ListBox();
            tabRead = new TabPage();
            idInputToReadOne = new TextBox();
            saleDetailInReadOne = new ListBox();
            label17 = new Label();
            readBtn = new Button();
            allSaleListBox = new ListBox();
            searchInput = new TextBox();
            label1 = new Label();
            tabControlSale.SuspendLayout();
            tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TotalPriceSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuentityForSale).BeginInit();
            tabUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalPriceForSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityForSale).BeginInit();
            tabDelete.SuspendLayout();
            tabRead.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlSale
            // 
            tabControlSale.Controls.Add(tabAdd);
            tabControlSale.Controls.Add(tabUpdate);
            tabControlSale.Controls.Add(tabDelete);
            tabControlSale.Controls.Add(tabRead);
            tabControlSale.Location = new Point(62, 82);
            tabControlSale.Margin = new Padding(3, 4, 3, 4);
            tabControlSale.Name = "tabControlSale";
            tabControlSale.RightToLeft = RightToLeft.Yes;
            tabControlSale.RightToLeftLayout = true;
            tabControlSale.SelectedIndex = 0;
            tabControlSale.Size = new Size(500, 600);
            tabControlSale.TabIndex = 0;
            tabControlSale.SelectedIndexChanged += tabControlSale_SelectedIndexChanged;
            // 
            // tabAdd
            // 
            tabAdd.Controls.Add(addSaleBtn);
            tabAdd.Controls.Add(label7);
            tabAdd.Controls.Add(TotalPriceSale);
            tabAdd.Controls.Add(label6);
            tabAdd.Controls.Add(checkIsAllCustomer);
            tabAdd.Controls.Add(label5);
            tabAdd.Controls.Add(EndDateCheck);
            tabAdd.Controls.Add(label4);
            tabAdd.Controls.Add(StartDateCheck);
            tabAdd.Controls.Add(label3);
            tabAdd.Controls.Add(QuentityForSale);
            tabAdd.Controls.Add(label2);
            tabAdd.Controls.Add(prodIdInput);
            tabAdd.Location = new Point(4, 29);
            tabAdd.Margin = new Padding(3, 4, 3, 4);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new Padding(3, 4, 3, 4);
            tabAdd.Size = new Size(492, 567);
            tabAdd.TabIndex = 0;
            tabAdd.Text = "הוספה";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // addSaleBtn
            // 
            addSaleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addSaleBtn.Location = new Point(79, 328);
            addSaleBtn.Margin = new Padding(3, 4, 3, 4);
            addSaleBtn.Name = "addSaleBtn";
            addSaleBtn.Size = new Size(100, 50);
            addSaleBtn.TabIndex = 17;
            addSaleBtn.Text = "הוספה";
            addSaleBtn.UseVisualStyleBackColor = true;
            addSaleBtn.Click += addSaleBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 151);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 16;
            label7.Text = "מחיר כולל";
            label7.Click += label7_Click;
            // 
            // TotalPriceSale
            // 
            TotalPriceSale.Location = new Point(79, 149);
            TotalPriceSale.Margin = new Padding(3, 4, 3, 4);
            TotalPriceSale.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            TotalPriceSale.Name = "TotalPriceSale";
            TotalPriceSale.Size = new Size(200, 27);
            TotalPriceSale.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 189);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 14;
            label6.Text = "המבצע מיועד לכלל הלקוחות";
            label6.Click += label6_Click;
            // 
            // checkIsAllCustomer
            // 
            checkIsAllCustomer.AutoSize = true;
            checkIsAllCustomer.Location = new Point(79, 192);
            checkIsAllCustomer.Margin = new Padding(3, 4, 3, 4);
            checkIsAllCustomer.Name = "checkIsAllCustomer";
            checkIsAllCustomer.Size = new Size(18, 17);
            checkIsAllCustomer.TabIndex = 13;
            checkIsAllCustomer.UseVisualStyleBackColor = true;
            checkIsAllCustomer.CheckedChanged += checkIsAllCustomer_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 271);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 12;
            label5.Text = "תאריך סיום מבצע";
            label5.Click += label5_Click;
            // 
            // EndDateCheck
            // 
            EndDateCheck.Location = new Point(79, 266);
            EndDateCheck.Margin = new Padding(3, 4, 3, 4);
            EndDateCheck.Name = "EndDateCheck";
            EndDateCheck.Size = new Size(200, 27);
            EndDateCheck.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 228);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 10;
            label4.Text = "תאריך התחלת מבצע";
            label4.Click += label4_Click;
            // 
            // StartDateCheck
            // 
            StartDateCheck.Location = new Point(79, 223);
            StartDateCheck.Margin = new Padding(3, 4, 3, 4);
            StartDateCheck.Name = "StartDateCheck";
            StartDateCheck.Size = new Size(200, 27);
            StartDateCheck.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 112);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 8;
            label3.Text = "כמות למבצע";
            label3.Click += label3_Click;
            // 
            // QuentityForSale
            // 
            QuentityForSale.Location = new Point(79, 105);
            QuentityForSale.Margin = new Padding(3, 4, 3, 4);
            QuentityForSale.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            QuentityForSale.Name = "QuentityForSale";
            QuentityForSale.Size = new Size(200, 27);
            QuentityForSale.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 70);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "מזהה מוצר";
            // 
            // prodIdInput
            // 
            prodIdInput.Location = new Point(79, 67);
            prodIdInput.Margin = new Padding(3, 4, 3, 4);
            prodIdInput.Name = "prodIdInput";
            prodIdInput.Size = new Size(200, 27);
            prodIdInput.TabIndex = 4;
            // 
            // tabUpdate
            // 
            tabUpdate.Controls.Add(saveCustomerUpdate);
            tabUpdate.Controls.Add(label9);
            tabUpdate.Controls.Add(totalPriceForSale);
            tabUpdate.Controls.Add(label10);
            tabUpdate.Controls.Add(isAllCustomer);
            tabUpdate.Controls.Add(label11);
            tabUpdate.Controls.Add(endDate);
            tabUpdate.Controls.Add(label12);
            tabUpdate.Controls.Add(startDate);
            tabUpdate.Controls.Add(label13);
            tabUpdate.Controls.Add(quantityForSale);
            tabUpdate.Controls.Add(label14);
            tabUpdate.Controls.Add(prodId);
            tabUpdate.Controls.Add(updateBtn);
            tabUpdate.Controls.Add(label8);
            tabUpdate.Controls.Add(idInputToUpdate);
            tabUpdate.Location = new Point(4, 29);
            tabUpdate.Margin = new Padding(3, 4, 3, 4);
            tabUpdate.Name = "tabUpdate";
            tabUpdate.Padding = new Padding(3, 4, 3, 4);
            tabUpdate.Size = new Size(492, 567);
            tabUpdate.TabIndex = 1;
            tabUpdate.Text = "עדכון";
            tabUpdate.UseVisualStyleBackColor = true;
            // 
            // saveCustomerUpdate
            // 
            saveCustomerUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            saveCustomerUpdate.Location = new Point(80, 391);
            saveCustomerUpdate.Margin = new Padding(3, 4, 3, 4);
            saveCustomerUpdate.Name = "saveCustomerUpdate";
            saveCustomerUpdate.Size = new Size(100, 50);
            saveCustomerUpdate.TabIndex = 32;
            saveCustomerUpdate.Text = "שמירה";
            saveCustomerUpdate.UseVisualStyleBackColor = true;
            saveCustomerUpdate.Click += saveCustomerUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(358, 225);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 31;
            label9.Text = "מחיר כולל";
            // 
            // totalPriceForSale
            // 
            totalPriceForSale.Location = new Point(80, 223);
            totalPriceForSale.Margin = new Padding(3, 4, 3, 4);
            totalPriceForSale.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            totalPriceForSale.Name = "totalPriceForSale";
            totalPriceForSale.Size = new Size(200, 27);
            totalPriceForSale.TabIndex = 30;
            totalPriceForSale.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(240, 260);
            label10.Name = "label10";
            label10.Size = new Size(191, 20);
            label10.TabIndex = 29;
            label10.Text = "המבצע מיועד לכלל הלקוחות";
            // 
            // isAllCustomer
            // 
            isAllCustomer.AutoSize = true;
            isAllCustomer.Location = new Point(80, 263);
            isAllCustomer.Margin = new Padding(3, 4, 3, 4);
            isAllCustomer.Name = "isAllCustomer";
            isAllCustomer.Size = new Size(18, 17);
            isAllCustomer.TabIndex = 28;
            isAllCustomer.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(308, 340);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 27;
            label11.Text = "תאריך סיום מבצע";
            // 
            // endDate
            // 
            endDate.Location = new Point(80, 335);
            endDate.Margin = new Padding(3, 4, 3, 4);
            endDate.Name = "endDate";
            endDate.Size = new Size(200, 27);
            endDate.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(286, 296);
            label12.Name = "label12";
            label12.Size = new Size(145, 20);
            label12.TabIndex = 25;
            label12.Text = "תאריך התחלת מבצע";
            // 
            // startDate
            // 
            startDate.Location = new Point(80, 296);
            startDate.Margin = new Padding(3, 4, 3, 4);
            startDate.Name = "startDate";
            startDate.Size = new Size(200, 27);
            startDate.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(340, 185);
            label13.Name = "label13";
            label13.Size = new Size(91, 20);
            label13.TabIndex = 23;
            label13.Text = "כמות למבצע";
            // 
            // quantityForSale
            // 
            quantityForSale.Location = new Point(80, 185);
            quantityForSale.Margin = new Padding(3, 4, 3, 4);
            quantityForSale.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantityForSale.Name = "quantityForSale";
            quantityForSale.Size = new Size(200, 27);
            quantityForSale.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(352, 150);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 21;
            label14.Text = "מזהה מוצר";
            // 
            // prodId
            // 
            prodId.Location = new Point(80, 150);
            prodId.Margin = new Padding(3, 4, 3, 4);
            prodId.Name = "prodId";
            prodId.Size = new Size(200, 27);
            prodId.TabIndex = 19;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(161, 64);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(172, 50);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "שלח מזהה מבצע";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(228, 32);
            label8.Name = "label8";
            label8.Size = new Size(243, 20);
            label8.TabIndex = 3;
            label8.Text = "הכנס מזהה מבצע לעדכון פרטי מבצע";
            // 
            // idInputToUpdate
            // 
            idInputToUpdate.Location = new Point(22, 29);
            idInputToUpdate.Margin = new Padding(3, 4, 3, 4);
            idInputToUpdate.Name = "idInputToUpdate";
            idInputToUpdate.Size = new Size(200, 27);
            idInputToUpdate.TabIndex = 0;
            // 
            // tabDelete
            // 
            tabDelete.Controls.Add(idBottonToDelete);
            tabDelete.Controls.Add(label16);
            tabDelete.Controls.Add(idInputToDelete);
            tabDelete.Controls.Add(deleteBtn);
            tabDelete.Controls.Add(saleDetialsToDelete);
            tabDelete.Location = new Point(4, 29);
            tabDelete.Margin = new Padding(3, 4, 3, 4);
            tabDelete.Name = "tabDelete";
            tabDelete.Padding = new Padding(3, 4, 3, 4);
            tabDelete.Size = new Size(492, 567);
            tabDelete.TabIndex = 2;
            tabDelete.Text = "מחיקה";
            tabDelete.UseVisualStyleBackColor = true;
            // 
            // idBottonToDelete
            // 
            idBottonToDelete.Font = new Font("Segoe UI", 12F);
            idBottonToDelete.ImeMode = ImeMode.NoControl;
            idBottonToDelete.Location = new Point(182, 97);
            idBottonToDelete.Margin = new Padding(3, 4, 3, 4);
            idBottonToDelete.Name = "idBottonToDelete";
            idBottonToDelete.Size = new Size(172, 50);
            idBottonToDelete.TabIndex = 9;
            idBottonToDelete.Text = "שלח מזהה מבצע";
            idBottonToDelete.UseVisualStyleBackColor = true;
            idBottonToDelete.Click += idBottonToDelete_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ImeMode = ImeMode.NoControl;
            label16.Location = new Point(261, 55);
            label16.Name = "label16";
            label16.Size = new Size(179, 20);
            label16.TabIndex = 8;
            label16.Text = "הכנס מזהה מבצע למחיקה";
            label16.Click += label16_Click;
            // 
            // idInputToDelete
            // 
            idInputToDelete.Location = new Point(101, 52);
            idInputToDelete.Margin = new Padding(3, 4, 3, 4);
            idInputToDelete.Name = "idInputToDelete";
            idInputToDelete.Size = new Size(142, 27);
            idInputToDelete.TabIndex = 7;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            deleteBtn.ImeMode = ImeMode.NoControl;
            deleteBtn.Location = new Point(49, 403);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(133, 49);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "מחק";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click_1;
            // 
            // saleDetialsToDelete
            // 
            saleDetialsToDelete.FormattingEnabled = true;
            saleDetialsToDelete.Location = new Point(49, 187);
            saleDetialsToDelete.Margin = new Padding(3, 4, 3, 4);
            saleDetialsToDelete.Name = "saleDetialsToDelete";
            saleDetialsToDelete.Size = new Size(409, 184);
            saleDetialsToDelete.TabIndex = 5;
            saleDetialsToDelete.SelectedIndexChanged += userDetialsToDelete_SelectedIndexChanged;
            // 
            // tabRead
            // 
            tabRead.Controls.Add(idInputToReadOne);
            tabRead.Controls.Add(saleDetailInReadOne);
            tabRead.Controls.Add(label17);
            tabRead.Controls.Add(readBtn);
            tabRead.Location = new Point(4, 29);
            tabRead.Margin = new Padding(3, 4, 3, 4);
            tabRead.Name = "tabRead";
            tabRead.Padding = new Padding(3, 4, 3, 4);
            tabRead.Size = new Size(492, 567);
            tabRead.TabIndex = 3;
            tabRead.Text = "פרטי מבצע בודד";
            tabRead.UseVisualStyleBackColor = true;
            // 
            // idInputToReadOne
            // 
            idInputToReadOne.Location = new Point(80, 42);
            idInputToReadOne.Margin = new Padding(3, 4, 3, 4);
            idInputToReadOne.Name = "idInputToReadOne";
            idInputToReadOne.Size = new Size(200, 27);
            idInputToReadOne.TabIndex = 7;
            // 
            // saleDetailInReadOne
            // 
            saleDetailInReadOne.FormattingEnabled = true;
            saleDetailInReadOne.Location = new Point(45, 185);
            saleDetailInReadOne.Margin = new Padding(3, 4, 3, 4);
            saleDetailInReadOne.Name = "saleDetailInReadOne";
            saleDetailInReadOne.Size = new Size(409, 184);
            saleDetailInReadOne.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ImeMode = ImeMode.NoControl;
            label17.Location = new Point(286, 45);
            label17.Name = "label17";
            label17.Size = new Size(123, 20);
            label17.TabIndex = 5;
            label17.Text = "הכנס מזהה מבצע";
            // 
            // readBtn
            // 
            readBtn.Font = new Font("Segoe UI", 12F);
            readBtn.ImeMode = ImeMode.NoControl;
            readBtn.Location = new Point(175, 91);
            readBtn.Margin = new Padding(3, 4, 3, 4);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(172, 50);
            readBtn.TabIndex = 4;
            readBtn.Text = "הצג פרטי מבצע";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += readBtn_Click;
            // 
            // allSaleListBox
            // 
            allSaleListBox.FormattingEnabled = true;
            allSaleListBox.Location = new Point(790, 123);
            allSaleListBox.Margin = new Padding(3, 4, 3, 4);
            allSaleListBox.Name = "allSaleListBox";
            allSaleListBox.RightToLeft = RightToLeft.Yes;
            allSaleListBox.Size = new Size(400, 584);
            allSaleListBox.TabIndex = 1;
            // 
            // searchInput
            // 
            searchInput.Location = new Point(962, 78);
            searchInput.Margin = new Padding(3, 4, 3, 4);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(200, 27);
            searchInput.TabIndex = 2;
            searchInput.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(790, 82);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 3;
            label1.Text = "הכנס מזהה מוצר לסינון";
            label1.Click += label1_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 843);
            Controls.Add(label1);
            Controls.Add(searchInput);
            Controls.Add(allSaleListBox);
            Controls.Add(tabControlSale);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SaleForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "מבצעים";
            tabControlSale.ResumeLayout(false);
            tabAdd.ResumeLayout(false);
            tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TotalPriceSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuentityForSale).EndInit();
            tabUpdate.ResumeLayout(false);
            tabUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalPriceForSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityForSale).EndInit();
            tabDelete.ResumeLayout(false);
            tabDelete.PerformLayout();
            tabRead.ResumeLayout(false);
            tabRead.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void idInputToDelete_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControlSale;
        private TabPage tabAdd;
        private TabPage tabUpdate;
        private TabPage tabDelete;
        private TabPage tabRead;
        private TextBox prodIdInput;
        private DateTimePicker StartDateCheck;
        private Label label3;
        private NumericUpDown QuentityForSale;
        private Label label2;
        private CheckBox checkIsAllCustomer;
        private Label label5;
        private DateTimePicker EndDateCheck;
        private Label label4;
        private Label label6;
        private Label label7;
        private NumericUpDown TotalPriceSale;
        private Button addSaleBtn;
        private TextBox idInputToUpdate;
        private Button updateBtn;
        private Label label8;
        private Button saveCustomerUpdate;
        private Label label9;
        private NumericUpDown totalPriceForSale;
        private Label label10;
        private CheckBox isAllCustomer;
        private Label label11;
        private DateTimePicker endDate;
        private Label label12;
        private DateTimePicker startDate;
        private Label label13;
        private NumericUpDown quantityForSale;
        private Label label14;
        private TextBox prodId;
        private Button idBottonToDelete;
        private Label label16;
        private TextBox idInputToDelete;
        private Button deleteBtn;
        private ListBox saleDetialsToDelete;
        private TextBox idInputToReadOne;
        private ListBox saleDetailInReadOne;
        private Label label17;
        private Button readBtn;
        private ListBox allSaleListBox;
        private TextBox searchInput;
        private Label label1;
    }
}