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
    public partial class Form1 : Form
    {

        private SQLConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            conn = new SQLConnection();
            string permitN = "1";
            conn.retrieveContactList();
            conn.createNewPermit(permitN, (permit_type_box.SelectedItem).ToString(), club_name_textBox.Text, applicant_name_textBox.Text, track_name_textBox.Text, start_picker.Value.Date, end_picker.Value.Date);
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
