using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example12
{
    class ClassStatistics
    {

        /// <summary>
        /// آیا متن وارد شده از نوع اعشاری می باشد یا نه
        /// </summary>
        /// <param name="TextNumber">مقدار متنی که باید کنترل شود</param>
        /// <returns></returns>
        public double? NumberOfText(string TextNumber)
        {
            double OutputDouble;
            if(double.TryParse(TextNumber,out OutputDouble) == false)
            {
                return null;
            }
            else
            {
                return OutputDouble;
            }
        }

        /// <summary>
        /// تعداد رکوردهای لیست
        /// </summary>
        /// <param name="MainList">لیست اعداد که باید شمارش شود</param>
        /// <returns></returns>
        public int CountOfItems(List<double> MainList)
        {
            int CountOfItem;
            CountOfItem = MainList.Count();
            return CountOfItem;
        }


        public List<double> SortListNumbers(List<double> MainList)
        {
            List<double> SortList = new List<double>();
            SortList = MainList;
            SortList.Sort();
            return SortList;
        }
    }
}
