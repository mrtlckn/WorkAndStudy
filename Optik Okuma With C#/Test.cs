using OptikFormOkuyucu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace OptikFormOkuyucu
{
    class Test : OptikOku
    {
        string Dosya;
        ArrayList Cevaplar = new ArrayList();

        public Test(string doysya_yolu) 
        {
            this.Dosya = doysya_yolu;
        }

        public Test(string doysya_yolu, int soru_sayisi) 
        {
            this.Dosya = doysya_yolu;
            this.Soru_sayisi = soru_sayisi;
        }

      

        public override void Heapla(ListBox L, ListBox N)
        {
            //base.Heapla(L, N);
            int yenid=0;


            // ArrayList Cevaplar = new ArrayList();

            GrupBul();
            StreamReader ok = new StreamReader(Dosya);
            string[] tum = ok.ReadToEnd().Split('\n');
            for (int i = 0; i < tum.Length; i++)
            {
                tum[i] = tum[i].Replace('\r', ' ').TrimEnd();
                for (int j = 0; j < Cevaplar.Count; j++)
                {
                    if (((string)Cevaplar[j]).Substring(0, 1) == tum[i].Substring(0, 1))
                    {
                        int d = 0, y = 0;
                        for (int x = 0; x < soru_sayisi; x++)
                        {
                            if (((string)Cevaplar[j]).Substring(13 + x, 1) == tum[i].Substring(13 + x, 1))
                            {
                                d++;

                            }
                            else
                            {
                                y++;
                            }
                        }
                       

                        
                        if (yanlis_dogru_goturme)
                        {
                            yenid = d - y;
                            if (yenid < 0) // notlar eksi olamaz
                            {
                                yenid = 0;
                            }
                        }
                             
                        


                        if (Yuvarlama_yonu)
                        {
                            tum[i] = tum[i] + "->d=" + d + " : y=" + y + " notu=" + Math.Ceiling((100.0 / soru_sayisi) * yenid);
                            if (tum[i].Substring(1, 12) != "000000000000")
                            {
                                N.Items.Add(tum[i].Substring(1, 12) + "\t" + Math.Ceiling((100.0 / soru_sayisi) * yenid));
                            }
                        }
                        else
                        {
                            tum[i] = tum[i] + "->d=" + d + " : y=" + y + " notu=" + Math.Floor((100.0 / soru_sayisi) * yenid);
                            if (tum[i].Substring(1, 12) != "000000000000")
                            {
                                N.Items.Add(tum[i].Substring(1, 12) + "\t" + Math.Floor((100.0 / soru_sayisi) * yenid));
                            }
                        }
                        L.Items.Add(tum[i]);
                        break;
                    }
                }



            }
     }
        
     

        

        void GrupBul()
        {
            StreamReader ok = new StreamReader(Dosya);
            while (!ok.EndOfStream)
            {
                string satir = ok.ReadLine();
                if (satir.Substring(1, 12) == "000000000000")
                {
                    Cevaplar.Add(satir.Trim());
                }
            }

        }



    }
}
