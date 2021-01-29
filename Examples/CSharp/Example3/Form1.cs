using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void HelloFunction(object sender, EventArgs e)
        {
            //foreach (Control c in this.Controls)
            //{
            //    if (c.Name == ((Control)sender).Name)
            //    {
            //        c.ForeColor = Color.Red;
            //    }
            //    else
            //    {
            //        c.ForeColor = Color.Black;
            //    }
            //}

            foreach (Control c in this.Controls)
            {
                if (c.Equals(sender))
                {
                    c.ForeColor = Color.Red;
                }
                else
                {
                    c.ForeColor = Color.Black;
                }
            }

            ((Control)sender).ForeColor = Color.Red;

            //string ObjectName;

            //ObjectName = ((Control)sender).Text;
            //MessageBox.Show("Hello " + ObjectName);
        }

        private void buttonForeach_Click(object sender, EventArgs e)
        {
            int[] b = new int[10];

            b[0] = 10;
            b[1] = 20;
            b[2] = 30;
            b[3] = 40;
            b[4] = 50;
            b[8] = 90;
            b[9] = 100;

            foreach (int x in b)
            {
                MessageBox.Show(x.ToString(), "foreach Function");
            }
        }

        private void buttonControlsName_Click(object sender, EventArgs e)
        {
            this.Text = "foreach sample on this.Controls.Name";

            foreach (Control c in this.Controls)
                MessageBox.Show(c.Name, c.Text);
        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            int[] a = new int[5];

            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;

            for (int i = 0; i < 5; ++i)
                MessageBox.Show(a[i].ToString(), "for Function");
        }

        private void buttonSizeChang_Click(object sender, EventArgs e)
        {
            this.Text = "Increase all heigh button +2 pix";

            foreach (Control c in this.Controls)
            {
                c.Height += 2;
                c.Width += 2;

                if (c.Name == "labelControl")
                {
                    c.ForeColor = Color.Red;
                }
            }
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            labelControl.Click += new EventHandler(MsgEvent);
        }

        private void MsgEvent(object sender, EventArgs e)
        {
            string ObjectName;

            ObjectName = ((Control)sender).Text;
            MessageBox.Show("Hello " + ObjectName);
        }

        private void buttonRunTimeEvent_Click(object sender, EventArgs e)
        {
            int Top, Left, Height;

            Top = this.Height / 10;
            Left = this.Width - 100;
            Height = this.Height / 10;

            TextBox textBox = new TextBox();
            textBox.Top = Top;
            textBox.Left = Left;
            textBox.Height = Height;
            textBox.Name = "NewTextBox";

            this.Controls.Add(textBox);

            for (int i = 1; i <= 4; ++i)
            {
                Button button = new Button();
                button.Left = Left;
                button.Top = (i + 1) * Top;
                button.Height = Height;
                button.Name = "button" + i.ToString();
                button.Text = "button" + i.ToString();

                this.Controls.Add(button);

                button.Click += new EventHandler(MsgEvent);
            }
        }
    }
}