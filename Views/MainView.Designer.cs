namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnProducts = new Button();
            BtnCategories = new Button();
            BtnCustomers = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 573);
            panel1.TabIndex = 0;
            // 
            // BtnProducts
            // 
            BtnProducts.BackColor = SystemColors.ButtonHighlight;
            BtnProducts.BackgroundImage = Properties.Resources.products;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(0, 388);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(219, 93);
            BtnProducts.TabIndex = 5;
            BtnProducts.UseVisualStyleBackColor = false;
            // 
            // BtnCategories
            // 
            BtnCategories.BackColor = SystemColors.ButtonHighlight;
            BtnCategories.BackgroundImage = Properties.Resources.categorias;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(0, 289);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(219, 93);
            BtnCategories.TabIndex = 4;
            BtnCategories.UseVisualStyleBackColor = false;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackColor = SystemColors.ButtonHighlight;
            BtnCustomers.BackgroundImage = Properties.Resources.providers;
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(0, 190);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(219, 93);
            BtnCustomers.TabIndex = 3;
            BtnCustomers.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.LightCoral;
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 480);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(219, 93);
            BtnExit.TabIndex = 2;
            BtnExit.Text = "\r\n";
            BtnExit.UseVisualStyleBackColor = false;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackColor = SystemColors.ButtonHighlight;
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 91);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(219, 93);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = Properties.Resources.Leonardo_Phoenix_A_vibrant_and_colorful_mural_depicting_a_larg_1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(943, 573);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnCustomers;
        private Button BtnCategories;
        private Button BtnProducts;
    }
}