using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Test
{
    class Test_MyLinQ
    {
        static void Main(string[] args)
        {
            MyLibrary.MyLinQ.myLinq nesne = new MyLibrary.MyLinQ.myLinq();

            //List<int> list = new List<int>();
            //Random rnd = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    list.Add(rnd.Next(100));
            //}

            //IEnumerable<int> x = nesne.Descending4Number(list);


            List<String> list = new List<string>();
            list.Add("Halil");
            list.Add("Hüseyin");
            list.Add("Siirt");
            list.Add("Üniversitesi");
            list.Add("Bilgisayar");
            list.Add("Mühendisliği");
            list.Add("Ali");
            list.Add("Sheroz");
            list.Add("Ziya");
            list.Add("Elif");
            list.Add("Batman");
            list.Add("Biçen");


            IEnumerable<Object> x = nesne.ListReverse(list);


            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
