using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamayı Kapatmak İstiyor musunuz?", "Çıkış Birimleri", MessageBoxButtons.YesNoCancel);
            if (cevap == DialogResult.Yes) 
            {
                MessageBox.Show("Uygulama Kapandı");
                Application.Exit();
            }
            else if (cevap == DialogResult.No) 
            {
                MessageBox.Show("Sisteme Geri Dönülüyor");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ekle = MessageBox.Show("Ürünü Almak İstiyor musunuz?", "Satın Alma", MessageBoxButtons.YesNoCancel);
            if (ekle == DialogResult.Yes)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else if (ekle == DialogResult.No)
            {
                textBox1.Clear();
                MessageBox.Show("Siparişiniz İptal Edildi");
            }
        }
    }
}
