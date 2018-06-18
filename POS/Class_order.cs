using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class Class_order
    {
        public int order_id;
        public int id_produit;
        public string options;
        public float Qte;
        public string nom_produit;
        public float price;
        public Class_order(int order_id, int id_produit, string options, float qte)
        {
            this.order_id = order_id;
            this.id_produit = id_produit;
            this.options = options;
            Qte = qte;
        }
        public Class_order()
        {

        }
    }
}
