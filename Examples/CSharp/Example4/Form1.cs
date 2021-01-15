using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example4
{
    public partial class Form1 : Form
    {
        private double x, y, z;
        private string Op;
        private Boolean Flag;

        private void OperationFunction(object sender, EventArgs e)
        {
            if (Op != null)
            {
                buttonEqual_Click(null, null);
            }
            x = Convert.ToDouble(textBoxInput.Text);
            Op = ((Button)sender).Text;
            //با اضافه شدن فلگ این خط حذف می شود
            //textBoxInput.Clear();

            Flag = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBoxInput.Text);

            switch (Op)
            {
                case "+":
                    z = x + y;
                    break;

                case "-":
                    z = x - y;
                    break;

                case "*":
                    z = x * y;
                    break;

                case "/":
                    z = x / y;
                    break;

                default:
                    break;
            }

            textBoxInput.Text = z.ToString();
            x = 0; y = 0; z = 0;
            Op = null;
            Flag = true;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            //if (textBoxInput.Text.Contains("."))
            //{
            //    buttonPoint.Enabled = false;
            //}
            //else
            //{
            //    buttonPoint.Enabled = true;
            //}

            buttonPoint.Enabled = !textBoxInput.Text.Contains(".");
            buttonBackSpace.Enabled = Convert.ToBoolean(textBoxInput.Text.Length);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            x = z;
            y = 0;
            z = 0;
            Op = null;
            Flag = false;
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            int Length = textBoxInput.Text.Length;
            textBoxInput.Text = textBoxInput.Text.Substring(0, Length - 1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Button x in panel1.Controls)
            {
                if (x.Text == e.KeyChar.ToString())
                {
                    x.Focus();
                    x.ForeColor = Color.Red;
                }
                else 
                {
                    x.ForeColor = Color.Black;
                }
            }

            Button Temp = new Button();
            Temp.Text = e.KeyChar.ToString();
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                NumbersFunction(Temp, null);
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                OperationFunction(Temp, null);
            }
            else if (e.KeyChar == '=')
            {
                //chon az sender estefade nakardim mitonim hardo ghesmat ro null bedim
                buttonEqual_Click(null, null);
            }
            else if (e.KeyChar == '.' && !textBoxInput.Text.Contains("."))
            {
                NumbersFunction(Temp, null);
            }
            else if (e.KeyChar == '\b' && textBoxInput.TextLength > 0)
            {
                buttonBackSpace_Click(null, null);
            }
            else if (e.KeyChar == (char)27)
            {
                ExitForm();
            }
        }

        public Form1()
        {
            InitializeComponent();
            buttonBackSpace.Enabled = false;
        }

        private void NumbersFunction(object sender, EventArgs e)
        {
            if (Flag)
            {
                textBoxInput.Clear();
                Flag = false;
            }

            textBoxInput.Text += ((Button)sender).Text;
        }

        private void ExitForm()
        {
            DialogResult dialogResult;
            dialogResult =
                MessageBox.Show("Do you want to exit?", "Exit....", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}