using System;
using System.Collections;
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
    public partial class Form_payment_methodes : MetroFramework.Forms.MetroForm
    {
        public Form_payment_methodes()
        {
            InitializeComponent();
        }
        public decimal total_amount;
        public ArrayList orders_List;
        private void Form_payment_methodes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_cash_btn_Click(object sender, EventArgs e)
        {
            Form_payment_cash f = new Form_payment_cash();
            
            f.Payment_amount = total_amount;
            MessageBox.Show(total_amount.ToString());
            MessageBox.Show(f.Payment_amount.ToString());
            f.PaymentMade += F_PaymentMade;
            //f.Show();
            f.ShowDialog();
        }

        private void F_PaymentMade(object sender, PaymentMadeEventArgs e)
        {
            //MessageBox.Show(e.Payment_success.ToString());
            if (e.Payment_success == true)
            {
                //save the current transaction
                Boolean is_saved = Database.save_transaction(orders_List);
                if (is_saved)
                {
                    MessageBox.Show("la transaction a été enregistrée");
                }
                else
                {
                    MessageBox.Show("il y a une erreur dans la sauvegarde des données");
                }
            }
        }
    }
}
