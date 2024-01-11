using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silasizde130
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] diziKaynak =new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            for (int i = 0; i<diziKaynak.Length;i++)
            {
                diziKaynak[i] = rastgele.Next(0,10);
            }
            for (int i = 0; i<diziKaynak.Length; i++)
            {
                listBox1.Items.Add(diziKaynak[i]);
            }
            label2.Text = "En büyük:" + diziKaynak.Max().ToString();
            label3.Text = "En küçük:"+ diziKaynak.Min().ToString();
            label4.Text = "Toplam:"+ diziKaynak.Sum().ToString();
            label5.Text = "Ortalama:"+ diziKaynak.Average().ToString();
            label6.Text = "İlk ereman:"+ diziKaynak.First().ToString();
            label7.Text = "Son ereman:"+ diziKaynak.Last().ToString();
        }
    }
}
