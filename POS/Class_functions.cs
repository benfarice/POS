using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace POS
{
    class Class_functions
    {
        public static bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }catch(Exception t)
            {
                MessageBox.Show(t.ToString());
                return false;
            }
        }

       
        public static Control FindControlByName(string name,Panel p)
        {
            foreach (Control c in p.Controls) //assuming this is a Form
            {
                if (c.Name == name)
                    return c; //found
                foreach(Control x in c.Controls)
                {
                    if (x.Name == name)
                        return x;//found
                }
            }
            return null; //not found
        }


        public static void empty_control(Control i)
        {
            List<Control> listControls = new List<Control>();

            foreach (Control control in i.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                i.Controls.Remove(control);
                control.Dispose();
            }
        }


        public static void create_keyboard_panel(Panel my_panel)
        {
            MetroButton b1 = create_btn_keyboard("b1", "1", 2, 2);
            b1.Click += B1_Click;
            my_panel.Controls.Add(b1);
            MetroButton b2 = create_btn_keyboard("b2", "2", 54, 2);
            b2.Click += B2_Click;
            my_panel.Controls.Add(b2);
            MetroButton b3 = create_btn_keyboard("b3", "3", 106, 2);
            b3.Click += B3_Click;
            my_panel.Controls.Add(b3);
            MetroButton b4 = create_btn_keyboard("b4", "4", 158, 2);
            b4.Click += B4_Click;
            my_panel.Controls.Add(b4);
            MetroButton b5 = create_btn_keyboard("b5", "5", 210, 2);
            b5.Click += B5_Click;
            my_panel.Controls.Add(b5);
            MetroButton b6 = create_btn_keyboard("b6", "6", 262, 2);
            b6.Click += B6_Click;
            my_panel.Controls.Add(b6);
            MetroButton b7 = create_btn_keyboard("b7", "7", 314, 2);
            b7.Click += B7_Click;
            my_panel.Controls.Add(b7);
            MetroButton b8 = create_btn_keyboard("b8", "8", 366, 2);
            b8.Click += B8_Click;
            my_panel.Controls.Add(b8);
            MetroButton b9 = create_btn_keyboard("b9", "9", 2, 54);
            b9.Click += B9_Click;
            my_panel.Controls.Add(b9);
            MetroButton b0 = create_btn_keyboard("b0", "0", 54, 54);
            b0.Click += B0_Click;
            my_panel.Controls.Add(b0);
            MetroButton bA = create_btn_keyboard("bA", "A", 106, 54);
            my_panel.Controls.Add(bA);
            MetroButton bZ = create_btn_keyboard("bZ", "Z", 158, 54);
            my_panel.Controls.Add(bZ);
            MetroButton bE = create_btn_keyboard("bE", "E", 210, 54);
            my_panel.Controls.Add(bE);
            MetroButton bR = create_btn_keyboard("bR", "R", 262, 54);
            my_panel.Controls.Add(bR);
            MetroButton bT = create_btn_keyboard("bT", "T", 314, 54);
            my_panel.Controls.Add(bT);
            MetroButton bY = create_btn_keyboard("bY", "Y", 366, 54);
            my_panel.Controls.Add(bY);
            MetroButton bU = create_btn_keyboard("bU", "U", 2, 106);
            my_panel.Controls.Add(bU);
            MetroButton bI = create_btn_keyboard("bI", "I", 54, 106);
            my_panel.Controls.Add(bI);
            MetroButton bO = create_btn_keyboard("bO", "O", 106, 106);
            my_panel.Controls.Add(bO);
            MetroButton bP = create_btn_keyboard("bP", "P", 158, 106);
            my_panel.Controls.Add(bP);
            MetroButton bQ = create_btn_keyboard("bQ", "Q", 210, 106);
            my_panel.Controls.Add(bQ);
            MetroButton bS = create_btn_keyboard("bS", "S", 262, 106);
            my_panel.Controls.Add(bS);
            MetroButton bD = create_btn_keyboard("bD", "D", 314, 106);
            my_panel.Controls.Add(bD);
            MetroButton bF = create_btn_keyboard("bF", "F", 366, 106);
            my_panel.Controls.Add(bF);
            MetroButton bG = create_btn_keyboard("bG", "G", 2, 158);
            my_panel.Controls.Add(bG);
            MetroButton bH = create_btn_keyboard("bH", "H", 54, 158);
            my_panel.Controls.Add(bH);
            MetroButton bJ = create_btn_keyboard("bJ", "J", 106, 158);
            my_panel.Controls.Add(bJ);
            MetroButton bK = create_btn_keyboard("bK", "K", 158, 158);
            my_panel.Controls.Add(bK);
            MetroButton bL = create_btn_keyboard("bL", "L", 210, 158);
            my_panel.Controls.Add(bL);
            MetroButton bM = create_btn_keyboard("bM", "M", 262, 158);
            my_panel.Controls.Add(bM);
            MetroButton bW = create_btn_keyboard("bW", "H", 314, 158);
            my_panel.Controls.Add(bW);
            MetroButton bX = create_btn_keyboard("bX", "X", 366, 158);
            my_panel.Controls.Add(bX);


            MetroButton bC = create_btn_keyboard("bC", "C", 2, 210);
            my_panel.Controls.Add(bC);
            MetroButton bV = create_btn_keyboard("bV", "V", 54, 210);
            my_panel.Controls.Add(bV);
            MetroButton bB = create_btn_keyboard("bB", "B", 106, 210);
            my_panel.Controls.Add(bB);
            MetroButton bN = create_btn_keyboard("bN", "N", 158, 210);
            my_panel.Controls.Add(bN);
        }

        private static void B0_Click(object sender, EventArgs e)
        {
            write_caracter("0");
        }

        private static void B9_Click(object sender, EventArgs e)
        {
            write_caracter("9");
        }

        private static void B8_Click(object sender, EventArgs e)
        {
            write_caracter("8");
        }

        private static void B7_Click(object sender, EventArgs e)
        {
            write_caracter("7");
        }

        private static void B6_Click(object sender, EventArgs e)
        {
            write_caracter("6");
        }

        private static void B5_Click(object sender, EventArgs e)
        {
            write_caracter("5");
        }

        private static void B4_Click(object sender, EventArgs e)
        {
            write_caracter("4");
        }

        private static void B3_Click(object sender, EventArgs e)
        {
            write_caracter("3");
        }

        private static void B2_Click(object sender, EventArgs e)
        {
            write_caracter("2");
        }

        private static void B1_Click(object sender, EventArgs e)
        {
            write_caracter("1");
        }
        public static void write_caracter(string c)
        {
            if (Program.focusedTextbox != null)
            {
                Program.focusedTextbox.Text += c;
            }
            else
            {
                MessageBox.Show("null");
            }
        }
        public static MetroButton create_btn_keyboard(string name,string text,int x,int y)
        {
            MetroButton b1 = new MetroButton();
           
            b1.Size = new Size(50, 50);
            b1.Text = text;
            b1.Name = name;
            b1.Location = new Point(x, y);
            b1.Theme = MetroFramework.MetroThemeStyle.Dark;
            return b1;
        }

        

    }
}
