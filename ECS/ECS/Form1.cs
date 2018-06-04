using System;
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
    public partial class Form1 : Form
    {
        Equipment equipFrm = new Equipment();
        Employee empFrm = new Employee();

        public Form1()
        {
            InitializeComponent();
        }

        private void equipBtn_Click(object sender, EventArgs e)
        {
            equipFrm.ShowDialog();
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            empFrm.ShowDialog();
        }

        private void welTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
