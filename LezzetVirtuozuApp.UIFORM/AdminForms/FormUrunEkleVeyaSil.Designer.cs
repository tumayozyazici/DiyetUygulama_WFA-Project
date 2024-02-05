namespace LezzetVirtuozuApp.UIFORM.AdminForms
{
    partial class FormUrunEkleVeyaSil
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
            label5 = new Label();
            txt_Protein = new TextBox();
            label4 = new Label();
            txt_Kalori = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_UrunSil = new Button();
            btn_UrunEkle = new Button();
            txt_Adi = new TextBox();
            lst_Urun = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            cmb_Kategori = new ComboBox();
            pcb_foto = new PictureBox();
            label6 = new Label();
            txt_Karbonhidrat = new TextBox();
            label7 = new Label();
            txt_Yag = new TextBox();
            label8 = new Label();
            txt_Porsiyon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcb_foto).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 116);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 24;
            label5.Text = "Protein:";
            // 
            // txt_Protein
            // 
            txt_Protein.Location = new Point(415, 113);
            txt_Protein.Name = "txt_Protein";
            txt_Protein.Size = new Size(204, 27);
            txt_Protein.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 73);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 22;
            label4.Text = "Kalori:";
            // 
            // txt_Kalori
            // 
            txt_Kalori.Location = new Point(415, 70);
            txt_Kalori.Name = "txt_Kalori";
            txt_Kalori.Size = new Size(204, 27);
            txt_Kalori.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 119);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 20;
            label3.Text = "Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 73);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 18;
            label2.Text = "Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 17;
            label1.Text = "Yeni Ürün";
            // 
            // btn_UrunSil
            // 
            btn_UrunSil.Location = new Point(525, 232);
            btn_UrunSil.Name = "btn_UrunSil";
            btn_UrunSil.Size = new Size(94, 29);
            btn_UrunSil.TabIndex = 16;
            btn_UrunSil.Text = "Ürün Sil";
            btn_UrunSil.UseVisualStyleBackColor = true;
            btn_UrunSil.Click += btn_UrunSil_Click;
            // 
            // btn_UrunEkle
            // 
            btn_UrunEkle.Location = new Point(415, 232);
            btn_UrunEkle.Name = "btn_UrunEkle";
            btn_UrunEkle.Size = new Size(94, 29);
            btn_UrunEkle.TabIndex = 15;
            btn_UrunEkle.Text = "Ürün Ekle";
            btn_UrunEkle.UseVisualStyleBackColor = true;
            btn_UrunEkle.Click += btn_UrunEkle_Click;
            // 
            // txt_Adi
            // 
            txt_Adi.Location = new Point(141, 70);
            txt_Adi.Name = "txt_Adi";
            txt_Adi.Size = new Size(151, 27);
            txt_Adi.TabIndex = 14;
            // 
            // lst_Urun
            // 
            lst_Urun.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lst_Urun.FullRowSelect = true;
            lst_Urun.Location = new Point(67, 276);
            lst_Urun.Name = "lst_Urun";
            lst_Urun.Size = new Size(552, 162);
            lst_Urun.TabIndex = 13;
            lst_Urun.UseCompatibleStateImageBehavior = false;
            lst_Urun.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Adı";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategori";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kalori";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Karbonhidrat";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Protein";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // cmb_Kategori
            // 
            cmb_Kategori.FormattingEnabled = true;
            cmb_Kategori.Location = new Point(141, 116);
            cmb_Kategori.Name = "cmb_Kategori";
            cmb_Kategori.Size = new Size(151, 28);
            cmb_Kategori.TabIndex = 25;
            // 
            // pcb_foto
            // 
            pcb_foto.Location = new Point(141, 150);
            pcb_foto.Name = "pcb_foto";
            pcb_foto.Size = new Size(151, 90);
            pcb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb_foto.TabIndex = 26;
            pcb_foto.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 159);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 28;
            label6.Text = "Karbonhidrat:";
            // 
            // txt_Karbonhidrat
            // 
            txt_Karbonhidrat.Location = new Point(415, 156);
            txt_Karbonhidrat.Name = "txt_Karbonhidrat";
            txt_Karbonhidrat.Size = new Size(204, 27);
            txt_Karbonhidrat.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 202);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 30;
            label7.Text = "Yağ:";
            // 
            // txt_Yag
            // 
            txt_Yag.Location = new Point(415, 199);
            txt_Yag.Name = "txt_Yag";
            txt_Yag.Size = new Size(204, 27);
            txt_Yag.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 35);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 32;
            label8.Text = "Porsiyon:";
            // 
            // txt_Porsiyon
            // 
            txt_Porsiyon.Location = new Point(415, 32);
            txt_Porsiyon.Name = "txt_Porsiyon";
            txt_Porsiyon.Size = new Size(204, 27);
            txt_Porsiyon.TabIndex = 31;
            // 
            // FormUrunEkleVeyaSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txt_Porsiyon);
            Controls.Add(label7);
            Controls.Add(txt_Yag);
            Controls.Add(label6);
            Controls.Add(txt_Karbonhidrat);
            Controls.Add(pcb_foto);
            Controls.Add(cmb_Kategori);
            Controls.Add(label5);
            Controls.Add(txt_Protein);
            Controls.Add(label4);
            Controls.Add(txt_Kalori);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_UrunSil);
            Controls.Add(btn_UrunEkle);
            Controls.Add(txt_Adi);
            Controls.Add(lst_Urun);
            Name = "FormUrunEkleVeyaSil";
            Text = "FormUrunEkleVeyaSil";
            Load += FormUrunEkleVeyaSil_Load;
            ((System.ComponentModel.ISupportInitialize)pcb_foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txt_Protein;
        private Label label4;
        private TextBox txt_Kalori;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_UrunSil;
        private Button btn_UrunEkle;
        private TextBox txt_Adi;
        private ListView lst_Urun;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox cmb_Kategori;
        private PictureBox pcb_foto;
        private Label label6;
        private TextBox txt_Karbonhidrat;
        private Label label7;
        private TextBox txt_Yag;
        private ColumnHeader columnHeader5;
        private Label label8;
        private TextBox txt_Porsiyon;
    }
}