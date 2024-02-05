namespace LezzetVirtuozuApp.UIFORM.AdminForms
{
    partial class AdminAnaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            pnlLogo = new Panel();
            label1 = new Label();
            btn_UyeEkle = new Button();
            btn_UrunEkle = new Button();
            pnlTitleBar = new Panel();
            btnMin = new Button();
            btnMax = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            pnlDesktopPanel = new Panel();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            pnlDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.OrangeRed;
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Controls.Add(btn_UyeEkle);
            pnlMenu.Controls.Add(btn_UrunEkle);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 628);
            pnlMenu.TabIndex = 0;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(label1);
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 94);
            pnlLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(214, 34);
            label1.TabIndex = 2;
            label1.Text = "Lezzet Virtüözü";
            // 
            // btn_UyeEkle
            // 
            btn_UyeEkle.FlatAppearance.BorderSize = 0;
            btn_UyeEkle.FlatStyle = FlatStyle.Flat;
            btn_UyeEkle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_UyeEkle.ForeColor = SystemColors.ControlLightLight;
            btn_UyeEkle.Image = Properties.Resources.useradddelete;
            btn_UyeEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_UyeEkle.Location = new Point(0, 147);
            btn_UyeEkle.Name = "btn_UyeEkle";
            btn_UyeEkle.Padding = new Padding(12, 0, 0, 0);
            btn_UyeEkle.Size = new Size(250, 58);
            btn_UyeEkle.TabIndex = 3;
            btn_UyeEkle.Text = "Üye Ekle veya Sil";
            btn_UyeEkle.TextAlign = ContentAlignment.MiddleLeft;
            btn_UyeEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_UyeEkle.UseVisualStyleBackColor = true;
            btn_UyeEkle.Click += btn_UyeEkle_Click;
            // 
            // btn_UrunEkle
            // 
            btn_UrunEkle.FlatAppearance.BorderSize = 0;
            btn_UrunEkle.FlatStyle = FlatStyle.Flat;
            btn_UrunEkle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_UrunEkle.ForeColor = SystemColors.ControlLightLight;
            btn_UrunEkle.Image = Properties.Resources.menu32;
            btn_UrunEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btn_UrunEkle.Location = new Point(0, 94);
            btn_UrunEkle.Name = "btn_UrunEkle";
            btn_UrunEkle.Padding = new Padding(12, 0, 0, 0);
            btn_UrunEkle.Size = new Size(250, 58);
            btn_UrunEkle.TabIndex = 1;
            btn_UrunEkle.Text = "Ürün Ekle veya Sil";
            btn_UrunEkle.TextAlign = ContentAlignment.MiddleLeft;
            btn_UrunEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_UrunEkle.UseVisualStyleBackColor = true;
            btn_UrunEkle.Click += btn_UrunEkle_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.YellowGreen;
            pnlTitleBar.Controls.Add(btnMin);
            pnlTitleBar.Controls.Add(btnMax);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnCloseChildForm);
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(250, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(948, 94);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMin
            // 
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(823, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(44, 29);
            btnMin.TabIndex = 4;
            btnMin.Text = "O";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMax.ForeColor = Color.Yellow;
            btnMax.Location = new Point(864, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(44, 29);
            btnMax.TabIndex = 3;
            btnMax.Text = "O";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(904, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(44, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(94, 94);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(406, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(156, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ana Menü";
            // 
            // pnlDesktopPanel
            // 
            pnlDesktopPanel.BackColor = SystemColors.ControlLightLight;
            pnlDesktopPanel.Controls.Add(label2);
            pnlDesktopPanel.Controls.Add(label3);
            pnlDesktopPanel.Controls.Add(pictureBox2);
            pnlDesktopPanel.Dock = DockStyle.Fill;
            pnlDesktopPanel.Location = new Point(250, 94);
            pnlDesktopPanel.Name = "pnlDesktopPanel";
            pnlDesktopPanel.Size = new Size(948, 534);
            pnlDesktopPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(628, 319);
            label2.Name = "label2";
            label2.Size = new Size(181, 34);
            label2.TabIndex = 4;
            label2.Text = "Hoş Geldiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 104);
            label3.Name = "label3";
            label3.Size = new Size(214, 34);
            label3.TabIndex = 3;
            label3.Text = "Lezzet Virtüözü";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.portakal;
            pictureBox2.Location = new Point(316, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(306, 538);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // AdminAnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 628);
            ControlBox = false;
            Controls.Add(pnlDesktopPanel);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminAnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlDesktopPanel.ResumeLayout(false);
            pnlDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlLogo;
        private Button btn_UrunEkle;
        private Button btn_UyeEkle;
        private Panel pnlTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel pnlDesktopPanel;
        private Button btnCloseChildForm;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Button btnMin;
        private Button btnMax;
        private Button btnClose;
    }
}
