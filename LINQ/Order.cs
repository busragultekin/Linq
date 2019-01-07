using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        //Navigation property
        public Customer Customer { get; set; }
        public static List<Order> GetOrders()
        {
            List<Order> list = new List<Order>();
            string query = "select o.CustomerID,o.EmployeeID,o.OrderID,o.OrderDate,(select ContactName from Customers Where CustomerID = o.CustomerID ) as 'ContactName' from Orders o";
            DataTable dt = GetDataTable(query);



            foreach (DataRow row in dt.Rows)
            {
                Order o = new Order();
                o.OrderID = (int)row["OrderID"];
                o.CustomerID = (string)row["CustomerID"];
                o.EmployeeID = (int)row["EmployeeID"];
                o.OrderDate = (DateTime)row["OrderDate"];
                o.Customer = new Customer();
                o.Customer.ContactName = row["ContactName"].ToString();
                o.Customer.CustomerID = (string)row["CustomerID"];
                list.Add(o);
            }

            return list;

        }
        public static DataTable GetDataTable(string query)
        {
            ///1- Connected architecture
            ///2-Disconnected architecture
            string cs = "Data Source=WISSEN\\SQLEXPRESS;Initial Catalog=Northwnd; User ID=Security1; Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter(query, cs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderCount
        {
            get
            {
                return Orders.Count;
            }
        }
    }
}
