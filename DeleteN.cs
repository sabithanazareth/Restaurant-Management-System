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
    public partial class DeleteN : Form
    {
        public DeleteN()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu n = new Menu();
            n.Show();
        }
    }
}
