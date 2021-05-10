using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class DigitControl
    {
        public bool checkdigit(String cardNo)
        {
            int nDigits = cardNo.Length;


            if (nDigits == 16)
            {
                return true;

            }
            return false;
        }
    }
}