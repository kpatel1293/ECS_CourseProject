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
    public partial class Employee : Form
    {
        Manager mngfrm = new Manager();

        public Employee()
        {
            InitializeComponent();
        }

        private void MangerBtn_Click(object sender, EventArgs e)
        {
            mngfrm.ShowDialog();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipCheckoutSystemDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.equipCheckoutSystemDataSet.Employee);
            // TODO: This line of code loads data into the 'equipCheckoutSystemDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.equipCheckoutSystemDataSet.Equipment);

        }
    }
}
