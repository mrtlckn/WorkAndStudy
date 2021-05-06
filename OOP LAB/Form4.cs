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
    public partial class Form4 : Form
    {
        int x = 0, y = 0;
        int X_Ekseni, Y_Ekseni;

        private void button1_Click(object sender, EventArgs e)
        {
            minigame2 yon = new minigame2();
            int a, b;
            X_Ekseni = Convert.ToInt32(textBox1.Text);
            Y_Ekseni = Convert.ToInt32(textBox2.Text);

            a = yon.X_Tahmin(X_Ekseni, x);
            b = yon.Y_Tahmin(Y_Ekseni, y);
            if (a == 1)
            {
                lblDogu.Text = "Dogu Yönüne Git";
                lblBatı.Text = " ";
            }

            else if (a == 2)
            {

                lblGuney.Text = " ";
                lblBatı.Text = " ";
            }
            else
            {
                lblDogu.Text = " ";
                lblBatı.Text = "Batı Yönüne Git";
            }
            ////
            if (b == 1)
            {
                lblGuney.Text = "Güney Yönüne Git";
                lblKuzey.Text = " ";
            }

            else if (b == 2)
            {
                lblKuzey.Text = " ";
                lblGuney.Text = " ";

            }
            else
            {
                lblKuzey.Text = "Kuzey Yönüne Git";
                lblGuney.Text = " ";
            }
            if(a == 2 && b == 2)
            {
                lblDogu.Text = " Dogru Yerdesin";
                lblBatı.Text = " ";
                lblKuzey.Text = " ";
                lblGuney.Text = " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = Convert.ToString(x);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = Convert.ToString(y);
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            X_Ekseni = Convert.ToInt32(textBox1.Text);
            Y_Ekseni = Convert.ToInt32(textBox2.Text);
            minigame2 kullan = new minigame2();


            x = kullan.Xekseni_Random();
            y = kullan.Yekseni_Random();

            
        }
     

    }
}
