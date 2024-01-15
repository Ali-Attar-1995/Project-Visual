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
using System.Xml.Linq;

namespace FinalProjectMokdad_Attar
{
    public partial class rental : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ALI-ATTAR;Initial Catalog=Cars;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        bool Mode = true;
        String id;
        int Totalfee;
        public rental()
        {
            InitializeComponent();
        }

        private void rental_Load(object sender, EventArgs e)
        {
            load();
            carload();
            cusload();
        }
        public void cusload()
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
        public void carload()
        {
            cmd.CommandText = "select * From Car";
            cmd.Connection = con;
            con.Open();
            try
            {
                DataTable Car = new DataTable();
                reader = cmd.ExecuteReader();
                Car.Load(reader);
                reader.Close();
                grid_car.DataSource = Car;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        public void load()
        {
            dt_Date.MinDate = DateTime.Now;
            dt_Due.MinDate = DateTime.Now;
            cmd.CommandText = "select * From Rental";
            cmd.Connection = con;
            con.Open();
            try
            {
                DataTable Rent = new DataTable();
                reader = cmd.ExecuteReader();
                Rent.Load(reader);
                reader.Close();
                grid_rental.DataSource = Rent;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        public void Clear()
        {
            Mode = true;
            txtId.Clear();
            txtcusname.Clear();
            txtcusid.Clear();
            txtfee.Clear();
            dt_Date.MinDate = DateTime.Now;
            dt_Due.MinDate = DateTime.Now;
        }

        private void grid_car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = grid_car.CurrentRow.Cells[0].Value.ToString();
                cmd.CommandText = "Select * From Car where RegNo = '" + id + "'";
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    txtId.Text = reader[0].ToString();
                    lbAv.Text = reader[3].ToString();
                    txtfee.Text = reader[4].ToString();

                    if (lbAv.Text == "No")
                    {
                        
                        dt_Date.Enabled = false;
                        dt_Due.Enabled = false;
                    }
                    else
                    {
                        
                        dt_Date.Enabled = true;
                        dt_Due.Enabled = true;
                    }

                }
                con.Close();
            }
        }

        private void grid_cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                id = grid_cus.CurrentRow.Cells[0].Value.ToString();

       
                cmd.CommandText = "Select * From Customer where cid = '" + id + "'";
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    txtcusid.Text = reader[0].ToString();
                    txtcusname.Text = reader[1].ToString();
                    
                }
                con.Close();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length == 0 || txtcusid.Text.Trim().Length == 0 || txtcusname.Text.Trim().Length == 0
                || txtfee.Text.Trim().Length == 0)
            {


                MessageBox.Show("All Fields Are Required");


            }
            else if(lbAv.Text == "YES") { 



            String carid = txtId.Text;
            String cid = txtcusid.Text;
            String cusname = txtcusname.Text;
            String fee = txtfee.Text;
            String date = dt_Date.Value.Date.ToString("yyyy-MM-dd");
            String due = dt_Due.Value.Date.ToString("yyyy-MM-dd");

            if (Mode == true)
            {
                cmd.CommandText = "Insert INTO Rental (car_id,cus_id,cusname,fee,date,duedate) VALUES " +
                    "('" + carid + "','" + cid + "','" + cusname + "','" + Totalfee.ToString() + "','" + date + "','" + due + "')";
                cmd.Connection = con;
                con.Open();
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally { con.Close(); }

                cmd.CommandText = "Update Car Set available = 'No' Where Regno='" + carid + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                load();
                carload();
                Clear();
            }

            }
            else
            {
                MessageBox.Show("Car Not Available");
            }
        }

        private void btFee_Click(object sender, EventArgs e)
        {
            DateTime Startdate = dt_Date.Value;
            DateTime Enddate = dt_Due.Value;
            TimeSpan days = Enddate.Subtract(Startdate);
            int day = days.Days + 1;
            
            
            Totalfee = day * Convert.ToInt32(txtfee.Text.ToString());

            MessageBox.Show(Totalfee.ToString());

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
    }
}
