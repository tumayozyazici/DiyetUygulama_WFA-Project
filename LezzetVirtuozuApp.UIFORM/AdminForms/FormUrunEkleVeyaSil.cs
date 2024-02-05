using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DATA.Entities;
using DiyetUygulama.SERVICE.Concrete;
using DiyetUygulama.SERVICE.Interfaces;
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
    public partial class FormUrunEkleVeyaSil : Form
    {
        ICategorySERVICE _categoryService;
        IProductSERVICE _productService;
        DiyetUygulamasiContext db;
        public FormUrunEkleVeyaSil()
        {
            db = new DiyetUygulamasiContext();
            _categoryService = new CategorySERVICE();
            _productService = new ProductSERVICE();
            InitializeComponent();
            Category();
            listele();

        }

        private void Category()
        {
            cmb_Kategori.DataSource = _categoryService.GetAll();
            cmb_Kategori.DisplayMember = "CategoryName";
            cmb_Kategori.ValueMember = "CategoryId";
        }

        private void listele()
        {
            lst_Urun.Items.Clear();
            var urunler = db.Products.ToList();
            foreach (var urun in urunler)
            {

                ListViewItem list = new ListViewItem(urun.ProductName);
                list.SubItems.Add(urun.Category?.ToString());
                list.SubItems.Add(urun.Calories?.ToString());
                list.SubItems.Add(urun.Carbonhydrate?.ToString());
                list.SubItems.Add(urun.Protein?.ToString());
                list.Tag = urun;
                lst_Urun.Items.Add(list);
            }
        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txt_Kalori.Text) || string.IsNullOrEmpty(txt_Adi.Text))
            {
                MessageBox.Show("Ürün Adı veya Kalorisi boş geçilemez.");
                return;
            }
            try
            {

                Product product = new Product();
                product.ProductName = txt_Adi.Text;
                product.CategoryId = (int)cmb_Kategori.SelectedValue;
                product.MealId = 1;
                product.Portion= txt_Porsiyon.Text;
                product.Calories = Convert.ToDouble(txt_Kalori.Text);
                product.Protein = Convert.ToDouble(txt_Protein.Text);
                product.Carbonhydrate = Convert.ToDouble(txt_Karbonhidrat.Text);
                product.Fat = Convert.ToDouble(txt_Yag.Text);

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PhotoPath(png,jpg,gif,jpeg,JPG)|*.png;*.jpg;*.gif;*.jpeg;*.JPG";
                DialogResult result = ofd.ShowDialog();
                try
                {
                    if (result == DialogResult.OK)
                    {
                        pcb_foto.Image = Image.FromFile(ofd.FileName);
                        pcb_foto.Tag = Path.GetExtension(ofd.FileName);

                        product.PhotoPath = "FoodPictures\\" + pcb_foto.Tag.ToString();
                        pcb_foto.Image.Save(Application.StartupPath + "FoodPictures\\" + pcb_foto.Tag);

                        MessageBox.Show("Fotoğrafınız başarıyla kaydedildi.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Doğru Formatta Resim Ekleyiniz.(png,jpg,gif,jpeg,JPG)");
                }
                db.Products.Add(product);
                db.SaveChanges();
                listele();

                MessageBox.Show("Ürün başarıyla eklendi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Verileri eksiksiz ve doğru formatta giriniz");
            }



        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            var urun = db.Products.FirstOrDefault(x => x.ProductName == ((Product)lst_Urun.SelectedItems[0].Tag).ProductName);
            _productService.Delete(urun);
            listele();

        }

        private void btn_FotoEkle_Click(object sender, EventArgs e)
        {

        }

        private void FormUrunEkleVeyaSil_Load(object sender, EventArgs e)
        {

        }
    }
}



