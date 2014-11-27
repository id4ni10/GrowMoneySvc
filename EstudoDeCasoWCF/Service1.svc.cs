using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace EstudoDeCasoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        List<Lib.Client> IService1.GetAllClients()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;User Id=root;database=test;password=root;Persist Security Info=True";
            conn.Open();

            MySqlCommand command = new MySqlCommand("Select * from client", conn);

            DataSet dt = new DataSet("Clients");

            MySql.Data.MySqlClient.MySqlDataAdapter adpt = new MySql.Data.MySqlClient.MySqlDataAdapter(command);
            adpt.Fill(dt);

            conn.Close();


            List<Lib.Client> retorno = new List<Lib.Client>();

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                Lib.Client client = new Lib.Client();
                client.AccountID = (Int32)row["account_id"];
                client.ID = (Int32)row["id"];
                client.BornDate = (DateTime)row["bornDate"];
                client.Name = (String)row["name"];
                retorno.Add(client);
            }

            return retorno;
        }

        List<Lib.Agency> IService1.GetAllAgencyes()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;User Id=root;database=test;password=root;Persist Security Info=True";
            conn.Open();

            MySqlCommand command = new MySqlCommand("Select * from agency", conn);

            DataSet dt = new DataSet("Agencyes");

            MySql.Data.MySqlClient.MySqlDataAdapter adpt = new MySql.Data.MySqlClient.MySqlDataAdapter(command);
            adpt.Fill(dt);

            conn.Close();


            List<Lib.Agency> retorno = new List<Lib.Agency>();

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                Lib.Agency agency = new Lib.Agency();

                agency.Adress = (String)row["adress"];
                agency.ID = (Int32)row["id"];
                agency.Code = (String)row["code"];

                retorno.Add(agency);
            }

            return retorno;
        }

        List<Lib.Account> IService1.GetAllAccounts()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;User Id=root;database=test;password=root;Persist Security Info=True";
            conn.Open();

            MySqlCommand command = new MySqlCommand("Select * from account", conn);

            DataSet dt = new DataSet("Agencyes");

            MySql.Data.MySqlClient.MySqlDataAdapter adpt = new MySql.Data.MySqlClient.MySqlDataAdapter(command);
            adpt.Fill(dt);

            conn.Close();


            List<Lib.Account> retorno = new List<Lib.Account>();

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                Lib.Account account = new Lib.Account();

                account.Balance = (Double)row["balance"];
                account.ID = (Int32)row["id"];
                account.Code = (String)row["code"];
                account.AgencyID = (Int32)row["agency_id"];

                retorno.Add(account);
            }

            return retorno;
        }
    }
}
