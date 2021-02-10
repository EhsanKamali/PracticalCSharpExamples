using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Example8
{
    class ClassDictionary
    {
        SqlConnection connection = new SqlConnection();
        
        /// <summary>
        /// یک سازنده برای این کلاس می باشد
        /// </summary>
        /// <param name="ConnStr">رشته اتصال را میگیرد</param>
        public ClassDictionary(string ConnStr)
        {
            connection.ConnectionString = ConnStr;
        }

        /// <summary>
        /// یک جدول به عنوان دیتای خروجی میدهد
        /// </summary>
        /// <param name="SearchStr">عبارت جستجو را می گیرد</param>
        /// <returns></returns>
        public DataTable ReturnRecord(string SearchStr)
        {
            string SearchText;
            SearchText = @"SELECT * FROM dbo.Words
                                        WHERE EnglishWord LIKE '" + SearchStr + "%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.CommandText = SearchText;
            command.Connection = connection;
            dataAdapter.SelectCommand = command;
            DataTable RetTable = new DataTable();
            dataAdapter.Fill(RetTable);
            return RetTable;
        }
    }
}
