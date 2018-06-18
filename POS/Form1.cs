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
    public partial class Form_login : MetroFramework.Forms.MetroForm
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton_connexion_btn_Click(object sender, EventArgs e)
        {
          

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            taper_number("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            taper_number("2");
        }
        public void taper_number(string number)
        {
            if (metroRadioButton_Votre_ID.Checked)
            {
                metroTextBox_username.Text += number;
            }
            else if (metroRadioButton_password.Checked)
            {
                metroTextBox_password.Text += number;
            }
        }
        public void vider_number()
        {
            if (metroRadioButton_Votre_ID.Checked)
            {
                metroTextBox_username.Text = "";
            }
            else if (metroRadioButton_password.Checked)
            {
                metroTextBox_password.Text = "";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            taper_number("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            taper_number("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            taper_number("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            taper_number("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            taper_number("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            taper_number("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            taper_number("9");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            taper_number("0");
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            vider_number();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string username = metroTextBox_username.Text;
            string password = metroTextBox_password.Text;
            if (username != "" && username != null && password != "" && password != null)
            {
                Boolean has_account = Database.connect_user(username, password);
                if (has_account)
                {
                    Program.username_loged_in = username;
                    Form_Home f = new Form_Home();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vous n'avez pas encore de compte");
                }

            }
            else
            {
                MessageBox.Show("Les champs sont vides");
            }
        }
    }
}
