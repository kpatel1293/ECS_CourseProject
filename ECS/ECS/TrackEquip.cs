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
    public partial class TrackEquip : Form
    {
        public TrackEquip()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
