namespace POS
{
    partial class Form_settings_products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.products = new MetroFramework.Controls.MetroTabControl();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTextBox_Recherche = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton_supprimer = new MetroFramework.Controls.MetroButton();
            this.metroButton_enregistrer = new MetroFramework.Controls.MetroButton();
            this.metroButton_image = new MetroFramework.Controls.MetroButton();
            this.metroComboBox_categorie = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox_prix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_price = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_barcode = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_nom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_barcode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_nom = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog_product_image = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.Location = new System.Drawing.Point(45, 239);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(860, 240);
            this.products.TabIndex = 29;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(347, 208);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Recherche";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.metroTextBox_Recherche);
            this.panel1.Location = new System.Drawing.Point(419, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 25);
            this.panel1.TabIndex = 32;
            // 
            // metroTextBox_Recherche
            // 
            this.metroTextBox_Recherche.Location = new System.Drawing.Point(3, 0);
            this.metroTextBox_Recherche.Name = "metroTextBox_Recherche";
            this.metroTextBox_Recherche.Size = new System.Drawing.Size(445, 23);
            this.metroTextBox_Recherche.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroButton_supprimer);
            this.panel2.Controls.Add(this.metroButton_enregistrer);
            this.panel2.Controls.Add(this.pictureBox_image);
            this.panel2.Controls.Add(this.metroButton_image);
            this.panel2.Controls.Add(this.metroComboBox_categorie);
            this.panel2.Controls.Add(this.metroTextBox_prix);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.metroLabel_price);
            this.panel2.Controls.Add(this.metroTextBox_barcode);
            this.panel2.Controls.Add(this.metroTextBox_nom);
            this.panel2.Controls.Add(this.metroLabel_barcode);
            this.panel2.Controls.Add(this.metroLabel_nom);
            this.panel2.Location = new System.Drawing.Point(45, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 100);
            this.panel2.TabIndex = 34;
            // 
            // metroButton_supprimer
            // 
            this.metroButton_supprimer.Location = new System.Drawing.Point(713, 62);
            this.metroButton_supprimer.Name = "metroButton_supprimer";
            this.metroButton_supprimer.Size = new System.Drawing.Size(130, 23);
            this.metroButton_supprimer.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton_supprimer.TabIndex = 11;
            this.metroButton_supprimer.Text = "Supprimer";
            this.metroButton_supprimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton_supprimer.Click += new System.EventHandler(this.metroButton_supprimer_Click);
            // 
            // metroButton_enregistrer
            // 
            this.metroButton_enregistrer.Location = new System.Drawing.Point(713, 14);
            this.metroButton_enregistrer.Name = "metroButton_enregistrer";
            this.metroButton_enregistrer.Size = new System.Drawing.Size(130, 23);
            this.metroButton_enregistrer.TabIndex = 10;
            this.metroButton_enregistrer.Text = "Modifier";
            this.metroButton_enregistrer.Click += new System.EventHandler(this.metroButton_enregistrer_Click);
            // 
            // metroButton_image
            // 
            this.metroButton_image.Location = new System.Drawing.Point(533, 14);
            this.metroButton_image.Name = "metroButton_image";
            this.metroButton_image.Size = new System.Drawing.Size(93, 24);
            this.metroButton_image.TabIndex = 8;
            this.metroButton_image.Text = "Image";
            this.metroButton_image.Click += new System.EventHandler(this.metroButton_image_Click);
            // 
            // metroComboBox_categorie
            // 
            this.metroComboBox_categorie.FormattingEnabled = true;
            this.metroComboBox_categorie.ItemHeight = 23;
            this.metroComboBox_categorie.Location = new System.Drawing.Point(377, 56);
            this.metroComboBox_categorie.Name = "metroComboBox_categorie";
            this.metroComboBox_categorie.Size = new System.Drawing.Size(139, 29);
            this.metroComboBox_categorie.TabIndex = 7;
            // 
            // metroTextBox_prix
            // 
            this.metroTextBox_prix.Location = new System.Drawing.Point(374, 14);
            this.metroTextBox_prix.Name = "metroTextBox_prix";
            this.metroTextBox_prix.Size = new System.Drawing.Size(142, 23);
            this.metroTextBox_prix.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(288, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Catégorie";
            // 
            // metroLabel_price
            // 
            this.metroLabel_price.AutoSize = true;
            this.metroLabel_price.Location = new System.Drawing.Point(288, 17);
            this.metroLabel_price.Name = "metroLabel_price";
            this.metroLabel_price.Size = new System.Drawing.Size(31, 19);
            this.metroLabel_price.TabIndex = 4;
            this.metroLabel_price.Text = "Prix";
            // 
            // metroTextBox_barcode
            // 
            this.metroTextBox_barcode.Location = new System.Drawing.Point(107, 55);
            this.metroTextBox_barcode.Name = "metroTextBox_barcode";
            this.metroTextBox_barcode.Size = new System.Drawing.Size(142, 23);
            this.metroTextBox_barcode.TabIndex = 3;
            // 
            // metroTextBox_nom
            // 
            this.metroTextBox_nom.Location = new System.Drawing.Point(107, 14);
            this.metroTextBox_nom.MaxLength = 13;
            this.metroTextBox_nom.Name = "metroTextBox_nom";
            this.metroTextBox_nom.Size = new System.Drawing.Size(142, 23);
            this.metroTextBox_nom.TabIndex = 2;
            // 
            // metroLabel_barcode
            // 
            this.metroLabel_barcode.AutoSize = true;
            this.metroLabel_barcode.Location = new System.Drawing.Point(26, 59);
            this.metroLabel_barcode.Name = "metroLabel_barcode";
            this.metroLabel_barcode.Size = new System.Drawing.Size(61, 19);
            this.metroLabel_barcode.TabIndex = 1;
            this.metroLabel_barcode.Text = "BarCode";
            // 
            // metroLabel_nom
            // 
            this.metroLabel_nom.AutoSize = true;
            this.metroLabel_nom.Location = new System.Drawing.Point(26, 18);
            this.metroLabel_nom.Name = "metroLabel_nom";
            this.metroLabel_nom.Size = new System.Drawing.Size(39, 19);
            this.metroLabel_nom.TabIndex = 0;
            this.metroLabel_nom.Text = "Nom";
            // 
            // openFileDialog_product_image
            // 
            this.openFileDialog_product_image.FileName = "openFileDialog1";
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(632, 14);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 9;
            this.pictureBox_image.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS.Properties.Resources.research;
            this.pictureBox1.Location = new System.Drawing.Point(454, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form_settings_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.products);
            this.Name = "Form_settings_products";
            this.Text = "Gérer les produits";
            this.Load += new System.EventHandler(this.Form_settings_products_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl products;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Recherche;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel_price;
        private MetroFramework.Controls.MetroTextBox metroTextBox_barcode;
        private MetroFramework.Controls.MetroTextBox metroTextBox_nom;
        private MetroFramework.Controls.MetroLabel metroLabel_barcode;
        private MetroFramework.Controls.MetroLabel metroLabel_nom;
        private MetroFramework.Controls.MetroButton metroButton_enregistrer;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private MetroFramework.Controls.MetroButton metroButton_image;
        private MetroFramework.Controls.MetroComboBox metroComboBox_categorie;
        private MetroFramework.Controls.MetroTextBox metroTextBox_prix;
        private MetroFramework.Controls.MetroButton metroButton_supprimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog_product_image;
    }
}