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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void managerBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager m = new Manager();
            m.Show();
        }

        private void chefBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef c = new Chef();
            c.Show();
        }

        private void waiterBox_Click(object sender, EventArgs e)
        {

            this.Hide();
            Waiter w = new Waiter();
            w.Show();
        }

        private void cashBox_Click(object sender, EventArgs e)
        {

            this.Hide();
            Cash c = new Cash();
            c.Show();
        }

        private void menuBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu n = new Menu();
            n.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
        

        private void orderBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order o= new Order();
            o.Show();
        }

        private void tableBox_Click(object sender, EventArgs e)
        {
            this.Hide();
             Table t = new Table();
            t.Show();
        }

        private void customerBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer c = new Customer();
            c.Show();
        }

        private void billBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill b = new Bill();
            b.Show();
        }
    }
}
