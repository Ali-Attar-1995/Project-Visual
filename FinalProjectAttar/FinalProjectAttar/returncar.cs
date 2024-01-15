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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinalProjectMokdad_Attar
{
    public partial class returncar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ALI-ATTAR;Initial Catalog=Cars;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        bool Mode = true;
        String id;

        int Fine;

        public returncar()
        {
            InitializeComponent();
        }

       public void returnload()
        {
            cmd.CommandText = "SELECT * From ReturnCar";
            cmd.Connection = con;
            con.Open();
            try {
            
                DataTable dt = new DataTable();
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                grid_return.DataSource = dt;

            
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        public void Rentload()
        {
            cmd.CommandText = "select * From Rental ";
            cmd.Connection = con;
            con.Open();
            try
            {
                DataTable Rent = new DataTable();
                reader = cmd.ExecuteReader();
                Rent.Load(reader);
                reader.Close();
                grid_rented.DataSource = Rent;

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
            txtcid.Clear();
            txtcusid.Clear();
            txtdate.Clear();
            txtelp.Clear();
            txtfine.Clear();
        }

        private void returncar_Load(object sender, EventArgs e)
        {
            returnload();
            Rentload();
        }

        private void grid_rented_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                id = grid_rented.CurrentRow.Cells[0].Value.ToString();
                
                cmd.CommandText = "Select * From Rental Where id = '" + id + "'";
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtcid.Text = reader[1].ToString();
                    txtcusid.Text = reader[2].ToString();
                    txtdate.Text = reader[6].ToString();
                    
                }
                con.Close();
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {

            if (txtcid.Text.Trim().Length == 0 || txtcusid.Text.Trim().Length == 0 || txtdate.Text.Trim().Length == 0
                || txtelp.Text.Trim().Length == 0)
            {


                MessageBox.Show("All Fields Are Required");


            }
            else { 

            String cid = txtcid.Text.ToString();
            String cusid = txtcusid.Text.ToString();
            String date = txtdate.Text.ToString();
            String elp = txtelp.Text.ToString();
            
           

            if (Mode == true)
            {
                cmd.CommandText = "Insert INTO ReturnCar (car_id,cus_id,date,elp,fine) VALUES " +
                   "('" + cid + "','" + cusid + "','" + date + "','" + elp + "','" + Fine.ToString() + "')";
                cmd.Connection = con;
                con.Open();
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Returned");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }

                cmd.CommandText = "Update Car Set available = 'YES' Where Regno='" + cid + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                returnload();
                



                cmd.CommandText = "Delete From Rental Where id ='"+id+"'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Rentload();
                Clear();
            }

            }


        }

        private void txtelp_TextChanged(object sender, EventArgs e)
        {
            if (txtelp.Text.Trim().Length > 0)
            {
                Fine = Convert.ToInt32(txtelp.Text) * 10;
                txtfine.Text = Fine.ToString();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.Show();
        }
    }
}
