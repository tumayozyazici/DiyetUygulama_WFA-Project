namespace LezzetVirtuozuApp.UIFORM.AdminForms
{
    partial class FormUyeEkleVeyaSil
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
            lst_Uye = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            txt_Adi = new TextBox();
            btn_UyeEkle = new Button();
            btn_UyeSil = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_SoyAdi = new TextBox();
            label4 = new Label();
            txt_Email = new TextBox();
            label5 = new Label();
            txt_Sifre = new TextBox();
            SuspendLayout();
            // 
            // lst_Uye
            // 
            lst_Uye.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lst_Uye.FullRowSelect = true;
            lst_Uye.Location = new Point(75, 276);
            lst_Uye.Name = "lst_Uye";
            lst_Uye.Size = new Size(552, 162);
            lst_Uye.TabIndex = 0;
            lst_Uye.UseCompatibleStateImageBehavior = false;
            lst_Uye.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Üye Adı";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Soyadı";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Email";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Şifre";
            columnHeader4.Width = 120;
            // 
            // txt_Adi
            // 
            txt_Adi.Location = new Point(149, 70);
            txt_Adi.Name = "txt_Adi";
            txt_Adi.Size = new Size(125, 27);
            txt_Adi.TabIndex = 1;
            // 
            // btn_UyeEkle
            // 
            btn_UyeEkle.Location = new Point(423, 175);
            btn_UyeEkle.Name = "btn_UyeEkle";
            btn_UyeEkle.Size = new Size(94, 29);
            btn_UyeEkle.TabIndex = 3;
            btn_UyeEkle.Text = "Üye Ekle";
            btn_UyeEkle.UseVisualStyleBackColor = true;
            btn_UyeEkle.Click += btn_UyeEkle_Click;
            // 
            // btn_UyeSil
            // 
            btn_UyeSil.Location = new Point(533, 175);
            btn_UyeSil.Name = "btn_UyeSil";
            btn_UyeSil.Size = new Size(94, 29);
            btn_UyeSil.TabIndex = 4;
            btn_UyeSil.Text = "Üye Sil";
            btn_UyeSil.UseVisualStyleBackColor = true;
            btn_UyeSil.Click += btn_UyeSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 35);
            label1.Name = "label1";
            label1.Size = new Size(73, 18);
            label1.TabIndex = 5;
            label1.Text = "Yeni Üye";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 73);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 6;
            label2.Text = "Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 118);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Soyadı:";
            // 
            // txt_SoyAdi
            // 
            txt_SoyAdi.Location = new Point(149, 116);
            txt_SoyAdi.Name = "txt_SoyAdi";
            txt_SoyAdi.Size = new Size(125, 27);
            txt_SoyAdi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 73);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(423, 70);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(204, 27);
            txt_Email.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 119);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 12;
            label5.Text = "Şifre:";
            // 
            // txt_Sifre
            // 
            txt_Sifre.Location = new Point(423, 116);
            txt_Sifre.Name = "txt_Sifre";
            txt_Sifre.Size = new Size(204, 27);
            txt_Sifre.TabIndex = 11;
            // 
            // FormUyeEkleVeyaSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txt_Sifre);
            Controls.Add(label4);
            Controls.Add(txt_Email);
            Controls.Add(label3);
            Controls.Add(txt_SoyAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_UyeSil);
            Controls.Add(btn_UyeEkle);
            Controls.Add(txt_Adi);
            Controls.Add(lst_Uye);
            Name = "FormUyeEkleVeyaSil";
            Text = "FormUyeEkleVeyaSil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lst_Uye;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txt_Adi;
        private Button btn_UyeEkle;
        private Button btn_UyeSil;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_SoyAdi;
        private Label label4;
        private TextBox txt_Email;
        private Label label5;
        private TextBox txt_Sifre;
        private ColumnHeader columnHeader4;
    }
}