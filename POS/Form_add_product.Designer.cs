namespace POS
{
    partial class Form_add_product
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
            this.metroLabel_product_name = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_product_name = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_product_price = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_product_price = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_Categorie = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox_Categorie = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel_image = new MetroFramework.Controls.MetroLabel();
            this.pictureBox_product_image = new System.Windows.Forms.PictureBox();
            this.metroButton_save = new MetroFramework.Controls.MetroButton();
            this.metroButton_upload_image = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog_product_img = new System.Windows.Forms.OpenFileDialog();
            this.metroTextBoxBarCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelBarCode = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product_image)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel_product_name
            // 
            this.metroLabel_product_name.AutoSize = true;
            this.metroLabel_product_name.Location = new System.Drawing.Point(25, 75);
            this.metroLabel_product_name.Name = "metroLabel_product_name";
            this.metroLabel_product_name.Size = new System.Drawing.Size(39, 19);
            this.metroLabel_product_name.TabIndex = 0;
            this.metroLabel_product_name.Text = "Nom";
            // 
            // metroTextBox_product_name
            // 
            this.metroTextBox_product_name.Location = new System.Drawing.Point(150, 75);
            this.metroTextBox_product_name.MaxLength = 13;
            this.metroTextBox_product_name.Name = "metroTextBox_product_name";
            this.metroTextBox_product_name.Size = new System.Drawing.Size(197, 23);
            this.metroTextBox_product_name.TabIndex = 1;
            // 
            // metroTextBox_product_price
            // 
            this.metroTextBox_product_price.Location = new System.Drawing.Point(150, 115);
            this.metroTextBox_product_price.Name = "metroTextBox_product_price";
            this.metroTextBox_product_price.Size = new System.Drawing.Size(197, 23);
            this.metroTextBox_product_price.TabIndex = 3;
            // 
            // metroLabel_product_price
            // 
            this.metroLabel_product_price.AutoSize = true;
            this.metroLabel_product_price.Location = new System.Drawing.Point(25, 115);
            this.metroLabel_product_price.Name = "metroLabel_product_price";
            this.metroLabel_product_price.Size = new System.Drawing.Size(31, 19);
            this.metroLabel_product_price.TabIndex = 2;
            this.metroLabel_product_price.Text = "Prix";
            // 
            // metroLabel_Categorie
            // 
            this.metroLabel_Categorie.AutoSize = true;
            this.metroLabel_Categorie.Location = new System.Drawing.Point(25, 155);
            this.metroLabel_Categorie.Name = "metroLabel_Categorie";
            this.metroLabel_Categorie.Size = new System.Drawing.Size(67, 19);
            this.metroLabel_Categorie.TabIndex = 4;
            this.metroLabel_Categorie.Text = "Catégorie";
            // 
            // metroComboBox_Categorie
            // 
            this.metroComboBox_Categorie.FormattingEnabled = true;
            this.metroComboBox_Categorie.ItemHeight = 23;
            this.metroComboBox_Categorie.Location = new System.Drawing.Point(150, 145);
            this.metroComboBox_Categorie.Name = "metroComboBox_Categorie";
            this.metroComboBox_Categorie.Size = new System.Drawing.Size(197, 29);
            this.metroComboBox_Categorie.TabIndex = 5;
            // 
            // metroLabel_image
            // 
            this.metroLabel_image.AutoSize = true;
            this.metroLabel_image.Location = new System.Drawing.Point(25, 195);
            this.metroLabel_image.Name = "metroLabel_image";
            this.metroLabel_image.Size = new System.Drawing.Size(46, 19);
            this.metroLabel_image.TabIndex = 6;
            this.metroLabel_image.Text = "Image";
            // 
            // pictureBox_product_image
            // 
            this.pictureBox_product_image.Location = new System.Drawing.Point(150, 195);
            this.pictureBox_product_image.Name = "pictureBox_product_image";
            this.pictureBox_product_image.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_product_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_product_image.TabIndex = 7;
            this.pictureBox_product_image.TabStop = false;
            // 
            // metroButton_save
            // 
            this.metroButton_save.Location = new System.Drawing.Point(150, 320);
            this.metroButton_save.Name = "metroButton_save";
            this.metroButton_save.Size = new System.Drawing.Size(197, 23);
            this.metroButton_save.TabIndex = 8;
            this.metroButton_save.Text = "Enregistrer";
            this.metroButton_save.Click += new System.EventHandler(this.metroButton_save_Click);
            // 
            // metroButton_upload_image
            // 
            this.metroButton_upload_image.Location = new System.Drawing.Point(220, 195);
            this.metroButton_upload_image.Name = "metroButton_upload_image";
            this.metroButton_upload_image.Size = new System.Drawing.Size(127, 23);
            this.metroButton_upload_image.TabIndex = 9;
            this.metroButton_upload_image.Text = "Upload";
            this.metroButton_upload_image.Click += new System.EventHandler(this.metroButton_upload_image_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(220, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "64pxX64px";
            // 
            // openFileDialog_product_img
            // 
            this.openFileDialog_product_img.FileName = "openFileDialog1";
            // 
            // metroTextBoxBarCode
            // 
            this.metroTextBoxBarCode.Location = new System.Drawing.Point(150, 280);
            this.metroTextBoxBarCode.Name = "metroTextBoxBarCode";
            this.metroTextBoxBarCode.Size = new System.Drawing.Size(197, 23);
            this.metroTextBoxBarCode.TabIndex = 12;
            // 
            // metroLabelBarCode
            // 
            this.metroLabelBarCode.AutoSize = true;
            this.metroLabelBarCode.Location = new System.Drawing.Point(25, 280);
            this.metroLabelBarCode.Name = "metroLabelBarCode";
            this.metroLabelBarCode.Size = new System.Drawing.Size(61, 19);
            this.metroLabelBarCode.TabIndex = 11;
            this.metroLabelBarCode.Text = "BarCode";
            // 
            // Form_add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 366);
            this.Controls.Add(this.metroTextBoxBarCode);
            this.Controls.Add(this.metroLabelBarCode);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroButton_upload_image);
            this.Controls.Add(this.metroButton_save);
            this.Controls.Add(this.pictureBox_product_image);
            this.Controls.Add(this.metroLabel_image);
            this.Controls.Add(this.metroComboBox_Categorie);
            this.Controls.Add(this.metroLabel_Categorie);
            this.Controls.Add(this.metroTextBox_product_price);
            this.Controls.Add(this.metroLabel_product_price);
            this.Controls.Add(this.metroTextBox_product_name);
            this.Controls.Add(this.metroLabel_product_name);
            this.Name = "Form_add_product";
            this.Text = "Ajouter un produit";
            this.Load += new System.EventHandler(this.Form_add_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel_product_name;
        private MetroFramework.Controls.MetroTextBox metroTextBox_product_name;
        private MetroFramework.Controls.MetroTextBox metroTextBox_product_price;
        private MetroFramework.Controls.MetroLabel metroLabel_product_price;
        private MetroFramework.Controls.MetroLabel metroLabel_Categorie;
        private MetroFramework.Controls.MetroComboBox metroComboBox_Categorie;
        private MetroFramework.Controls.MetroLabel metroLabel_image;
        private System.Windows.Forms.PictureBox pictureBox_product_image;
        private MetroFramework.Controls.MetroButton metroButton_save;
        private MetroFramework.Controls.MetroButton metroButton_upload_image;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.OpenFileDialog openFileDialog_product_img;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBarCode;
        private MetroFramework.Controls.MetroLabel metroLabelBarCode;
    }
}