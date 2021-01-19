using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example5
{
    public partial class Form1 : Form
    {
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
                //if (Tsi.Name==((ToolStripItem)sender).Name)
                if (Tsi.Equals(sender))
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
    }
}