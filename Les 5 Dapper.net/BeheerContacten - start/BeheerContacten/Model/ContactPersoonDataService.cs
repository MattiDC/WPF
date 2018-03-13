using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace BeheerContacten.Model
{
    public class ContactPersoonDataService
    {
        // Ophalen ConnectionString uit App.config
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["azure"].ConnectionString;

        // Stap 1 Dapper
        // Aanmaken van een object uit de IDbConnection class en 
        // instantiëren van een SqlConnection.
        // Dit betekent dat de connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new SqlConnection(connectionString);

        public List<ContactPersoon> GetContactPersonen()
        {
            // Stap 2 Dapper
            // Uitschrijven SQL statement & bewaren in een string. 
            string sql = "Select * from Contact order by Naam";

            // Stap 3 Dapper
            // Uitvoeren SQL statement op db instance 
            // Type casten van het generieke return type naar een collectie van contactpersonen
            return (List<ContactPersoon>)db.Query<ContactPersoon>(sql);
        }

        public void UpdateContactPersoon(ContactPersoon contactPersoon)
        {
            // SQL statement update 
            string sql = "Update Contact set naam = @naam, email = @email where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new
            {
                contactPersoon.Naam,
                contactPersoon.Email,
                contactPersoon.ID
            });
        }

        public void InsertContactPersoon(ContactPersoon contactPersoon)
        {
            // SQL statement insert
            string sql = "Insert into Contact (naam, email) values (@naam, @email)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new
            {
                contactPersoon.Naam,
                contactPersoon.Email
            });
        }

        public void DeleteContactPersoon(ContactPersoon contactPersoon)
        {
            // SQL statement delete 
            string sql = "Delete Contact where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { contactPersoon.ID });
        }
    }
}
