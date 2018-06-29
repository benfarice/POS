using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;
using MetroFramework.Controls;

namespace POS
{
    public partial class Form_Order : MetroFramework.Forms.MetroForm
    {
        int idO = -1;
        static ArrayList  list_des_orders = new ArrayList();
        static ArrayList  les_tables_array = new ArrayList();
        static ArrayList  les_customers = new ArrayList();
        static Class_restaurant_table selected_table = new Class_restaurant_table();
        static Class_customer selected_customer = new Class_customer();
        float total_money = 0;
        public Form_Order(int id_order)
        {
            this.idO = id_order;
            InitializeComponent();
           
        }
       
        public void func_tb()
        {
          
            foreach (Control tb in this.Controls)
            {
                if(tb is MetroTextBox)
                {
                    //MessageBox.Show("me");
                    tb.Enter += textBox_Enter;
                    //MessageBox.Show(tb.Name.ToString());
                }
                else
                {
                    //MessageBox.Show("no text box");
                }
                foreach (Control c in tb.Controls)
                {
                    if (c is MetroTextBox)
                    {
                        //MessageBox.Show("me");
                        c.Enter += textBox_Enter;
                        //MessageBox.Show(c.Name.ToString());
                    }
                    else
                    {
                        //MessageBox.Show("no text box");
                    }
                    foreach (Control d in c.Controls)
                    {
                        if (d is MetroTextBox)
                        {
                            //MessageBox.Show("me");
                            d.Enter += textBox_Enter;
                            //MessageBox.Show(d.Name.ToString());
                        }
                        else
                        {
                            //MessageBox.Show("no text box");
                        }
                        foreach (Control p in d.Controls)
                        {
                            if (p is MetroTextBox)
                            {
                                //MessageBox.Show("me");
                                p.Enter += textBox_Enter;
                                //MessageBox.Show(p.Name.ToString());
                            }
                            else
                            {
                                //MessageBox.Show("no text box");
                            }
                            foreach (Control v in p.Controls)
                            {
                                if (v is MetroTextBox)
                                {
                                    //MessageBox.Show("me");
                                    v.Enter += textBox_Enter;
                                    //MessageBox.Show(v.Name.ToString());
                                }
                                else
                                {
                                    //MessageBox.Show("no text box");
                                }
                                foreach (Control w in v.Controls)
                                {
                                    if (w is MetroTextBox)
                                    {
                                        //MessageBox.Show("me");
                                        w.Enter += textBox_Enter;
                                        //MessageBox.Show(w.Name.ToString());
                                    }
                                    else
                                    {
                                        //MessageBox.Show("no text box");
                                    }
                                    foreach (Control q in w.Controls)
                                    {
                                        if (q is MetroTextBox)
                                        {
                                            //MessageBox.Show("me");
                                            q.Enter += textBox_Enter;
                                            //MessageBox.Show(q.Name.ToString());
                                        }
                                        else
                                        {
                                            //MessageBox.Show("no text box");
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
            //MessageBox.Show("func tb executed");

        }
        void textBox_Enter(object sender, EventArgs e)
        {
            Program.focusedTextbox = (MetroTextBox)sender;
            //MessageBox.Show("her");
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {
            //get_gridview_data();
            add_order_details_titles();
            add_items_products();
            add_tables_to_form();
            add_customers_to_form();


            metroTabControl1.SelectedTab = metroTabPage_Choisi_le_produit;
            Program.focusedKeyBoardPanel = panel_keyboard_orders_create;


            create_keyboards();
            func_tb();
            

        }

        public void add_customers_to_form()
        {
            les_customers = Database.get_customers_array();
            foreach(Class_customer s in les_customers)
            {
                add_panel_customer_menu(s);
            }
        }
        public void add_panel_customer_menu(Class_customer r)
        {
            Panel myCustomer = new Panel();
            myCustomer.Size = new Size(95, 130);
            PictureBox img = new PictureBox();
            img.Image = Image.FromFile("../images/man.png");
            img.Location = new Point(15, 0);
            img.Size = new Size(64, 64);
            img.Click += new EventHandler(customer_img_Click);
            myCustomer.Controls.Add(img);
            TextBox tb = new TextBox();
            tb.Text = r.id.ToString();
            tb.Name = "id";
            tb.Visible = false;
            myCustomer.Controls.Add(tb);



            Label l = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,

            };
            l.Text = r.name;
            l.Name = "name";
            l.Click += new EventHandler(customer_img_Click);
            l.Location = new Point(0, 70);
            l.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            l.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            l.Font = new Font("Arial", 9, FontStyle.Bold);
            myCustomer.Controls.Add(l);

            Label l2 = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,

            };
            l2.Text = r.email;
            l2.Name = "email";
            l2.Click += new EventHandler(customer_img_Click);
            l2.Location = new Point(0, 90);
            l2.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            l2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            l2.Font = new Font("Arial", 9, FontStyle.Bold);
            myCustomer.Controls.Add(l2);

            Label l3 = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,

            };
            l3.Text = r.phone;
            l3.Name = "phone";
            l3.Click += new EventHandler(customer_img_Click);
            l3.Location = new Point(0, 110);
            l3.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            l3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            l3.Font = new Font("Arial", 9, FontStyle.Bold);
            myCustomer.Controls.Add(l3);

            flowLayoutPanel_customers_menu.Controls.Add(myCustomer);
          
        }

        protected void customer_img_Click(object sender, EventArgs e)
        {

            Control mylabel = sender as Control;
            foreach (Control c in mylabel.Parent.Controls.OfType<TextBox>())
            {
                if(c.Name == "id")
                {
                    selected_customer.id = int.Parse(c.Text);
                    //MessageBox.Show(selected_customer.id.ToString());
                }
               

            }
            foreach (Control c in mylabel.Parent.Controls.OfType<Label>())
            {
                if (c.Name == "name")
                {
                    selected_customer.name = c.Text;
                    metroTextBox_nom.Text = c.Text;
                    //MessageBox.Show(selected_customer.name);
                }
                if (c.Name == "email")
                {
                    selected_customer.email = c.Text;
                    metroTextBox_email.Text = c.Text;
                }
                if (c.Name == "phone")
                {
                    selected_customer.phone = c.Text;
                    metroTextBox_phone.Text = c.Text;
                }


            }

        }

        public void add_tables_to_form()
        {
            les_tables_array = Database.get_restaurant_tables();
            foreach(Class_restaurant_table ct in les_tables_array)
            {
                add_panel_table_to_select_menu(ct);
            }
        }
        public void add_panel_table_to_select_menu(Class_restaurant_table t)
        {
            Panel coffee_table = new Panel();
            coffee_table.Size = new Size(95, 95);
            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(t.image_url);
            img.Size = new System.Drawing.Size(64, 64);
            img.Location = new Point(15, 0);
            img.Click += new EventHandler(table_img_Click);
            coffee_table.Controls.Add(img);
            TextBox tb = new TextBox();
            tb.Text = t.id.ToString();
            tb.Visible = false;
            tb.Name = "id";
            TextBox dispo_box = new TextBox();
            dispo_box.Text = t.dispo.ToString();
            dispo_box.Visible = false;
            dispo_box.Name = "dispo";
            coffee_table.Controls.Add(dispo_box);
            coffee_table.Controls.Add(tb);
            Label l = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                
            };
            l.Text = t.number;
            l.Location = new Point(0, 70);
            l.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            l.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            l.Font = new Font("Arial", 9, FontStyle.Bold);

            coffee_table.Controls.Add(l);

            coffee_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            flowLayoutPanel_tables.Controls.Add(coffee_table);
        }

        protected void table_img_Click(object sender, EventArgs e)
        {
            
            PictureBox mylabel = sender as PictureBox;
            int is_dispo = 0;
            foreach (Control c in mylabel.Parent.Controls.OfType<TextBox>())
            {
                if (c.Name == "dispo")
                {
                    //MessageBox.Show(c.Text);
                    is_dispo = int.Parse(c.Text);
                }

            }
            if(is_dispo == 0)
            {
                foreach (Control c in mylabel.Parent.Controls.OfType<TextBox>())
                {
                    if (c.Name == "id")
                    {
                        selected_table.id = int.Parse(c.Text);
                        //MessageBox.Show(selected_table.id.ToString());
                    }

                }
                foreach (Control c in mylabel.Parent.Controls.OfType<Label>())
                {
                    selected_table.number = c.Text;
                    //MessageBox.Show(selected_table.number);
                    metroTextBox_numero_table.Text = c.Text;
                }
            }
           

        }

        //protected void table_img_Click(object sender, EventArgs e)
        //{

        //    Label mylabel = sender as Label;
        //    foreach (Control c in mylabel.Parent.Controls.OfType<TextBox>())
        //    {

        //        add_item_to_order(c.Text);

        //    }

        //}

        public void get_gridview_data()
        {
            DataTable t = new DataTable();
            t = Database.get_orders_details(idO);
            //dataGridView_orders_details.DataSource = t;
        }
        public void add_items_products()
        {
            foreach(Control item in products.Controls.OfType<TabPage>())
            {
                products.Controls.Remove(item);
            }

            Database.connecter();
            String query = "select id,name from Categories";
            SqlCommand command = new SqlCommand(query, Database.Con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id_cat = (int)reader[0];
                String cat_name = (string)reader[1];
                TabPage x = new TabPage(cat_name);
                products.TabPages.Add(x);
                FlowLayoutPanel f = new FlowLayoutPanel();
                string query_items = "select id,name,img,barcode,price from products where cat_id = @c";
                SqlCommand command_items = new SqlCommand(query_items,Database.Con);

                command_items.Parameters.Add("@c", SqlDbType.Int);
                command_items.Parameters["@c"].Value = id_cat;

                SqlDataReader r = command_items.ExecuteReader();
               
                while (r.Read())
                {
                    int item_id = (int)r[0];
                    string item_name = (string)r[1];



                    Byte[] data = new Byte[0];
                    data = (Byte[])(r[2]);
                    MemoryStream mem = new MemoryStream(data);
                   
                    
                    Panel v = new Panel();
                    v.Size = new System.Drawing.Size(95, 95);
                    v.Click += new EventHandler(button_Click);
                    PictureBox img = new PictureBox();
                    img.Image = Image.FromStream(mem);
                    img.Size = new System.Drawing.Size(64, 64);
                    img.Location = new Point(15, 0);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Click += new EventHandler(img_Click);
                    v.Controls.Add(img);

                    TextBox t = new TextBox();
                    t.Text = item_id.ToString();
                    
                    t.Visible = false;
                    v.Controls.Add(t);
                    Label l = new Label() {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        //Dock = DockStyle.Fill,
                    };
                    l.Click += new EventHandler(label_Click);
                    l.Text = item_name;
                    l.Location = new Point(0, 70);
                    l.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
                    l.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
                    l.Font = new Font("Arial",9, FontStyle.Bold);
                    v.Controls.Add(l);
                    v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    f.Controls.Add(v);
                    
                    
                }
                //f.Size = new System.Drawing.Size(830, 5000);
                f.Dock = DockStyle.Fill;
                x.AutoScroll = true;
                f.WrapContents = true;
                f.AutoScroll = true;
                x.Controls.Add(f);
            }
            Database.disconnect();
            //for(int i = 0; i < 20; i++)
            //{
            //    TabPage x = new TabPage("test");
            //    products.TabPages.Add(x);

            //    FlowLayoutPanel f = new FlowLayoutPanel();
                
            //    int y = 1;
            //    while (y < 50)
            //    {
            //        Panel v = new Panel();
            //        v.Size = new System.Drawing.Size(100, 100);
            //        PictureBox img = new PictureBox();
            //        img.Image = Image.FromFile("../cake.png");
            //        img.Size = new System.Drawing.Size(64, 64);
            //        v.Controls.Add(img);
                   
            //        Label l = new Label();
            //        l.Text = "cake";
            //        l.Location = new Point(0, 70);
            //        v.Controls.Add(l);
            //        v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //        f.Controls.Add(v);
            //        y++;
            //    }
            //    f.Size = new System.Drawing.Size(450,300);
            //    x.AutoScroll = true;
            //    f.WrapContents = true;
            //    f.AutoScroll = true;
            //    x.Controls.Add(f);


            //}
        }
        protected void button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("yeah");
            Panel myPanel = sender as Panel;
            foreach(Control c in myPanel.Controls.OfType<TextBox>())
            {
                //MessageBox.Show("id : " + );
                add_item_to_order(c.Text);

            }
            // identify which button was clicked and perform necessary actions
        }
        public void qte_change(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("yeah");
                MetroFramework.Controls.MetroTextBox mytextbox = sender as MetroFramework.Controls.MetroTextBox;
                Boolean need_refresh = true;
                foreach (Control c in mytextbox.Parent.Parent.Controls)
                {
                    //MessageBox.Show(c.Name);
                    if (c.Name == "id")
                    {
                        foreach (Class_order order_y in list_des_orders)
                        {
                            //MessageBox.Show(order_y.id_produit.ToString());
                            //MessageBox.Show(c.Text);
                            if (order_y.id_produit.ToString() == c.Text)
                            {
                                try
                                {
                                    if (mytextbox.Text == "")
                                    {
                                        need_refresh = false;
                                        order_y.Qte = 1;
                                    }
                                    else
                                    {
                                        order_y.Qte = float.Parse(mytextbox.Text);
                                    }

                                }
                                catch (Exception i)
                                {
                                    MessageBox.Show(i.ToString());
                                }

                            }
                        }
                    }
                    else
                    {
                        //MessageBox.Show("you did not find me");
                    }
                }
                if (need_refresh)
                {
                    refresh_orders_list();

                }
            }
           
            
            // identify which button was clicked and perform necessary actions
        }
        //
        public void delete_item(object sender, EventArgs e)
        {
            //MessageBox.Show("yeah");
            PictureBox mypic = sender as PictureBox;
            
            foreach (Control c in mypic.Parent.Parent.Controls)
            {
                //MessageBox.Show(c.Name);
                if (c.Name == "id")
                {
                    foreach (Class_order order_y in list_des_orders)
                    {
                        //MessageBox.Show(order_y.id_produit.ToString());
                        //MessageBox.Show(c.Text);
                        if (order_y.id_produit.ToString() == c.Text)
                        {
                            list_des_orders.Remove(order_y);
                            break;
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("you did not find me");
                }
            }
            refresh_orders_list();
       

            // identify which button was clicked and perform necessary actions
        }
        public void add_item_to_order(string id_product)
        {
            if(idO == -1)
            {
                Class_order order = new Class_order();
                order.id_produit = int.Parse(id_product);
                ArrayList p_n = Database.get_product_price_name(order.id_produit);
                order.nom_produit = (string)p_n[0];
                order.price = (float)p_n[1];
                order.Qte = 1;
                list_des_orders.Add(order);



                foreach(Control myPanel in flowLayoutPanel_order_details.Controls.OfType<Panel>())
                {
                    foreach (Class_order order_y in list_des_orders)
                    {
                        try
                        {
                            string input_id = "";
                            //string input_id = myPanel.Controls.Find("id", true)[0].Text;
                            if (Class_functions.FindControlByName("id", (Panel)myPanel) != null)
                            {
                                 input_id = Class_functions.FindControlByName("id", (Panel)myPanel).Text;
                            }
                            else
                            {
                                MessageBox.Show("null");
                            }
                            

                            if (int.Parse(input_id)== order_y.id_produit)
                            {
                                try
                                {
                                    string input_qte = "";
                                    if(Class_functions.FindControlByName("Quantite_title",(Panel)myPanel) != null)
                                    {
                                        input_qte = Class_functions.FindControlByName("Quantite_title", (Panel)myPanel).Text;
                                    }
                                    else
                                    {
                                        MessageBox.Show("null");
                                    }
                                    order_y.Qte = float.Parse(input_qte);
                                }catch(Exception x)
                                {
                                    MessageBox.Show(x.ToString());
                                    order_y.Qte = -1;
                                }

                                try
                                {
                                    string options_input = "";
                                    
                                    if(Class_functions.FindControlByName("Options_title",(Panel)myPanel) != null)
                                    {
                                        options_input = Class_functions.FindControlByName("Options_title", (Panel)myPanel).Text;
                                    }
                                    else
                                    {
                                        MessageBox.Show("null");
                                    }

                                    if (options_input != "")
                                    {
                                        order_y.options = options_input;
                                    }
                                    else
                                    {
                                        order_y.options = "Sans spécifier les options";
                                    }
                                }catch(Exception n)
                                {
                                    MessageBox.Show(n.ToString());
                                }
                            }
                            else
                            {
                                //************************************
                                //******* code here
                            }
                           
                        }catch(Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                    }
                }
                //function here

                refresh_orders_list();





                //    foreach (DataGridViewRow row in dataGridView_orders_details.Rows)
                //    {
                //        if (dataGridView_orders_details.Rows.Count != 0 && dataGridView_orders_details.Rows != null)
                //        {
                //            foreach (Class_order order_y in list_des_orders)
                //            {

                //                try
                //                {

                //                    if (int.Parse(row.Cells["ID"].Value.ToString()) == order_y.id_produit)
                //                    {
                //                        try
                //                        {
                //                            order_y.Qte = float.Parse(row.Cells["Quantité"].Value.ToString());
                //                        }
                //                        catch (Exception e)
                //                        {
                //                            MessageBox.Show(e.ToString());
                //                            order_y.Qte = 1;
                //                        }
                //                        try
                //                        {
                //                            if(row.Cells["Options"].Value != null)
                //                            {
                //                                order_y.options = row.Cells["Options"].Value.ToString();
                //                            }
                //                            else
                //                            {
                //                                order_y.options = "Sans spécifier les options";
                //                            }

                //                        }
                //                        catch (Exception e)
                //                        {
                //                            MessageBox.Show(e.ToString());
                //                            order_y.options = "Error";
                //                        }
                //                    }
                //                    else
                //                    {

                //                    }
                //                }


                //                catch (Exception ex)
                //                {
                //                    MessageBox.Show(ex.ToString());
                //                }

                //            }
                //        }


                //    }
                //    dataGridView_orders_details.DataSource = null;
                //    dataGridView_orders_details.Rows.Clear();
                //    dataGridView_orders_details.ColumnCount = 6;
                //    dataGridView_orders_details.Columns[0].Name = "ID";
                //    dataGridView_orders_details.Columns[1].Name = "Produit";
                //    dataGridView_orders_details.Columns[2].Name = "Prix";
                //    dataGridView_orders_details.Columns[3].Name = "Quantité";
                //    dataGridView_orders_details.Columns[4].Name = "Total";
                //    dataGridView_orders_details.Columns[5].Name = "Options";

                //    total_money = 0;
                //    foreach (Class_order order_x in list_des_orders)
                //    {  
                //        string[] row = new string[] {order_x.id_produit.ToString(), order_x.nom_produit,order_x.price.ToString(),order_x.Qte.ToString(),(order_x.Qte * order_x.price).ToString(),order_x.options };
                //        dataGridView_orders_details.Rows.Add(row);

                //        total_money += order_x.price * order_x.Qte;
                //    }
                //    label_Total.Text = "Total "+total_money+" DH";
            }
            else
            {
                //code here
            }
        }
        protected void img_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("yeah");
            PictureBox myPicture = sender as PictureBox;
            foreach (Control c in myPicture.Parent.Controls.OfType<TextBox>())
            {
                //MessageBox.Show("id : " + );
                add_item_to_order(c.Text);
            }
            // identify which button was clicked and perform necessary actions
        }
        public  void refresh_orders_list()
        {
            flowLayoutPanel_order_details.Controls.Clear();
            total_money = 0;
            foreach (Class_order order_x in list_des_orders)
            {
                //string[] row = new string[] { order_x.id_produit.ToString(), order_x.nom_produit, order_x.price.ToString(), order_x.Qte.ToString(), (order_x.Qte * order_x.price).ToString(), order_x.options };
                //dataGridView_orders_details.Rows.Add(row);
                Panel thePanel = createPanel_order(order_x);
                flowLayoutPanel_order_details.Controls.Add(thePanel);

                total_money += order_x.price * order_x.Qte;
            }
            label_Total.Text = "Total " + total_money + " DH";
            func_tb();
        }
        private  Panel createPanel_order(Class_order order)
        {
            Panel p = new Panel();
            p.Size = new Size(840, 25);

            Label id = new Label();
            id.Text = order.id_produit.ToString();
            id.Visible = false;
            id.Name = "id";
            p.Controls.Add(id);

            Panel produit_name = new Panel();
            Label p_title = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            p_title.Text = order.nom_produit;

            p_title.Size = new Size(120, 24);
            p_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
            p_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            p_title.Font = new Font("Arial", 9, FontStyle.Bold);


            produit_name.Size = new Size(129, 24);
            //produit_title.Location = new Point(0, 0);
            produit_name.Controls.Add(p_title);
            p.Controls.Add(produit_name);
            //*******
            Label Prix_title = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Prix_title.Text = order.price.ToString();
            //Prix_title.Location = new Point(0, 70);
            Prix_title.Size = new Size(120, 24);
            Prix_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
            Prix_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            Prix_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel Prix_title_panel = new Panel();

            Prix_title_panel.Size = new Size(129, 24);
            Prix_title_panel.Location = new Point(129, 0);
            Prix_title_panel.Controls.Add(Prix_title);
            p.Controls.Add(Prix_title_panel);
            //*****************
            MetroFramework.Controls.MetroTextBox Quantite_title = new MetroFramework.Controls.MetroTextBox();

            Quantite_title.Text = order.Qte.ToString();
         
            Quantite_title.Size = new Size(120, 24);
            Quantite_title.Name = "Quantite_title";


            //Quantite_title.Leave += new EventHandler(qte_change);
            Quantite_title.KeyDown += new  KeyEventHandler(qte_change);
            

            Quantite_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel Quantite_title_panel = new Panel();

            Quantite_title_panel.Size = new Size(129, 24);
            Quantite_title_panel.Location = new Point(258, 0);
            Quantite_title_panel.Controls.Add(Quantite_title);
            p.Controls.Add(Quantite_title_panel);
           
            //*****************
            Label Total_title = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            try
            {
                Total_title.Text = (order.price * order.Qte).ToString()+" DH ";
            }
            catch (Exception t)
            {
                Total_title.Text = "error";
            }

            Total_title.Size = new Size(120, 24);
            Total_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#1abc9c");
            Total_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            Total_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel Total_title_panel = new Panel();

            Total_title_panel.Size = new Size(129, 24);
            Total_title_panel.Location = new Point(387, 0);
            Total_title_panel.Controls.Add(Total_title);
            p.Controls.Add(Total_title_panel);

            //*****************
            MetroFramework.Controls.MetroTextBox Options_title = new MetroFramework.Controls.MetroTextBox();

            Options_title.Text = order.options;

            Options_title.Size = new Size(200, 24);
            Options_title.TextChanged += new EventHandler(update_order_options_func);
            Options_title.Name = "Options_title";
            Options_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel Options_title_panel = new Panel();

            Options_title_panel.Size = new Size(200, 24);
            Options_title_panel.Location = new Point(516, 0);
            Options_title_panel.Controls.Add(Options_title);
            p.Controls.Add(Options_title_panel);

            //*****************
            PictureBox delete_title = new PictureBox();
            delete_title.Image = Image.FromFile("../images/delete.png");

            delete_title.Size = new Size(24, 24);
            delete_title.Location = new Point(52, 0);
            //Quantite_title.TextChanged += new EventHandler(qte_change);
            delete_title.Click += new EventHandler(delete_item);
            Panel delete_title_panel = new Panel();

            delete_title_panel.Size = new Size(129, 24);
            delete_title_panel.Location = new Point(725, 0);
            delete_title_panel.Controls.Add(delete_title);
            p.Controls.Add(delete_title_panel);


            return p;
        }
        protected void update_order_options_func(object sender, EventArgs e)
        {

            Control mylabel = sender as Control;
            foreach (Control c in mylabel.Parent.Parent.Controls)
            {
                if (c.Name == "id")
                {
                    foreach (Class_order o in list_des_orders)
                    {
                        if(o.id_produit.ToString() == c.Text)
                        {
                            o.options = mylabel.Text;
                            //MessageBox.Show(o.options);
                        }
                    }
                }
            }

        }

        protected void label_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("yeah");
            Label mylabel = sender as Label;
            foreach (Control c in mylabel.Parent.Controls.OfType<TextBox>())
            {
                //MessageBox.Show("id : " + );
                add_item_to_order(c.Text);

            }
            // identify which button was clicked and perform necessary actions
        }
        
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void add_order_details_titles()
        {
            //Panel p = new Panel();
            //p.Size = new Size(775, 135);
            //flowLayoutPanel_order_details.Controls.Add(p);
            Panel produit_title = new Panel();
            Label p_title = new Label() {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            p_title.Text = "Produit";
            
            //p_title.Location = new Point(0, 70);
            p_title.Size = new Size(120, 24);
            p_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            p_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            p_title.Font = new Font("Arial", 9, FontStyle.Bold);

            
            produit_title.Size = new Size(129, 24);
            //produit_title.Location = new Point(0, 0);
            produit_title.Controls.Add(p_title);
            p_titles.Controls.Add(produit_title);
            //*******
            Label Prix_title = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Prix_title.Text = "Prix";
            //Prix_title.Location = new Point(0, 70);
            Prix_title.Size = new Size(120, 24);
            Prix_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            Prix_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            Prix_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel Prix_title_panel = new Panel();

            Prix_title_panel.Size = new Size(129, 24);
            Prix_title_panel.Location = new Point(129, 0);
            Prix_title_panel.Controls.Add(Prix_title);
            p_titles.Controls.Add(Prix_title_panel);
            //*****************
            Label Quantite_title = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Quantite_title.Text = "Quantité";
           
            Quantite_title.Size = new Size(120, 24);
            Quantite_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            Quantite_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            Quantite_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel Quantite_title_panel = new Panel();

            Quantite_title_panel.Size = new Size(129, 24);
            Quantite_title_panel.Location = new Point(258, 0);
            Quantite_title_panel.Controls.Add(Quantite_title);
            p_titles.Controls.Add(Quantite_title_panel);

            //*****************
            Label Total_title = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Total_title.Text = "Total";

            Total_title.Size = new Size(120, 24);
            Total_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            Total_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            Total_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel Total_title_panel = new Panel();

            Total_title_panel.Size = new Size(129, 24);
            Total_title_panel.Location = new Point(387, 0);
            Total_title_panel.Controls.Add(Total_title);
            p_titles.Controls.Add(Total_title_panel);

            //*****************
            Label Options_title = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Options_title.Text = "Options";

            Options_title.Size = new Size(200, 24);
            Options_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
            Options_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            Options_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel Options_title_panel = new Panel();

            Options_title_panel.Size = new Size(200, 24);
            Options_title_panel.Location = new Point(516, 0);
            Options_title_panel.Controls.Add(Options_title);
            p_titles.Controls.Add(Options_title_panel);

            //*****************
            Label delete_title = new Label()
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            delete_title.Text = "Supprimer";

            delete_title.Size = new Size(120, 24);
            delete_title.BackColor = System.Drawing.ColorTranslator.FromHtml("#e74c3c");
            delete_title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
            delete_title.Font = new Font("Arial", 9, FontStyle.Bold);
            Panel delete_title_panel = new Panel();

            delete_title_panel.Size = new Size(120, 24);
            delete_title_panel.Location = new Point(725, 0);
            delete_title_panel.Controls.Add(delete_title);
            p_titles.Controls.Add(delete_title_panel);

        }

        public void confirm_commande()
        {
           
            if (true)//valider_form()
            {

                

                DialogResult ok = MessageBox.Show("Voulez-vous effectuer le paiement immédiatement", "Paiement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                   
                    add_order_to_database();
                    
                    //redirect to payment form
                    Form_payment_methodes f = new Form_payment_methodes();
                  
                    f.total_amount = decimal.Parse(total_money.ToString());
                    f.orders_List = list_des_orders;

                    list_des_orders = new ArrayList();
                    selected_customer = new Class_customer();
                    selected_table = new Class_restaurant_table();
                    //MessageBox.Show(total_money.ToString());
                    //MessageBox.Show(f.total_amount.ToString());
                    //f.Show();
                    f.ShowDialog();
                }
                else
                {
                    //redirect to user panel
                    add_order_to_database();
                    list_des_orders = new ArrayList();
                    selected_customer = new Class_customer();
                    selected_table = new Class_restaurant_table();
                    Form_Home f = new Form_Home();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("no no");
            }
        }
        public Boolean valider_form()
        {
            Boolean is_ok = true;
            if(total_money <= 0)
            {
                is_ok = false;
            }
            try
            {
                int.Parse(metroTextBox_numero_table.Text);
            }
            catch(Exception e)
            {
                is_ok = false;
            }
           
            if(metroTextBox_nom.Text == "")
            {
                is_ok = false;
            }
            Regex regex = new Regex(@"^\d$");
            string phone_input = metroTextBox_phone.Text;
            if (phone_input != "")
            {
                Match match = regex.Match(phone_input);
                if (!match.Success)
                {
                    is_ok = false;
                }
            }
           

            
            string nbr_input = metroTextBox_nbr_clients.Text;
            if(nbr_input != "")
            {
                Match match_nbr = regex.Match(nbr_input);
                if (!match_nbr.Success)
                {
                    is_ok = false;
                }
            }
            else
            {
                metroTextBox_nbr_clients.Text = "1";
            }
           


            string input_email = metroTextBox_email.Text;
            if(input_email != "")
            {
                if (!Class_functions.IsValidEmail(input_email))
                {
                    is_ok = false;
                }
            }
            
            return is_ok;
        }

        public void add_order_to_database()
        {
            string name = selected_customer.name;
            string email = selected_customer.email;
            string phone = selected_customer.phone;
            int nbr_clients = int.Parse(metroTextBox_nbr_clients.Text);
            int numero_table = selected_table.id;//int.Parse(metroTextBox_numero_table.Text);

            Database.insert_order(   list_des_orders,
                                     numero_table, 
                                     nbr_clients, 
                                     total_money, 
                                     name, 
                                     email,
                                     phone
                                  );


      
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            annuler_command();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            annuler_command();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            confirm_commande();
        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {
            annuler_command();
        }
        public void annuler_command()
        {
            list_des_orders = new ArrayList();
            selected_customer = new Class_customer();
            selected_table = new Class_restaurant_table();

            Form_Home f = new Form_Home();
            f.Show();
            this.Close();
        }

        private void metroTextBox_Recherche_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public void create_keyboards()
        {
            Class_functions.create_keyboard_panel(panel_keyboard_orders_create);
        }
    }
}
