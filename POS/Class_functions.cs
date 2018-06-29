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
            bA.Click += BA_Click;
            my_panel.Controls.Add(bA);
            MetroButton bZ = create_btn_keyboard("bZ", "Z", 158, 54);
            bZ.Click += BZ_Click;
            my_panel.Controls.Add(bZ);
            MetroButton bE = create_btn_keyboard("bE", "E", 210, 54);
            bE.Click += BE_Click;
            my_panel.Controls.Add(bE);
            MetroButton bR = create_btn_keyboard("bR", "R", 262, 54);
            bR.Click += BR_Click;
            my_panel.Controls.Add(bR);
            MetroButton bT = create_btn_keyboard("bT", "T", 314, 54);
            bT.Click += BT_Click;
            my_panel.Controls.Add(bT);
            MetroButton bY = create_btn_keyboard("bY", "Y", 366, 54);
            bY.Click += BY_Click;
            my_panel.Controls.Add(bY);
            MetroButton bU = create_btn_keyboard("bU", "U", 2, 106);
            bU.Click += BU_Click;
            my_panel.Controls.Add(bU);
            MetroButton bI = create_btn_keyboard("bI", "I", 54, 106);
            bI.Click += BI_Click;
            my_panel.Controls.Add(bI);
            MetroButton bO = create_btn_keyboard("bO", "O", 106, 106);
            bO.Click += BO_Click;
            my_panel.Controls.Add(bO);
            MetroButton bP = create_btn_keyboard("bP", "P", 158, 106);
            bP.Click += BP_Click;
            my_panel.Controls.Add(bP);
            MetroButton bQ = create_btn_keyboard("bQ", "Q", 210, 106);
            bQ.Click += BQ_Click;
            my_panel.Controls.Add(bQ);
            MetroButton bS = create_btn_keyboard("bS", "S", 262, 106);
            bS.Click += BS_Click;
            my_panel.Controls.Add(bS);
            MetroButton bD = create_btn_keyboard("bD", "D", 314, 106);
            bD.Click += BD_Click;
            my_panel.Controls.Add(bD);
            MetroButton bF = create_btn_keyboard("bF", "F", 366, 106);
            bF.Click += BF_Click;
            my_panel.Controls.Add(bF);
            MetroButton bG = create_btn_keyboard("bG", "G", 2, 158);
            bG.Click += BG_Click;
            my_panel.Controls.Add(bG);
            MetroButton bH = create_btn_keyboard("bH", "H", 54, 158);
            bH.Click += BH_Click;
            my_panel.Controls.Add(bH);
            MetroButton bJ = create_btn_keyboard("bJ", "J", 106, 158);
            bJ.Click += BJ_Click;
            my_panel.Controls.Add(bJ);
            MetroButton bK = create_btn_keyboard("bK", "K", 158, 158);
            bK.Click += BK_Click;
            my_panel.Controls.Add(bK);
            MetroButton bL = create_btn_keyboard("bL", "L", 210, 158);
            bL.Click += BL_Click;
            my_panel.Controls.Add(bL);
            MetroButton bM = create_btn_keyboard("bM", "M", 262, 158);
            bM.Click += BM_Click;
            my_panel.Controls.Add(bM);
            MetroButton bW = create_btn_keyboard("bW", "W", 314, 158);
            bW.Click += BW_Click;
            my_panel.Controls.Add(bW);
            MetroButton bX = create_btn_keyboard("bX", "X", 366, 158);
            bX.Click += BX_Click;
            my_panel.Controls.Add(bX);
            MetroButton bC = create_btn_keyboard("bC", "C", 2, 210);
            bC.Click += BC_Click;
            my_panel.Controls.Add(bC);
            MetroButton bV = create_btn_keyboard("bV", "V", 54, 210);
            bV.Click += BV_Click;
            my_panel.Controls.Add(bV);
            MetroButton bB = create_btn_keyboard("bB", "B", 106, 210);
            bB.Click += BB_Click;
            my_panel.Controls.Add(bB);
            MetroButton bN = create_btn_keyboard("bN", "N", 158, 210);
            bN.Click += BN_Click;
            my_panel.Controls.Add(bN);
            CheckBox caps = new CheckBox();
            caps.Appearance = Appearance.Button;
            caps.Text = "Verr Maj";
            caps.Size = new Size(50, 50);
            caps.Location = new Point(210,210);
            caps.Name = "caps";
            my_panel.Controls.Add(caps);
            MetroButton bSuppr = create_btn_keyboard("Suppr", "Suppr", 262, 210);
            bSuppr.Click += BSuppr_Click;
            my_panel.Controls.Add(bSuppr);
            

        }

        private static void BN_Click(object sender, EventArgs e)
        {
            write_char("n", "N");
        }

        private static void BB_Click(object sender, EventArgs e)
        {
            write_char("b", "B");
        }

        private static void BV_Click(object sender, EventArgs e)
        {
            write_char("v", "V");
        }

        private static void BC_Click(object sender, EventArgs e)
        {
            write_char("c", "C");
        }

        private static void BX_Click(object sender, EventArgs e)
        {
            write_char("x", "X");
        }

        private static void BW_Click(object sender, EventArgs e)
        {
            write_char("w", "W");
        }

        private static void BM_Click(object sender, EventArgs e)
        {
            write_char("m", "M");
        }

        private static void BL_Click(object sender, EventArgs e)
        {
            write_char("l", "L");
        }

        private static void BK_Click(object sender, EventArgs e)
        {
            write_char("k", "K");
        }

        private static void BJ_Click(object sender, EventArgs e)
        {
            write_char("j", "J");
        }

        private static void BH_Click(object sender, EventArgs e)
        {
            write_char("h", "H");
        }

        private static void BG_Click(object sender, EventArgs e)
        {
            write_char("g", "G");
        }

        private static void BF_Click(object sender, EventArgs e)
        {
            write_char("f", "F");
        }

        private static void BD_Click(object sender, EventArgs e)
        {
            write_char("d", "D");
        }

        private static void BS_Click(object sender, EventArgs e)
        {
            write_char("s", "S");
        }

        private static void BQ_Click(object sender, EventArgs e)
        {
            write_char("q", "Q");
        }

        private static void BP_Click(object sender, EventArgs e)
        {
            write_char("p", "P");
        }

        private static void BO_Click(object sender, EventArgs e)
        {
            write_char("o", "O");
        }

        private static void BI_Click(object sender, EventArgs e)
        {
            write_char("i", "I");
        }

        private static void BU_Click(object sender, EventArgs e)
        {
            write_char("u", "U");
        }

        private static void BY_Click(object sender, EventArgs e)
        {
            write_char("y", "Y");
        }

        private static void BT_Click(object sender, EventArgs e)
        {
            write_char("t", "T");
        }

        private static void BR_Click(object sender, EventArgs e)
        {
            write_char("r", "R");
        }

        private static void BE_Click(object sender, EventArgs e)
        {
            write_char("e", "E");
        }

        private static void BSuppr_Click(object sender, EventArgs e)
        {
           if(Program.focusedTextbox.Text.Length > 0)
           {
              Program.focusedTextbox.Text = Program.focusedTextbox.Text.Substring(0,Program.focusedTextbox.Text.Length-1);
           }
        }

        private static void BZ_Click(object sender, EventArgs e)
        {
            write_char("z", "Z");
        }

        private static void BA_Click(object sender, EventArgs e)
        {
            write_char("a", "A");
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
                //MessageBox.Show("null");
            }
        }

        public static void write_char(string m,string M)
        {
            if (Program.focusedTextbox != null)
            {
                if(Program.focusedKeyBoardPanel != null)
                {
                    Control c = FindControlByName("caps", Program.focusedKeyBoardPanel);
                    if(c is CheckBox)
                    {
                        if (((CheckBox)c).Checked)
                        {
                            Program.focusedTextbox.Text += m;
                        }
                        else
                        {
                            Program.focusedTextbox.Text += M;
                        }
                    }
                }
                
            }
            else
            {
                //MessageBox.Show("null");
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
