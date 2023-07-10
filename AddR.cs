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
    public partial class AddR : Form
    {
        public AddR()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c = new Customer();
            c.Show();
        }

        private void AddR_Load(object sender, EventArgs e)
        {

        }
    }
}
