using System;
using System.Windows.Forms;

namespace Example11
{
    public partial class FormModify : Form
    {
        private FormMain fm = new FormMain();

        private ClassReadme readme =
            new ClassReadme();

        private bool IsNewRecord;
        private string Script;

        public FormModify()
        {
            InitializeComponent();
            //اگر از این سازنده استفاده شده باشد یعنی اطلاعاتی انتقال داده نشد
            //پس رکورد جدید است و ارتباطی با فرم اصلی ندارد
            IsNewRecord = true;
        }

        /// <summary>
        /// یک سازنده جدید برای فرم تغییرات
        /// </summary>
        /// <param name="main">فرمی که می خواهیم اطلاعات از آن انتقال یابد</param>
        public FormModify(FormMain main)
        {
            InitializeComponent();
            //اگر از این سازنده استفاده شده باشد یعنی اطلاعات از فرم قبلی آمده است و ویرایش است
            IsNewRecord = false;
            textBoxId.Text = main.GetID();
            textBoxTitle.Text = main.GetTitle();
            richTextBox1.Text = main.GetDescription();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsNewRecord == true)
            {
                Script = (@"INSERT INTO ReadmeTable
                                (
	                                Title,
	                                [Description]
                                )
                                VALUES
                                (
	                                '" + readme.CorrectText(textBoxTitle.Text) + "',  " +
                                   "N'" + readme.CorrectText(richTextBox1.Text) + "' )");
            }
            else
            {
                Script = (@"UPDATE ReadmeTable
                                SET
	                                Title = '" + readme.CorrectText(textBoxTitle.Text) + "',  " +
                                    "[Description] = N'" + readme.CorrectText(richTextBox1.Text) + "'  " +
                                    "WHERE Id = " + textBoxId.Text);
            }

            //Script = readme.CorrectText(Script);

            readme.ModifyRecord(Script);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}