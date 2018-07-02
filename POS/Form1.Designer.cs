namespace POS
{
    partial class Form_login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroRadioButton_password = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton_Votre_ID = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_password = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_username = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.Button0 = new MetroFramework.Controls.MetroButton();
            this.ButtonX = new MetroFramework.Controls.MetroButton();
            this.Button9 = new MetroFramework.Controls.MetroButton();
            this.Button8 = new MetroFramework.Controls.MetroButton();
            this.Button7 = new MetroFramework.Controls.MetroButton();
            this.Button6 = new MetroFramework.Controls.MetroButton();
            this.Button5 = new MetroFramework.Controls.MetroButton();
            this.Button4 = new MetroFramework.Controls.MetroButton();
            this.Button3 = new MetroFramework.Controls.MetroButton();
            this.Button2 = new MetroFramework.Controls.MetroButton();
            this.Button1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.metroRadioButton_password);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroRadioButton_Votre_ID);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroTextBox_password);
            this.metroPanel2.Controls.Add(this.metroTextBox_username);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(528, 159);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(345, 180);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(291, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroRadioButton_password
            // 
            this.metroRadioButton_password.AutoSize = true;
            this.metroRadioButton_password.Location = new System.Drawing.Point(229, 145);
            this.metroRadioButton_password.Name = "metroRadioButton_password";
            this.metroRadioButton_password.Size = new System.Drawing.Size(82, 15);
            this.metroRadioButton_password.TabIndex = 13;
            this.metroRadioButton_password.Text = "Votre Code";
            this.metroRadioButton_password.UseVisualStyleBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Votre Code";
            // 
            // metroRadioButton_Votre_ID
            // 
            this.metroRadioButton_Votre_ID.AutoSize = true;
            this.metroRadioButton_Votre_ID.Checked = true;
            this.metroRadioButton_Votre_ID.Location = new System.Drawing.Point(120, 145);
            this.metroRadioButton_Votre_ID.Name = "metroRadioButton_Votre_ID";
            this.metroRadioButton_Votre_ID.Size = new System.Drawing.Size(65, 15);
            this.metroRadioButton_Votre_ID.TabIndex = 8;
            this.metroRadioButton_Votre_ID.TabStop = true;
            this.metroRadioButton_Votre_ID.Text = "Votre ID";
            this.metroRadioButton_Votre_ID.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Votre ID";
            // 
            // metroTextBox_password
            // 
            this.metroTextBox_password.Location = new System.Drawing.Point(120, 99);
            this.metroTextBox_password.Name = "metroTextBox_password";
            this.metroTextBox_password.PasswordChar = '*';
            this.metroTextBox_password.ReadOnly = true;
            this.metroTextBox_password.Size = new System.Drawing.Size(203, 23);
            this.metroTextBox_password.TabIndex = 4;
            // 
            // metroTextBox_username
            // 
            this.metroTextBox_username.Location = new System.Drawing.Point(120, 61);
            this.metroTextBox_username.Name = "metroTextBox_username";
            this.metroTextBox_username.ReadOnly = true;
            this.metroTextBox_username.Size = new System.Drawing.Size(203, 23);
            this.metroTextBox_username.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(126, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Connexion";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.Button0);
            this.metroPanel3.Controls.Add(this.ButtonX);
            this.metroPanel3.Controls.Add(this.Button9);
            this.metroPanel3.Controls.Add(this.Button8);
            this.metroPanel3.Controls.Add(this.Button7);
            this.metroPanel3.Controls.Add(this.Button6);
            this.metroPanel3.Controls.Add(this.Button5);
            this.metroPanel3.Controls.Add(this.Button4);
            this.metroPanel3.Controls.Add(this.Button3);
            this.metroPanel3.Controls.Add(this.Button2);
            this.metroPanel3.Controls.Add(this.Button1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(528, 345);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(345, 201);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(120, 148);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(61, 37);
            this.Button0.TabIndex = 12;
            this.Button0.Text = "0";
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonX
            // 
            this.ButtonX.Location = new System.Drawing.Point(31, 148);
            this.ButtonX.Name = "ButtonX";
            this.ButtonX.Size = new System.Drawing.Size(61, 37);
            this.ButtonX.TabIndex = 11;
            this.ButtonX.Text = "X";
            this.ButtonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(210, 100);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(61, 37);
            this.Button9.TabIndex = 10;
            this.Button9.Text = "9";
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(120, 100);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(61, 37);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "8";
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(31, 100);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(61, 37);
            this.Button7.TabIndex = 8;
            this.Button7.Text = "7";
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(210, 57);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(61, 37);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "6";
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(120, 57);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(61, 37);
            this.Button5.TabIndex = 6;
            this.Button5.Text = "5";
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(31, 57);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(61, 37);
            this.Button4.TabIndex = 5;
            this.Button4.Text = "4";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(210, 14);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(61, 37);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "3";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(120, 14);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(61, 37);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "2";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(31, 14);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(61, 37);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "1";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS.Properties.Resources.coffee_shop__1_;
            this.pictureBox1.Location = new System.Drawing.Point(112, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 715);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_login";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_password;
        private MetroFramework.Controls.MetroTextBox metroTextBox_username;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton Button0;
        private MetroFramework.Controls.MetroButton ButtonX;
        private MetroFramework.Controls.MetroButton Button9;
        private MetroFramework.Controls.MetroButton Button8;
        private MetroFramework.Controls.MetroButton Button7;
        private MetroFramework.Controls.MetroButton Button6;
        private MetroFramework.Controls.MetroButton Button5;
        private MetroFramework.Controls.MetroButton Button4;
        private MetroFramework.Controls.MetroButton Button3;
        private MetroFramework.Controls.MetroButton Button2;
        private MetroFramework.Controls.MetroButton Button1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton_password;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton_Votre_ID;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

