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
    public partial class DeleteT : Form
    {
        public DeleteT()
        {
            InitializeComponent();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Table t= new Table();
            t.Show();
        }
    }
}
