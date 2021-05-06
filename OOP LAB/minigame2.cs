using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class minigame2
    {

        private int RandomX, RandomY,map = 1024;
        Random RndX = new Random();
        Random RndY = new Random();


        public int Xekseni_Random()
        {
            RandomX = RndX.Next(0, map*map);
            return RandomX;
        }

        public int Yekseni_Random()
        {
            RandomY = RndY.Next(0, map*map) - 12;
            return RandomY;
        }
        public int X_Tahmin(int x_kullanıcı, int xekseni)
        {
            int flag_x = 0;
            if (x_kullanıcı > xekseni)
            {
                flag_x = 1;  //Doğu Yönündesin, Batıya git.
            }
            else if (x_kullanıcı == xekseni)
            {
                flag_x = 2;
            }


            return flag_x; //Batı Yönündesin, Doguya git
        }

        public int Y_Tahmin(int y_kullanıcı, int yekseni)
        {
            int flag_y = 0;
            if (y_kullanıcı > yekseni)
            {
                flag_y = 1;  //Kuzey Yönündesin, Doğuya git.
            }
            else if (y_kullanıcı == yekseni)
            {
                flag_y = 2;
            }
            
            return flag_y;
        }
    }
}
