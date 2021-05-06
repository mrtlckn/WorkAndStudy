using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class minigame
    {  
        private int RandomX,map = 1024;
        Random RndX = new Random();
        public int Xekseni_Random()
        {
            RandomX = RndX.Next(1, map*map);
            return RandomX;
        }

        public int X_Tahmin(int x_kullanıcı, int xekseni)
        {
            int flag_x = 0;
            int mod_kullanıcı, mod_eksen;
            mod_kullanıcı = x_kullanıcı % map;
            mod_eksen = xekseni % map;
            if (mod_kullanıcı > mod_eksen)
            {
                flag_x = 0;  //Doğu Yönündesin, Batıya git.
            }
            else if (mod_kullanıcı == mod_eksen)
            {
                flag_x = 2; //Aynı
            }
           else if (mod_kullanıcı < mod_eksen)
            {
                flag_x = 1; //Doğuya git
            }
            if(mod_kullanıcı == 0 && mod_eksen != 0)
            {
                flag_x = 0;  //Doğu Yönündesin, Batıya git.
            }

            return flag_x; 
        }


        public int Y_Tahmin(int y_kullanıcı, int yekseni)
        {

            int flag_y = 0;
            int dalga_1 = yekseni;
            int dalga_2 = y_kullanıcı;
            while ((dalga_1 % 6) != 0)
            {
                dalga_1++;
            }
            while ((dalga_2 % 6) != 0)
            {
                dalga_2++;
            }

            if (dalga_1 > dalga_2)
            {
                flag_y = 1;  // Guneye git
            }
            else if (dalga_1 < dalga_2)
            {
                flag_y = 0;  // Kuzeye git
            }
            else
                flag_y = 2;

            return flag_y;
        }
    }
}
