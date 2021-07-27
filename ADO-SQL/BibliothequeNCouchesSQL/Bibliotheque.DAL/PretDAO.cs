using Bibliotheque.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public void Update(Pret pret) {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandText = "dbo.Pret_Update";
                command.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres
                SqlParameter parameter;
                parameter = new SqlParameter {
                    ParameterName = "@RETURN_VALUE",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@IdAdherent",
                    SqlDbType = SqlDbType.NChar,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@IdExemplaire",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@DateEmprunt",
                    SqlDbType = SqlDbType.Date,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@DateRetour",
                    SqlDbType = SqlDbType.Date,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };

                command.Parameters.Add(parameter);
                // Passage des valeurs
                command.Parameters["@IdAdherent"].Value = pret.AdherentID;
                command.Parameters["@IdExemplaire"].Value = pret.IdExemplaire;
                command.Parameters["@DateEmprunt"].Value = pret.DateEmprunt;
                command.Parameters["@DateRetour"].Value = pret.DateRetour;

                if (command.ExecuteNonQuery() == 0) {
                    throw new Exception(Messages.UpdateNonTraite);
                }
            }
        }

        public void Create(Pret pret) {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandText = "dbo.Pret_Insert";
                command.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres
                SqlParameter parameter;
                parameter = new SqlParameter {
                    ParameterName = "@RETURN_VALUE",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.ReturnValue
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@IdAdherent",
                    SqlDbType = SqlDbType.NChar,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@IdExemplaire",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@DateEmprunt",
                    SqlDbType = SqlDbType.Date,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@DateRetour",
                    SqlDbType = SqlDbType.Date,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };

                command.Parameters.Add(parameter);
                // Passage des valeurs
                command.Parameters["@IdAdherent"].Value = pret.AdherentID;
                command.Parameters["@IdExemplaire"].Value = pret.IdExemplaire;
                command.Parameters["@DateEmprunt"].Value = pret.DateEmprunt;
                command.Parameters["@DateRetour"].Value = null;
                command.ExecuteNonQuery();
            }
        }
    }
}