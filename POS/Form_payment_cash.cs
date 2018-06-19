using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form_payment_cash : MetroFramework.Forms.MetroForm
    {
        public Form_payment_cash()
        {
            InitializeComponent();
        }
        public delegate void PaymentMadeEvent(object sender, PaymentMadeEventArgs e);

        public event PaymentMadeEvent PaymentMade;

        public decimal Payment_amount;

       

        private void Form_payment_cash_Load(object sender, EventArgs e)
        {
            metroTextBoxmontant_a_payer.Text = Payment_amount.ToString() + " DH ";
        }

        private void paymentHasBeingMade(object sender, EventArgs e)
        {
            try
            {
                decimal total = 0;

                total = Payment_amount - decimal.Parse(metroTextBox_montant_paiement.Text);

                if (total > 0)
                {
                    Payment_amount = total;
                    metroTextBoxmontant_a_payer.Text = Payment_amount.ToString() + " DH ";
                }
                else if (total < 0)
                {
                    MessageBox.Show("s'il vous plaît donner au client : " + total*-1 + " DH ", "monnaie",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    PaymentMade(this, new PaymentMadeEventArgs() { Payment_success = true });
                }else if(total == 0)
                {
                    PaymentMade(this, new PaymentMadeEventArgs() { Payment_success = true });
                }
            }
            catch(Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        

            
        }
    }
    public class PaymentMadeEventArgs:EventArgs {
        private Boolean payment_success;

        public bool Payment_success {
            get => payment_success;
            set => payment_success = value; }
    }
}
