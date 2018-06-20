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
    public partial class Form_products_chart : MetroFramework.Forms.MetroForm
    {
        public Form_products_chart()
        {
            InitializeComponent();
        }

        private void Form_products_chart_Load(object sender, EventArgs e)
        {
            afficher_chart();
        }
        public void afficher_chart()
        {
            chart_products.DataSource = Database.get_display_sales_chart();

            chart_products.Series["Series1"].XValueMember = "name";
            chart_products.Series["Series1"].YValueMembers= "nbr";
            chart_products.Series["Series1"].Name = "Produits";


           

            chart_products.DataBind();
            chart_products.Show();
        }
    }
}
