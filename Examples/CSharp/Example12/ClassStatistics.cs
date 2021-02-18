using System;
using System.Collections.Generic;

namespace Example12
{
    internal class ClassStatistics
    {
        /// <summary>
        /// آیا متن وارد شده از نوع اعشاری می باشد یا نه
        /// </summary>
        /// <param name="TextNumber">مقدار متنی که باید کنترل شود</param>
        /// <returns></returns>
        public double? NumberOfText(string TextNumber)
        {
            double OutputDouble;
            if (double.TryParse(TextNumber, out OutputDouble) == false)
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
            CountOfItem = MainList.Count;
            return CountOfItem;
        }

        /// <summary>
        /// اطلاعات درون یک لیست را مرتب می کند
        /// </summary>
        /// <param name="MainList">لیست با اعداد نامرتب</param>
        /// <returns></returns>
        public List<double> SortListNumbers(List<double> MainList)
        {
            List<double> SortList = new List<double>();
            SortList = MainList;
            SortList.Sort();
            return SortList;
        }

        /// <summary>
        /// تبدیل اطلاعات یک لیست عددی به رشته
        /// </summary>
        /// <param name="MainList">لیستی که باید مقادیر آن به رشته تبدیل شود</param>
        /// <returns></returns>
        public string ListToText(List<double> MainList)
        {
            string OutputText = "";

            foreach (double Row in MainList)
            {
                OutputText += Row.ToString() + "\n";
            }
            return OutputText;
        }

        /// <summary>
        /// تبدیل اطلاعات یک لیست متنی به رشته
        /// </summary>
        /// <param name="MainList">لیستی که باید مقادیر آن به رشته تبدیل شود</param>
        /// <returns></returns>
        public string ListToText(List<string> MainList)
        {
            string OutputText = "";

            foreach (string Row in MainList)
            {
                OutputText += Row.ToString() + "\n";
            }
            return OutputText;
        }

        /// <summary>
        /// تعریف دو لیست یکی جهت ایجاد لیستی از اعداد بدون تکرار
        /// و دیگری جهت شمارش تعداد تکرار آنها
        /// </summary>
        private List<double> DistinctList = new List<double>();

        private List<int> CountList = new List<int>();

        /// <summary>
        /// جهت مقدار دهی به دو لیست اعداد بدون تکرار و تعداد تکرار اعداد
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        private void MakeLists(List<double> MainList)
        {
            foreach (double Row in MainList)
            {
                if (DistinctList.Contains(Row))
                {
                    CountList[DistinctList.IndexOf(Row)]++;
                }
                else
                {
                    DistinctList.Add(Row);
                    CountList.Add(1);
                }
            }
        }

        /// <summary>
        /// شمارش تعداد تکرار اعداد با ایجاد یک لیست اعداد بدون تکرار و یک لیست تعداد تکرار و ترکیب آنها در انتها
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        public string CountOfSortNumber(List<double> MainList)
        {
            MakeLists(MainList);

            string TextResult = "";
            for (int i = 0; i < DistinctList.Count; i++)
            {
                TextResult += DistinctList[i].ToString() + " تعداد : " + CountList[i] + "\n";
            }

            return TextResult;
        }

        /// <summary>
        /// محاسبه میانگین حسابی به صورت خروجی عددی
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        private double CalcArithmatic(List<double> MainList)
        {
            double Sum = 0;
            foreach (double Row in MainList)
            {
                Sum += Row;
            }
            return Sum / MainList.Count;
        }


        /// <summary>
        /// محاسبه میانگین حسابی به صورت خروجی رشته ای
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        public string ArithmeticAvg(List<double> MainList)
        {            
            string TextResult =
                "میانگین حسابی : " + CalcArithmatic(MainList).ToString() + " \n";
            return TextResult;
        }

        /// <summary>
        /// محاسبه میانگین وزنی به صورت خروجی رشته ای
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        public string WeightedAvg(List<double> MainList)
        {
            MakeLists(MainList);

            double Sum = 0;
            for (int i = 0; i < DistinctList.Count; i++)
            {
                Sum += DistinctList[i] * CountList[i];
            }
            string TextResult = "";
            TextResult = "میانگین وزنی : " + (Sum / DistinctList.Count).ToString() + " \n";
            return TextResult;
        }

        /// <summary>
        /// محاسبه میانگین هندسی به صورت خروجی رشته ای
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        public string GeometricAvg(List<double> MainList)
        {
            MakeLists(MainList);

            double Sum = 0;
            for (int i = 0; i < DistinctList.Count; i++)
            {
                Sum *= Math.Pow(DistinctList[i], CountList[i]);
            }
            string TextResult = "";
            TextResult = "میانگین هندسی : " + ((1 / (double)DistinctList.Count) * Sum).ToString() + " \n";
            return TextResult;
        }


        /// <summary>
        /// محاسبه میانگین همساز به صورت خروجی رشته ای
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        public string HarmonicAvg(List<double> MainList)
        {
            MakeLists(MainList);

            double Sum = 0;
            for (int i = 0; i < DistinctList.Count; i++)
            {
                Sum += CountList[i] / DistinctList[i];
            }
            string TextResult = "";
            TextResult = "میانگین همساز : " + ((1 / (double)DistinctList.Count) * Sum).ToString() + " \n";
            return TextResult;
        }

        /// <summary>
        /// محاسبه واریانس به صورت خروجی عددی
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        private double CalcVariance(List<double> MainList)
        {
            double Sum = 0;
            foreach (double Row in MainList)
            {
                Sum += Row;
            }
            double VarSum = 0;
            for (int i = 0; i < MainList.Count; i++)
            {
                VarSum += Math.Pow(MainList[i] - Sum, 2);
            }
            double Variance = 0;
            Variance = (VarSum / (MainList.Count - 1));
            return Variance;
        }


        /// <summary>
        /// محاسبه واریانس به صورت خروجی رشته ای
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        public string Variance(List<double> MainList)
        {                        
            string TextResult = "";
            TextResult = "واریانس : " + CalcVariance(MainList) + " \n";
            return TextResult;
        }

        /// <summary>
        /// محاسبه انحراف معیار به صورت رشته ای
        /// </summary>
        /// <param name="MainList">لیست اعداد</param>
        /// <returns></returns>
        public string StandardDeviation(List<double> MainList)
        {
            string TextResult = "";
            TextResult = "انحراف معیار : " + Math.Sqrt(CalcVariance(MainList)).ToString() + "\n";
            return TextResult;
        }
    }
}