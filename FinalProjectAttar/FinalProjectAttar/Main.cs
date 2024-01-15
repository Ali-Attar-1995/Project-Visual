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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            carReg car = new carReg();
            this.Hide();
            car.Show();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            this.Hide();
            c.Show();
        }

        private void btRental_Click(object sender, EventArgs e)
        {
            rental r = new rental();
            this.Hide();
            r.Show();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            returncar r = new returncar();
            this.Hide();
            r.Show();
        }

        
    }
}
