﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongusu_toplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi1=Convert.ToInt32(txtsayi1.Text);
            int sayi2=Convert.ToInt32(txtsayi2.Text);

            for (int  i=sayi1; i <=sayi2;i ++)
            {
                toplam += i;
            }
            lblsonuc.Text=toplam.ToString();
        }
    }
}
