using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Class_restaurant_table
    {
        public int id;
        public string number;
        public string image_url;
        public int dispo;
        public Class_restaurant_table()
        {
        }

        public Class_restaurant_table(int id, string number, string image_url)
        {
            this.id = id;
            this.number = number;
            this.image_url = image_url;
        }
    }
}
