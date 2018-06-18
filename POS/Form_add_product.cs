using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form_add_product : MetroFramework.Forms.MetroForm
    {
        public byte[] bimage;
        public Form_add_product()
        {
            InitializeComponent();
        }

        private void Form_add_product_Load(object sender, EventArgs e)
        {
            fill_comboBox();
        }
        public void fill_comboBox()
        {
            DataTable t = Database.get_products_catgs();
            metroComboBox_Categorie.DataSource = t;
            metroComboBox_Categorie.DisplayMember = "name";
            metroComboBox_Categorie.ValueMember = "id";
        }

        private void metroButton_upload_image_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog_product_img.ShowDialog();
            if(result == DialogResult.OK)
            {
                string image = openFileDialog_product_img.FileName;
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                MemoryStream m = new MemoryStream(bimage);
                pictureBox_product_image.Image = Image.FromStream(m);
                
            }
        }

        private void metroButton_save_Click(object sender, EventArgs e)
        {
            Class_product p = new Class_product();
            p.name = metroTextBox_product_name.Text;
            p.price = float.Parse(metroTextBox_product_price.Text);
            p.barcode = metroTextBoxBarCode.Text;
            p.category = int.Parse(metroComboBox_Categorie.SelectedValue.ToString());
            p.image = bimage;
            Boolean is_saved = Database.save_new_product(p);
            if (is_saved)
            {
                MessageBox.Show("Le produit a été enregistré");
            }
            else
            {
                MessageBox.Show("Oops Error");
            }
        }
    }
}
