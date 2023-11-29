using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        KitapDB vtsinif = new KitapDB();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtsinif.Liste();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kitap ktpsinif=new kitap();
            ktpsinif.ADI=textBox1.Text;
            ktpsinif.YAZAR=textBox2.Text;
            vtsinif.KitapEk(ktpsinif);
            MessageBox.Show("Kayıt Başarılı.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
