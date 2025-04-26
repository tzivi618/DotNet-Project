namespace UI
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            TabCustomer = new TabControl();
            AddCustomerTab = new TabPage();
            AddCustomer = new Button();
            CustomerAddressInput = new TextBox();
            CustomerTelInput = new TextBox();
            label4 = new Label();
            label3 = new Label();
            CustomerIdInput = new TextBox();
            label2 = new Label();
            CustomerNameInput = new TextBox();
            label1 = new Label();
            UpdateCustomerTab = new TabPage();
            saveCustomerUpdate = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            customerAddressToUpdate = new TextBox();
            customerPhoneToUpdate = new TextBox();
            customerNameToUpdate = new TextBox();
            label5 = new Label();
            idInputToUpdate = new TextBox();
            updateBtn = new Button();
            DeleteCustomerTab = new TabPage();
            idBottonToDelete = new Button();
            label9 = new Label();
            idInputToDelete = new TextBox();
            deleteBtn = new Button();
            userDetialsToDelete = new ListBox();
            ReadOneCustomerTab = new TabPage();
            idInputToReadOne = new TextBox();
            userDetailInReadOne = new ListBox();
            label10 = new Label();
            readBtn = new Button();
            allCustomerListBox = new ListBox();
            label11 = new Label();
            searchCustomerInputBtPhoneNumber = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            TabCustomer.SuspendLayout();
            AddCustomerTab.SuspendLayout();
            UpdateCustomerTab.SuspendLayout();
            DeleteCustomerTab.SuspendLayout();
            ReadOneCustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TabCustomer
            // 
            resources.ApplyResources(TabCustomer, "TabCustomer");
            TabCustomer.Controls.Add(AddCustomerTab);
            TabCustomer.Controls.Add(UpdateCustomerTab);
            TabCustomer.Controls.Add(DeleteCustomerTab);
            TabCustomer.Controls.Add(ReadOneCustomerTab);
            errorProvider1.SetError(TabCustomer, resources.GetString("TabCustomer.Error"));
            errorProvider1.SetIconAlignment(TabCustomer, (ErrorIconAlignment)resources.GetObject("TabCustomer.IconAlignment"));
            errorProvider1.SetIconPadding(TabCustomer, (int)resources.GetObject("TabCustomer.IconPadding"));
            TabCustomer.Name = "TabCustomer";
            TabCustomer.SelectedIndex = 0;
            // 
            // AddCustomerTab
            // 
            resources.ApplyResources(AddCustomerTab, "AddCustomerTab");
            AddCustomerTab.Controls.Add(AddCustomer);
            AddCustomerTab.Controls.Add(CustomerAddressInput);
            AddCustomerTab.Controls.Add(CustomerTelInput);
            AddCustomerTab.Controls.Add(label4);
            AddCustomerTab.Controls.Add(label3);
            AddCustomerTab.Controls.Add(CustomerIdInput);
            AddCustomerTab.Controls.Add(label2);
            AddCustomerTab.Controls.Add(CustomerNameInput);
            AddCustomerTab.Controls.Add(label1);
            errorProvider1.SetError(AddCustomerTab, resources.GetString("AddCustomerTab.Error"));
            errorProvider1.SetIconAlignment(AddCustomerTab, (ErrorIconAlignment)resources.GetObject("AddCustomerTab.IconAlignment"));
            errorProvider1.SetIconPadding(AddCustomerTab, (int)resources.GetObject("AddCustomerTab.IconPadding"));
            AddCustomerTab.Name = "AddCustomerTab";
            AddCustomerTab.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            resources.ApplyResources(AddCustomer, "AddCustomer");
            errorProvider1.SetError(AddCustomer, resources.GetString("AddCustomer.Error"));
            errorProvider1.SetIconAlignment(AddCustomer, (ErrorIconAlignment)resources.GetObject("AddCustomer.IconAlignment"));
            errorProvider1.SetIconPadding(AddCustomer, (int)resources.GetObject("AddCustomer.IconPadding"));
            AddCustomer.Name = "AddCustomer";
            AddCustomer.UseVisualStyleBackColor = true;
            AddCustomer.Click += AddCustomer_Click;
            // 
            // CustomerAddressInput
            // 
            resources.ApplyResources(CustomerAddressInput, "CustomerAddressInput");
            errorProvider1.SetError(CustomerAddressInput, resources.GetString("CustomerAddressInput.Error"));
            errorProvider1.SetIconAlignment(CustomerAddressInput, (ErrorIconAlignment)resources.GetObject("CustomerAddressInput.IconAlignment"));
            errorProvider1.SetIconPadding(CustomerAddressInput, (int)resources.GetObject("CustomerAddressInput.IconPadding"));
            CustomerAddressInput.Name = "CustomerAddressInput";
            // 
            // CustomerTelInput
            // 
            resources.ApplyResources(CustomerTelInput, "CustomerTelInput");
            errorProvider1.SetError(CustomerTelInput, resources.GetString("CustomerTelInput.Error"));
            errorProvider1.SetIconAlignment(CustomerTelInput, (ErrorIconAlignment)resources.GetObject("CustomerTelInput.IconAlignment"));
            errorProvider1.SetIconPadding(CustomerTelInput, (int)resources.GetObject("CustomerTelInput.IconPadding"));
            CustomerTelInput.Name = "CustomerTelInput";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            errorProvider1.SetError(label4, resources.GetString("label4.Error"));
            errorProvider1.SetIconAlignment(label4, (ErrorIconAlignment)resources.GetObject("label4.IconAlignment"));
            errorProvider1.SetIconPadding(label4, (int)resources.GetObject("label4.IconPadding"));
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            errorProvider1.SetError(label3, resources.GetString("label3.Error"));
            errorProvider1.SetIconAlignment(label3, (ErrorIconAlignment)resources.GetObject("label3.IconAlignment"));
            errorProvider1.SetIconPadding(label3, (int)resources.GetObject("label3.IconPadding"));
            label3.Name = "label3";
            // 
            // CustomerIdInput
            // 
            resources.ApplyResources(CustomerIdInput, "CustomerIdInput");
            errorProvider1.SetError(CustomerIdInput, resources.GetString("CustomerIdInput.Error"));
            errorProvider1.SetIconAlignment(CustomerIdInput, (ErrorIconAlignment)resources.GetObject("CustomerIdInput.IconAlignment"));
            errorProvider1.SetIconPadding(CustomerIdInput, (int)resources.GetObject("CustomerIdInput.IconPadding"));
            CustomerIdInput.Name = "CustomerIdInput";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            errorProvider1.SetError(label2, resources.GetString("label2.Error"));
            errorProvider1.SetIconAlignment(label2, (ErrorIconAlignment)resources.GetObject("label2.IconAlignment"));
            errorProvider1.SetIconPadding(label2, (int)resources.GetObject("label2.IconPadding"));
            label2.Name = "label2";
            // 
            // CustomerNameInput
            // 
            resources.ApplyResources(CustomerNameInput, "CustomerNameInput");
            errorProvider1.SetError(CustomerNameInput, resources.GetString("CustomerNameInput.Error"));
            errorProvider1.SetIconAlignment(CustomerNameInput, (ErrorIconAlignment)resources.GetObject("CustomerNameInput.IconAlignment"));
            errorProvider1.SetIconPadding(CustomerNameInput, (int)resources.GetObject("CustomerNameInput.IconPadding"));
            CustomerNameInput.Name = "CustomerNameInput";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            errorProvider1.SetError(label1, resources.GetString("label1.Error"));
            errorProvider1.SetIconAlignment(label1, (ErrorIconAlignment)resources.GetObject("label1.IconAlignment"));
            errorProvider1.SetIconPadding(label1, (int)resources.GetObject("label1.IconPadding"));
            label1.Name = "label1";
            // 
            // UpdateCustomerTab
            // 
            resources.ApplyResources(UpdateCustomerTab, "UpdateCustomerTab");
            UpdateCustomerTab.Controls.Add(saveCustomerUpdate);
            UpdateCustomerTab.Controls.Add(label8);
            UpdateCustomerTab.Controls.Add(label7);
            UpdateCustomerTab.Controls.Add(label6);
            UpdateCustomerTab.Controls.Add(customerAddressToUpdate);
            UpdateCustomerTab.Controls.Add(customerPhoneToUpdate);
            UpdateCustomerTab.Controls.Add(customerNameToUpdate);
            UpdateCustomerTab.Controls.Add(label5);
            UpdateCustomerTab.Controls.Add(idInputToUpdate);
            UpdateCustomerTab.Controls.Add(updateBtn);
            errorProvider1.SetError(UpdateCustomerTab, resources.GetString("UpdateCustomerTab.Error"));
            errorProvider1.SetIconAlignment(UpdateCustomerTab, (ErrorIconAlignment)resources.GetObject("UpdateCustomerTab.IconAlignment"));
            errorProvider1.SetIconPadding(UpdateCustomerTab, (int)resources.GetObject("UpdateCustomerTab.IconPadding"));
            UpdateCustomerTab.Name = "UpdateCustomerTab";
            UpdateCustomerTab.UseVisualStyleBackColor = true;
            // 
            // saveCustomerUpdate
            // 
            resources.ApplyResources(saveCustomerUpdate, "saveCustomerUpdate");
            errorProvider1.SetError(saveCustomerUpdate, resources.GetString("saveCustomerUpdate.Error"));
            errorProvider1.SetIconAlignment(saveCustomerUpdate, (ErrorIconAlignment)resources.GetObject("saveCustomerUpdate.IconAlignment"));
            errorProvider1.SetIconPadding(saveCustomerUpdate, (int)resources.GetObject("saveCustomerUpdate.IconPadding"));
            saveCustomerUpdate.Name = "saveCustomerUpdate";
            saveCustomerUpdate.UseVisualStyleBackColor = true;
            saveCustomerUpdate.Click += saveCustomerUpdate_Click;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            errorProvider1.SetError(label8, resources.GetString("label8.Error"));
            errorProvider1.SetIconAlignment(label8, (ErrorIconAlignment)resources.GetObject("label8.IconAlignment"));
            errorProvider1.SetIconPadding(label8, (int)resources.GetObject("label8.IconPadding"));
            label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            errorProvider1.SetError(label7, resources.GetString("label7.Error"));
            errorProvider1.SetIconAlignment(label7, (ErrorIconAlignment)resources.GetObject("label7.IconAlignment"));
            errorProvider1.SetIconPadding(label7, (int)resources.GetObject("label7.IconPadding"));
            label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            errorProvider1.SetError(label6, resources.GetString("label6.Error"));
            errorProvider1.SetIconAlignment(label6, (ErrorIconAlignment)resources.GetObject("label6.IconAlignment"));
            errorProvider1.SetIconPadding(label6, (int)resources.GetObject("label6.IconPadding"));
            label6.Name = "label6";
            // 
            // customerAddressToUpdate
            // 
            resources.ApplyResources(customerAddressToUpdate, "customerAddressToUpdate");
            errorProvider1.SetError(customerAddressToUpdate, resources.GetString("customerAddressToUpdate.Error"));
            errorProvider1.SetIconAlignment(customerAddressToUpdate, (ErrorIconAlignment)resources.GetObject("customerAddressToUpdate.IconAlignment"));
            errorProvider1.SetIconPadding(customerAddressToUpdate, (int)resources.GetObject("customerAddressToUpdate.IconPadding"));
            customerAddressToUpdate.Name = "customerAddressToUpdate";
            // 
            // customerPhoneToUpdate
            // 
            resources.ApplyResources(customerPhoneToUpdate, "customerPhoneToUpdate");
            errorProvider1.SetError(customerPhoneToUpdate, resources.GetString("customerPhoneToUpdate.Error"));
            errorProvider1.SetIconAlignment(customerPhoneToUpdate, (ErrorIconAlignment)resources.GetObject("customerPhoneToUpdate.IconAlignment"));
            errorProvider1.SetIconPadding(customerPhoneToUpdate, (int)resources.GetObject("customerPhoneToUpdate.IconPadding"));
            customerPhoneToUpdate.Name = "customerPhoneToUpdate";
            // 
            // customerNameToUpdate
            // 
            resources.ApplyResources(customerNameToUpdate, "customerNameToUpdate");
            errorProvider1.SetError(customerNameToUpdate, resources.GetString("customerNameToUpdate.Error"));
            errorProvider1.SetIconAlignment(customerNameToUpdate, (ErrorIconAlignment)resources.GetObject("customerNameToUpdate.IconAlignment"));
            errorProvider1.SetIconPadding(customerNameToUpdate, (int)resources.GetObject("customerNameToUpdate.IconPadding"));
            customerNameToUpdate.Name = "customerNameToUpdate";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            errorProvider1.SetError(label5, resources.GetString("label5.Error"));
            errorProvider1.SetIconAlignment(label5, (ErrorIconAlignment)resources.GetObject("label5.IconAlignment"));
            errorProvider1.SetIconPadding(label5, (int)resources.GetObject("label5.IconPadding"));
            label5.Name = "label5";
            // 
            // idInputToUpdate
            // 
            resources.ApplyResources(idInputToUpdate, "idInputToUpdate");
            errorProvider1.SetError(idInputToUpdate, resources.GetString("idInputToUpdate.Error"));
            errorProvider1.SetIconAlignment(idInputToUpdate, (ErrorIconAlignment)resources.GetObject("idInputToUpdate.IconAlignment"));
            errorProvider1.SetIconPadding(idInputToUpdate, (int)resources.GetObject("idInputToUpdate.IconPadding"));
            idInputToUpdate.Name = "idInputToUpdate";
            // 
            // updateBtn
            // 
            resources.ApplyResources(updateBtn, "updateBtn");
            errorProvider1.SetError(updateBtn, resources.GetString("updateBtn.Error"));
            errorProvider1.SetIconAlignment(updateBtn, (ErrorIconAlignment)resources.GetObject("updateBtn.IconAlignment"));
            errorProvider1.SetIconPadding(updateBtn, (int)resources.GetObject("updateBtn.IconPadding"));
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
            DeleteCustomerTab.Controls.Add(userDetialsToDelete);
            errorProvider1.SetError(DeleteCustomerTab, resources.GetString("DeleteCustomerTab.Error"));
            errorProvider1.SetIconAlignment(DeleteCustomerTab, (ErrorIconAlignment)resources.GetObject("DeleteCustomerTab.IconAlignment"));
            errorProvider1.SetIconPadding(DeleteCustomerTab, (int)resources.GetObject("DeleteCustomerTab.IconPadding"));
            DeleteCustomerTab.Name = "DeleteCustomerTab";
            DeleteCustomerTab.UseVisualStyleBackColor = true;
            // 
            // idBottonToDelete
            // 
            resources.ApplyResources(idBottonToDelete, "idBottonToDelete");
            errorProvider1.SetError(idBottonToDelete, resources.GetString("idBottonToDelete.Error"));
            errorProvider1.SetIconAlignment(idBottonToDelete, (ErrorIconAlignment)resources.GetObject("idBottonToDelete.IconAlignment"));
            errorProvider1.SetIconPadding(idBottonToDelete, (int)resources.GetObject("idBottonToDelete.IconPadding"));
            idBottonToDelete.Name = "idBottonToDelete";
            idBottonToDelete.UseVisualStyleBackColor = true;
            idBottonToDelete.Click += idBottonToDelete_Click;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            errorProvider1.SetError(label9, resources.GetString("label9.Error"));
            errorProvider1.SetIconAlignment(label9, (ErrorIconAlignment)resources.GetObject("label9.IconAlignment"));
            errorProvider1.SetIconPadding(label9, (int)resources.GetObject("label9.IconPadding"));
            label9.Name = "label9";
            // 
            // idInputToDelete
            // 
            resources.ApplyResources(idInputToDelete, "idInputToDelete");
            errorProvider1.SetError(idInputToDelete, resources.GetString("idInputToDelete.Error"));
            errorProvider1.SetIconAlignment(idInputToDelete, (ErrorIconAlignment)resources.GetObject("idInputToDelete.IconAlignment"));
            errorProvider1.SetIconPadding(idInputToDelete, (int)resources.GetObject("idInputToDelete.IconPadding"));
            idInputToDelete.Name = "idInputToDelete";
            // 
            // deleteBtn
            // 
            resources.ApplyResources(deleteBtn, "deleteBtn");
            errorProvider1.SetError(deleteBtn, resources.GetString("deleteBtn.Error"));
            errorProvider1.SetIconAlignment(deleteBtn, (ErrorIconAlignment)resources.GetObject("deleteBtn.IconAlignment"));
            errorProvider1.SetIconPadding(deleteBtn, (int)resources.GetObject("deleteBtn.IconPadding"));
            deleteBtn.Name = "deleteBtn";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // userDetialsToDelete
            // 
            resources.ApplyResources(userDetialsToDelete, "userDetialsToDelete");
            errorProvider1.SetError(userDetialsToDelete, resources.GetString("userDetialsToDelete.Error"));
            userDetialsToDelete.FormattingEnabled = true;
            errorProvider1.SetIconAlignment(userDetialsToDelete, (ErrorIconAlignment)resources.GetObject("userDetialsToDelete.IconAlignment"));
            errorProvider1.SetIconPadding(userDetialsToDelete, (int)resources.GetObject("userDetialsToDelete.IconPadding"));
            userDetialsToDelete.Name = "userDetialsToDelete";
            // 
            // ReadOneCustomerTab
            // 
            resources.ApplyResources(ReadOneCustomerTab, "ReadOneCustomerTab");
            ReadOneCustomerTab.Controls.Add(idInputToReadOne);
            ReadOneCustomerTab.Controls.Add(userDetailInReadOne);
            ReadOneCustomerTab.Controls.Add(label10);
            ReadOneCustomerTab.Controls.Add(readBtn);
            errorProvider1.SetError(ReadOneCustomerTab, resources.GetString("ReadOneCustomerTab.Error"));
            errorProvider1.SetIconAlignment(ReadOneCustomerTab, (ErrorIconAlignment)resources.GetObject("ReadOneCustomerTab.IconAlignment"));
            errorProvider1.SetIconPadding(ReadOneCustomerTab, (int)resources.GetObject("ReadOneCustomerTab.IconPadding"));
            ReadOneCustomerTab.Name = "ReadOneCustomerTab";
            ReadOneCustomerTab.UseVisualStyleBackColor = true;
            // 
            // idInputToReadOne
            // 
            resources.ApplyResources(idInputToReadOne, "idInputToReadOne");
            errorProvider1.SetError(idInputToReadOne, resources.GetString("idInputToReadOne.Error"));
            errorProvider1.SetIconAlignment(idInputToReadOne, (ErrorIconAlignment)resources.GetObject("idInputToReadOne.IconAlignment"));
            errorProvider1.SetIconPadding(idInputToReadOne, (int)resources.GetObject("idInputToReadOne.IconPadding"));
            idInputToReadOne.Name = "idInputToReadOne";
            // 
            // userDetailInReadOne
            // 
            resources.ApplyResources(userDetailInReadOne, "userDetailInReadOne");
            errorProvider1.SetError(userDetailInReadOne, resources.GetString("userDetailInReadOne.Error"));
            userDetailInReadOne.FormattingEnabled = true;
            errorProvider1.SetIconAlignment(userDetailInReadOne, (ErrorIconAlignment)resources.GetObject("userDetailInReadOne.IconAlignment"));
            errorProvider1.SetIconPadding(userDetailInReadOne, (int)resources.GetObject("userDetailInReadOne.IconPadding"));
            userDetailInReadOne.Name = "userDetailInReadOne";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            errorProvider1.SetError(label10, resources.GetString("label10.Error"));
            errorProvider1.SetIconAlignment(label10, (ErrorIconAlignment)resources.GetObject("label10.IconAlignment"));
            errorProvider1.SetIconPadding(label10, (int)resources.GetObject("label10.IconPadding"));
            label10.Name = "label10";
            // 
            // readBtn
            // 
            resources.ApplyResources(readBtn, "readBtn");
            errorProvider1.SetError(readBtn, resources.GetString("readBtn.Error"));
            errorProvider1.SetIconAlignment(readBtn, (ErrorIconAlignment)resources.GetObject("readBtn.IconAlignment"));
            errorProvider1.SetIconPadding(readBtn, (int)resources.GetObject("readBtn.IconPadding"));
            readBtn.Name = "readBtn";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += readBtn_Click;
            // 
            // allCustomerListBox
            // 
            resources.ApplyResources(allCustomerListBox, "allCustomerListBox");
            errorProvider1.SetError(allCustomerListBox, resources.GetString("allCustomerListBox.Error"));
            allCustomerListBox.FormattingEnabled = true;
            errorProvider1.SetIconAlignment(allCustomerListBox, (ErrorIconAlignment)resources.GetObject("allCustomerListBox.IconAlignment"));
            errorProvider1.SetIconPadding(allCustomerListBox, (int)resources.GetObject("allCustomerListBox.IconPadding"));
            allCustomerListBox.Name = "allCustomerListBox";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            errorProvider1.SetError(label11, resources.GetString("label11.Error"));
            errorProvider1.SetIconAlignment(label11, (ErrorIconAlignment)resources.GetObject("label11.IconAlignment"));
            errorProvider1.SetIconPadding(label11, (int)resources.GetObject("label11.IconPadding"));
            label11.Name = "label11";
            // 
            // searchCustomerInputBtPhoneNumber
            // 
            resources.ApplyResources(searchCustomerInputBtPhoneNumber, "searchCustomerInputBtPhoneNumber");
            errorProvider1.SetError(searchCustomerInputBtPhoneNumber, resources.GetString("searchCustomerInputBtPhoneNumber.Error"));
            errorProvider1.SetIconAlignment(searchCustomerInputBtPhoneNumber, (ErrorIconAlignment)resources.GetObject("searchCustomerInputBtPhoneNumber.IconAlignment"));
            errorProvider1.SetIconPadding(searchCustomerInputBtPhoneNumber, (int)resources.GetObject("searchCustomerInputBtPhoneNumber.IconPadding"));
            searchCustomerInputBtPhoneNumber.Name = "searchCustomerInputBtPhoneNumber";
            searchCustomerInputBtPhoneNumber.TextChanged += searchCustomerInputBtPhoneNumber_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            resources.ApplyResources(errorProvider1, "errorProvider1");
            // 
            // CustomerForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchCustomerInputBtPhoneNumber);
            Controls.Add(label11);
            Controls.Add(allCustomerListBox);
            Controls.Add(TabCustomer);
            Name = "CustomerForm";
            TabCustomer.ResumeLayout(false);
            AddCustomerTab.ResumeLayout(false);
            AddCustomerTab.PerformLayout();
            UpdateCustomerTab.ResumeLayout(false);
            UpdateCustomerTab.PerformLayout();
            DeleteCustomerTab.ResumeLayout(false);
            DeleteCustomerTab.PerformLayout();
            ReadOneCustomerTab.ResumeLayout(false);
            ReadOneCustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private TextBox CustomerIdInput;
        private Label label2;
        private TextBox CustomerNameInput;
        private Label label1;
        private Button AddCustomer;
        private TextBox CustomerAddressInput;
        private TextBox CustomerTelInput;
        private TextBox idInputToUpdate;
        private Button updateBtn;
        private Label label5;
        private TextBox customerNameToUpdate;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox customerAddressToUpdate;
        private TextBox customerPhoneToUpdate;
        private Button saveCustomerUpdate;
        private TextBox idInputToDelete;
        private Button deleteBtn;
        private ListBox userDetialsToDelete;
        private Label label9;
        private Button idBottonToDelete;
        private ListBox userDetailInReadOne;
        private Label label10;
        private Button readBtn;
        private TextBox idInputToReadOne;
        private ListBox allCustomerListBox;
        private Label label11;
        private TextBox searchCustomerInputBtPhoneNumber;
        private ErrorProvider errorProvider1;
    }
}