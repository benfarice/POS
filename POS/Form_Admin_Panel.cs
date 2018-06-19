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
    public partial class Form_Admin_Panel : MetroFramework.Forms.MetroForm
    {
        public Form_Admin_Panel()
        {
            InitializeComponent();
        }

        private void Form_Admin_Panel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_add_product_btn_Click(object sender, EventArgs e)
        {
            Form_add_product f = new Form_add_product();
            f.Show();
        }

        private void pictureBox_view_all_products_btn_Click(object sender, EventArgs e)
        {
            Form_view_all_products f = new Form_view_all_products();
            f.Show();
        }

        private void pictureBox_setting_products_btn_Click(object sender, EventArgs e)
        {
            Form_settings_products f = new Form_settings_products();
            f.Show();
        }
    }
}
