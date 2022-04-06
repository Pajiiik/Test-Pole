using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        char[] pole;
        int[] pole_jedna;
        char[] pole_dva;

        Random nahoda = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int pocet_prvku = 50, rng;
            pole = new char[pocet_prvku];
            pole_jedna = new int[pocet_prvku];
            pole_dva = new char[pocet_prvku];
            for (int i = 0; pocet_prvku > i; i++)
            {
                rng = nahoda.Next(32, 128);
                pole[i] = Convert.ToChar(rng);
                pole_jedna[i] = rng;
                pole_dva[i] = Convert.ToChar(rng);
                listBox1.Items.Add(pole[i]);
            }
            int u = 0,first=0,last=0;
            bool jednou = true;
            foreach (int z in pole_jedna)
            {
                if ((z > 47 && z < 58) || (z > 64 && z < 91))
                {
                    u++;
                    //textBox1.Lines[u] = (Convert.ToChar(z)).ToString();
                    if (z == 87)
                    {
                        if (jednou)
                        {
                            first = u;
                        }
                        else //co když se nachází pouze 1..
                        {
                            last = u;
                        }
                    }
                }

            }
            pole_dva.Reverse();
            pole_dva.Distinct();
            foreach (char y in pole_dva)
            {
                listBox2.Items.Add(y.ToString());
            }
            label1.Text = "První " + first.ToString();
            label2.Text = "Poslední " + last.ToString();

        }
    }
}
