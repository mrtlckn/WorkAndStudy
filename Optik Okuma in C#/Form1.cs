using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp10;

namespace OptikFormOkuyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog() == DialogResult.OK)
            {
                
                    if (listBox3.SelectedIndex == 0)
                    {
                        Test test = new Test(op.FileName, 14);
                        test.Yanlis_dogru_goturme = true;
                        if (listBox4.SelectedIndex == 1)
                    {
                        test.Yuvarlama_yonu = false;
                    }
                        else
                    {
                        test.Yuvarlama_yonu = true;
                    }

                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        test.Heapla(listBox1, listBox2);
                        textBox1.Text = "  ";

                    }
                    else if (listBox3.SelectedIndex == 2)
                    {
                        OptikOku oku = new OptikOku(op.FileName, 14);
                        oku.Yuvarlama_yonu = true;
                        if (listBox4.SelectedIndex == 1)
                    {
                        oku.Yuvarlama_yonu = false;
                    }
                        else 
                    {
                        oku.Yuvarlama_yonu = true;
                    }
                   
                    listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        oku.Heapla(listBox1, listBox2);
                        textBox1.Text = "  ";

                    }
                    else
                    {
                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        textBox1.Text = "Ogrenci Not Hesaplamayı Seciniz.";
                        listBox1.Items.Add("Secenek Bos gecilemez");
                        listBox2.Items.Add("Secenek Bos gecilemez");
                    }
                

              


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                OptikOku oku = new OptikOku(op.FileName);
                oku.AyniOgrNoBul(listBox1);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

       
      
       
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
