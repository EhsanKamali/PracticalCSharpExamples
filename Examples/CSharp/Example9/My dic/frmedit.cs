using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_dic
{
    public partial class frmedit : Form
    {
        public frmedit()
        {
            InitializeComponent();
        }
        public frmedit(Form1 x)
        {
            InitializeComponent();
            txtenglish.Text = x.getenglishword();
            txtfarsi.Text=x.getfarsihword();
        }

        private void frmedit_Load(object sender, EventArgs e)
        {

        }

        private void Btnapply_Click(object sender, EventArgs e)
        {
            dic a = new dic(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Application.StartupPath + @"\dicDb.mdf;Integrated Security=True");
            a.Editrec(txtfarsi.Text, txtenglish.Text);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
