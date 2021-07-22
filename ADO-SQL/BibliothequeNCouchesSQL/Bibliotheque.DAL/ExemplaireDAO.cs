using Bibliotheque.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.DAL {

    public class ExemplaireDAO {
        private static ExemplaireDAO _instance = null;
        private static readonly object _verrou = new object();

        public static ExemplaireDAO Instance {
            get {
                lock (_verrou) {
                    if (_instance == null) {
                        _instance = new ExemplaireDAO();
                    }
                }
                return _instance;
            }
        }

        public HashSet<Exemplaire> GetAll() {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdExemplaire, " +
                    "Empruntable, " +
                    "ISBN " +
                    "FROM Exemplaire";
                return AlimenterListe(command);
            }
        }

        private HashSet<Exemplaire> AlimenterListe(SqlCommand command) {
            HashSet<Exemplaire> adherents = new HashSet<Exemplaire>();
            using (SqlDataReader rd = command.ExecuteReader()) {
                while (rd.Read()) {
                    adherents.Add(ChargerDonnees(rd));
                }
            }
            return adherents;
        }

        private Exemplaire ChargerDonnees(SqlDataReader rd) {
            Exemplaire adherent = new Exemplaire {
                IdExemplaire = (int)rd["IdExemplaire"],
                Empruntable = (bool)rd["Empruntable"],
                Disponible = !(bool)rd["Empruntable"],
                ISBN = rd["ISBN"].ToString()
            };
            return adherent;
        }
    }
}