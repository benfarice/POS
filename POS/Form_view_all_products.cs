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
    public partial class Form_view_all_products : MetroFramework.Forms.MetroForm
    {
        public Form_view_all_products()
        {
            InitializeComponent();
        }

        private void Form_view_all_products_Load(object sender, EventArgs e)
        {
            fill_dataGrid();
            fill_combo_filter();
        }
        public void fill_dataGrid()
        {
            dataGridView_all_products.DataSource = Database.get_products();
        }
        public void fill_combo_filter()
        {
            DataTable t = Database.get_products_catgs();
            metroComboBox_filter.DataSource = t;
            metroComboBox_filter.DisplayMember = "name";
            metroComboBox_filter.ValueMember = "id";
        }

        private void metroComboBox_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView_all_products.DataSource = Database.get_products_by_cat(int.Parse(metroComboBox_filter.SelectedValue.ToString()));
        }

        private void metroButton_tous_Click(object sender, EventArgs e)
        {
            dataGridView_all_products.DataSource = Database.get_products();
        }
    }
}
