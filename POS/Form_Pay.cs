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

namespace POS
{
    public partial class Form_Pay : MetroFramework.Forms.MetroForm
    {
        public Form_Pay()
        {
            InitializeComponent();
        }

        private void Form_Pay_Load(object sender, EventArgs e)
        {
            remplir_listes_order_no_payee();
        }

        public void remplir_listes_order_no_payee()
        {
            foreach (Control item in flowLayoutPanel_list_des_orders_non_payee.Controls.OfType<TabPage>())
            {
                flowLayoutPanel_list_des_orders_non_payee.Controls.Remove(item);
            }

            Database.connecter();
            String query = "select t.id,c.name,t.restaurant_table,sum(o.Quantite * p.price) total from the_order t inner join Ordre_details o on o.order_id = t.id inner join products p on p.id = o.product_id inner join customer c on c.id = t.customer_id group by t.id,c.name,t.restaurant_table";
            SqlCommand command = new SqlCommand(query, Database.Con);
            SqlDataReader reader = command.ExecuteReader();
            Panel b = new Panel();
            b.Size = new Size(640, 25);
            Panel customer_name0 = new Panel();
            Label p_title0 = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            p_title0.Text = "CLient";

            p_title0.Size = new Size(120, 24);
            p_title0.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
            p_title0.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            p_title0.Font = new Font("Arial", 9, FontStyle.Bold);


            customer_name0.Size = new Size(129, 24);

            customer_name0.Controls.Add(p_title0);
            b.Controls.Add(customer_name0);



            Panel n_tab0 = new Panel();
            Label n_tab_label0 = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            n_tab_label0.Text = "numero table";

            n_tab_label0.Size = new Size(120, 24);
            n_tab_label0.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
            n_tab_label0.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            n_tab_label0.Font = new Font("Arial", 9, FontStyle.Bold);


            n_tab0.Size = new Size(129, 24);
            n_tab0.Location = new Point(129, 0);

            n_tab0.Controls.Add(n_tab_label0);
            b.Controls.Add(n_tab0);



            Panel total_panel0 = new Panel();
            Label total_label0 = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            total_label0.Text ="Total";

            total_label0.Size = new Size(120, 24);
            total_label0.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
            total_label0.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            total_label0.Font = new Font("Arial", 9, FontStyle.Bold);


            total_panel0.Size = new Size(129, 24);
            total_panel0.Location = new Point(258, 0);

            total_panel0.Controls.Add(total_label0);
            b.Controls.Add(total_panel0);


            flowLayoutPanel_list_des_orders_non_payee.Controls.Add(b);


            while (reader.Read())
            {
                int id_order = (int)reader[0];
                String name_customer = (string)reader[1];
                int n_table = (int)reader[2];
                float total = float.Parse(reader[3].ToString());
                //***********************************************
                Panel p = new Panel();
                p.Size = new Size(640, 25);


                Label id = new Label();
                id.Text = id_order.ToString();
                id.Visible = false;
                id.Name = "id";
                p.Controls.Add(id);







                Panel customer_name = new Panel();
                Label p_title = new Label()
                {
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                p_title.Text = name_customer;

                p_title.Size = new Size(120, 24);
                p_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
                p_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
                p_title.Font = new Font("Arial", 9, FontStyle.Bold);


                customer_name.Size = new Size(129, 24);
              
                customer_name.Controls.Add(p_title);
                p.Controls.Add(customer_name);

                Panel n_tab = new Panel();
                Label n_tab_label = new Label()
                {
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                n_tab_label.Text = n_table.ToString();

                n_tab_label.Size = new Size(120, 24);
                n_tab_label.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
                n_tab_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
                n_tab_label.Font = new Font("Arial", 9, FontStyle.Bold);


                n_tab.Size = new Size(129, 24);
                n_tab.Location = new Point(129, 0);

                n_tab.Controls.Add(n_tab_label);
                p.Controls.Add(n_tab);

                //***
                Panel total_panel = new Panel();
                Label total_label = new Label()
                {
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                total_label.Text = total.ToString();

                total_label.Size = new Size(120, 24);
                total_label.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
                total_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
                total_label.Font = new Font("Arial", 9, FontStyle.Bold);


                total_panel.Size = new Size(129, 24);
                total_panel.Location = new Point(258, 0);

                total_panel.Controls.Add(total_label);
                p.Controls.Add(total_panel);


                PictureBox delete_title = new PictureBox();
                delete_title.Image = Image.FromFile("../images/cash.png");

                delete_title.Size = new Size(24, 24);
                //delete_title.Location = new Point(52, 0);
               
                //delete_title.Click += new EventHandler(delete_item);
                Panel delete_title_panel = new Panel();

                delete_title_panel.Size = new Size(129, 34);
                delete_title_panel.Location = new Point(400, 0);
                delete_title_panel.Controls.Add(delete_title);
                p.Controls.Add(delete_title_panel);






                flowLayoutPanel_list_des_orders_non_payee.Controls.Add(p);

            }

            }
    }
}
