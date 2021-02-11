using System;
using System.Windows.Forms;

namespace Example11
{
    public partial class FormMain : Form
    {
        private ClassReadme readme =
            new ClassReadme();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxSearchBy.Items.Add("Title");
            comboBoxSearchBy.Text = "Title";
            comboBoxSearchBy.Items.Add("Description");

            FillGrid();
        }

        private void FillGrid(string Script = null)
        {
            dataGridView1.DataSource = readme.ReturnRecord(comboBoxSearchBy.Text, textBoxSearchText.Text);
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Name = "Title";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].Name = "Description";
            //dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            textBoxID.DataBindings.Clear();
            textBoxID.DataBindings.Add("Text", dataGridView1.DataSource, "ID");
            textBoxTitle.DataBindings.Clear();
            textBoxTitle.DataBindings.Add("Text", dataGridView1.DataSource, "Title");
            richTextBox1.DataBindings.Clear();
            richTextBox1.DataBindings.Add("Text", dataGridView1.DataSource, "Description");
        }

        private void textBoxSearchText_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormModify fmn = new FormModify();
            fmn.ShowDialog();
            FillGrid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            FormModify fme = new FormModify(this);
            fme.ShowDialog(this);
            FillGrid();
            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
        }

        public string GetID()
        {
            return (dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        public string GetTitle()
        {
            return (dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        public string GetDescription()
        {
            return (dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = 
                MessageBox.Show("Do you want to delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {
                readme.DeleteRecord(textBoxID.Text);
                FillGrid();
            }
            else
            {
                return;
            }
            
        }
    }
}