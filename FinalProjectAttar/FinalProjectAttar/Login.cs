using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectMokdad_Attar
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            String name = txtUser.Text;
            String pass = txtPass.Text;

            if (name == "Admin" && pass == "Admin")
            {
                Main m = new Main();
                this.Hide();
                m.Show();
            }
            else if(name == "Employee" && pass == "12345"){
                Main2 m = new Main2();
                this.Hide();
                m.Show();
            }
            else{
                MessageBox.Show("Username or Password doesn't match");
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
