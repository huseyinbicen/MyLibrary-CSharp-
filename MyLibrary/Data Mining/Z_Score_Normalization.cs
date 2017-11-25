using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class Z_Score_Normalization
    {
        private List<double> dizi;

        private StatisticalCalculations istatislik;

        public Z_Score_Normalization(List<double> list)
        {
            dizi = list;
            istatislik = new StatisticalCalculations(dizi);
            CreateList();
        }

        private void CreateList()
        {
            double dizi_sp = istatislik.StandartSapma();
            double dizi_ort = istatislik.Ortalama();

            for (int i = 0; i < dizi.Count; i++)
            {
                dizi[i] = (dizi[i] - dizi_ort) / dizi_sp;
            }
        }

        public List<double> GetList()
        {
            return dizi;
        }
    }
}
