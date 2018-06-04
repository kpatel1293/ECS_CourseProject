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
    public partial class Manager : Form
    {
        ReportProblem repFrm = new ReportProblem();
        AddNewEmployee addFrm = new AddNewEmployee();

        public Manager()
        {
            InitializeComponent();
        }

        private void probBtn_Click(object sender, EventArgs e)
        {
            repFrm.ShowDialog();
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            addFrm.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
     
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }
    }
}
