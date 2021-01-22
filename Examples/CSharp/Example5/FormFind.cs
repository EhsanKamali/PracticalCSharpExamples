using System;
using System.Windows.Forms;

namespace Example5
{
    public partial class FormFind : Form
    {
        //با این کار فرم یک رو به صورت مرجعی تبدیل میکنیم که همه جای این فرم بهش دسترسی داشته باشیم
        private Form1 FrmMain;

        //به فرم فعلی یک مرجع میدهیم تا از این طریق دسترسی به اجزای فرم مرجع داشته باشیم
        public FormFind(Form1 Frm)
        {
            FrmMain = Frm;
            InitializeComponent();
        }

        private int FindIndex = 0;

        private void buttonFindNext_Click(object sender, EventArgs e)
        {
            StringComparison sc;
            Boolean RightToLeft;
            if (checkBoxMatchCase.Checked)
            {
                sc = StringComparison.Ordinal;
            }
            else
            {
                sc = StringComparison.OrdinalIgnoreCase;
            }

            if (radioButtonDown.Checked)
            {
                RightToLeft = true;
            }
            else
            {
                RightToLeft = false;
            }
            FindIndex = FrmMain.FindNextFunction(textBoxFindWhat.Text, FindIndex, sc, RightToLeft);
            //FrmMain.FindFunction(textBoxFindWhat.Text);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}