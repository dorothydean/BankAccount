using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents bank customer
    /// </summary>
    class Customer
    {
        public int AccountNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
    }

    /// <summary>
    /// Helper class: provides methods to interact with DB
    /// </summary>
    static class BankDB
    {
        /// <summary>
        /// Adds a customer to the database
        /// </summary>
        /// <param name="c">The customer to be added</param>
        /// <exception cref="SqlException">Thrown when database issues occur</exception>
        public static void AddCustomer(Customer c)
        {
            if (c== null)
            {
                throw new NullReferenceException();
            }
            //using statement compiles intoa try/finally and calls dispose in the finally
            using (var con = new SqlConnection())
            {
                con.ConnectionString = "";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "query here";
                
                //TODO add parameters

                int rows = cmd.ExecuteNonQuery();
                //do something with rows if necessary

                //if this was a stored procedure
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandText = "Stored Procedure Name Here";
            }

        }
    }
}
