using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BrokerBaze
{
    public class Broker
    {
        SqlConnection connection;
        SqlTransaction transaction;
        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProSoft-Januar2019;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }

        public void OpenConnection() {
            connection.Open();
        }

        public void Closeconnection() {
            connection.Close();
        }

        public List<Igra> VratiSveIgre()
        {
            List<Igra> igre = new List<Igra>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Igra";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Igra i = new Igra
                {
                    IgradId = (int)reader[0],
                    Naziv = (string)reader[1],
                 
                };
                igre.Add(i);
            }
            return igre;
        }

        public List<Pitanje> VratiSvaPitanja(Igra igra)
        {
            List<Pitanje> listaPitanja = new List<Pitanje>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from Pitanje where IgraId = {igra.IgradId}";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Pitanje p = new Pitanje
                {
                    IgraId = (int)reader[0],
                    PitanjeId = (int)reader[1],
                    PitanjeTekst = (string)reader[2],
                    TacanOdgovor = (string)reader[3],
                    BrojPoena = (int)reader[4]
                };
                listaPitanja.Add(p);
            }
            return listaPitanja;
        }

        public void BeginTransaction() {
            transaction = connection.BeginTransaction();
        }

       
        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback() {
            transaction?.Rollback();
        }

    }
}
