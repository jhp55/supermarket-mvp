namespace Supermarket_mvp.Views
{
    partial class ProductsView
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
            tabPageProductsList = new TabPage();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProducts = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductsDetail = new TabPage();
            TxtProductStock = new TextBox();
            TxtProductsIdCateg = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            TxtProductsPrice = new TextBox();
            label5 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductsName = new TextBox();
            TxtProductsId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductsDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 116);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
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
            label1.Font = new Font("Bernard MT Condensed", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 95);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 116);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1136, 451);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(BtnDelete);
            tabPageProductsList.Controls.Add(BtnClose);
            tabPageProductsList.Controls.Add(BtnEdit);
            tabPageProductsList.Controls.Add(BtnNew);
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(1128, 418);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Pay Products";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(937, 310);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(183, 68);
            BtnDelete.TabIndex = 7;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(937, 236);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(183, 68);
            BtnClose.TabIndex = 6;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(937, 162);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(183, 68);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(937, 88);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(183, 68);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(29, 83);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.Size = new Size(902, 327);
            DgProducts.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(873, 29);
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
            TxtSearch.Size = new Size(832, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 20);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Products";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(TxtProductStock);
            tabPageProductsDetail.Controls.Add(TxtProductsIdCateg);
            tabPageProductsDetail.Controls.Add(label7);
            tabPageProductsDetail.Controls.Add(label6);
            tabPageProductsDetail.Controls.Add(TxtProductsPrice);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(BtnCancel);
            tabPageProductsDetail.Controls.Add(BtnSave);
            tabPageProductsDetail.Controls.Add(TxtProductsName);
            tabPageProductsDetail.Controls.Add(TxtProductsId);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 29);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(1128, 418);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Products Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(671, 36);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "Products Stock";
            TxtProductStock.Size = new Size(367, 27);
            TxtProductStock.TabIndex = 14;
            // 
            // TxtProductsIdCateg
            // 
            TxtProductsIdCateg.FormattingEnabled = true;
            TxtProductsIdCateg.Location = new Point(671, 101);
            TxtProductsIdCateg.Name = "TxtProductsIdCateg";
            TxtProductsIdCateg.Size = new Size(367, 28);
            TxtProductsIdCateg.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(671, 81);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 12;
            label7.Text = "Products Categories";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(671, 13);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 10;
            label6.Text = "Products Stock";
            // 
            // TxtProductsPrice
            // 
            TxtProductsPrice.Location = new Point(98, 178);
            TxtProductsPrice.Name = "TxtProductsPrice";
            TxtProductsPrice.PlaceholderText = "Products Price";
            TxtProductsPrice.Size = new Size(375, 27);
            TxtProductsPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(98, 155);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 8;
            label5.Text = "Products Price";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(567, 240);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(101, 53);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(429, 240);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(101, 53);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductsName
            // 
            TxtProductsName.Location = new Point(98, 101);
            TxtProductsName.Name = "TxtProductsName";
            TxtProductsName.PlaceholderText = "Products Name";
            TxtProductsName.Size = new Size(375, 27);
            TxtProductsName.TabIndex = 4;
            // 
            // TxtProductsId
            // 
            TxtProductsId.Location = new Point(98, 36);
            TxtProductsId.Name = "TxtProductsId";
            TxtProductsId.ReadOnly = true;
            TxtProductsId.Size = new Size(185, 27);
            TxtProductsId.TabIndex = 3;
            TxtProductsId.Text = "0";
            TxtProductsId.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(98, 81);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 1;
            label4.Text = "Products Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 13);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "Products Id";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1136, 567);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "Products Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProducts;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPageProductsDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductsName;
        private TextBox TxtProductsId;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Label label6;
        private TextBox TxtProductsPrice;
        private Label label5;
        private ComboBox TxtProductsIdCateg;
        private Label label7;
        private TextBox TxtProductStock;
    }
}