using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form_settings_products : MetroFramework.Forms.MetroForm
    {

        int id_product_to_modify;
        Class_product product_selected;
        Byte[] my_image;
        public Form_settings_products()
        {
            InitializeComponent();
        }

        private void Form_settings_products_Load(object sender, EventArgs e)
        {
            add_items_products();
            fill_comboBox();
        }

        public void add_items_products()
        {

            Class_functions.empty_control(products);


            Database.connecter();
            String query = "select distinct id,name from Categories";
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
                SqlCommand command_items = new SqlCommand(query_items, Database.Con);

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
                    v.Click += new EventHandler(product_Click);
                    PictureBox img = new PictureBox();
                    img.Image = Image.FromStream(mem);
                    img.Size = new System.Drawing.Size(64, 64);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.Click += new EventHandler(c_product_Click);
                    v.Controls.Add(img);

                    TextBox t = new TextBox();
                    t.Text = item_id.ToString();
                    t.Name = "id";
                    t.Visible = false;
                    v.Controls.Add(t);
                    Label l = new Label()
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        //Dock = DockStyle.Fill,
                    };
                    l.Click += new EventHandler(c_product_Click);
                    l.Text = item_name;
                    l.Location = new Point(0, 70);
                    l.BackColor = System.Drawing.ColorTranslator.FromHtml("#34495e");
                    l.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ecf0f1");
                    l.Font = new Font("Arial", 9, FontStyle.Bold);
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
         
        }
        protected void product_Click(object sender, EventArgs e)
        {
          
            Control myPanel = sender as Control;
            Control d = Class_functions.FindControlByName("id", (Panel)myPanel);
               if(d != null)
               {
                    try
                    {
                        id_product_to_modify = int.Parse(d.Text);
                        change_product_selected();
                        //MessageBox.Show(id_product_to_modify.ToString());
                    }catch(Exception ec)
                    {
                        MessageBox.Show(ec.ToString());
                    }
                    
             
              

            }
            
        }
        protected void c_product_Click(object sender, EventArgs e)
        {

            Control myPanel = sender as Control;
            Control d = Class_functions.FindControlByName("id", (Panel)myPanel.Parent);
                if (d != null)
                {
                    try
                    {
                        id_product_to_modify = int.Parse(d.Text);
                        //MessageBox.Show(id_product_to_modify.ToString());
                        change_product_selected();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.ToString());
                    }

            


                }

        }

        public void change_product_selected()
        {
            try
            {
                product_selected = Database.get_products_by_id(id_product_to_modify);
                metroTextBox_nom.Text = product_selected.name;
                metroTextBox_prix.Text = product_selected.price.ToString();
                metroTextBox_barcode.Text = product_selected.barcode;
                metroComboBox_categorie.SelectedValue = product_selected.category;
                MemoryStream m = new MemoryStream((byte[])product_selected.image);
                my_image = (byte[])product_selected.image;
                pictureBox_image.Image = Image.FromStream(m);
            }
            catch(Exception n)
            {
                MessageBox.Show(n.ToString());
            }
           
        }

        public void fill_comboBox()
        {
            DataTable t = Database.get_products_catgs();
            metroComboBox_categorie.DataSource = t;
            metroComboBox_categorie.DisplayMember = "name";
            metroComboBox_categorie.ValueMember = "id";
        }

        private void metroButton_image_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog_product_image.ShowDialog();
            if (result == DialogResult.OK)
            {
                string image = openFileDialog_product_image.FileName;
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                my_image = new byte[fs.Length];
                fs.Read(my_image, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                MemoryStream m = new MemoryStream(my_image);
                pictureBox_image.Image = Image.FromStream(m);

            }
        }

        private void metroButton_enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                Class_product updated_one = new Class_product();
                updated_one.name = metroTextBox_nom.Text;
                updated_one.barcode = metroTextBox_barcode.Text;
                updated_one.price = float.Parse(metroTextBox_prix.Text);
                updated_one.category = int.Parse(metroComboBox_categorie.SelectedValue.ToString());
                updated_one.image = my_image;
                Boolean is_updated = Database.update_product_by_id(id_product_to_modify, updated_one);
                if (is_updated)
                {
                    MessageBox.Show("updated");
                    add_items_products();
                }
                else
                {
                    MessageBox.Show("Oops Error");
                }

            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }


        }
    }
}
