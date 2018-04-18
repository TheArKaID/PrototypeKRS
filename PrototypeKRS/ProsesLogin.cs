using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace PrototypeKRS
{
    class ProsesLogin
    {
        SqlConnection ConfigurationManager;

        public void Runer()
        {

            //string y = Console.ReadLine();

            //Person x = DataTaker(y);

            //Console.WriteLine(x.id);
            //Console.WriteLine(x.username);
            //Console.WriteLine(x.password);
            //Console.Read();
        }


        public Person DataTaker(string user, string pass)
        {
            ConfigurationManager = new SqlConnection();
            var con = ConfigurationManager.ConnectionString = "Data Source=ARKA;Initial Catalog=AdventureWorks;User ID=sa;Password=ArKa2752";

            Person matchingPerson = new Person();
            SqlConnection myConnection = new SqlConnection(con);

            string oString = "Select * from [dbo].[Table] WHERE Username='" + user + "' AND Password='" + pass + "'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);
            //oCmd.Parameters.AddWithValue("@user", user);
            //oCmd.Parameters.AddWithValue("@pass", pass);
            myConnection.Open();


            //check user
            SqlDataAdapter sda = new SqlDataAdapter(oString, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                SqlDataReader oReader = oCmd.ExecuteReader();
                while (oReader.Read())
                {
                    matchingPerson.username = oReader["Username"].ToString();
                    matchingPerson.password = oReader["Password"].ToString();
                    matchingPerson.id = oReader["Id"].ToString();
                    matchingPerson.loginsukses = true;
                }

            }
            else
            {
                matchingPerson.loginsukses = false;
            }
            myConnection.Close();
            return matchingPerson;
        }
        
    }
    public class Person
    {
        public string username { get; set; }
        public string password { get; set; }
        public string id { get; set; }
        public bool loginsukses { get; set; }
    }


}
