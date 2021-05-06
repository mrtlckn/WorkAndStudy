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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }
        private void click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            btnToplama.BackColor = Color.Transparent;
            btnCıkartma.BackColor = Color.Transparent;
            btnCarpma.BackColor = Color.Transparent;
            btnBolme.BackColor = Color.Transparent;
            b.BackColor = Color.Blue;
            
            if(b == btnToplama)
            {
                button1_Click(b,e);
            }
            
            else if(b == btnCıkartma)
            {
                button2_Click(b, e);
            }
            else if (b == btnCarpma)
            {
                button3_Click(b, e);
            }
            else if (b == btnBolme)
            {
                button4_Click(b, e);
            }
        }

        private void hover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            btnToplama.ForeColor = Color.Black;
            btnCıkartma.ForeColor = Color.Black;
            btnCarpma.ForeColor = Color.Black;
            btnBolme.ForeColor = Color.Black;
            b.ForeColor = Color.Red;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Calculator islem = Calculator.Nesnever();

            islem.ValueOne = Convert.ToDouble(txtVarOne.Text);
            islem.ValueTwo = Convert.ToDouble(txtVarTwo.Text);
            if (islem.Addition() > 0)
                lblFinal.BackColor = Color.Green;
            else
                lblFinal.BackColor = Color.Red;

            lblFinal.Text = Convert.ToString(islem.Addition());
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            Calculator islem = Calculator.Nesnever();

            islem.ValueOne = Convert.ToDouble(txtVarOne.Text);
            islem.ValueTwo = Convert.ToDouble(txtVarTwo.Text);

            if (islem.Subtraction() > 0)
                lblFinal.BackColor = Color.Green;
            else
                lblFinal.BackColor = Color.Red;

            lblFinal.Text = Convert.ToString(islem.Subtraction());

        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            Calculator islem = Calculator.Nesnever();

            islem.ValueOne = Convert.ToDouble(txtVarOne.Text);
            islem.ValueTwo = Convert.ToDouble(txtVarTwo.Text);
            if (islem.Multiplication() > 0)
                lblFinal.BackColor = Color.Green;
            else
                lblFinal.BackColor = Color.Red;

            lblFinal.Text = Convert.ToString(islem.Multiplication());
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Calculator islem = Calculator.Nesnever();

            islem.ValueOne = Convert.ToDouble(txtVarOne.Text);
            islem.ValueTwo = Convert.ToDouble(txtVarTwo.Text);
            if (islem.Division() > 0)
                lblFinal.BackColor = Color.Green;
            else
                lblFinal.BackColor = Color.Red;

            lblFinal.Text = Convert.ToString(islem.Division());
        }
        
    }
}
