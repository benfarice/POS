namespace POS
{
    partial class Form_payment_cash
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
            this.metroLabel_montant_a_payer = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxmontant_a_payer = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_montant_paiement = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel_montant_paiement = new MetroFramework.Controls.MetroLabel();
            this.metroButtonPaiement_Effectue = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel_montant_a_payer
            // 
            this.metroLabel_montant_a_payer.AutoSize = true;
            this.metroLabel_montant_a_payer.Location = new System.Drawing.Point(23, 81);
            this.metroLabel_montant_a_payer.Name = "metroLabel_montant_a_payer";
            this.metroLabel_montant_a_payer.Size = new System.Drawing.Size(106, 19);
            this.metroLabel_montant_a_payer.TabIndex = 0;
            this.metroLabel_montant_a_payer.Text = "Montant à Payer";
            // 
            // metroTextBoxmontant_a_payer
            // 
            this.metroTextBoxmontant_a_payer.Location = new System.Drawing.Point(189, 77);
            this.metroTextBoxmontant_a_payer.Name = "metroTextBoxmontant_a_payer";
            this.metroTextBoxmontant_a_payer.ReadOnly = true;
            this.metroTextBoxmontant_a_payer.Size = new System.Drawing.Size(277, 23);
            this.metroTextBoxmontant_a_payer.TabIndex = 1;
            // 
            // metroTextBox_montant_paiement
            // 
            this.metroTextBox_montant_paiement.Location = new System.Drawing.Point(189, 123);
            this.metroTextBox_montant_paiement.Name = "metroTextBox_montant_paiement";
            this.metroTextBox_montant_paiement.Size = new System.Drawing.Size(277, 23);
            this.metroTextBox_montant_paiement.TabIndex = 3;
            // 
            // metroLabel_montant_paiement
            // 
            this.metroLabel_montant_paiement.AutoSize = true;
            this.metroLabel_montant_paiement.Location = new System.Drawing.Point(23, 123);
            this.metroLabel_montant_paiement.Name = "metroLabel_montant_paiement";
            this.metroLabel_montant_paiement.Size = new System.Drawing.Size(136, 19);
            this.metroLabel_montant_paiement.TabIndex = 2;
            this.metroLabel_montant_paiement.Text = "Montant du Paiement";
            // 
            // metroButtonPaiement_Effectue
            // 
            this.metroButtonPaiement_Effectue.Location = new System.Drawing.Point(189, 180);
            this.metroButtonPaiement_Effectue.Name = "metroButtonPaiement_Effectue";
            this.metroButtonPaiement_Effectue.Size = new System.Drawing.Size(277, 23);
            this.metroButtonPaiement_Effectue.TabIndex = 4;
            this.metroButtonPaiement_Effectue.Text = "Paiement Effectué";
            this.metroButtonPaiement_Effectue.Click += new System.EventHandler(this.paymentHasBeingMade);
            // 
            // Form_payment_cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 269);
            this.Controls.Add(this.metroButtonPaiement_Effectue);
            this.Controls.Add(this.metroTextBox_montant_paiement);
            this.Controls.Add(this.metroLabel_montant_paiement);
            this.Controls.Add(this.metroTextBoxmontant_a_payer);
            this.Controls.Add(this.metroLabel_montant_a_payer);
            this.Name = "Form_payment_cash";
            this.Text = "Paiements en espèces";
            this.Load += new System.EventHandler(this.Form_payment_cash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel_montant_a_payer;
        private MetroFramework.Controls.MetroTextBox metroTextBoxmontant_a_payer;
        private MetroFramework.Controls.MetroTextBox metroTextBox_montant_paiement;
        private MetroFramework.Controls.MetroLabel metroLabel_montant_paiement;
        private MetroFramework.Controls.MetroButton metroButtonPaiement_Effectue;
    }
}