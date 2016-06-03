﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            panel_next.Visible = true;
            panel_back.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            panel_next.Visible = false;
            panel_back.Visible = true;
        }
    }
}