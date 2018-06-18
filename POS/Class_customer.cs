using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Class_customer
    {
        public int id;
        public string name;
        public string phone;
        public string email;

        public Class_customer()
        {
        }

        public Class_customer(int id, string name, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
    }
}
