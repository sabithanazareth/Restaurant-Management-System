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
    public partial class Bill : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\sony\Desktop\Restuarant management system\Restuarant management system\RestDatabase.mdf;Integrated Security=True");
        public Bill()
            {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void bILLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bILLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Bill_Load(object sender, EventArgs e)
        {
           /* // TODO: This line of code loads data into the 'dataSet1.MANAGER' table. You can move, or remove it, as needed.
            this.mANAGERTableAdapter.Fill(this.dataSet1.MANAGER);
            // TODO: This line of code loads data into the 'dataSet1.BILL' table. You can move, or remove it, as needed.
            this.bILLTableAdapter.Fill(this.dataSet1.BILL);*/

        }

        private void bILLDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {



            disp_data();
        }
            public void disp_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "select e.ssn,e.name,d.dno,d.dname from employee e ,department d where e.dno=d.dno ";
            cmd.CommandText = "select * from BILL where order_no=@ord";
            cmd.Parameters.Add("@ord", SqlDbType.VarChar).Value = textBox6.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
    
}
