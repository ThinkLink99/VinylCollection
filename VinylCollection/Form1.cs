﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinylCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlOwner.Items.Add("Trey");
            ddlOwner.Items.Add("Dilly");
            ddlOwner.Items.Add("Pav");
            ddlOwner.Items.Add("JP");

            ddlOwner.SelectedIndex = 0;
            ddlDay.SelectedIndex = 0;
            ddlMonth.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
