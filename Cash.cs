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
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddS s = new AddS();
            s.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteS s = new DeleteS();
            s.Show();
        }

        private void cASHIERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cASHIERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Cash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.CASHIER' table. You can move, or remove it, as needed.
            this.cASHIERTableAdapter.Fill(this.dataSet.CASHIER);

        }
    }
}
