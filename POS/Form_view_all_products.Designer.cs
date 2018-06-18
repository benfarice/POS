namespace POS
{
    partial class Form_view_all_products
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
            this.dataGridView_all_products = new System.Windows.Forms.DataGridView();
            this.metroComboBox_filter = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_all_products
            // 
            this.dataGridView_all_products.AllowUserToAddRows = false;
            this.dataGridView_all_products.AllowUserToDeleteRows = false;
            this.dataGridView_all_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_all_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_all_products.Location = new System.Drawing.Point(23, 81);
            this.dataGridView_all_products.Name = "dataGridView_all_products";
            this.dataGridView_all_products.ReadOnly = true;
            this.dataGridView_all_products.Size = new System.Drawing.Size(740, 300);
            this.dataGridView_all_products.TabIndex = 0;
            // 
            // metroComboBox_filter
            // 
            this.metroComboBox_filter.FormattingEnabled = true;
            this.metroComboBox_filter.ItemHeight = 23;
            this.metroComboBox_filter.Location = new System.Drawing.Point(23, 397);
            this.metroComboBox_filter.Name = "metroComboBox_filter";
            this.metroComboBox_filter.Size = new System.Drawing.Size(319, 29);
            this.metroComboBox_filter.TabIndex = 1;
            // 
            // Form_view_all_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroComboBox_filter);
            this.Controls.Add(this.dataGridView_all_products);
            this.Name = "Form_view_all_products";
            this.Text = "Afficher tous les produits";
            this.Load += new System.EventHandler(this.Form_view_all_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_all_products;
        private MetroFramework.Controls.MetroComboBox metroComboBox_filter;
    }
}