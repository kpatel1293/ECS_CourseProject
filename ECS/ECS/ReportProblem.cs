﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECS
{
    public partial class ReportProblem : Form
    {
        public ReportProblem()
        {
            InitializeComponent();
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
