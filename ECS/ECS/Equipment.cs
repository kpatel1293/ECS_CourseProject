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
    public partial class Equipment : Form
    {
        Depot dFrm = new Depot();
        ChkOutFrom chkFrm = new ChkOutFrom();

        public Equipment()
        {
            InitializeComponent();
        }

        private void depotBtn_Click(object sender, EventArgs e)
        {
            dFrm.ShowDialog();
        }

        private void chkOutBtn_Click(object sender, EventArgs e)
        {
            chkFrm.ShowDialog();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipCheckoutSystemDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.equipCheckoutSystemDataSet.Equipment);

        }
    }
}
