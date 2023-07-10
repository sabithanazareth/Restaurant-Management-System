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
    public partial class DeleteC : Form
    {
        public DeleteC()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef c = new Chef();
            c.Show();
        }
    }
}
