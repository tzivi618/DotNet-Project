namespace UI
{
    partial class ProductFormGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFormGood));
            TabCustomer = new TabControl();
            AddCustomerTab = new TabPage();
            QuantityNumericUpDown = new NumericUpDown();
            priceNumericUpDown = new NumericUpDown();
            chooseCategoryAddComboBox = new ComboBox();
            AddCustomer = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ProductNameInput = new TextBox();
            label1 = new Label();
            UpdateCustomerTab = new TabPage();
            quantityNumericUpDownToUpdate = new NumericUpDown();
            PriceNumericUpDownToUpdate = new NumericUpDown();
            categoryComboBoxToUpdate = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            productNameToUpdate = new TextBox();
            label15 = new Label();
            saveProductUpdate = new Button();
            label5 = new Label();
            idInputToUpdateProduct = new TextBox();
            updateBtn = new Button();
            DeleteCustomerTab = new TabPage();
            idBottonToDelete = new Button();
            label9 = new Label();
            idInputToDelete = new TextBox();
            deleteBtn = new Button();
            productDetialsToDelete = new ListBox();
            ReadOneCustomerTab = new TabPage();
            idInputToReadOne = new TextBox();
            productDetialsToReadOne = new ListBox();
            label10 = new Label();
            readBtn = new Button();
            allProductsListBox = new ListBox();
            label11 = new Label();
            searchProductByCategoryCombo = new ComboBox();
            TabCustomer.SuspendLayout();
            AddCustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            UpdateCustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDownToUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDownToUpdate).BeginInit();
            DeleteCustomerTab.SuspendLayout();
            ReadOneCustomerTab.SuspendLayout();
            SuspendLayout();
            // 
            // TabCustomer
            // 
            resources.ApplyResources(TabCustomer, "TabCustomer");
            TabCustomer.Controls.Add(AddCustomerTab);
            TabCustomer.Controls.Add(UpdateCustomerTab);
            TabCustomer.Controls.Add(DeleteCustomerTab);
            TabCustomer.Controls.Add(ReadOneCustomerTab);
            TabCustomer.Name = "TabCustomer";
            TabCustomer.SelectedIndex = 0;
            // 
            // AddCustomerTab
            // 
            resources.ApplyResources(AddCustomerTab, "AddCustomerTab");
            AddCustomerTab.Controls.Add(QuantityNumericUpDown);
            AddCustomerTab.Controls.Add(priceNumericUpDown);
            AddCustomerTab.Controls.Add(chooseCategoryAddComboBox);
            AddCustomerTab.Controls.Add(AddCustomer);
            AddCustomerTab.Controls.Add(label4);
            AddCustomerTab.Controls.Add(label3);
            AddCustomerTab.Controls.Add(label2);
            AddCustomerTab.Controls.Add(ProductNameInput);
            AddCustomerTab.Controls.Add(label1);
            AddCustomerTab.Name = "AddCustomerTab";
            AddCustomerTab.UseVisualStyleBackColor = true;
            // 
            // QuantityNumericUpDown
            // 
            resources.ApplyResources(QuantityNumericUpDown, "QuantityNumericUpDown");
            QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            // 
            // priceNumericUpDown
            // 
            resources.ApplyResources(priceNumericUpDown, "priceNumericUpDown");
            priceNumericUpDown.Name = "priceNumericUpDown";
            // 
            // chooseCategoryAddComboBox
            // 
            resources.ApplyResources(chooseCategoryAddComboBox, "chooseCategoryAddComboBox");
            chooseCategoryAddComboBox.FormattingEnabled = true;
            chooseCategoryAddComboBox.Name = "chooseCategoryAddComboBox";
            // 
            // AddCustomer
            // 
            resources.ApplyResources(AddCustomer, "AddCustomer");
            AddCustomer.Name = "AddCustomer";
            AddCustomer.UseVisualStyleBackColor = true;
            AddCustomer.Click += AddProduct_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // ProductNameInput
            // 
            resources.ApplyResources(ProductNameInput, "ProductNameInput");
            ProductNameInput.Name = "ProductNameInput";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // UpdateCustomerTab
            // 
            resources.ApplyResources(UpdateCustomerTab, "UpdateCustomerTab");
            UpdateCustomerTab.Controls.Add(quantityNumericUpDownToUpdate);
            UpdateCustomerTab.Controls.Add(PriceNumericUpDownToUpdate);
            UpdateCustomerTab.Controls.Add(categoryComboBoxToUpdate);
            UpdateCustomerTab.Controls.Add(label12);
            UpdateCustomerTab.Controls.Add(label13);
            UpdateCustomerTab.Controls.Add(label14);
            UpdateCustomerTab.Controls.Add(productNameToUpdate);
            UpdateCustomerTab.Controls.Add(label15);
            UpdateCustomerTab.Controls.Add(saveProductUpdate);
            UpdateCustomerTab.Controls.Add(label5);
            UpdateCustomerTab.Controls.Add(idInputToUpdateProduct);
            UpdateCustomerTab.Controls.Add(updateBtn);
            UpdateCustomerTab.Name = "UpdateCustomerTab";
            UpdateCustomerTab.UseVisualStyleBackColor = true;
            // 
            // quantityNumericUpDownToUpdate
            // 
            resources.ApplyResources(quantityNumericUpDownToUpdate, "quantityNumericUpDownToUpdate");
            quantityNumericUpDownToUpdate.Name = "quantityNumericUpDownToUpdate";
            // 
            // PriceNumericUpDownToUpdate
            // 
            resources.ApplyResources(PriceNumericUpDownToUpdate, "PriceNumericUpDownToUpdate");
            PriceNumericUpDownToUpdate.Name = "PriceNumericUpDownToUpdate";
            // 
            // categoryComboBoxToUpdate
            // 
            resources.ApplyResources(categoryComboBoxToUpdate, "categoryComboBoxToUpdate");
            categoryComboBoxToUpdate.FormattingEnabled = true;
            categoryComboBoxToUpdate.Name = "categoryComboBoxToUpdate";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // productNameToUpdate
            // 
            resources.ApplyResources(productNameToUpdate, "productNameToUpdate");
            productNameToUpdate.Name = "productNameToUpdate";
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // saveProductUpdate
            // 
            resources.ApplyResources(saveProductUpdate, "saveProductUpdate");
            saveProductUpdate.Name = "saveProductUpdate";
            saveProductUpdate.UseVisualStyleBackColor = true;
            saveProductUpdate.Click += saveProductUpdate_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // idInputToUpdateProduct
            // 
            resources.ApplyResources(idInputToUpdateProduct, "idInputToUpdateProduct");
            idInputToUpdateProduct.Name = "idInputToUpdateProduct";
            // 
            // updateBtn
            // 
            resources.ApplyResources(updateBtn, "updateBtn");
            updateBtn.Name = "updateBtn";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // DeleteCustomerTab
            // 
            resources.ApplyResources(DeleteCustomerTab, "DeleteCustomerTab");
            DeleteCustomerTab.Controls.Add(idBottonToDelete);
            DeleteCustomerTab.Controls.Add(label9);
            DeleteCustomerTab.Controls.Add(idInputToDelete);
            DeleteCustomerTab.Controls.Add(deleteBtn);
            DeleteCustomerTab.Controls.Add(productDetialsToDelete);
            DeleteCustomerTab.Name = "DeleteCustomerTab";
            DeleteCustomerTab.UseVisualStyleBackColor = true;
            // 
            // idBottonToDelete
            // 
            resources.ApplyResources(idBottonToDelete, "idBottonToDelete");
            idBottonToDelete.Name = "idBottonToDelete";
            idBottonToDelete.UseVisualStyleBackColor = true;
            idBottonToDelete.Click += idBottonToDelete_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            label9.Click += label9_Click;
            // 
            // idInputToDelete
            // 
            resources.ApplyResources(idInputToDelete, "idInputToDelete");
            idInputToDelete.Name = "idInputToDelete";
            // 
            // deleteBtn
            // 
            resources.ApplyResources(deleteBtn, "deleteBtn");
            deleteBtn.Name = "deleteBtn";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // productDetialsToDelete
            // 
            resources.ApplyResources(productDetialsToDelete, "productDetialsToDelete");
            productDetialsToDelete.FormattingEnabled = true;
            productDetialsToDelete.Name = "productDetialsToDelete";
            // 
            // ReadOneCustomerTab
            // 
            resources.ApplyResources(ReadOneCustomerTab, "ReadOneCustomerTab");
            ReadOneCustomerTab.Controls.Add(idInputToReadOne);
            ReadOneCustomerTab.Controls.Add(productDetialsToReadOne);
            ReadOneCustomerTab.Controls.Add(label10);
            ReadOneCustomerTab.Controls.Add(readBtn);
            ReadOneCustomerTab.Name = "ReadOneCustomerTab";
            ReadOneCustomerTab.UseVisualStyleBackColor = true;
            // 
            // idInputToReadOne
            // 
            resources.ApplyResources(idInputToReadOne, "idInputToReadOne");
            idInputToReadOne.Name = "idInputToReadOne";
            // 
            // productDetialsToReadOne
            // 
            resources.ApplyResources(productDetialsToReadOne, "productDetialsToReadOne");
            productDetialsToReadOne.FormattingEnabled = true;
            productDetialsToReadOne.Name = "productDetialsToReadOne";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // readBtn
            // 
            resources.ApplyResources(readBtn, "readBtn");
            readBtn.Name = "readBtn";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += readBtn_Click;
            // 
            // allProductsListBox
            // 
            resources.ApplyResources(allProductsListBox, "allProductsListBox");
            allProductsListBox.FormattingEnabled = true;
            allProductsListBox.Name = "allProductsListBox";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // searchProductByCategoryCombo
            // 
            resources.ApplyResources(searchProductByCategoryCombo, "searchProductByCategoryCombo");
            searchProductByCategoryCombo.FormattingEnabled = true;
            searchProductByCategoryCombo.Name = "searchProductByCategoryCombo";
            searchProductByCategoryCombo.SelectedIndexChanged += searchProductByCategoryCombo_SelectedIndexChanged;
            // 
            // ProductFormGood
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchProductByCategoryCombo);
            Controls.Add(label11);
            Controls.Add(allProductsListBox);
            Controls.Add(TabCustomer);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProductFormGood";
            TabCustomer.ResumeLayout(false);
            AddCustomerTab.ResumeLayout(false);
            AddCustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            UpdateCustomerTab.ResumeLayout(false);
            UpdateCustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDownToUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDownToUpdate).EndInit();
            DeleteCustomerTab.ResumeLayout(false);
            DeleteCustomerTab.PerformLayout();
            ReadOneCustomerTab.ResumeLayout(false);
            ReadOneCustomerTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl TabCustomer;
        private TabPage AddCustomerTab;
        private TabPage UpdateCustomerTab;
        private TabPage DeleteCustomerTab;
        private TabPage ReadOneCustomerTab;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox ProductNameInput;
        private Label label1;
        private Button AddCustomer;
        private TextBox idInputToUpdateProduct;
        private Button updateBtn;
        private Label label5;
        private Button saveProductUpdate;
        private TextBox idInputToDelete;
        private Button deleteBtn;
        private ListBox productDetialsToDelete;
        private Label label9;
        private Button idBottonToDelete;
        private ListBox productDetialsToReadOne;
        private Label label10;
        private Button readBtn;
        private TextBox idInputToReadOne;
        private ListBox allProductsListBox;
        private Label label11;
        private ComboBox chooseCategoryAddComboBox;
        private NumericUpDown QuantityNumericUpDown;
        private NumericUpDown priceNumericUpDown;
        private ComboBox searchProductByCategoryCombo;
        private NumericUpDown quantityNumericUpDownToUpdate;
        private NumericUpDown PriceNumericUpDownToUpdate;
        private ComboBox categoryComboBoxToUpdate;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox productNameToUpdate;
        private Label label15;
    }
}