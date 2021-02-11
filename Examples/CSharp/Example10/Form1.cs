using System;
using System.Windows.Forms;

namespace Example10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            //تمامی اطلاعات موجود در لیست را خالی می کنیم
            listBoxPrimeNumber.Items.Clear();
            //این متغییر برای دریافت عدد از کاربر است
            int Number;
            //کنترل می کنیم که عدد وارد شده عدد است یا خیر و اگر عدد است مقدار چند است
            if (int.TryParse(textBoxNumber.Text, out Number) == false)
            {
                MessageBox.Show("Please enter a number...", "Number...", MessageBoxButtons.OK);
            }
            //یک متغییر تعریف می کنیم تا تعداد اعداد بخش پدیری را محاسبه کند
            int Count = 0;
            //تا زمانی که عدد بزرگتر از صفر است
            while (Number > 0)
            {
                //به ازای متغییر شمارشی تا وقتی کوچکتر مساوی عدد اعلامی است با یک پله گردش می کنیم
                for (int i = 1; i <= Number; i++)
                {
                    //اگر باقی مانده تقسیم عدد به شمارنده برابر صفر باشد
                    if (Number % i == 0)
                    {
                        //متغییر تعداد یکی اضافه می شود
                        Count += 1;
                    }
                }
                //اگر تعداد مقسوم علیه ها کمتر از 3 عدد است مقدار آن را در لیست قرار بده
                if (Count < 3)
                {
                    listBoxPrimeNumber.Items.Add(Number);
                }
                Number--;
                Count = 0;
            }
        }
    }
}