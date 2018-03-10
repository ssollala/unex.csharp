using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSQLStatements
{
    class Program
    {
        private static readonly string connString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                @"AttachDbFilename=c:\databases\northwnd.mdf;" +
                "Integrated Security=True";
        private static string sqlSelectStatement = "SELECT AVG(UnitsInStock) FROM Products";

        static void Main(string[] args)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = connString;
            myConnection.Open();
            SqlCommand cmdProduct = new SqlCommand(sqlSelectStatement,
            myConnection);
            Console.WriteLine("Product Table Average Units in Stock\n");
            var obj = cmdProduct.ExecuteScalar();

            double avgUnitsInStock = 0.0;
            if (!Convert.IsDBNull(obj))
                avgUnitsInStock = Convert.ToDouble(obj);

            Console.WriteLine($"Average Units In Stock: {avgUnitsInStock}");
            myConnection.Close();

            Console.WriteLine("\nPress <Enter> to quit...");
            Console.ReadKey();
        }
    }
}
