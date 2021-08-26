using System;
using System.Windows.Forms;

namespace Example14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int x, y;
            if (Int32.TryParse(textBoxTool.Text, out x) == false)
            {
                MessageBox.Show("مقدار طول باید عدد صحیح باشد.");
            };

            if (Int32.TryParse(textBoxArz.Text, out y) == false)
            {
                MessageBox.Show("مقدار عرض باید عدد صحیح باشد.");
            };

            int Mohit, Masahat;

            Mohit = 2 * (x + y);
            Masahat = x * y;

            labelMohit.Text = "محیط مستطیل برابر است با " + Mohit.ToString();
            labelMasahat.Text = "مساحت مستطیل برابر است با " + Masahat.ToString();
            linkLabelMostatil.Text = "https://fa.wikipedia.org/wiki/مستطیل";
            linkLabelMasahat.Text = "https://fa.wikipedia.org/wiki/مساحت";
        }

        private void linkLabelMostatil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelMostatil.LinkVisited = true;
        }

        private void linkLabelMasahat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelMasahat.LinkVisited = true;
        }
    }
}