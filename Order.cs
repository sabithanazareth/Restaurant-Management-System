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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CloseOrder d = new CloseOrder();
            d.Show();
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewOrder n = new NewOrder();
            n.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void oRDERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void oRDERBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.dataSet.ORDER);

        }

      
    }
    }

