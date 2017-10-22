using System;
using System.Collections.Generic;
using System.Text;
using MyLibrary;

namespace Deneme
{
    class Max_Min_Normalization
    {
        static void Main(string[] args)
        {
            List<float> abc = new List<float>();

            abc.Add(20);
            abc.Add(70);
            abc.Add(10);
            abc.Add(60);
            abc.Add(20);
            abc.Add(40);
            abc.Add(90);
            abc.Add(30);
            abc.Add(100);
            abc.Add(80);

            MyLibrary.Max_Min_Normalization nesne = new MyLibrary.Max_Min_Normalization(abc);


            foreach (float item in nesne.GetList())
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("----------------------------------------------");

            foreach (float item in abc)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
