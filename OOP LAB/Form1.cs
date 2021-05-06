using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp17;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }
     
        private void button1_Click(object sender, EventArgs e)
        {

            User isim = User.Nesnever();

            if (isim.Control(txtUsername.Text, txtPass.Text) == true)
            {
                lblFinal.Text = "Succesful";
                lblFinal.BackColor = Color.Green;
                MessageBox.Show("3 second wait");
                Thread.Sleep(3000);
                this.Hide();
                Form3 f = new Form3();
                f.ShowDialog();

            }

            else
            {
                lblFinal.Text = "Yanlis";
                lblFinal.BackColor = Color.Red;
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayit f = new kayit();
            f.ShowDialog();
        }
    }
}
