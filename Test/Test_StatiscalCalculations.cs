using MyLibrary;
using System;
using System.Collections.Generic;

namespace Test
{
    class StatiscalCalculations
    {
        static void Main(string[] args)
        {
            List<double> dizi = new List<double>();

            dizi.Add(1);
            dizi.Add(5);
            dizi.Add(2);
            dizi.Add(3);
            dizi.Add(2);
            dizi.Add(3);
            dizi.Add(4);
            dizi.Add(5);
            dizi.Add(5);
            dizi.Add(7);
            dizi.Add(9);
            dizi.Add(9);
            dizi.Add(14);
            dizi.Add(14);
            dizi.Add(16);

            StatisticalCalculations nesne = new StatisticalCalculations(dizi);

            Console.WriteLine("Ortalama = " + nesne.Ortalama());
            Console.WriteLine("OGMoment(3) = " + nesne.OGMoment(3));
            Console.WriteLine("OGMoment(2) = " + nesne.OGMoment(2));
            Console.WriteLine("Max = " + nesne.Max());
            Console.WriteLine("Min = " + nesne.Min());
            Console.WriteLine("Mod = " + nesne.Mod());
            Console.WriteLine("Medyan = " + nesne.Medyan());
            Console.WriteLine("Standart Sapma = " + nesne.StandartSapma());
            Console.WriteLine("Carpiklik Kat sayisi = " + nesne.Carpiklik());
            Console.WriteLine("Basiklik Kat sayisi = " + nesne.Basiklik());
            Console.ReadKey();
        }
    }
}
