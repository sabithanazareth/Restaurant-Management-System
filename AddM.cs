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
    public partial class AddM : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\sony\Desktop\Restuarant management system\Restuarant management system\RestDatabase.mdf;Integrated Security=True");

        public AddM()
        {
            InitializeComponent();
            Display();
        }

        private void addButton_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();


            string s = "insert into MANAGER(MANAGER_ID,NAME,GENDER,CONTACT_NO,ORDER_NO) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(s, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("data inserted");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            Display();
        }

        void Display()
        {

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM MANAGER", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DMM.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = DMM.Rows.Add();
                    DMM.Rows[n].Cells[0].Value = item[0].ToString();
                    DMM.Rows[n].Cells[1].Value = item[1].ToString();
                    DMM.Rows[n].Cells[2].Value = item[2].ToString();
                    DMM.Rows[n].Cells[3].Value = item[3].ToString();
                    DMM.Rows[n].Cells[4].Value = item[4].ToString();
                    

                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {

            }
            catch (System.NullReferenceException ex)
            {

            }

        }

    }
}
