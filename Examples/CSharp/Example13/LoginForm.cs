using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example13
{
    public partial class LoginForm : Form
    {
        private SQLConnectionClass SQLcc =
            new SQLConnectionClass();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            /*با زدن کنسل کلا از برنامه خارج می شیم*/
            Application.Exit();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            /*ابتدا نتیجه پسورد را در یک متغییر ذخیره می کنیم*/
            string Pass = 
            SQLcc.ReturnPassword(textBoxUserName.Text);

            /*اگر پسورد درست بود وارد برنامه می شود*/
            if (textBoxPass.Text == Pass)
            {
                MainForm mf = new MainForm();
                this.Hide();
                mf.ShowDialog();
            }
            else
            {
                MessageBox.Show("UserName or Password is incorrect!!!!");
            }
        }

        private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            /*با این تنظیم می خواهیم با زدن دکمه اینتر کلید اوکی زده شود*/
            if (e.KeyCode == Keys.Enter)
            {
                buttonOk_Click(null, null);
            }
        }
    }
}
