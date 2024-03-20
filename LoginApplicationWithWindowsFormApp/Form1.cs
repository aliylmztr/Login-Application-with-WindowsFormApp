using System;
using System.Windows.Forms;

namespace LoginApplicationWithWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";

            kullaniciAdi = txt_kullaniciAdi.Text;
            sifre = txt_sifre.Text;

            if (kullaniciAdi.ToLower() == "enes" && sifre == "1")
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız.", "Bilgilendirme");

            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifresi!", "Bilgilendirme");
            }
        }
    }
}
