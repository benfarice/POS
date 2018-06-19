using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace POS
{
    class Database
    {
        private static SqlConnection con;

        public static SqlConnection Con { get => con; set => con = value; }

        public static void connecter()
        {
            string connection_string = "Data Source=YOUSSEF-PC\\SQLEXPRESS;Initial Catalog=POS;User ID=sa;Password=sa;MultipleActiveResultSets=True";
            con = new SqlConnection(connection_string);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                
                try
                {
                    con.Open();

                }catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public static void disconnect()
        {
            if(con.State == System.Data.ConnectionState.Connecting)
            {
                con.Close();
            }
        }

        public static Boolean connect_user(string username,string password)
        {
            Boolean is_ok = false;
            connecter();
           
            string query = "select isnull(count(*),0) as have_account from employe s where s.id = @username and s.pass_word = @password";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.Add("@username", SqlDbType.VarChar);
            command.Parameters["@username"].Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar);
            command.Parameters["@password"].Value = password;

            int x = (int)command.ExecuteScalar();
            
            if (x > 0)
            {
                is_ok = true;
            }
            disconnect();
            return is_ok;
        }

        public static void employee_arrived(string id)
        {
            connecter();
            string query = "insert into arrive_sortis(mois,jour,heur,minute_,id_employe,is_in) values(@mois, @jour, @heur, @minute_, @id, 1)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.Add("@mois", SqlDbType.Int);
            command.Parameters["@mois"].Value = DateTime.Now.Month;
            command.Parameters.Add("@jour", SqlDbType.Int);
            command.Parameters["@jour"].Value = DateTime.Now.Day;
            command.Parameters.Add("@heur", SqlDbType.Int);
            command.Parameters["@heur"].Value = DateTime.Now.Hour;
            command.Parameters.Add("@minute_", SqlDbType.Int);
            command.Parameters["@minute_"].Value = DateTime.Now.Minute;
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Value = int.Parse(id);
            command.ExecuteNonQuery();
            disconnect();
        }

        public static DataTable get_orders_details(int id_order)
        {
            DataTable d = new DataTable();
            connecter();
            string query = "";
            if (id_order == -1)
            {
                 query = "select p.id as ID,p.name as Produit,p.price as Prix,d.Quantite as Quantité,(p.price * d.Quantite) as Total,d.options as Options from the_order o inner join Ordre_details d on o.id = d.order_id inner join products p on p.id = d.product_id where order_id = -1";
                 SqlCommand command = new SqlCommand(query, con);
                 SqlDataAdapter adapter = new SqlDataAdapter(command);
                 adapter.Fill(d);
            }
            else
            {
                 query = "select p.id as ID,p.name as Produit,p.price as Prix,d.Quantite as Quantité,(p.price * d.Quantite) as Total,d.options as Options from the_order o inner join Ordre_details d on o.id = d.order_id inner join products p on p.id = d.product_id where order_id = @id";
                 SqlCommand command = new SqlCommand(query, con);
                 command.Parameters.Add("@id", SqlDbType.Int);
                 command.Parameters["@id"].Value = id_order;
                 SqlDataAdapter adapter = new SqlDataAdapter(command);
                 adapter.Fill(d);
            }
           
           
           
            disconnect();
            return d;
        }
        
        
        public static ArrayList get_restaurant_tables()
        {
            ArrayList a = new ArrayList();
            connecter();
            string query = "select r.id,r.number,r.dispo_status from restaurant_table r";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Class_restaurant_table t = new Class_restaurant_table();
                t.id = (int)reader[0];
                t.number = reader[1].ToString();
                int url = (int)reader[2];
                t.dispo = url;
                if (url == 1)
                {
                    t.image_url = "../images/table_not.png";
                }
                else if(url==0)
                {
                    t.image_url = "../images/table.png";
                }
                a.Add(t);
            }
            disconnect();

            return a;
        }

        public static ArrayList get_customers_array()
        {
            ArrayList c = new ArrayList();
            connecter();
            string query = "select c.id,c.name,c.email,c.phone from customer c";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Class_customer client = new Class_customer();
                client.id    = (int)reader[0];
                client.name  = reader[1].ToString();
                client.email = reader[2].ToString();
                client.phone = reader[3].ToString();
                c.Add(client);
            }
            disconnect();
            return c;
        }
        public static ArrayList get_product_price_name(int id)
        {
            ArrayList data = new ArrayList();
            string name = "";
            float price = 0;
            connecter();
            string query = "select p.name,p.price from products p where p.id = @id";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Value = id;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = (string)reader[0];
                try
                {
                    price = float.Parse(reader[1].ToString());
                }
                catch(Exception y)
                {
                    price = -1;
                }
                
            }
            data.Add(name);
            data.Add(price);
            disconnect();
            return data;
        }

        public static void insert_order(ArrayList order_details,
            int numero_table,int nbr_clients,float total,string nom,
            string phone,string email)
        {
            
            int id_customer = 0;
            int id_the_order = 0;
           // MessageBox.Show(nom);
            try {
                string query_check_customer = "select c.id from customer c where c.name = @name and c.email = @email and c.phone = @phone";
                SqlCommand command = new SqlCommand(query_check_customer, con);
                command.Parameters.Add("@name", SqlDbType.VarChar);
                command.Parameters["@name"].Value = nom;
                command.Parameters.Add("@email", SqlDbType.VarChar);
                command.Parameters["@email"].Value = email;
                command.Parameters.Add("@phone", SqlDbType.VarChar);
                command.Parameters["@phone"].Value = phone;
                var s = command.ExecuteScalar();
                if (s != null)
                {
                    id_customer = (int)s;
                    MessageBox.Show(id_customer.ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
            
            if(id_customer == 0)
            {
                try {
                    string query_insert_customer = "insert into customer(name,email,phone) output INSERTED.id values(@name,@email,@phone)";
                    SqlCommand command2 = new SqlCommand(query_insert_customer, con);
                    command2.Parameters.Add("@name", SqlDbType.VarChar);
                    command2.Parameters["@name"].Value = nom;
                    command2.Parameters.Add("@email", SqlDbType.VarChar);
                    command2.Parameters["@email"].Value = email;
                    command2.Parameters.Add("@phone", SqlDbType.VarChar);
                    command2.Parameters["@phone"].Value = phone;
                    id_customer = (int)command2.ExecuteScalar();
                    MessageBox.Show(id_customer.ToString());
                }
                catch(Exception u)
                {
                    MessageBox.Show(u.ToString());
                }
               
            }


            try
            {
                string query_insert_the_order = "insert into the_order(employe_id,customer_id,restaurant_table,has_payed,how_much_customers) output INSERTED.id values(@employee_id, @customer_id, @numero_t, 0, @nbr)";
                SqlCommand insert_command = new SqlCommand(query_insert_the_order, con);
                insert_command.Parameters.Add("@employee_id", SqlDbType.Int);
                insert_command.Parameters["@employee_id"].Value = int.Parse(Program.username_loged_in);
                insert_command.Parameters.Add("@customer_id", SqlDbType.Int);
                insert_command.Parameters["@customer_id"].Value = id_customer;
                insert_command.Parameters.Add("@numero_t", SqlDbType.Int);
                insert_command.Parameters["@numero_t"].Value = numero_table;
                insert_command.Parameters.Add("@nbr", SqlDbType.Int);
                insert_command.Parameters["@nbr"].Value = nbr_clients;
                id_the_order = (int)insert_command.ExecuteScalar();
                MessageBox.Show(id_the_order.ToString());
            }
            catch(Exception y)
            {
                MessageBox.Show(y.ToString());
            }
            
            foreach(Class_order o in order_details)
            {
                string query_insert_detail = "insert into Ordre_details(order_id,product_id,options,Quantite) values(@id, @p_id,@options, @qte)";
                SqlCommand insert_c = new SqlCommand(query_insert_detail, con);
                insert_c.Parameters.Add("@id", SqlDbType.Int);
                insert_c.Parameters["@id"].Value = id_the_order;
                insert_c.Parameters.Add("@p_id", SqlDbType.Int);
                insert_c.Parameters["@p_id"].Value = o.id_produit;
                insert_c.Parameters.Add("@options", SqlDbType.VarChar);
                if(o.options != "" && o.options != null)
                {
                    insert_c.Parameters["@options"].Value = o.options;
                }
                else
                {
                    insert_c.Parameters["@options"].Value = "Sans spécifier les options";
                }
                
                insert_c.Parameters.Add("@qte", SqlDbType.Float);
                insert_c.Parameters["@qte"].Value = o.Qte;
                insert_c.ExecuteNonQuery();
            }


            string query_update_table_status = "update restaurant_table set dispo_status = 1 where id = @id";
            SqlCommand update_table_status = new SqlCommand(query_update_table_status, con);
            update_table_status.Parameters.Add("@id", SqlDbType.Int);
            update_table_status.Parameters["@id"].Value = numero_table;
            update_table_status.ExecuteNonQuery();

        }


       public static DataTable get_products_catgs()
       {
            DataTable t = new DataTable();
            connecter();
            string query = "select c.id,c.name from Categories c";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(t);
            disconnect();
            return t;
       }



       public static DataTable get_products()
        {
            DataTable t = new DataTable();
            connecter();
            string query = "select p.name as Nom,p.barcode as BareCode,p.price as Prix,p.img as Image,c.name as Catégorie from products p inner join Categories c on c.id=p.cat_id";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(t);
            disconnect();
            return t;
        }
        public static Class_product get_products_by_id(int id)
        {
            Class_product t = new Class_product();
            try
            {
                
                connecter();
                string query = "select p.name as Nom,p.barcode as BareCode,p.price as Prix,p.img as Image,p.cat_id as Catégorie from products p where id = @id";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = id;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    t.name = reader[0].ToString();
                    t.barcode = reader[1].ToString();
                    t.price = float.Parse(reader[2].ToString());
                    t.image = reader[3];
                    t.category = int.Parse(reader[4].ToString());
                }
                disconnect();
            }
            catch(Exception et)
            {
                MessageBox.Show(et.ToString());
            }
           
            return t;
        }
        public static DataTable get_products_by_cat(int cat_id)
        {
            DataTable t = new DataTable();
            connecter();
            string query = "select p.name as Nom,p.barcode as BareCode,p.price as Prix,p.img as Image,c.name as Catégorie from products p inner join Categories c on c.id=p.cat_id where p.cat_id = "+cat_id;
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(t);
            disconnect();
            return t;
        }
        public static Boolean save_new_product(Class_product p)
       {
            Boolean is_saved = true;
            connecter();
            try
            {
                string query = "insert into products(name,price,cat_id,barcode,img) values(@name,@price,@cat_id,@barcode,@img)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@img", SqlDbType.Image).Value = p.image;
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = p.name;
                cmd.Parameters.Add("@barcode", SqlDbType.VarChar);
                cmd.Parameters["@barcode"].Value = p.barcode;
                cmd.Parameters.Add("@cat_id", SqlDbType.Int);
                cmd.Parameters["@cat_id"].Value = p.category;
                cmd.Parameters.Add("@price", SqlDbType.Float);
                cmd.Parameters["@price"].Value = p.price;
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    is_saved = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                is_saved = false;
            }
           
            disconnect();
            return is_saved;
       }

        public static Boolean update_product_by_id(int id,Class_product p)
        {
            Boolean is_updated = true;
            try
            {
                string query = @"update products set name = @n ,barcode =@b,price = @p,img = @i ,cat_id = @c
                 where id = @id";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@i", SqlDbType.Image).Value = p.image;
                cmd.Parameters.Add("@n", SqlDbType.VarChar);
                cmd.Parameters["@n"].Value = p.name;
                cmd.Parameters.Add("@b", SqlDbType.VarChar);
                cmd.Parameters["@b"].Value = p.barcode;
                cmd.Parameters.Add("@c", SqlDbType.Int);
                cmd.Parameters["@c"].Value = p.category;
                cmd.Parameters.Add("@p", SqlDbType.Float);
                cmd.Parameters["@p"].Value = p.price;
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                int i = cmd.ExecuteNonQuery();
                if (i == -1)
                {
                    is_updated = false;
                }
            }catch(Exception r)
            {
                MessageBox.Show(r.ToString());
            }
           
            
            return is_updated;
        }
    }
}
