﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANT
{
    public partial class MAIN : Form
    {
        
        private Form1 myForm;

        public MAIN()
        {
            InitializeComponent();
            permit_gridview.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            myForm = new Form1();
            myForm.Show();

        }

        private void permit_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
