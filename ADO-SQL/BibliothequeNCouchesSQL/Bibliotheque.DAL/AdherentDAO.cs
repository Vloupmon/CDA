using Bibliotheque.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bibliotheque.DAL {

    public class AdherentDAO {
        private static AdherentDAO _instance = null;
        private static readonly object _verrou = new object();

        public static AdherentDAO Instance {
            get {
                lock (_verrou) {
                    if (_instance == null) {
                        _instance = new AdherentDAO();
                    }
                }
                return _instance;
            }
        }

        public Adherent GetByID(string idAdherent) {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandType = CommandType.Text;
                SqlParameter pIdAdherent = command.CreateParameter();
                pIdAdherent.ParameterName = "@IdAdherent";
                pIdAdherent.DbType = DbType.String;
                pIdAdherent.Direction = ParameterDirection.InputOutput;
                pIdAdherent.Value = idAdherent;
                command.Parameters.Add(pIdAdherent);
                command.CommandText = "Select IdAdherent,PrenomAdherent,NomAdherent from Adherent where idAdherent = @IdAdherent";
                using (SqlDataReader rd = command.ExecuteReader()) {
                    return rd.Read() ? ChargerDonnees(rd) : null;
                }
            }
        }

        public HashSet<Adherent> GetAll() {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandType = CommandType.Text;
                command.CommandText = "Select IdAdherent,PrenomAdherent,NomAdherent from Adherent";
                return AlimenterListe(command);
            }
        }

        private HashSet<Adherent> AlimenterListe(SqlCommand command) {
            HashSet<Adherent> adherents = new HashSet<Adherent>();
            using (SqlDataReader rd = command.ExecuteReader()) {
                while (rd.Read()) {
                    adherents.Add(ChargerDonnees(rd));
                }
            }
            return adherents;
        }

        private Adherent ChargerDonnees(SqlDataReader rd) {
            Adherent adherent = new Adherent {
                AdherentID = rd["IdAdherent"].ToString(),
                Nom = rd["NomAdherent"].ToString(),
                Prenom = rd["PrenomAdherent"] ==
            DBNull.Value ? string.Empty : rd["PrenomAdherent"].ToString()
                // Prenom = rd["PrenomAdherent"]?.ToString
            };
            return adherent;
        }

        public void Create(Adherent adherent) {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandText = "dbo.Adherent_Insert";
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
                    ParameterName = "@NomAdherent",
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input,
                    Size = 50
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@PrenomAdherent",
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input,
                    Size = 50
                };
                command.Parameters.Add(parameter);
                // Passage des valeurs
                command.Parameters["@IdAdherent"].Value = adherent.AdherentID;
                command.Parameters["@NomAdherent"].Value = adherent.Nom;
                command.Parameters["@PrenomAdherent"].Value = adherent.Prenom;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Adherent adherent) {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandText = "dbo.Adherent_Update";
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
                    ParameterName = "@NomAdherent",
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input,
                    Size = 50
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@PrenomAdherent",
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input,
                    Size = 50
                };
                command.Parameters.Add(parameter);
                // Passage des valeurs
                command.Parameters["@IdAdherent"].Value = adherent.AdherentID;
                command.Parameters["@NomAdherent"].Value = adherent.Nom;
                command.Parameters["@PrenomAdherent"].Value = adherent.Prenom;

                if (command.ExecuteNonQuery() == 0) {
                    throw new Exception(Messages.UpdateNonTraite);
                }
            }
        }

        public void Delete(string idAdherent) {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandText = "dbo.Adherent_Delete";
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

                // Passage des valeurs

                command.Parameters["@IdAdherent"].Value = idAdherent;
                if (command.ExecuteNonQuery() == 0) {
                    throw new Exception(Messages.UpdateNonTraite);
                }
            }
        }
    }
}