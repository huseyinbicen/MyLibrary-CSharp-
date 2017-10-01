using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class StatisticalCalculations
    {

        private List<double> dizi;


        public StatisticalCalculations(List<double> dizi)
        {
            this.dizi = dizi;
        }


        /// <summary>
        /// Bir sayı dizisindeki elemanların monentini verir. 
        /// </summary>
        /// <param name="r">1,2,3,4......(N)</param>
        /// <returns>r-ıncı dereceden momentin değerini verir.</returns>
        public double Moment(int r)
        {
            double sonuc = 0;
            foreach (double item in dizi)
            {
                sonuc += Math.Pow(item, r);
            }
            return sonuc / (dizi.Count);
        }




        /// <summary>
        /// Bir Listedeki elemanların artalamasını verir.
        /// </summary>
        /// <returns>Listedeki sayıların ortalaması</returns>
        public double Ortalama()
        {
            double sonuc = 0;
            foreach (double item in dizi)
            {
                sonuc += item;
            }
            return sonuc / (dizi.Count);
        }




        /// <summary>
        /// Ortalamaya göre moment olan metoddur.Burada M(r); aritmetik ortalamaya göre r'inci momenttir
        /// OGMoment(2) = Bir sayı dizisindeki, Sayıların Varyans'ına eşittir.
        /// </summary>
        /// <param name="r"> r = 1,2,3,4........(N)</param>
        /// <returns>r'inci dereceden moment değerini verir.</returns>
        public double OGMoment(int r)
        {
            double sonuc = 0;
            foreach (double item in dizi)
            {
                sonuc += Math.Pow((item - Ortalama()), r);
            }
            return sonuc / (dizi.Count);
        }



        /// <summary>
        /// Bir sayı dizisinde en çok tekrar edilen sayıdır
        /// </summary>
        /// <returns>En çok tekrar edilen sayıyı dönderir.</returns>
        public double Mod()
        {
            dizi.Sort();
            double mod = 0;
            double GeciciMod = 0;
            double TerarlamaSayisi = 0;
            GeciciMod = dizi[0];
            for (int i = 0; i < dizi.Count - 1; i++)
            {
                if (dizi[i] == dizi[i + 1])
                    GeciciMod++;

                if (i == (dizi.Count - 2) || dizi[i] != dizi[i + 1])
                {
                    if (GeciciMod > TerarlamaSayisi)
                    {
                        TerarlamaSayisi = GeciciMod;
                        mod = dizi[i];
                    }

                    GeciciMod = dizi[0];
                }
            }
            return mod;
        }




        /// <summary>
        /// Bir sayı dizisindeki değerlerin büyükten küçüğe doğru sıralandığında ortada bulunan değere medyan denir.
        /// </summary>
        /// <returns>Bir dizideki ortanca değer dönderir.</returns>
        public double Medyan()
        {
            dizi.Sort();
            if ((dizi.Count) % 2 == 0)
            {
                return (dizi[dizi.Count / 2] + dizi[(dizi.Count / 2) - 1]) / 2;
            }
            else
            {
                return dizi[(int)(dizi.Count / 2)];
            }
        }




        /// <summary>
        /// Bir sayı dizisindeki sayıların Standart Sapmasını verir.
        /// Standart sapma, Olasılık kuramı ve istatistik bilim dallarında, bir anakütle, bir örneklem, bir olasılık dağılımı veya bir rassal değişken, veri değerlerinin yayılımının özetlenmesi için kullanılan bir ölçüdür.
        /// </summary>
        /// <returns>Standart Sapmayı Dönderir.</returns>
        public double StandartSapma()
        {
            return Math.Sqrt(OGMoment(2));
        }




        /// <summary>
        /// Standart sapmanın aritmetik ortalamaya bölünüp yüzle çarpılması ile elde edilen katsayıdır. 
        /// Oransal değişim ölçüsü olarak dağılımlardaki ölçek etkisini gidermiş olur. Bu nedenle farklı örneklerin karşılaştırılmasıda kullanılır. 
        /// Değişim katsayıları karşılaştırıldığında, değişim katsayısı küçük olan serilerde dağılımın aritmetik ortalama etrafında daha yoğun dağıldığı anlaşılır.
        /// </summary>
        /// <returns>Bir sayı dizisinde değişim katsayısını dönderir.</returns>
        public double DegisimKatSayisi()
        {
            return (StandartSapma() / Ortalama()) * 100;
        }



        /// <summary>
        /// Serilerin dağılımı hakkında ortalamalar ve değişim ölçüleri yardımıyla belli ölçüde bilgi edinebiliriz.
        /// Bu iki ölçünün yanında, serilerin simetriden ne kadar uzaklaştığını gösteren“Çarpıklık Katsayısı” denir.
        /// </summary>
        /// <returns>Çarpıklık katsayısını dönderir</returns>
        public string Carpiklik()
        {
            double Carpiklik = OGMoment(3) / Math.Pow(Ortalama(), 3);

            if (Carpiklik < 0)
            {
                return "Sola Çarpık";
            }
            else if (Carpiklik > 0)
            {
                return "Sağa Çarpık";
            }
            else if (Carpiklik == 0)
            {
                return "Simetrik";
            }
            else
            {
                return "Hata Oluştu.";
            }

        }





        /// <summary>
        /// Serilerin dağılımı hakkında ortalamalar ve değişim ölçüleri yardımıyla belli ölçüde bilgi edinebiliriz.
        /// Bu iki ölçünün yanında, serinin yüksekliğinin normal serinin yüksekliğinden ne kadar uzaklaştığını gösteren “Basıklık Katsayısı” denir
        /// </summary>
        /// <returns>Basıklık kat sayısı dönderir.</returns>
        public string Basiklik()
        {
            double Basiklik = OGMoment(4) / Math.Pow(Ortalama(), 4);

            if (Basiklik < 3)
            {
                return "Düz";
            }
            else if (Basiklik > 3)
            {
                return "Sivri";
            }
            else if (Basiklik == 3)
            {
                return "Orta Basık";
            }
            else
            {
                return "Hata Oluştu.";
            }
        }




        /// <summary>
        /// Bir sayı dizisindeki en küçük elemanı verir.
        /// </summary>
        /// <returns>En küçük sayıyı dönderir</returns>
        public double Min()
        {
            dizi.Sort();
            return dizi[0];
        }





        /// <summary>
        /// Bir sayı dizisinde en büyük elemanı verir.
        /// </summary>
        /// <returns>En büyük sayıyı dönderir.</returns>
        public double Max()
        {
            dizi.Sort();
            return dizi[dizi.Count-1];
        }
    }
}
