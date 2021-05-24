using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptikFormOkuyucu
{
    class OptikOku
    {
        protected int soru_sayisi = 0;
        protected bool yanlis_dogru_goturme = false;
        protected bool yuvarlama_yonu = true;
        ArrayList Cevaplar= new ArrayList();
        string Dosya;

        public int Soru_sayisi { get => soru_sayisi; set => soru_sayisi = value; }
        public bool Yanlis_dogru_goturme { get => yanlis_dogru_goturme; set => yanlis_dogru_goturme = value; }
        public bool Yuvarlama_yonu { get => yuvarlama_yonu; set => yuvarlama_yonu = value; }

        public OptikOku(string doysya_yolu)
        {
            this.Dosya = doysya_yolu;
        }
        public OptikOku(string doysya_yolu,int soru_sayisi)
        {
            this.Dosya = doysya_yolu;
            this.Soru_sayisi = soru_sayisi;
        }

        public OptikOku()
        {
        }

        public virtual void Heapla(ListBox L,ListBox N)
        {
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
                        int d=0, y=0;
                        for (int x = 0; x < soru_sayisi; x++)
                        {
                            if(((string)Cevaplar[j]).Substring(13+x, 1)== tum[i].Substring(13+x, 1))
                            {
                                d++;
                            }
                            else
                            {
                                y++;
                            }
                        }
                        if (Yuvarlama_yonu)
                        {
                            tum[i] = tum[i] + "->d=" + d + " : y=" + y + " notu=" + Math.Ceiling((100.0 / soru_sayisi) * d);
                            if (tum[i].Substring(1, 12) != "000000000000")
                            {
                                N.Items.Add(tum[i].Substring(1, 12) + "\t" + Math.Ceiling((100.0 / soru_sayisi) * d));
                            }
                        }
                        else
                        {
                            tum[i] = tum[i] + "->d=" + d + " : y=" + y + " notu=" + Math.Floor((100.0 / soru_sayisi) * d);
                            if (tum[i].Substring(1, 12) != "000000000000")
                            {
                                N.Items.Add(tum[i].Substring(1, 12) + "\t" + Math.Floor((100.0 / soru_sayisi) * d));
                            }
                        }
                        L.Items.Add(tum[i]);
                        break;
                    }
                }
            }
        }
        public void AyniOgrNoBul(ListBox L)
        {
            StreamReader ok = new StreamReader(Dosya);
            string[] tum = ok.ReadToEnd().Split('\n');
            for (int i = 0; i < tum.Length-1; i++)
            {
                for (int j = i+1; j < tum.Length; j++)
                {
                    if (tum[i].Substring(1, 12) == "000000000000") break;
                    if(tum[i].Substring(1, 12)== tum[j].Substring(1, 12))
                    {
                        tum[i] = i + ":" + tum[i];
                        tum[j] = i + ":" + tum[j];
                    }
                }
            }
            for (int i = 0; i < tum.Length; i++)
            {
                L.Items.Add(tum[i]);

            }
        }
       void GrupBul()
        {
            StreamReader ok = new StreamReader(Dosya);
            while (!ok.EndOfStream)
            {
                string satir = ok.ReadLine();
                if (satir.Substring(1, 12)=="000000000000")
                {
                    Cevaplar.Add(satir.Trim());
                }
            }
         
        }
    }
}
