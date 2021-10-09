using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tambah_Click(object sender, EventArgs e)
        {
            double nilai = Convert.ToDouble(nilai1.Text);
            double nilaiKedua = Convert.ToDouble(nilai2.Text);
            

            double hasil = nilai + nilaiKedua;
            nilai3.Text = hasil.ToString();
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            double nilai = Convert.ToDouble(nilai1.Text);
            double nilaiKedua = Convert.ToDouble(nilai2.Text);


            double hasil = nilai - nilaiKedua;
            nilai3.Text = hasil.ToString();
        }

        private void kali_Click(object sender, EventArgs e)
        {
            double nilai = Convert.ToDouble(nilai1.Text);
            double nilaiKedua = Convert.ToDouble(nilai2.Text);


            double hasil = nilai * nilaiKedua;
            nilai3.Text = hasil.ToString();
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            double nilai = Convert.ToDouble(nilai1.Text);
            double nilaiKedua = Convert.ToDouble(nilai2.Text);


            double hasil = nilai / nilaiKedua;
            nilai3.Text = hasil.ToString();
        }

        private void bersih_Click(object sender, EventArgs e)
        {
            nilai1.Text = "";
            nilai2.Text = "";
            nilai3.Text = "";
        }
    }
}
