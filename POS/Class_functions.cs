using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
      

    }
}
