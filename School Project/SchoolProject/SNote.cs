﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class SNote : Form
    {
        public SNote(string name, string id)
        {
            InitializeComponent();
            IDtextBox1.Text = id;
            NametextBox2.Text = name;
        }

        private void SNote_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentPannel fr = new StudentPannel(6,NametextBox2.Text,NametextBox2.Text);
            fr.Show();
        }
    }
}
