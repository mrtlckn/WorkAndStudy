using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form5 : Form
    {
        int x = 0;
        int X_Ekseni;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X_Ekseni = Convert.ToInt32(textBox1.Text);

            minigame kullan = new minigame();
            x = kullan.Xekseni_Random();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minigame yon = new minigame();
            int a, b;
            X_Ekseni = Convert.ToInt32(textBox1.Text);


            a = yon.X_Tahmin(X_Ekseni, x);
            b = yon.Y_Tahmin(X_Ekseni, x);
            if (a == 0)
            {
                lblDogu.Text = "Dogu Yönüne Git";
                lblBatı.Text = " ";
                label1.Text = " ";
            }

            else if (a == 2)
            {

                lblGuney.Text = " ";
                lblBatı.Text = " ";
                label1.Text = " ";
            }
            else
            {
                lblDogu.Text = " ";
                lblBatı.Text = "Batı Yönüne Git";
                label1.Text = " ";
            }
            ////
            if (b == 1)
            {
                lblGuney.Text = "Güney Yönüne Git";
                lblKuzey.Text = " ";
                label1.Text = " ";
            }

            else if (b == 2)
            {
                lblKuzey.Text = " ";
                lblGuney.Text = " ";
                label1.Text = " ";
            }
            else
            {
                lblKuzey.Text = "Kuzey Yönüne Git";
                lblGuney.Text = " ";
                label1.Text = " ";
            }
            if (a == 2 && b == 2)
            {
                label1.Text = "Dogru Yerdesin ";
                lblDogu.Text = " ";
                lblBatı.Text = " ";
                lblKuzey.Text = " ";
                lblGuney.Text = " ";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(x);
        }
    }
}

