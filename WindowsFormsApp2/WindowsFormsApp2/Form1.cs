using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime bugun = DateTime.Now; 
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbladi.Text = dt.ToString("dddd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "En Küçük: " + DateTime.MinValue;
            label2.Text = "En Büyük: " + DateTime.MaxValue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Now  : " + DateTime.Now;
            label4.Text = "Today: " + DateTime.Today;

            //DateTime tarihSaat = new DateTime();
            //tarihSaat = DateTime.Now;

            //DateTime tarih = new DateTime();
            //tarih = DateTime.Today;

            //label3.Text = tarihSaat.ToString();
            //label4.Text = tarih.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = new DateTime(2022, 8, 25);


            label5.Text = "Tarih: " + bugun.ToShortDateString();
            label6.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = dateTimePicker1.Value;


            label7.Text = "Tarih: " + bugun.ToShortDateString();
            label8.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = bugun.Date.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label10.Text = bugun.Month.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label11.Text = bugun.Day.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label12.Text = bugun.Year.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label13.Text = bugun.DayOfWeek.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label14.Text = bugun.DayOfYear.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label15.Text = bugun.TimeOfDay.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label16.Text = bugun.Hour.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label17.Text = bugun.Minute.ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label18.Text = bugun.Second.ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label19.Text = bugun.Millisecond.ToString();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            label20.Text = bugun.Ticks.ToString();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            label21.Text = bugun.ToString();
            label22.Text = bugun.AddDays(5).ToString() + " 5 gün eklendi.";
            label23.Text = bugun.AddMonths(2).ToString() + " 2 ay eklendi.";
            label24.Text = bugun.AddYears(2).ToString() + " 2 yıl eklendi.";
            label25.Text = bugun.AddHours(3).ToString() + " 3 saat eklendi.";
            label26.Text = bugun.AddMinutes(15).ToString() + " 15 dakika eklendi.";
            label27.Text = bugun.AddSeconds(20).ToString() + " 20 saniye eklendi.";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            DateTime sonOdeme = new DateTime(2022, 3, 30, 14, 30, 50, 20);
            label28.Text = "Bugün: " + bugun.ToString();
            label29.Text = "Son Ödeme: " + sonOdeme.ToString();
            TimeSpan tarihFark = sonOdeme - bugun;
            label30.Text = "Gün Farkı: " + tarihFark.Days.ToString();
            label31.Text = "Saat Farkı: " + tarihFark.Hours.ToString();
            label32.Text = "Dakika Farkı: " + tarihFark.Minutes.ToString();
            label33.Text = "Saniye Farkı: " + tarihFark.Seconds.ToString();
            label34.Text = "MiliSaniye Farkı: " + tarihFark.Milliseconds.ToString();
        }


    }
}


