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
    public partial class Menu : Form
    {
        public Menu()
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
            AddN a = new AddN();
            a.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteN d= new DeleteN();
            d.Show();
        }

        private void mENUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mENUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.MENU' table. You can move, or remove it, as needed.
            this.mENUTableAdapter.Fill(this.dataSet.MENU);

        }
    }
}
