using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Example5
{
    public partial class Form1 : Form
    {
        private string FilePath;
        private Boolean SaveFlag;
        private MyUndo NotePadUndo = new MyUndo();

        //کلاسی ایجاد می کنیم تا برگشت ها را کنترل کنیم
        //و بعدا از روی آن شی دیگری تعریف کنیم
        public class MyUndo
        {
            private string[] Temp = new string[100];
            private int Index;
            private int CurrentPosition;

            public MyUndo()
            {
                Index = 0;
                CurrentPosition = 0;
            }

            public void SetText(string s)
            {
                Temp[Index] = s;
                CurrentPosition = Index;
                ++Index;
            }

            public string Undo()
            {
                if (CurrentPosition > 0)
                {
                    return Temp[--CurrentPosition];
                }
                else
                {
                    return null;
                }
            }

            public string Redo()
            {
                if (CurrentPosition < Index)
                {
                    return Temp[++CurrentPosition];
                }
                else
                {
                    return null;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetBackColor(object sender, EventArgs e)
        {
            textBoxNotePad.BackColor = Color.FromName(((ToolStripItem)sender).Text);

            foreach (ToolStripMenuItem Tsi in backColorToolStripMenuItem.DropDownItems)
            {
                if (Tsi.Text == ((ToolStripItem)sender).Text)
                //if (Tsi.Equals(sender))
                {
                    Tsi.Checked = true;
                }
                else
                {
                    Tsi.Checked = false;
                }
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            //با این گزینه یک فرم انتخاب رنگ باز می شود
            textBoxNotePad.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //فونت پیش فرض همون فونت جاری نشان داده می شود
            fontDialog1.Font = textBoxNotePad.Font;
            //پنجره نمایش فونت ها را نشان می دهد
            fontDialog1.ShowDialog();
            //مقدار فونت نمایش را با خروجی انتخاب از فرم برابر قرار می دیم
            textBoxNotePad.Font = fontDialog1.Font;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            newToolStripMenuItem_Click(null, null);

            //یک آرایه رشته ای تعریف میکنیم تا اطلاعات را در فایل ذخیره کنیم
            string[] ToFile = new string[5];
            ToFile[0] = textBoxNotePad.BackColor.Name;
            ToFile[1] = textBoxNotePad.Font.Name;
            ToFile[2] = textBoxNotePad.Font.Size.ToString();
            ToFile[3] = this.Height.ToString();
            ToFile[4] = this.Width.ToString();
            //برای ذخیره کردن تمام خط ها در فایل
            System.IO.File.WriteAllLines(Path, ToFile);

            //جهت ذخیره کردن نام رنگ در یک فایل
            //System.IO.File.WriteAllText(@"E:\Temp\Ex5.txt", textBoxNotePad.BackColor.Name);
            //Application.Exit();
        }

        private string Path = @"E:\Temp\Ex5.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            SaveFlag = true;

            //اگر فایل موجود بود اون رو میخونیم
            string[] FromFile = new string[5];

            if (System.IO.File.Exists(Path))
            {
                FromFile = System.IO.File.ReadAllLines(Path);

                //این برای حالتیه که فقط رنگ رو ذخیره کرده بودیم
                string FileText;
                FileText = System.IO.File.ReadAllText(Path);
                ToolStripMenuItem BackColor = new ToolStripMenuItem();
                //BackColor.Text = FileText;
                //براساس فایل رنگ مشخص میشه
                BackColor.Text = FromFile[0];
                //فونت را تنظیم میکنیم
                textBoxNotePad.Font = new Font(FromFile[1], float.Parse(FromFile[2]));
                //ابعاد فرم را تنظیم میکنیم
                this.Height = Convert.ToInt16(FromFile[3]);
                this.Width = Convert.ToInt16(FromFile[4]);

                //textBoxNotePad.BackColor = Color.FromName(FileText);
                SetBackColor(BackColor, null);
            }

            //در لحظه باز شدن فرم موقعیت نمایش داده شود
            SetRowCol();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotePad.WordWrap = wordWrapToolStripMenuItem.Checked;
            goToToolStripMenuItem.Enabled = !wordWrapToolStripMenuItem.Checked;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMethod(FilePath);
        }

        private void SaveMethod(string SaveFilePath)
        {
            FilePath = SaveFilePath;
            if (!SaveFlag)
            {
                if (FilePath == null)
                {
                    //برای فایل پسوند ها را مشخص می کنیم
                    saveFileDialog1.Filter = "Text Document|*.txt|All File|*.*";
                    //یک پسوند پیش فرض برای ذخیره مشخص می کنیم
                    saveFileDialog1.DefaultExt = "txt";
                    //پنجره ذخیره را باز می کند
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //مسیر و نامن فایل ذخیره شده را به یک متغییر می دهیم
                        FilePath = saveFileDialog1.FileName;
                    }
                    else
                        return;
                }

                //فایل را ذخیره می کنیم
                System.IO.File.WriteAllText(FilePath, textBoxNotePad.Text);
                //نام فرم را به نام فایل تغییر می دیم
                this.Text = FilePath;
                //فلگ ذخیره شده را صحیح می کنیم
                SaveFlag = true;
                //نوار پایین را به ذخیره شده تغییر می دهیم
                toolStripStatusLabelStatus.Text = "Saved";
            }
            else
            {
                //تغییرات را در فایل ذخیره می کنیم
                System.IO.File.WriteAllText(FilePath, textBoxNotePad.Text);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!SaveFlag)
            {
                DialogResult Result =
                MessageBox.Show("Do you want to save your file?", "Save file",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (Result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
                else if (Result == DialogResult.No)
                {
                    MakeNewForm();
                }
                else if (Result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                MakeNewForm();
            }
        }

        private void MakeNewForm()
        {
            textBoxNotePad.Text = null;
            this.Text = "My NotePad";
            FilePath = null;
            SaveFlag = false;
        }

        private void textBoxNotePad_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = false;

            //برای اینکه موقعیت مکان نما را نمایش دهد
            SetRowCol();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            FilePath = openFileDialog1.FileName;
            textBoxNotePad.Text = File.ReadAllText(FilePath);
            this.Text = FilePath;
            SaveFlag = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFlag = false;
            SaveMethod(null);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxNotePad.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotePad.SelectedText = Clipboard.GetText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
            deleteToolStripMenuItem_Click(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotePad.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotePad.SelectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //از روی فرم یک شی ایجاد می کنیم
            //در فرم جستجو چون مرجع بهش دادیم اینجا هم باید مرجع رو مشخص کنیم
            FormFind FormFind = new FormFind(this);
            //با این کار میگیم اون فرم یک اونر دارد که فرم اصلی است.
            //پس از روی اون میشه به فرم اصلی دسترسی داشت
            FormFind.Show(this);
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReplace formReplace = new FormReplace(this);
            formReplace.Show(this);
        }

        //گزینه goto را برنامه ریزی می کند
        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToForm goToForm = new GoToForm(this);
            goToForm.ShowDialog();
        }

        /// <summary>
        /// از این تابع برای پیدا کردن استفاده می کنیم
        /// </summary>
        /// <param name="FindString">عبارتی که می خواهیم آن را جستجو کنیم</param>
        /// <returns></returns>
        public Boolean FindFunction(string FindString)
        {
            int FindIndex;
            FindIndex = textBoxNotePad.Text.IndexOf(FindString);
            if (FindIndex == -1)
            {
                MessageBox.Show("Not Fund", "Find Result");
                return false;
            }
            else
            {
                //مکان نما به ابتدای ایندکس معرفی شده می رود
                textBoxNotePad.SelectionStart = FindIndex;
                //متن به اندازه مورد نظر انتخاب می شود
                textBoxNotePad.SelectionLength = FindString.Length;

                textBoxNotePad.Focus();
                return true;
            }
        }

        /// <summary>
        /// متدی برای جستجو در متن
        /// </summary>
        /// <param name="FindString">رشته مورد جستجو</param>
        /// <param name="StartIndex">ایندکس شروع</param>
        /// <param name="sc">نوع مقایسه که حساس به حروف کوچک و بزرگ باشد یا نه</param>
        /// <param name="RightToLeft">جستجو راست به چپ یا چپ به راست</param>
        /// <returns></returns>
        public int FindNextFunction(string FindString, int StartIndex,
            StringComparison sc, Boolean RightToLeft)
        {
            int FindIndex;
            if (RightToLeft)
            {
                FindIndex = textBoxNotePad.Text.IndexOf(FindString,
                    StartIndex + FindString.Length, sc);
            }
            else
            {
                FindIndex = textBoxNotePad.Text.LastIndexOf(FindString,
                    StartIndex + FindString.Length, sc);
            }
            if (FindIndex == -1)
            {
                MessageBox.Show("Not Found", "Find Result");
                return FindIndex;
            }
            else
            {
                //مکان نما به ابتدای ایندکس معرفی شده می رود
                textBoxNotePad.SelectionStart = FindIndex;
                //متن به اندازه مورد نظر انتخاب می شود
                textBoxNotePad.SelectionLength = FindString.Length;

                textBoxNotePad.Focus();
                return FindIndex;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotePad.Text = NotePadUndo.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotePad.Text = NotePadUndo.Redo();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //KeyPreview را برای فرم فعال میکنیم
            NotePadUndo.SetText(textBoxNotePad.Text);
        }

        /// <summary>
        /// متدی برای جایگزین کردن متن انتخابی
        /// </summary>
        /// <param name="ReplaceString">رشته مورد نظر که میخواهیم جایگزین متن انتخاب شده شود</param>
        public void ReplaceFunction(string ReplaceString)
        {
            //متنی انتخاب شده است
            if (textBoxNotePad.SelectionLength > 0)
            {
                textBoxNotePad.SelectedText = ReplaceString;
            }
        }

        /// <summary>
        /// متدی برای جایگزین کردن همه موارد
        /// </summary>
        /// <param name="str1">رشته مورد جستجو</param>
        /// <param name="str2">رشته جایگزین</param>
        /// <param name="sc">نوع مقایسه</param>
        /// <param name="LeftToRight">جهت مقایسه</param>
        public void ReplaceAllFunction(string str1, string str2, StringComparison sc,
            Boolean LeftToRight)
        {
            while (Convert.ToBoolean(FindNextFunction(str1, 0, sc, LeftToRight)))
            {
                ReplaceFunction(str2);
            };
        }

        /// <summary>
        /// این آیتم تعداد خط های متن را محاسبه می کند
        /// </summary>
        /// <returns></returns>
        public int LineNumber()
        {
            int LineNumber;
            LineNumber = textBoxNotePad.Lines.Length;
            return LineNumber;
        }

        /// <summary>
        /// این آیتم میرود به سر خط انتخابی
        /// </summary>
        /// <param name="GoToLineNumber">شماره خط مورد نظر</param>
        public void GoToLineNumber(int GoToLineNumber)
        {
            textBoxNotePad.SelectionStart =
                textBoxNotePad.GetFirstCharIndexFromLine(GoToLineNumber - 1);
        }

        public void SetRowCol()
        {
            int Row = textBoxNotePad.GetLineFromCharIndex(textBoxNotePad.SelectionStart) + 1;
            /* ستون میشه موقعیت جاری منهای موقعیت اول خط
             * که میتونیم از این هم استفاده کنیم
             * GetFirstCharIndexFromLine(Row)*/
            int Col = textBoxNotePad.SelectionStart -
                textBoxNotePad.GetFirstCharIndexOfCurrentLine();

            toolStripStatusRowCol.Text = "Ln" + Row.ToString() + ",Col" + Col.ToString();
        }

        //در زمان کلیک کردن در متن اجرا می شود
        private void textBoxNotePad_Click(object sender, EventArgs e)
        {
            //برای اینکه موقعیت مکان نما را نمایش دهد
            SetRowCol();
            //وضعیت گزینه ها کنترل می شود
            SetEnables();
        }

        //در زمان آزاد کردن یک کلید کار میکنه
        //باید دقت کنیم که در KeyDown چون هزینه کلید آزاد نشده وضعیت قبل از اون کلید هست
        //پی اگر از اون استفاده می کردیم همیشه وضعیت قبل رو نشون میداد و به درد ما نمیخورد
        private void textBoxNotePad_KeyUp(object sender, KeyEventArgs e)
        {
            //برای اینکه موقعیت مکان نما را نمایش دهد
            SetRowCol();
        }

        //برای کنترل وضعیت گزینه های منو از این آیتم استفاده می کنیم
        public void SetEnables()
        {
            //اگر ویژگی WordWrap فعال باشد نباید گزینه GoTo فعال باشد و بالعکس
            goToToolStripMenuItem.Enabled = !wordWrapToolStripMenuItem.Checked;

            //اگر متنی انتخاب نشده نباید برخی گزینه ها فعال باشد
            //if (textBoxNotePad.SelectionLength == 0)
            //{
            //    copyToolStripMenuItem.Enabled = false;
            //    cutToolStripMenuItem.Enabled = false;
            //    deleteToolStripMenuItem.Enabled = false;
            //}
            //else
            //{
            //    copyToolStripMenuItem.Enabled = true;
            //    cutToolStripMenuItem.Enabled = true;
            //    deleteToolStripMenuItem.Enabled = true;
            //}
            //اگر کلیپ بورد مقدار متنی داشت گزینه Paste فعال باشد
            //این همون مدل شرطی تک خطی هست
            //چی رو میخوای تنظیم کنی؟ با چه شرطی؟ اگر درست بود چی؟ اگر درست نبود چی؟
            //pasteToolStripMenuItem.Enabled = Clipboard.ContainsText() ? true : false;

            //حتی میشه راحت تر هم نوشت
            copyToolStripMenuItem.Enabled = Convert.ToBoolean(textBoxNotePad.SelectionLength);
            cutToolStripMenuItem.Enabled = textBoxNotePad.SelectionLength > 0;
            deleteToolStripMenuItem.Enabled = textBoxNotePad.SelectionLength > 0;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
            findToolStripMenuItem.Enabled = textBoxNotePad.Text.Length > 0;
            goToToolStripMenuItem.Enabled = textBoxNotePad.TextLength > 0;
            saveToolStripMenuItem.Enabled = !SaveFlag;
        }

        //در زمان باز شدن گزینه ها اتفاق میوفتد
        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            //وضعیت چون برای گزینه ها نوشته شده صرفا در زمان باز شدن اونها کنترل بشه کافیه
            SetEnables();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult PrintResult;
            //چه سندی را پرینت بگیرد
            printDialog1.Document = printDocument1;
            //برای باز کردن پنجره پرینت
            PrintResult = printDialog1.ShowDialog();
            if(PrintResult==DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        //رویدادی که در اثر پرینت اتفاق میوفته
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //مشخص می کنیم چی رو پرینت بگیره
            e.Graphics.DrawString(textBoxNotePad.Text, textBoxNotePad.Font,
                Brushes.Black, 0, 0);
        }

        //تنظیم پیش نمایش
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }
    }
}