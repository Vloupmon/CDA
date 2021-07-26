using Bibliotheque.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.DAL {

    public class PretDAO {
        private static PretDAO _instance = null;
        private static readonly object _verrou = new object();

        public static PretDAO Instance {
            get {
                lock (_verrou) {
                    if (_instance == null) {
                        _instance = new PretDAO();
                    }
                }
                return _instance;
            }
        }

        public HashSet<Pret> GetAll() {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdAdherent, " +
                    "IdExemplaire, " +
                    "DateEmprunt, " +
                    "DateRetour " +
                    "FROM Pret";
                return AlimenterListe(command);
            }
        }

        private HashSet<Pret> AlimenterListe(SqlCommand command) {
            HashSet<Pret> adherents = new HashSet<Pret>();
            using (SqlDataReader rd = command.ExecuteReader()) {
                while (rd.Read()) {
                    adherents.Add(ChargerDonnees(rd));
                }
            }
            return adherents;
        }

        private Pret ChargerDonnees(SqlDataReader rd) {
            Pret adherent = new Pret {
                AdherentID = rd["IdAdherent"].ToString(),
                IdExemplaire = (int)rd["IdExemplaire"],
                DateEmprunt = Convert.ToDateTime(rd["DateEmprunt"]),
                DateRetour = rd["DateRetour"] ==
                DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(rd["DateRetour"])
            };
            return adherent;
        }
    }
}