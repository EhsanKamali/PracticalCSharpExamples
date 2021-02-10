using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Example7
{
    public partial class FormMain : Form
    {
        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlDataAdapter sqlData = new SqlDataAdapter();
        private DataSet dataSet = new DataSet();
        CurrencyManager cr;

        private void FillGrid(string SCommand = "SELECT * FROM dbo.Words")
        {
            sqlCommand.CommandText = SCommand;
            sqlCommand.Connection = sqlConnection;
            sqlData.SelectCommand = sqlCommand;
            dataSet.Clear();
            sqlData.Fill(dataSet, "DataSetWords");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("DataSource", dataSet, "DataSetWords");
            dataGridView1.Columns[0].HeaderText = "Words";
            dataGridView1.Columns[1].Visible = false;
            textBoxTranslate.DataBindings.Clear();
            textBoxTranslate.DataBindings.Add("Text", dataSet, "DataSetWords.FarsiWord");
            cr = (CurrencyManager)this.BindingContext[dataSet, "DataSetWords"];
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            sqlConnection.ConnectionString = @"Data Source=.;Initial Catalog=CSharpDataBase;Persist Security Info=True;User ID=sa;Password=1";
            sqlConnection.Open();
            FillGrid("SELECT * FROM dbo.Words");
        }

        private void textBoxEnglishWords_KeyUp(object sender, KeyEventArgs e)
        {
            SearchWord();
        }

        private void SearchWord()
        {
            string SerachScript;
            SerachScript = @"SELECT * FROM dbo.Words
                            WHERE EnglishWord LIKE '%" + textBoxEnglishWords.Text + "%'";
            FillGrid(SerachScript);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }
    }
}