using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Example6
{
    public partial class FormMain : Form
    {
        //اول یک متغییر برای معرفی کانکشن میسازیم
        private SqlConnection SqlConn = new SqlConnection();

        //برای معرفی دستورات
        private SqlCommand SqlComm = new SqlCommand();

        //برای ایجاد مدیریت کننده برنامه
        private SqlDataAdapter SqlDA = new SqlDataAdapter();

        //منبع داده که اطلاعات در اون ذخیره میشه و خروجی داده ها در رم ذخیره میشه
        private DataSet SqlDS = new DataSet();

        //چون به صورت کلی خودش به وجود اومده دیگه نیاز نداریم از روی اون با new ایجاد کنیم
        private CurrencyManager cr;

        //برای ذخیره ابعاد و موقعیت تصویر
        private Region PicRegion = new Region();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //میخوایم وقتی فرم باز میشه اتصال برقرار بشه
            //برای به دست آوردن این آیتم میشه از روی گرید ارتباط با دیتاست رو بزنیم
            //تا خودش برامون کد رو بسازه و همون رو کپی کنیم اینجا
            /*SqlConn.ConnectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=E:\Repository\GitHub\PracticalCSharpExamples\Examples\CSharp\Example6\TellBook.mdf;
                Integrated Security=True";*/
            //میخوام رشته اتصال را طوری بدم که فایل بانک اطلاعاتی هرجا ذخیره شده بود من متوجه ارتباطم بشم
            SqlConn.ConnectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=" + Application.StartupPath + @"\TellBook.mdf;
                Integrated Security=True";
            //اتصال به بانک اطلاعاتی را باز میکنیم
            SqlConn.Open();
            //حالا میگیم بعد از بازکردنش میخوای چیکار کنی؟
            FillGrid();
        }

        /// <summary>
        /// برای پر کردن گرید از این تابع استفاده میکنیم که یک دستور به صورت پیش فرض هم دارد
        /// </summary>
        /// <param name="SCommand">متن دستوری که باید فراخوانی کند و پیشفرض اون همرو میاره</param>
        private void FillGrid(string SCommand = "Select * from TblTell")
        {
            //دستوری که میخواهیم اجرا شود را بهش میدیم
            SqlComm.CommandText = SCommand;
            //ارتباط اون رو براش مشخص می کنیم
            SqlComm.Connection = SqlConn;
            //به آداپتر دستوری که باید اجرا شود را متصل می کنیم
            SqlDA.SelectCommand = SqlComm;
            //قبل از اینکه اطلاعات رو بیاریم یکبار اطلاعات داخل رم رو خالی میکنیم
            //وگرنه در زمان فراخوانی اطلاعات را مجدد زیر اطلاعات قبلی اضافه میکنه
            SqlDS.Clear();
            //داده ها را از توی هارد میاره بیرون و توی رم میزاره
            //میگه از کدوم دیتاست؟ اسم جدول توی رم چی باشه؟ توی هارد رو که زمان ساخت
            //دیتابیس گفتیم. میگه حالا توی رم اسمش رو چی بزارم؟
            SqlDA.Fill(SqlDS, "T1");
            //همه کنترل ها شی به نام DataBinding دارند که اتصال داده اون کنترل رو به
            //یک منبع داده نشون میده. یعنی مثلا فلان فیلد اطلاعات خودش رو از کجا بیاره
            //دستور Clear اتصالش رو به منبع داده دیگه ای قطع میکنه و آماده است برای متصل کردن
            dataGridView1.DataBindings.Clear();
            //حالا براش یک منبع داده متصل میکنیم
            //اول میگیم کدوم خصوصیت از این کنترل قراره این منبع داده رو به خودش تخصیص بده
            //که در گرید ویو اون ویژگی که باید منبع داده رو به خودش تخصیص بده اسمش هست
            //DataSource
            //در پارامتر دوم میگه حالا اون منبع داده شما چی هست که ما روی
            //DataSet که تتنظیم کردیم بهش میدیم که اطلاعات هارد رو آوردیم باهاش روی رم
            //بعدش میگیم اینجا کلی اطلاعات هست، کدوم بخشش رو میخوای بهش بدی؟
            //که ما اومدیم گفتیم اسمش توی رم T1 باشه
            dataGridView1.DataBindings.Add("DataSource", SqlDS, "T1");
            //همونطور که به کمک دو خط بالا اومدیم به گرید منبع داده تخصیص دادیم
            //حالا میخوایم به فیلدهای دیگه هم مقدار تخصیص بدیم
            //چون احتمال میدیم چندبار صدا بزنیم اول قطعش میکنیم
            textBoxName.DataBindings.Clear();
            //حالا بهش مقدار میدیم
            //اول میگیم به کدوم ویژگی اون میخوایم مقدار بدیم
            //در واقع مثل اینه بگیم TextBoxName.Text برابر است با چه چیزی
            //از کدوم DataSet
            //بعدش میگیم کدوم بخش از اون اطلاعات
            textBoxName.DataBindings.Add("Text", SqlDS, "T1.FirstName");
            //حالا برای تمام فیلدهامون همین کار رو میکنیم
            textBoxFamily.DataBindings.Clear();
            textBoxFamily.DataBindings.Add("Text", SqlDS, "T1.LastName");
            textBoxTell.DataBindings.Clear();
            textBoxTell.DataBindings.Add("Text", SqlDS, "T1.PhoneNo");
            textBoxAddress.DataBindings.Clear();
            textBoxAddress.DataBindings.Add("Text", SqlDS, "T1.Address");
            pictureBoxContact.DataBindings.Clear();
            pictureBoxContact.DataBindings.Add("ImageLocation", SqlDS, "T1.PictureURL");

            //BindingContext
            //اشیایی که مدیریت کننده کنترل های روی فرم هستند را در خودش ذخیره کرده است
            //به ازای هر اتصال به منبع داده یک شی از نوع
            //CurrencyManager
            //به وجود میاد و در BindingContext فرم قرار میگیرد
            //و کار اونها مدیریت کردن منبع داده و کنترل های روی فرم است
            //چون به صورت پیش فرض نمیتونیم بهش اون دیتا رو پاس بدیم اولش cast میکنیم
            cr = (CurrencyManager)this.BindingContext[SqlDS, "T1"];
            //خوبیش اینه وقتی برنامه اجرا میشه خودش مستقیم وصل میشه به دیتا
            //بخاطر همین میریم روی دکمه next و راحت اون رو فراخوانی میکنیم
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //یعنی رکورد جاری در منبع داده T1 رو یکی ببر جلو
            //cr.Position++;
            //یا میشه با اون تابع جدید نوشتش
            SetCurrentRec(cr.Position++);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //قابل ویرایش میکنیم
            textBoxName.ReadOnly = false;
            textBoxFamily.ReadOnly = false;
            textBoxTell.ReadOnly = false;
            textBoxAddress.ReadOnly = false;
            //متن اونها رو خالی میکنیم
            textBoxName.Text = string.Empty;
            textBoxFamily.Text = string.Empty;
            textBoxTell.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            //دکمه رو خاموش میکنیم
            buttonNew.Enabled = false;
            buttonSave.Enabled = true;
            //به اولین فیلد پرش کنیم
            textBoxName.Focus();
            buttonBrowse.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //ابتدا یک command local تعریف میکنیم که با ورود به save ایجاد
            //میشن و با خروج از save از بین میرن
            SqlCommand SaveComm = new SqlCommand();
            //متن فرمان را به آن میدیم
            //SaveComm.CommandText = @"Insert into TblTell
            //                        values ('FirstSave','LastSave','0912745896','SaveLocation')";
            //حالا میخوایم اون رو پارامتری تعریف کنیم
            SaveComm.CommandText = @"Insert into TblTell
                                    values (@Name,@Family,@Tell,@Address,@PictureURL)";
            //حالا پارامترها رو مقدار دهی میکنیم
            //AddWithValue مقدار میده به پارامتر ها به همراه منبع داده اون
            SaveComm.Parameters.AddWithValue("Name", textBoxName.Text);
            SaveComm.Parameters.AddWithValue("Family", textBoxFamily.Text);
            SaveComm.Parameters.AddWithValue("Tell", textBoxTell.Text);
            SaveComm.Parameters.AddWithValue("Address", textBoxAddress.Text);
            SaveComm.Parameters.AddWithValue("PictureURL", pictureBoxContact.ImageLocation);
            //برای اون کانکشنش رو مشخص می کنیم
            SaveComm.Connection = SqlConn;
            //چون فقط درج میکنیم و مقداری برنمیگردانیم
            SaveComm.ExecuteNonQuery();
            //دکمه رو خاموش میکنیم که دوبار نتونه ذخیره کنه
            buttonSave.Enabled = false;
            buttonNew.Enabled = true;
            //غیرقابل ویرایش میکنیم
            textBoxName.ReadOnly = true;
            textBoxFamily.ReadOnly = true;
            textBoxTell.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
            buttonBrowse.Enabled = false;
            //چون میخوایم دوباره اطلاعات را فراخوانی کند
            FillGrid();
        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            //یعنی رکورد جاری در منبع داده T1 رو یکی ببر عقب
            //cr.Position--;
            SetCurrentRec(cr.Position--);
        }

        private int CrPosition;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (buttonEdit.Text == "Edit")
            {
                //قابل ویرایش میکنیم
                textBoxName.ReadOnly = false;
                textBoxFamily.ReadOnly = false;
                buttonBrowse.Enabled = true;
                //ویرایش روی کلید اصلی بی معنی هست
                textBoxTell.ReadOnly = true;
                textBoxAddress.ReadOnly = false;
                //دکمه رو خاموش میکنیم
                buttonNew.Enabled = false;
                buttonSave.Enabled = false;
                buttonDel.Enabled = false;
                //نام دکمه رو تغییر میدیم
                buttonEdit.Text = "Apply";
                textBoxName.Focus();
                CrPosition = cr.Position;
                buttonBrowse.Enabled = true;
            }
            else if (buttonEdit.Text == "Apply")
            {
                SqlCommand SaveEditComm = new SqlCommand();
                SaveEditComm.CommandText = @"UPDATE TblTell
                                            SET
	                                            FirstName = @FirstName,
	                                            LastName = @LastName,
	                                            [Address] = @Address,
                                                PictureURL = @PictureURL
                                            WHERE PhoneNo = @PhoneNo";
                SaveEditComm.Parameters.AddWithValue("FirstName", textBoxName.Text);
                SaveEditComm.Parameters.AddWithValue("LastName", textBoxFamily.Text);
                SaveEditComm.Parameters.AddWithValue("Address", textBoxAddress.Text);
                SaveEditComm.Parameters.AddWithValue("PhoneNo", textBoxTell.Text);
                SaveEditComm.Parameters.AddWithValue("PictureURL",
                    CopyPic(pictureBoxContact.ImageLocation, textBoxTell.Text));
                SaveEditComm.Connection = SqlConn;
                SaveEditComm.ExecuteNonQuery();
                FillGrid();
                buttonEdit.Text = "Edit";
                buttonNew.Enabled = true;
                buttonDel.Enabled = true;
                //غیرقابل ویرایش میکنیم
                textBoxName.ReadOnly = true;
                textBoxFamily.ReadOnly = true;
                textBoxTell.ReadOnly = true;
                textBoxAddress.ReadOnly = true;
                SetCurrentRec(CrPosition);
                cr.Position = CrPosition;
                buttonBrowse.Enabled = false;
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            //یعنی رکورد جاری را ببر به تعداد رکوردهای منبع منهای یک که میشه آخرین ایندکس
            //cr.Position = cr.Count - 1;
            SetCurrentRec(cr.Count - 1);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DialogResult DelResult;
            DelResult = MessageBox.Show("Do you want to delete " + textBoxName.Text + " " +
                textBoxFamily.Text + " ?",
                "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DelResult == DialogResult.Yes)
            {
                //برای هر مورد یک کامند درست می کنیم و دستورات را برای آن می نویسیم
                //اینجا هم اول یک کامند درست میکنیم تا بتونیم دستورات رو بنویسیم
                SqlCommand DelComm = new SqlCommand();
                //میتونیم حذف رو براساس فیلد کلیدی که اینجا شماره تلفن هست انجام بدیم
                //اما برای تمرین من همه فیلد ها رو میزارم
                DelComm.CommandText = @"DELETE FROM TblTell
                                    WHERE FirstName= @FirstName and
                                    LastName= @LastName and
                                    PhoneNo= @PhoneNo and
                                    [Address]= @Address and
                                    PictureURL = @PictureURL";
                DelComm.Parameters.AddWithValue("FirstName", textBoxName.Text);
                DelComm.Parameters.AddWithValue("LastName", textBoxFamily.Text);
                DelComm.Parameters.AddWithValue("PhoneNo", textBoxTell.Text);
                DelComm.Parameters.AddWithValue("Address", textBoxAddress.Text);
                DelComm.Parameters.AddWithValue("PictureURL",
                    CopyPic(pictureBoxContact.ImageLocation, textBoxTell.Text));
                DelComm.Connection = SqlConn;
                DelComm.ExecuteNonQuery();
                FillGrid();
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            //یعنی رکورد جاری را ببر به اولین رکورد
            //cr.Position = 0;
            SetCurrentRec(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //با این رویداد میخوایم بگیم هرجایی که کلیک کردیم اون بشه رکورد جاری ما
            //شماره سطر کلیک شده e.RowIndex
            //شماره ستون کلیک شده e.ColumnIndex
            //شماره سطری که روی اون کلیک شده رکورد جاری بشه
            cr.Position = e.RowIndex;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //میخوایم متن جستجو رو بنویسیم
            //برای اون با یک عبارت این متن رو میسازیم
            string SearchScript;
            SearchScript = "Select * from TblTell where " + comboBoxSearchBy.Text + " Like '%" + textBoxFind.Text + "%'";
            //موقع نوشتن FillGrid گفتیم میتونیم بهش اسکریپت بدیم و اگر ندادیم همرو بیار
            //حالا اینجا داریم اون اسکریپتی که ساختیم رو میدیم.
            FillGrid(SearchScript);
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            //برای اینکه در زمان جستجو با زدن هر کلید خودش سرچ کنه
            //کلید سرچ رو میاریم توی این بخش که تغییر متن هست
            buttonSearch_Click(null, null);
        }

        private void SetCurrentRec(int CurrentRec)
        {
            if (CurrentRec < 0 || CurrentRec >= cr.Count)
            {
                return;
            }
            else
            {
                //در قسمت انتهابب میتونستیم از ستون 0 استفاده کنیم
                //اما چون می خواهیم روی همون ستون با عثب و جلو رفتن حرکت کنیم
                //از شماره سلول انتخاب شده استفاده می کنیم
                dataGridView1.CurrentCell = dataGridView1.Rows[CurrentRec].Cells[dataGridView1.CurrentCell.ColumnIndex];
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            SetCurrentRec(dataGridView1.CurrentCell.RowIndex);
        }

        private void pictureBoxContact_Click(object sender, EventArgs e)
        {
            //اگر عکس با ابعاد واقعی نبود یعنی تازه کلیک شده آنگاه
            if (pictureBoxContact.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                //ویژگی اون رو برام نگه دار
                PicRegion = pictureBoxContact.Region;
                //ابعادش رو به ابعاد واقعی عکس تبدیل کن
                pictureBoxContact.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else
            {
                //ابعاد رو برگردون به مدل کشیده شده
                pictureBoxContact.SizeMode = PictureBoxSizeMode.StretchImage;
                //ابعادش رو تنظیم کن
                pictureBoxContact.Region = PicRegion;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BMP|*.bmp|PNG|*.png|All Files|*.*";
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Title = "Contact Picture...";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                pictureBoxContact.ImageLocation = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// برنامه ای برای کپی کردن عکس مخاطب
        /// </summary>
        /// <param name="SourceFile">مسیر فایل اصلی</param>
        /// <param name="Key">کلید اصلی برای نامگذاری فایل</param>
        /// <returns></returns>
        private String CopyPic(string SourceFile, string Key)
        {
            if (SourceFile == "")
            {
                return "";
            }
            //جایی که نرم افزار از آن اجرا میشه
            string CurrentPath;
            //مسیری که بعد از کپی کردن عکس به وجود آمده
            string NewPath;
            //آدرس دهی به محل اجرا، جایی که برنامه اجرا می شود
            CurrentPath = Application.StartupPath + @"\Images\";
            //میگه اگه اون مسیر وجود ندارد
            if (System.IO.Directory.Exists(CurrentPath) == false)
            {
                //برو از روی اون یک پوشه درست کن
                Directory.CreateDirectory(CurrentPath);
            }
            //اسم فایل را با توجه به شماره موبایل برای فیلد کلیدی استفاده می کنیم
            NewPath = CurrentPath + Key + SourceFile.Substring(SourceFile.LastIndexOf("."));
            //کنترل میکنیم اگر قبلا وجود داشته اون رو حذف میکنیم
            if (File.Exists(NewPath) == true)
            {
                File.Delete(NewPath);
            }
            //کپی می کنیم
            File.Copy(SourceFile, NewPath);
            //خروجی مسیر جدید رو برمیگردونیم
            return NewPath;
        }

        private void pictureBoxContact_MouseLeave(object sender, EventArgs e)
        {
            //اگر موس از روی عکس کنار رفت
            //ابعاد رو برگردون به مدل کشیده شده
            pictureBoxContact.SizeMode = PictureBoxSizeMode.StretchImage;
            //ابعادش رو تنظیم کن
            pictureBoxContact.Region = PicRegion;
        }
    }
}