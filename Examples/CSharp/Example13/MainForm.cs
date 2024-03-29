﻿using System;
using System.Windows.Forms;

namespace Example13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonParty_Click(object sender, EventArgs e)
        {
            PartyForm pf = new PartyForm();
            pf.ShowDialog();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}