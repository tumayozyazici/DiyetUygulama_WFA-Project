﻿namespace LezzetVirtuozuApp.UIFORM
{
    partial class UyeOlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeOlForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lbl_sifreGucu = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            btnGiris = new Button();
            txtSifre = new TextBox();
            pictureBox1 = new PictureBox();
            pbKilitFoto = new PictureBox();
            txtEposta = new TextBox();
            btnCikis = new Button();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKilitFoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 553);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 55);
            label2.Name = "label2";
            label2.Size = new Size(181, 34);
            label2.TabIndex = 2;
            label2.Text = "Hoş Geldiniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(214, 34);
            label1.TabIndex = 1;
            label1.Text = "Lezzet Virtüözü";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(lbl_sifreGucu);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnGiris);
            panel2.Controls.Add(txtSifre);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pbKilitFoto);
            panel2.Controls.Add(txtEposta);
            panel2.Controls.Add(btnCikis);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(321, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 553);
            panel2.TabIndex = 5;
            // 
            // lbl_sifreGucu
            // 
            lbl_sifreGucu.AutoSize = true;
            lbl_sifreGucu.Location = new Point(166, 350);
            lbl_sifreGucu.Name = "lbl_sifreGucu";
            lbl_sifreGucu.Size = new Size(0, 20);
            lbl_sifreGucu.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(166, 444);
            label10.Name = "label10";
            label10.Size = new Size(460, 20);
            label10.TabIndex = 12;
            label10.Text = "Şifre en az 7 karakterden fazla, bir büyük harf ve sayıdan oluşmalıdır.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.member_card_7186404_enbüyük1;
            pictureBox2.Location = new Point(238, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnGiris
            // 
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.Location = new Point(166, 393);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Üye Ol";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(166, 307);
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.Size = new Size(376, 27);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pbKilitFoto
            // 
            pbKilitFoto.Image = (Image)resources.GetObject("pbKilitFoto.Image");
            pbKilitFoto.Location = new Point(91, 305);
            pbKilitFoto.Name = "pbKilitFoto";
            pbKilitFoto.Size = new Size(35, 29);
            pbKilitFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKilitFoto.TabIndex = 8;
            pbKilitFoto.TabStop = false;
            pbKilitFoto.Click += pbKilitFoto_Click;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(166, 239);
            txtEposta.Name = "txtEposta";
            txtEposta.PlaceholderText = "Eposta(Örn:Kullanıcı@gmail.com)";
            txtEposta.Size = new Size(376, 27);
            txtEposta.TabIndex = 1;
            // 
            // btnCikis
            // 
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.OrangeRed;
            btnCikis.Location = new Point(621, 0);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(40, 40);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "X";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(571, 527);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 4;
            label4.Text = "Grup Şurup";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(531, 510);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 3;
            label3.Text = "Develop By";
            // 
            // UyeOlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UyeOlForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKilitFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCikis;
        private Label label4;
        private Panel panel4;
        private TextBox txtSifre;
        private PictureBox pbKilitFoto;
        private Panel panel3;
        private TextBox txtEposta;
        private PictureBox pictureBox1;
        private Button btnGiris;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label10;
        private Label lbl_sifreGucu;
    }
}