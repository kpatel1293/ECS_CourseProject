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
    public partial class ChkOutFrom : Form
    {
        public ChkOutFrom()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
