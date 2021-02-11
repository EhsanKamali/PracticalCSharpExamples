using System.Data;
using System.Data.SqlClient;

namespace Example11
{
    internal class ClassReadme
    {
        //اول یک متغییر برای معرفی کانکشن میسازیم
        private SqlConnection connection = new SqlConnection();

        //string Conn =
        //    @"Data Source=.;Initial Catalog=CSharpDataBase;Persist Security Info=True;User ID=sa;Password=1";
        /// <summary>
        /// یک سازنده برای این کلاس
        /// </summary>
        /// <param name="ConnString">رشته اتصال را میگیرد</param>
        public ClassReadme(string ConnString =
            @"Data Source=.;Initial Catalog=CSharpDataBase;Persist Security Info=True;User ID=sa;Password=1")
        {
            connection.ConnectionString = ConnString;
        }

        /// <summary>
        /// برای ایجاد یک جدول خروجی از اطلاعات
        /// </summary>
        /// <param name="SearchCol">عنوان متغییر برای فیلتر</param>
        /// <param name="SearchString">عبارت جستجو</param>
        /// <returns></returns>
        public DataTable ReturnRecord(string SearchCol, string SearchString)
        {

            SearchString = CorrectText(SearchString);

            string SearchText = @"SELECT *
                                    FROM   dbo.ReadmeTable
                                    WHERE " + SearchCol + " LIKE '%" + SearchString + "%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.CommandText = SearchText;
            command.Connection = connection;
            dataAdapter.SelectCommand = command;
            DataTable ReturnTable = new DataTable();
            dataAdapter.Fill(ReturnTable);
            return ReturnTable;
        }

        /// <summary>
        /// اعمال تغییرات در دیتا
        /// </summary>
        /// <param name="Script">اسکریپتی که می خواهیم تغییر را ایجاد کند</param>
        public void ModifyRecord(string Script)
        {
            string InsertScript;
            InsertScript = Script;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.CommandText = InsertScript;
            command.Connection = connection;
            dataAdapter.SelectCommand = command;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// رکورد انتخاب شده را حذف می کند
        /// </summary>
        /// <param name="RecordId">شماره سریال رکورد را به عنوان کلید اصلی دریافت می کند</param>
        public void DeleteRecord(string RecordId)
        {
            string Script = @"DELETE FROM ReadmeTable
                                WHERE Id = " + RecordId;
            SqlCommand command = new SqlCommand();
            command.CommandText = Script;
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// کاراکترهای غیر مجاز را اصلاح می کند
        /// </summary>
        /// <param name="InputText">متن اصلی را میگیرد و کاراکترهای غیر مجاز را اصلاح می کند</param>
        /// <returns></returns>
        public string CorrectText (string InputText)
        {
            string OutputString;
            OutputString = InputText;

            if(InputText.Contains("'")==true)
            {
                OutputString = InputText.Replace("'", "''");
            }

            return OutputString;
        }
    }
}