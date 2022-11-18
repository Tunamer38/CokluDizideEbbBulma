using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇokluDiziEbbBulma
{
    class Program
    {
        static void Main()
        {

            #region İnsertion Sort
            double[,,] dizi = new double[5,10,20];
            Random rnd = new Random();
            int x = dizi.GetLength(0);
            int y = dizi.GetLength(1);
            int z = dizi.GetLength(2);
            double[] v = new double[x * y * z];
            int k = 0;
            int l = 0;
            int m = 0;
            int sayac = 0;
            EbbBul(dizi, 0);
            void EbbBul(double[,,] dizi1, int indeks)
            {
                if (k < x)
                {
                    dizi[k, l, m] = rnd.Next(1, 1000);
                    v[sayac] = dizi[k, l, m];
                    sayac++;
                    m++;
                    if (m == z)
                    {
                        m = 0;
                        l++;
                        if (l == y)
                        {
                            l = 0;
                            k++;
                        }
                    }
                }

                else return;
                EbbBul(dizi, indeks + 1);

                Sırala(v);
            }
            double Ebb, Tmp;

            void Sırala(double[] f) //BUBBLE SORT METODU UYGULANDI
            {
                for (int i = 0; i < f.Length; i++)
                {
                    for (int j = i; j < f.Length; j++)
                    {
                        if (v[i] < v[j])
                        {
                            Tmp = v[j];
                            v[j] = v[i];
                            v[i] = Tmp;
                        }
                    }
                }
            }
            Console.WriteLine("SIRLAMA ÖNCESİ DİZİNİN İLK HALİ");
            sayac = 0;
            foreach (double item in dizi)
            {

                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("BÜYÜKTEN KÜÇÜĞE SIRALANMIŞ LİSTE");
            foreach (double item in v)
            {
                Console.Write(item + "\t");
            }

            #endregion
            Console.WriteLine();

            Console.WriteLine("DİZİDEKİ EN BÜYÜK SAYI DEĞERİ" + "\n" + v[0]);

            Console.Read();
        }
    }
}
