using System;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalculateEnable();
        }

        private void CalculateEnable()
        {
            buttonCalculate.Enabled = Convert.ToBoolean(textBoxSalary.Text.Length);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int Salary;
            string Result;
            int SalaryTax;

            int.TryParse(textBoxSalary.Text, out Salary);

            if (Salary < 500000)
            {
                SalaryTax = Salary * 0;
            }
            else
            if (Salary < 1000000)
            {
                SalaryTax = Salary * 5 / 100;
            }
            else
            if (Salary < 2000000)
            {
                SalaryTax = Salary * 10 / 100;
            }
            else
                if (Salary < 3000000)
            {
                SalaryTax = Salary * 15 / 100;
            }
            else
            {
                SalaryTax = Salary * 20 / 100;
            }

            Result ="\n"+ textBoxName.Text + 
                " your tax is = " + SalaryTax.ToString() + "T"+
                "\nYour Pure salary is = " + (Salary - SalaryTax).ToString() +"T";

            labelResult.Text = "Result: " + Result;

            MessageBox.Show(Result,"Result");

            textBoxName.Focus();
            textBoxName.SelectAll();
        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {
            CalculateEnable();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxSalary.Clear();
            labelResult.Text = "Result:";
            textBoxName.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            
            dialogResult = MessageBox.Show("Do you want to exit?", "Exit......", MessageBoxButtons.YesNo);

            if (dialogResult==DialogResult.Yes)
            Application.Exit();
        }
    }
}