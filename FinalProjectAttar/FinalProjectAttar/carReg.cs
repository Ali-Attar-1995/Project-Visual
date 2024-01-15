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
    public partial class carReg : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ALI-ATTAR;Initial Catalog=Cars;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        bool Mode = true;
        String id;
        public carReg()
        {
            InitializeComponent();
        }

        public void load()
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

        public void Clear()
        {
            txtregno.Enabled = true;
            Mode = true;
            txtregno.Clear();
            txttype.Clear();
            txtmodel.Clear();
            
            txtfee.Clear();
            txtregno.Focus();
        }

        private void carReg_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (txtregno.Text.Trim().Length == 0 || txttype.Text.Trim().Length == 0 || txtmodel.Text.Trim().Length == 0
                || txtfee.Text.Trim().Length == 0) {


                MessageBox.Show("All Fields Are Required");


            }
            else { 
            
            String id = txtregno.Text.ToString();
            String type = txttype.Text.ToString();
            String model = txtmodel.Text.ToString();
            String av = txtAv.SelectedItem.ToString();
            String fee = txtfee.Text.ToString();
            
            if (Mode == true)
            {


                cmd.CommandText = "Insert Into Car (RegNo,Type,Model,Available,fee) Values" + 
                    "('" + id + "','" + type + "','" + model + "','" + av + "','"+fee+"')";
                cmd.Connection = con;
                con.Open();
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Added");


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

        private void grid_car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Mode = false;
                id = grid_car.CurrentRow.Cells[0].Value.ToString();

                txtregno.Enabled = false;
                cmd.CommandText = "Select * From Car where RegNo = '" + id + "'";
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    txtregno.Text = reader[0].ToString();
                    txttype.Text = reader[1].ToString();
                    txtmodel.Text = reader[2].ToString();
                    txtAv.Text = reader[3].ToString();
                    txtfee.Text = reader[4].ToString();
                }
                con.Close();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            
            String type = txttype.Text.ToString();
            String model = txtmodel.Text.ToString();
            String av = txtAv.SelectedItem.ToString();
            String fee = txtfee.Text.ToString();
            if (Mode == false)
            {
                cmd.CommandText = "Update Car Set type = '" + type + "',model='" + model + "',available='" + av + "',fee='" + fee + "'Where RegNo ='" + id + "'";
                cmd.Connection = con;
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Updated");

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
                cmd.CommandText = "Delete From Car Where RegNo ='" + id + "'";
                cmd.Connection = con;
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted");

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
