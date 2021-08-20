using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MD5Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBoxHashString.Text = Md5(textBoxMainText.Text);
        }

        /// <summary>
        /// Ehsan: این تابع برای ساخت هش کد براساس MD5 می باشد
        /// فقط یک نکته مهم
        /// این الگوریتم مدل های مختلف داره مثلا 16 یا 32 بیت
        /// یا حتی کلیدهای مختلف
        /// این رو براتون میفرستم به عنوان یک نمونه حالا توی ارتباط با سامانه جامع انبارها
        /// موقعی که باید ارتباط رو برقرار کنیم اگر نوع کلید متفاوت بود براتون توضیح میدم
        /// این مدل 32 بیت اون هست
        /// </summary>
        /// <param name="input">متنی که قرار هست هش شود</param>
        /// <returns></returns>
        public static string Md5(string input)
        {
            // اول یک نسخه از روی  MD5CryptoServiceProvider ایجاد می کنیم.
            MD5 md5 = MD5.Create();
            // متن ورودی رو به آرایه های از نوع بایت تبدیل می کنه و هش رو محاسبه می کنه
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            // یک Stringbuilder جدید درست می کنیم که بایت ها رو جمع کنه و رشته رو بسازه
            StringBuilder sb = new StringBuilder();
            // یک حلقه درست میکنیم که هر بایت هش شده رو به فرمت هگزادسیمال رشته ای تبدیل کنه
            for (int i = 0; i < data.Length; i++)
                sb.Append(data[i].ToString("x2"));
            return sb.ToString();
        }
    }
}
