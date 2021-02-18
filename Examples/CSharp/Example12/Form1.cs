using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Example12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxCount.Text = "0";
        }

        private ClassStatistics cs = new ClassStatistics();

        /// <summary>
        /// برای خالی کردن اشیاء و بارگذاری مجدد فرم
        /// </summary>
        private void RestartForm()
        {
            textBoxInputNumber.Clear();
            listBoxInputNumber.Items.Clear();
            richTextBoxResult.Clear();
            textBoxCount.Text = "0";
        }

        private void AddCounter()
        {
            textBoxCount.Text = cs.CountOfItems(listBoxInputNumber.Items.Cast<double>().ToList()).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            RestartForm();
        }

        private void buttonAddValue_Click(object sender, EventArgs e)
        {
            double? InputNumber;
            InputNumber = cs.NumberOfText(textBoxInputNumber.Text);

            if (InputNumber == null)
            {
                MessageBox.Show("لطفا مقدار ورودی را از نوع صحیح یا اعشاری وارد نمایید", "عدد ورودی",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBoxInputNumber.Items.Add(InputNumber);
                AddCounter();
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxResult.Clear();

                if (textBoxCount.Text != "0")
                {
                    if (radioButtonArithmeticAvg.Checked == true)
                    {                        
                        richTextBoxResult.Text =
                            cs.ArithmeticAvg(listBoxInputNumber.Items.Cast<double>().ToList());
                    }
                    else if (radioButtonWeightedAvg.Checked == true)
                    {
                        richTextBoxResult.Text =
                        cs.WeightedAvg(listBoxInputNumber.Items.Cast<double>().ToList());
                    }
                    else if (radioButtonGeometricAvg.Checked == true)
                    {
                        richTextBoxResult.Text =
                            cs.GeometricAvg(listBoxInputNumber.Items.Cast<double>().ToList());
                    }
                    else if (radioButtonHarmonicAvg.Checked == true)
                    {
                        richTextBoxResult.Text =
                            cs.HarmonicAvg(listBoxInputNumber.Items.Cast<double>().ToList());
                    }
                    else if (radioButtonVariance.Checked == true)
                    {
                        richTextBoxResult.Text =
                            cs.Variance(listBoxInputNumber.Items.Cast<double>().ToList());
                    }
                    else if (radioButtonStandardDeviation.Checked == true)
                    {
                        richTextBoxResult.Text =
                            cs.StandardDeviation(listBoxInputNumber.Items.Cast<double>().ToList());
                    }
                    else if (radioButtonCountOfSortNumber.Checked == true)
                    {
                        richTextBoxResult.Text =
                            cs.CountOfSortNumber(cs.SortListNumbers(listBoxInputNumber.Items.Cast<double>().ToList()));
                    }
                    else if (radioButtonSortList.Checked == true)
                    {
                        richTextBoxResult.Text =
                            cs.ListToText(cs.SortListNumbers(listBoxInputNumber.Items.Cast<double>().ToList()));
                    }
                }
                else
                {
                    MessageBox.Show("لیست ورودی خالی می باشد", "عدم وجود دیتا", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی رخ داده است");
                throw;
            }
        }
    }
}