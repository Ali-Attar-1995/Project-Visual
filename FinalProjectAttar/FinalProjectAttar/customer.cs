using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectMokdad_Attar
{
    public partial class customer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ALI-ATTAR;Initial Catalog=Cars;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        bool Mode = true;
        String id;
        public customer()
        {
            InitializeComponent();
        }

        public void load()
        {

            cmd.CommandText = "select * From Customer";
            cmd.Connection = con;
            con.Open();
            try
            {
                DataTable Customer = new DataTable();
                reader = cmd.ExecuteReader();
                Customer.Load(reader);
                reader.Close();
                grid_cus.DataSource = Customer;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        public void Clear()
        {
            txtid.Enabled = true;
            Mode = true;
            txtid.Clear();
            txtname.Clear();
            txtad.Clear();
            txtmobile.Clear();
            txtid.Focus();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            load();
        }

        private void grid_cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Mode = false;
                id = grid_cus.CurrentRow.Cells[0].Value.ToString();

                txtid.Enabled = false;
                cmd.CommandText = "Select * From Customer where cid = '" + id + "'";
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    txtid.Text = reader[0].ToString();
                    txtname.Text = reader[1].ToString();
                    txtad.Text = reader[2].ToString();
                    txtmobile.Text = reader[3].ToString();
                }
                con.Close();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (txtid.Text.Trim().Length == 0 || txtname.Text.Trim().Length == 0 || txtad.Text.Trim().Length == 0
                || txtmobile.Text.Trim().Length == 0)
            {


                MessageBox.Show("All Fields Are Required");


            }
            else { 

            if (Mode == true)
            {

                cmd.CommandText = "Insert INTO Customer (cid,cusname,address,mobile) VALUES " +
                    "('" + txtid.Text.ToString() + "','" + txtname.Text.ToString() + "','" + txtad.Text.ToString() + "','" + txtmobile.Text.ToString() + "')";
                cmd.Connection = con;
                con.Open();
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally { con.Close(); }

                load();
                Clear();
            }

            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            String name = txtname.Text.ToString();
            String address = txtad.Text.ToString();
            String mobile = txtmobile.Text.ToString();
            if (Mode == false)
            {
                cmd.CommandText = "Update Customer Set cusname = '" + name + "',address='" + address + "',mobile='" + mobile + "' Where cid ='" + id + "'";
                cmd.Connection = con;
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }

                load();
                Clear();
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (Mode == false)
            {
                cmd.CommandText = "Delete From Customer Where cid ='" + id + "'";
                cmd.Connection = con;
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }

                load();
                Clear();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
             Main m = new Main();
             this.Hide();
            m.Show();
        }
    }
}
