using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CustomerWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CustomerWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Customer GetCustomerById(int id)
        {
            string conString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("GetCustomerById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                Customer customer = new Customer(); 
                while (reader.Read())
                {
                    customer.Id = Convert.ToInt32(reader["ID"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.Age = Convert.ToInt32(reader["Age"]);
                    customer.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
                }
                con.Close();
                return customer;
            }
        }
    }
}
