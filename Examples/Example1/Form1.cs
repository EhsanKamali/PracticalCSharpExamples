using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSayHi_Click(object sender, EventArgs e)
        {
            string Result = "Hello " + textBoxName.Text;

            if (textBoxName.Text != string.Empty)
            {
                labelResult.Text = Result;
                MessageBox.Show(Result);
            }
            
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            labelResult.Text = string.Empty;
            textBoxName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelName_MouseMove(object sender, MouseEventArgs e)
        {
            labelName.ForeColor = Color.Red;
        }

        private void labelName_MouseLeave(object sender, EventArgs e)
        {
            labelName.ForeColor = Color.Black;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            FormControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormControl();
        }

        private void FormControl()
        {
            if (textBoxName.Text == string.Empty)
            {
                buttonSayHi.Enabled = false;
            }
            else
            {
                buttonSayHi.Enabled = true;
            }

            buttonClear.Enabled = Convert.ToBoolean(textBoxName.Text.Length);
        }
    }
}
