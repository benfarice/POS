using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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


        public void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printdocument = new PrintDocument();

            printDialog.Document = printdocument;

            printdocument.PrintPage += Printdocument_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printdocument.Print();
            }

        }

        private void Printdocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12, FontStyle.Bold);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 200;
            int offset = 40;

            graphic.DrawString("Bienvenue dans votre restaurant", new Font("Courier New", 27, FontStyle.Bold), new SolidBrush(Color.Black),new RectangleF(startX,0,300,400));


            string date_et_heur = "Date : "+DateTime.Now.ToString();
            graphic.DrawString("ticket de paiement", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX,160);
            graphic.DrawString(date_et_heur, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX,190);

            float receipt_total = 0;
            foreach (Class_order  c in orders_List)
            {
                string product_desc = c.nom_produit;
                string product_total = (c.price * c.Qte).ToString();
                string espace = "".PadRight(13);
                string productprice = espace + product_total + " DH";
                receipt_total += c.price * c.Qte;
                graphic.DrawString(product_desc, font, new SolidBrush(Color.Black),new RectangleF(startX, startY + offset, 300, 150));
                graphic.DrawString(productprice, font, new SolidBrush(Color.Black),new RectangleF(startX, startY + offset + (int)FontHeight+5, 300, 150));

                offset += (int)FontHeight + 35;
            }
            graphic.DrawString("Total : "+receipt_total.ToString()+" DH ", font, new SolidBrush(Color.Black), new RectangleF(startX, startY + offset + (int)FontHeight + 5, 300, 150));
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
                    PrintReceipt();
                }
                else
                {
                    MessageBox.Show("il y a une erreur dans la sauvegarde des données");
                }
            }
        }
    }
}
