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
            System.IO.File.WriteAllText(@"E:\Temp\Ex5.txt", textBoxNotePad.BackColor.Name);
            //Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaveFlag = true;
            string Path;
            Path = @"E:\Temp\Ex5.txt";
            if (System.IO.File.Exists(Path))
            {
                string FileText;
                FileText = System.IO.File.ReadAllText(Path);

                ToolStripMenuItem BackColor = new ToolStripMenuItem();
                BackColor.Text = FileText;

                //textBoxNotePad.BackColor = Color.FromName(FileText);
                SetBackColor(BackColor, null);
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotePad.WordWrap = wordWrapToolStripMenuItem.Checked;
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
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

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

        public int FindNextFunction(string FindString, int StartIndex,StringComparison sc)
        {
            int FindIndex;
            FindIndex = textBoxNotePad.Text.IndexOf(FindString, StartIndex + FindString.Length,sc);
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
    }
}