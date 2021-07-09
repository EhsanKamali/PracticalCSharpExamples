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
            Application.Exit();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string Pass = 
            SQLcc.ReturnPassword(textBoxUserName.Text);

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
    }
}
