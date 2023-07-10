using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restuarant_management_system
{
    public partial class CloseOrder : Form
    {
        public CloseOrder()
        {
            InitializeComponent();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order d = new Order();
            d.Show();
        }
    }
}
