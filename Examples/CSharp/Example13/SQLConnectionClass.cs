using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Example13
{
    class SQLConnectionClass
    {
        //اول یک متغییر برای معرفی کانکشن میسازیم
        private SqlConnection connection = new SqlConnection();

        /// <summary>
        /// یک سازنده برای این کلاس
        /// </summary>
        /// <param name="ConnString">رشته اتصال را میگیرد</param>
        public SQLConnectionClass(string ConnString =
            @"Data Source=.;Initial Catalog=CSharpDataBase;Persist Security Info=True;User ID=sa;Password=1")
        {
            connection.ConnectionString = ConnString;
        }

        /// <summary>
        /// برای ایجاد یک جدول خروجی از اطلاعات
        /// </summary>
        /// <param name="TableName">عنوان جدولی که باید اطلاعات از آن بیاید</param>
        /// <param name="SearchCol">عنوان متغییر برای فیلتر</param>
        /// <param name="SearchString">عبارت جستجو</param>
        /// <returns></returns>
        public DataTable ReturnRecord(string TableName, string SearchCol, string SearchString)
        {

            SearchString = CorrectText(SearchString);

            string SearchText = @"SELECT *
                                    FROM   dbo." + TableName + " " +
                                    "WHERE " + SearchCol + " LIKE '%" + SearchString + "%'";
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
        /// افزودن رکورد در دیتا
        /// </summary>
        /// <param name="Script">اسکریپتی که می خواهیم تغییر را ایجاد کند</param>
        public void InsertRecord(string Script)
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
        /// اعمال تغییرات در دیتا
        /// </summary>
        /// <param name="Script">اسکریپتی که می خواهیم تغییر را ایجاد کند</param>
        public void ModifyRecord(string Script)
        {
            string ModifyScript;
            ModifyScript = Script;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            command.CommandText = ModifyScript;
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
        public string CorrectText(string InputText)
        {
            string OutputString;
            OutputString = InputText;

            if (InputText.Contains("'") == true)
            {
                OutputString = InputText.Replace("'", "''");
            }

            return OutputString;
        }

        /// <summary>
        /// کلمه عبور نام کاربری را برمیگرداند
        /// </summary>
        /// <param name="UserName">نام کاربری</param>
        /// <returns></returns>
        public string ReturnPassword (string UserName)
        {           

            string Script = @"SELECT [Password] FROM dbo.Users 
                                WHERE NAME = '" + UserName + "'";
            SqlCommand command = new SqlCommand();
            command.CommandText = Script;
            command.Connection = connection;
            connection.Open();
            string ReturnedPassword = (string)command.ExecuteScalar();
            connection.Close();

            return ReturnedPassword;
        }
    }
}
