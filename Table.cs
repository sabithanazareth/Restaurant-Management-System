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
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddT a = new AddT();
            a.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteT t = new DeleteT();
            t.Show();
        }

        private void tABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Table_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.TABLE' table. You can move, or remove it, as needed.
            this.tABLETableAdapter.Fill(this.dataSet.TABLE);

        }
    }
}
