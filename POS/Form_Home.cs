using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form_Home : MetroFramework.Forms.MetroForm
    {
        public static bool he_is_in_work = false;
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }

        private void metroButton_ok_employee_Click(object sender, EventArgs e)
        {
           
            
        }

        private void metroButton_get_order_Click(object sender, EventArgs e)
        {
           
        }
        public void design_layout()
        {

        }

        private void metroButton_Paiement_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!he_is_in_work)
            {
                metroRadioButton_arrive.Text = "Je sortis de l'emploi";
                metroRadioButton_pausse.Enabled = true;
                he_is_in_work = true;
                Database.employee_arrived(Program.username_loged_in);
            }
            else
            {

            }
        }

        private void metroButton_autre_employees_ok_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form_Order o = new Form_Order(-1);
            o.Show();
            this.Hide();
        }

        private void metroButton_gestion_orders_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form_Pay f = new Form_Pay();
            //f.Show();
            //this.Hide();
            f.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form_Admin_Panel f = new Form_Admin_Panel();
            f.Show();
            this.Hide();
        }
    }
}
