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
    public partial class Form1 : Form
    {
        dic d1 = new dic(@"Data Source=(LocalDB)\v11.0;AttachDbFilename="+ Application.StartupPath+ @"\dicDb.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            showdata();
        }
        void showdata(string s = null) {
            dataGridView1.DataSource = d1.returnrec(s);
            dataGridView1.Columns[0].Width = dataGridView1.Width;
            btnedit.Enabled = dataGridView1.RowCount > 0;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                txttranslate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }

           
           }

        private void txtenglisgword_TextChanged(object sender, EventArgs e)
        {
            showdata(txtenglisgword.Text);
        }

        public string getenglishword() { 
        
        return( dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        public string getfarsihword()
        {

            return (dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            frmedit f1 = new frmedit(this);
            f1.ShowDialog();
            showdata();
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
        }
    }
}
