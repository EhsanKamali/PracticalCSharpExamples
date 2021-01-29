using System;

namespace Example5
{
    public partial class FormReplace : Example5.FormFind
    {
        public FormReplace()
        {
            InitializeComponent();
        }

        //بخاطر ارث بری باید این خط تکمیل شود
        //جلسه 9 دقیقه 44
        public FormReplace(Form1 form1) : base(form1)
        {
            FrmMain = form1;
            InitializeComponent();
        }

        //با این کار فرم یک رو به صورت مرجعی تبدیل میکنیم که همه جای این فرم بهش دسترسی داشته باشیم
        private Form1 FrmMain;

        private void FormReplace_Load(object sender, EventArgs e)
        {
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            FrmMain.ReplaceFunction(textBoxReplace.Text);
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e)
        {
            StringComparison sc;
            Boolean LeftToRight;
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
                LeftToRight = true;
            }
            else
            {
                LeftToRight = false;
            }

            FrmMain.ReplaceAllFunction(textBoxFindWhat.Text, textBoxReplace.Text, sc, LeftToRight);
        }
    }
}