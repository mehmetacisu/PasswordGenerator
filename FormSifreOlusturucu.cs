using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSifreOlusturucu
{
    public partial class FormSifreOlusturucu : Form
    {
        public FormSifreOlusturucu()
        {
            InitializeComponent();
            ComboboxItemEkle();
            label_Message.Text = "";
            label_Sifre.Text = "";
        }

        private void ComboboxItemEkle()
        {
            for (int i = 1; i <= 25; i++)
            {
                comboBox_Uzunluk.Items.Add(i);
            }
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void SifreOlustur()
        {
            string harfRakamSembol = "abcdefghijklmnoprstuwxyz" +
                "ABCDEFGHIKLMNOPRSTUWXYZ" +
                "0123456789"+
                "~!£$%^*&*";
            Random rastgele = new Random();
            string sifre = "";
            try
            {
                if (comboBox_Uzunluk.SelectedItem == null || comboBox_Uzunluk.Text=="")
                {
                    label_Message.Text = "Lütfen Uzunluk Seçimi Yapınız.";
                }
                else
                {
                    for (int i = 0; i < int.Parse(comboBox_Uzunluk.SelectedItem.ToString()); i++)
                    {
                        sifre += harfRakamSembol[rastgele.Next(harfRakamSembol.Length)];
                    }
                    label_Sifre.Text = "Oluşturulan Şifreniz : " + sifre;
                    label_Message.Text = "";
                }

            }
            catch (Exception hata)
            {
                label_Message.Text = hata.Message;
            }

        }
        private void button_Olustur_Click(object sender, EventArgs e)
        {
            SifreOlustur();
        }

        private void button_Kopyala_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(label_Sifre.Text))
                {
                    label_Message.Text = "Lütfen şifre oluşturunuz.";
                }
                else
                {
                    Clipboard.SetText(label_Sifre.Text.Split(' ').Last());
                    MessageBox.Show("Şifre kopyalandı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);   
                }
            }
            catch (Exception hata)
            {
                label_Message.Text = hata.Message;
            }

        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            comboBox_Uzunluk.SelectedItem = "";
            comboBox_Uzunluk.Text = "";
            label_Sifre.Text = "";
            label_Message.Text = "Seçimler Başarıyla Temizlendi";
        }
    }
}