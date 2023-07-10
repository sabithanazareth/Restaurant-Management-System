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
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddC a = new AddC();
            a.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            DeleteC c = new DeleteC();
            c.Show();
        }

        private void cHEFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHEFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        
    }
}
