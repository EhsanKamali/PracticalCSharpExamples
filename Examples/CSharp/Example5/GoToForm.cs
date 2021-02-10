using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example5
{
    public partial class GoToForm : Form
    {
        private Form1 FormMain;

        int MainLineNumber;

        public GoToForm(Form1 Frm)
        {
            FormMain = Frm;
            InitializeComponent();

            SetMaxLineNumber();
        }
                
        private void SetMaxLineNumber()
        {
            MainLineNumber = FormMain.LineNumber();
            textBoxLineNumber.Text = MainLineNumber.ToString();
            textBoxLineNumber.Focus();
            textBoxLineNumber.SelectAll();
        }

        private void buttonGoTo_Click(object sender, EventArgs e)
        {
            int LineNumber;
            if(int.TryParse(textBoxLineNumber.Text,out LineNumber)==false)
            {
                MessageBox.Show("You can only type a number here.", "Unacceptable character",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetMaxLineNumber();
            }
            else 
            if (LineNumber > MainLineNumber)
            {
                MessageBox.Show("The line number is beyond the total number of lines",
                    "GoTo Line", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetMaxLineNumber();
            }
            else
            {
                FormMain.GoToLineNumber(LineNumber);
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
