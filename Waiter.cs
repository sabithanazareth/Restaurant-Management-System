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
    public partial class Waiter : Form
    {
        public Waiter()
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
            AddW a = new AddW();
            a.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            this.Hide();
            DeleteW d = new DeleteW();
            d.Show();
        }

        private void wAITERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wAITERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Waiter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.WAITER' table. You can move, or remove it, as needed.
            this.wAITERTableAdapter.Fill(this.dataSet.WAITER);

        }

        
    }
}
