using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap1=new Kitap();
            kitap1.turu = "Roman";
            kitap1.yazari = "Arslı Arslan";
            kitap1.sayfasayisi = 624;
            kitap1.kitapismi = "Sokak Nöbetçileri 3";
            kitap1.yayintarihi = 2023;
            label1.Text = kitap1.turu + " " + kitap1.yazari + " " + kitap1.sayfasayisi +" "+kitap1.kitapismi+" "+kitap1.yayintarihi;



        }
    }
    }

