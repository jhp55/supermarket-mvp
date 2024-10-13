namespace Supermarket_mvp.Views
{
    partial class CustomersView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomers = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomersDetail = new TabPage();
            TxtCustomersDocument = new TextBox();
            TxtCustomersBirthday = new DateTimePicker();
            TxtCustomersEmail = new TextBox();
            label10 = new Label();
            TxtCustomersPhoneNumber = new TextBox();
            label9 = new Label();
            TxtCustomersLastName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            TxtCustomersAddress = new TextBox();
            label6 = new Label();
            TxtCustomersFirstName = new TextBox();
            label5 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCustomersId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 116);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 40);
            label1.Name = "label1";
            label1.Size = new Size(156, 40);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 116);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 334);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(BtnDelete);
            tabPageCustomersList.Controls.Add(BtnClose);
            tabPageCustomersList.Controls.Add(BtnEdit);
            tabPageCustomersList.Controls.Add(BtnNew);
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(BtnSearch);
            tabPageCustomersList.Controls.Add(TxtSearch);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Location = new Point(4, 29);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(792, 301);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers List";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(641, 235);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(148, 45);
            BtnDelete.TabIndex = 7;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(641, 184);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(148, 45);
            BtnClose.TabIndex = 6;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(641, 133);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(148, 45);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(641, 83);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(148, 45);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(29, 83);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 51;
            DgCustomers.Size = new Size(594, 210);
            DgCustomers.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(565, 29);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(58, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(29, 43);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(518, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 20);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Customers";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(TxtCustomersDocument);
            tabPageCustomersDetail.Controls.Add(TxtCustomersBirthday);
            tabPageCustomersDetail.Controls.Add(TxtCustomersEmail);
            tabPageCustomersDetail.Controls.Add(label10);
            tabPageCustomersDetail.Controls.Add(TxtCustomersPhoneNumber);
            tabPageCustomersDetail.Controls.Add(label9);
            tabPageCustomersDetail.Controls.Add(TxtCustomersLastName);
            tabPageCustomersDetail.Controls.Add(label8);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(TxtCustomersAddress);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(TxtCustomersFirstName);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(BtnCancel);
            tabPageCustomersDetail.Controls.Add(BtnSave);
            tabPageCustomersDetail.Controls.Add(TxtCustomersId);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Location = new Point(4, 29);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(792, 301);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Detail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersDocument
            // 
            TxtCustomersDocument.Location = new Point(23, 95);
            TxtCustomersDocument.Name = "TxtCustomersDocument";
            TxtCustomersDocument.PlaceholderText = "Customers Document";
            TxtCustomersDocument.Size = new Size(311, 27);
            TxtCustomersDocument.TabIndex = 21;
            // 
            // TxtCustomersBirthday
            // 
            TxtCustomersBirthday.Format = DateTimePickerFormat.Short;
            TxtCustomersBirthday.Location = new Point(438, 95);
            TxtCustomersBirthday.Name = "TxtCustomersBirthday";
            TxtCustomersBirthday.Size = new Size(308, 27);
            TxtCustomersBirthday.TabIndex = 20;
            // 
            // TxtCustomersEmail
            // 
            TxtCustomersEmail.Location = new Point(438, 207);
            TxtCustomersEmail.Name = "TxtCustomersEmail";
            TxtCustomersEmail.PlaceholderText = "Customers Email";
            TxtCustomersEmail.Size = new Size(311, 27);
            TxtCustomersEmail.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(441, 187);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 18;
            label10.Text = "Customers Email";
            // 
            // TxtCustomersPhoneNumber
            // 
            TxtCustomersPhoneNumber.Location = new Point(435, 147);
            TxtCustomersPhoneNumber.Name = "TxtCustomersPhoneNumber";
            TxtCustomersPhoneNumber.PlaceholderText = "Customers Phone Number";
            TxtCustomersPhoneNumber.Size = new Size(311, 27);
            TxtCustomersPhoneNumber.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(438, 127);
            label9.Name = "label9";
            label9.Size = new Size(194, 20);
            label9.TabIndex = 16;
            label9.Text = "Customers Phone Number";
            // 
            // TxtCustomersLastName
            // 
            TxtCustomersLastName.Location = new Point(26, 207);
            TxtCustomersLastName.Name = "TxtCustomersLastName";
            TxtCustomersLastName.PlaceholderText = "Customers Last Name";
            TxtCustomersLastName.Size = new Size(311, 27);
            TxtCustomersLastName.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 187);
            label8.Name = "label8";
            label8.Size = new Size(163, 20);
            label8.TabIndex = 14;
            label8.Text = "Customers Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(438, 72);
            label7.Name = "label7";
            label7.Size = new Size(148, 20);
            label7.TabIndex = 12;
            label7.Text = "Customers Birthday";
            // 
            // TxtCustomersAddress
            // 
            TxtCustomersAddress.Location = new Point(435, 36);
            TxtCustomersAddress.Name = "TxtCustomersAddress";
            TxtCustomersAddress.PlaceholderText = "Customers Address";
            TxtCustomersAddress.Size = new Size(311, 27);
            TxtCustomersAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(438, 16);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 10;
            label6.Text = "Customers Address";
            // 
            // TxtCustomersFirstName
            // 
            TxtCustomersFirstName.Location = new Point(23, 147);
            TxtCustomersFirstName.Name = "TxtCustomersFirstName";
            TxtCustomersFirstName.PlaceholderText = "Customers First Name";
            TxtCustomersFirstName.Size = new Size(311, 27);
            TxtCustomersFirstName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 127);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 8;
            label5.Text = "Customers First Name";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(425, 240);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(101, 53);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(306, 240);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(101, 53);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersId
            // 
            TxtCustomersId.Location = new Point(23, 36);
            TxtCustomersId.Name = "TxtCustomersId";
            TxtCustomersId.ReadOnly = true;
            TxtCustomersId.Size = new Size(185, 27);
            TxtCustomersId.TabIndex = 3;
            TxtCustomersId.Text = "0";
            TxtCustomersId.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 72);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 1;
            label4.Text = "Customers Document";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 16);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 0;
            label3.Text = "Customers Id";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "Customers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCustomers;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageCustomersDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtCustomersId;
        private Label label4;
        private Label label3;
        private TextBox TxtCustomersFirstName;
        private Label label5;
        private TextBox TxtCustomersEmail;
        private Label label10;
        private TextBox TxtCustomersPhoneNumber;
        private Label label9;
        private TextBox TxtCustomersLastName;
        private Label label8;
        private Label label7;
        private TextBox TxtCustomersAddress;
        private Label label6;
        private DateTimePicker TxtCustomersBirthday;
        private TextBox TxtCustomersDocument;
    }
}