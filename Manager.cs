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
    public partial class Manager : Form
    {
        public Manager()
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
            AddM a = new AddM();
            a.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteM d = new DeleteM();
            d.Show();
        }

        private void mANAGERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mANAGERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }


        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.MANAGER' table. You can move, or remove it, as needed.
            this.mANAGERTableAdapter.Fill(this.dataSet.MANAGER);

        }

    }
}
