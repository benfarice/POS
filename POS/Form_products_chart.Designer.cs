namespace POS
{
    partial class Form_products_chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_products)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_products
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_products.ChartAreas.Add(chartArea1);
            this.chart_products.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_products.Legends.Add(legend1);
            this.chart_products.Location = new System.Drawing.Point(20, 60);
            this.chart_products.Name = "chart_products";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_products.Series.Add(series1);
            this.chart_products.Size = new System.Drawing.Size(631, 329);
            this.chart_products.TabIndex = 0;
            this.chart_products.Text = "chart1";
            // 
            // Form_products_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 409);
            this.Controls.Add(this.chart_products);
            this.Name = "Form_products_chart";
            this.Text = "Affichage des ventes par produit";
            this.Load += new System.EventHandler(this.Form_products_chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_products;
    }
}