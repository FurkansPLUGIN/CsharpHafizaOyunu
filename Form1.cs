using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu
{
    public partial class Form1 : Form
    {
        List<string> icon = new List<string>()
        {
            "f","u","r","k","a","n","2","3","S","i","m","z","y","q","b","o",
            "f","u","r","k","a","n","2","3", "S","i","m","z","y","q","b","o"
        };

      

        Random rnd = new Random();
        int pos=0;
        Timer time = new Timer();
        Timer time1 = new Timer();
        Button birinci;
        Button ikinci;
        public Form1()
        {
            InitializeComponent();
            time.Tick += zaman;
            time.Start();
            time.Interval = 10000;
            Goster();
          
            time1.Tick += zaman1;
        }

        private void zaman1(object sender, EventArgs e)
        {
            time1.Stop();
            birinci.ForeColor = Color.Maroon;
            ikinci.ForeColor = Color.Maroon;
            birinci = null;
            ikinci = null;
        }

        private void zaman(object sender, EventArgs e)
        {
            time.Stop();
            foreach(Button item in Controls)
            {
                item.ForeColor = Color.Maroon;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //int pos1 ;

       
        private void Goster()
        {
            Button btn;
            //Button btn1;
            foreach (Button item in Controls)
            {
                btn = item as Button;
                pos = rnd.Next(icon.Count);
                btn.Text = icon[pos];
                btn.ForeColor = Color.Black;
                icon.RemoveAt(pos);

                //btn = item as Button;
                //pos = rnd.Next(icon1.Count);
                //btn.Text = icon1[pos1];
                //btn.ForeColor = Color.Black;
                //icon.RemoveAt(pos1);
            }
        }
        int sayac = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (birinci == null)
            {
                birinci = btn;
                birinci.ForeColor = Color.Black;
                return;
            }
            ikinci = btn;
            ikinci.ForeColor = Color.Black;
            if (birinci.Text == ikinci.Text)
            {
                birinci.ForeColor = Color.Black;
                ikinci.ForeColor = Color.Black;
                birinci = null;
                ikinci = null;
                sayac++;
                if (sayac >= 8)
                {

                }
            }
            else
            {
                time1.Start();
                time1.Interval = 1000;
            }
        }
    }
}
