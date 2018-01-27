using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary.MyLinQ
{
    public class myLinq
    {

        public myLinq()
        {

        }




        /// <summary>
        /// Bir Sayı dizesinin tek elemanlarını alan metoddur.
        /// </summary>
        /// <param name="list">İnteger bir sayi List'i alır.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<int> OddNumbers(List<int> list)
        {
            var tekler = list.Where(tek => tek % 2 == 1);
            return tekler;
        }




        /// <summary>
        /// Bir Sayı dizesinin Çift elemanlarını alan metoddur.
        /// </summary>
        /// <param name="list">İnteger bir sayi List'i alır.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<int> EvenNumbers(List<int> list)
        {
            var Ciftler = list.Where(cift => cift % 2 == 0);
            return Ciftler;
        }




        /// <summary>
        /// Bir Sayı dizisinin Küçükten büyüğe doğru sıralayan bir metoddur.
        /// </summary>
        /// <param name="list">İnteger bir sayi List'i alır.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<int> Ascending4Number(List<int> list)
        {
            var KucuktenBuyuge = list.Where(ktenBuyuge => ktenBuyuge > 0).OrderBy(ktenBuyuge => ktenBuyuge);
            return KucuktenBuyuge;
        }





        /// <summary>
        /// Bir Sayı dizisinin Büyükten küçüğe doğru sıralayan bir metoddur.
        /// </summary>
        /// <param name="list">İnteger bir sayi List'i alır.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<int> Descending4Number(List<int> list)
        {
            var BuyuktenKucuge = list.Where(btenkucuge => btenkucuge > 0).OrderByDescending(btenkucuge => btenkucuge);
            return BuyuktenKucuge;
        }




        /// <summary>
        /// Listenin elemanlarını Uzukluklarına göre Küçükten Büyüğe doğru sıralama.
        /// </summary>
        /// <param name="list">String bir listedir.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<String> AscendingByCasesLenght(List<String> list)
        {
            var Lenght4String = list.OrderBy(x => x.Length);
            return Lenght4String;
        }



        /// <summary>
        /// Listenin elemanlarını Uzukluklarına göre büyükten küçüğe doğru sıralama.
        /// </summary>
        /// <param name="list">String bir listedir.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<String> DescendingByCasesLenght(List<String> list)
        {
            var Lenght4String = list.OrderByDescending(x => x.Length);
            return Lenght4String;
        }




        /// <summary>
        /// Bir String dizisinin Küçükten büyüğe doğru sıralayan bir metoddur.
        /// </summary>
        /// <param name="list">String bir listedir.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<String> Ascending4String(List<String> list)
        {
            var KucuktenBuyuge = list.Where(x => x.Length > 0).OrderBy(x => x);
            return KucuktenBuyuge;
        }



        /// <summary>
        /// Bir String dizisinin Büyükten küçüğe doğru sıralayan bir metoddur.
        /// </summary>
        /// <param name="list">String bir listedir.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<String> Descending4String(List<String> list)
        {
            var BuyuktenKucuge = list.Where(x => x.Length > 0 ).OrderByDescending(x => x);
            return BuyuktenKucuge;
        }




        /// <summary>
        /// Bir String dizisinin elemanlarının yerlerinin ters düz eden bir metoddur.
        /// </summary>
        /// <param name="list">String bir listedir.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<String> ListReverse(List<String> list)
        {
            var reverseList = list.Where(x => x.Length > 0).Reverse();
            return reverseList;
        }




        /// <summary>
        /// Bir String dizisinin elemanlarını tersten yazan  metoddur.
        /// </summary>
        /// <param name="list">String bir listedir.</param>
        /// <returns>IEnumerable tipinde bir değişken dönderir.</returns>
        public IEnumerable<String> ListReverse4Element(List<String> list)
        {
            var reverseList = list.Select(k => k = new String(k.Reverse().ToArray()));
            return reverseList;
        }



    }
}
