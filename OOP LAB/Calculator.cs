using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Calculator
    {
        private Calculator()
        {

        }

        private static Calculator sayı1;

        public static Calculator Nesnever()
        {
            if (sayı1 == null)
            {
                sayı1 = new Calculator();
            }
            return sayı1;
        }
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        public double Addition()
        {
            return ValueOne + ValueTwo;
        }
        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }
        public double Multiplication()
        {
            return ValueOne * ValueTwo;
        }
        public double Division()
        {
            return ValueOne / ValueTwo;
        }


    }
}
