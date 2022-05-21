using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class CardTypeControl
    {
        public bool checkcardmaster(String cardNo)
        {
            double card = Convert.ToInt64(cardNo);

            if (card >= 5100000000000000 & card <= 5599999999999999)
            {
                return true;

            }
            return false;
        }

        public bool checkcardvisa(String cardNo)
        {
            double card = Convert.ToInt64(cardNo);

            if (card >= 4000000000000000 & card <= 4999999999999999)
            {
                return true;

            }
            return false;
        }
    }
}