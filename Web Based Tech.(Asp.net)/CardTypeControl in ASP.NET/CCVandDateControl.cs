using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class CCVandDateControl
    {
        public bool checkCCV(String cardCCV)
        {
            int nDigits = cardCCV.Length;


            if (nDigits == 3)
            {
                return true;

            }
            return false;
        }
        public bool checkmonth(String cardmonth)
        {
          
            int nDigits = cardmonth.Length;
            
            if (nDigits >= 1 & nDigits <= 2 )
            {
                int month = Convert.ToInt32(cardmonth);
                if (month >= 1 & month <= 12)
                {
                    
                    return true;
                }
            }
            return false;
        } 
        public bool checkyear(String cardyear)
        {
           
            int nDigits = cardyear.Length;
           
            if (nDigits >= 1)
            {
                int year = Convert.ToInt32(cardyear);
                if (year >= 2000 & year <= 2099)
                {
                    return true;
                }
            }
            return false;
        }
    }
}