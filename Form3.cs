﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests_Planetas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labRezultats.Text = Form2.punkti + " balles";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void labRezultats_Click(object sender, EventArgs e)
        {
            labRezultats.Text = Form2.punkti + " balles";
        }
    }
}
