using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test_Z_Score_Normalization
    {
        static void Main(String[] args)
        {
            List<double> abc = new List<double>();

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

            MyLibrary.Z_Score_Normalization nesne = new MyLibrary.Z_Score_Normalization(abc);

            foreach (var item in nesne.GetList())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
