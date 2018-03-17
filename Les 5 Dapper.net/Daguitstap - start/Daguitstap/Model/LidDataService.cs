using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Daguitstap.Model
{
    class LidDataService
    {
        // Ophalen ConnectionString uit App.config
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["azure"].ConnectionString;

        // Stap 1 Dapper
        // Aanmaken van een object uit de IDbConnection class en 
        // instantiëren van een SqlConnection.
        // Dit betekent dat de connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new SqlConnection(connectionString);

        public List<Lid> GetDeelnemers(bool neemtDeel)
        {
            // SQL statement select
            string sql = "Select * from Lid where GaatMee = @neemtDeel order by Naam ASC";

            return (List<Lid>)db.Query<Lid>(sql, new { neemtDeel });
        }

        public void Inschrijven(Lid lid, bool neemtDeel)
        {
            // SQL Statement update
            string sql = "Update Lid set GaatMee = @neemtDeel where id = @id";

            // Uitvoeren SQL statement en doorgeven paramatercolletie
            db.Execute(sql, new
            {
                neemtDeel,
                lid.Id
            });
        }
    }
}
