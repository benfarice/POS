namespace POS
{
    partial class Form_Pay
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
            this.flowLayoutPanel_list_des_orders_non_payee = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_list_des_orders_non_payee
            // 
            this.flowLayoutPanel_list_des_orders_non_payee.AutoScroll = true;
            this.flowLayoutPanel_list_des_orders_non_payee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_list_des_orders_non_payee.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel_list_des_orders_non_payee.Name = "flowLayoutPanel_list_des_orders_non_payee";
            this.flowLayoutPanel_list_des_orders_non_payee.Size = new System.Drawing.Size(984, 303);
            this.flowLayoutPanel_list_des_orders_non_payee.TabIndex = 0;
            // 
            // Form_Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 383);
            this.Controls.Add(this.flowLayoutPanel_list_des_orders_non_payee);
            this.Name = "Form_Pay";
            this.Text = "Paiement";
            this.Load += new System.EventHandler(this.Form_Pay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_list_des_orders_non_payee;
    }
}