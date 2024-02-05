using DiyetUygulama.DAL.Contexts;
using LezzetVirtuozuApp.UIFORM.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LezzetVirtuozuApp.UIFORM
{

    public partial class AdminGirisiForm : Form
    {
        DiyetUygulamasiContext db;
        public AdminGirisiForm()
        {
            db = new DiyetUygulamasiContext();
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void pbKilitFoto_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.Admins.Where(x => x.Email == txtEposta.Text & x.Password == txtSifre.Text).Count();
                if (result != 0)
                {
                    AdminAnaMenu admin = new AdminAnaMenu();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı E-Posta veya Şifre.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
    

