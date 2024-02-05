using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LezzetVirtuozuApp.UIFORM.AdminForms
{
    public partial class FormUyeEkleVeyaSil : Form
    {
        DiyetUygulamasiContext db;
        public FormUyeEkleVeyaSil()
        {
            InitializeComponent();
            db = new DiyetUygulamasiContext();
            Listele();
        }
        private void Listele()
        {
            lst_Uye.Items.Clear();
            var uyeler = db.Members.ToList();
            foreach (var uye in uyeler)
            {
                ListViewItem list = new ListViewItem(uye.MemberName);
                list.SubItems.Add(uye.MemberSurname);
                list.SubItems.Add(uye.Email);
                list.SubItems.Add(uye.Password);
                lst_Uye.Items.Add(list);


            }
        }


        private void btn_UyeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_Sifre.Text))
            {
                MessageBox.Show("Email ve şifre boş geçilemez.");
                return;
            }
            try
            {
                Member member = new Member();
                member.MemberName = txt_Adi.Text;
                member.MemberSurname = txt_SoyAdi.Text;
                member.Email = txt_Email.Text;
                member.Password = txt_Sifre.Text;
                db.Members.Add(member);
                db.SaveChanges();
                Listele();
                MessageBox.Show("Üye başarıyla eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Üye eklerken bir sorun oluştu.");
            }


        }

        private void btn_UyeSil_Click(object sender, EventArgs e)
        {
            if (lst_Uye.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem secilenUye = lst_Uye.SelectedItems[0];
                    string uyeEmail = secilenUye.SubItems[2].Text;

                    var silinecekUye = db.Members.FirstOrDefault(m => m.Email == uyeEmail);

                    if (silinecekUye != null)
                    {
                        db.Members.Remove(silinecekUye);
                        db.SaveChanges();
                        lst_Uye.Items.Remove(secilenUye);
                        MessageBox.Show("Üye başarıyla silindi.");
                        Listele();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Üye silme işleminde bir sorun oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi seçin.");
            }
        }


    }
}
