using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_örenek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            List<int>sayi=new List<int>();
            int[] sayilar = {1,2,3, 4, 5, 6, 7, 8, 9,10, 11, 12, 13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30 };

            int toplam = 0;
            //int sonuc=0;
            foreach (int sayi1 in sayilar)
            {
                toplam= toplam + sayi1;   
            }
            lblSonuc.Text =toplam.ToString();
        
            
            
        }
    }
}
