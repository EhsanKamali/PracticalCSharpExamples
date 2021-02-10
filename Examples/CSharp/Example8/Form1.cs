using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example8
{
    public partial class Form1 : Form
    {
        ClassDictionary dictionary = 
            new ClassDictionary
            (@"Data Source=.;Initial Catalog=CSharpDataBase;Persist Security Info=True;User ID=sa;Password=1");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        /// <summary>
        /// داده ها را روی فرم نشان می دهد
        /// </summary>
        /// <param name="Script">عبارت جستجوی دیتا</param>
        private void FillGrid(string Script = null)
        {
            dataGridView1.DataSource = dictionary.ReturnRecord(Script);
            dataGridView1.Columns[0].HeaderText = "Word";
            dataGridView1.Columns[0].Width = dataGridView1.Width;
            dataGridView1.Columns[1].Visible = false;

            textBoxTranslate.DataBindings.Clear();
            textBoxTranslate.DataBindings.Add("Text", dataGridView1.DataSource, "FarsiWord");
        }

        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FillGrid(textBoxWord.Text);
            }
            catch
            {

            }
            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormDataControl fdc = new FormDataControl();
            fdc.ShowDialog(this);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormDataControl fdc = new FormDataControl();
            fdc.ShowDialog(this);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
