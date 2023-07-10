using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restuarant_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Samantha\source\Restuarant\Restuarant management system\Restuarant management system\RestDatabase.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where USERNAME='" + textBox1.Text + "'and PASSWORD='" + textBox2.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home h = new Home();
                h.Show();

            }
            else
                MessageBox.Show("Invalid username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);



            

        }
    }
}
