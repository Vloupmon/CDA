using Bibliotheque.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
            HashSet<Exemplaire> exemplaires = new HashSet<Exemplaire>();
            using (SqlDataReader rd = command.ExecuteReader()) {
                while (rd.Read()) {
                    exemplaires.Add(ChargerDonnees(rd));
                }
            }
            return exemplaires;
        }

        private Exemplaire ChargerDonnees(SqlDataReader rd) {
            Exemplaire exemplaire = new Exemplaire {
                IdExemplaire = (int)rd["IdExemplaire"],
                Empruntable = !Convert.ToBoolean(rd["Empruntable"]),
                ISBN = rd["ISBN"].ToString()
            };
            return exemplaire;
        }

        public void Update(Exemplaire exemplaire) {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand()) {
                command.CommandText = "dbo.Exemplaire_Update";
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
                    ParameterName = "@IdExemplaire",
                    SqlDbType = SqlDbType.NChar,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@Empruntable",
                    SqlDbType = SqlDbType.Bit,
                    Direction = ParameterDirection.Input,
                    Size = 1
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter {
                    ParameterName = "@ISBN",
                    SqlDbType = SqlDbType.NChar,
                    Direction = ParameterDirection.Input,
                    Size = 10
                };
                command.Parameters.Add(parameter);
                // Passage des valeurs
                command.Parameters["@IdExemplaire"].Value = exemplaire.IdExemplaire;
                command.Parameters["@Empruntable"].Value = (exemplaire.Empruntable == true ? 0 : 1);
                command.Parameters["@ISBN"].Value = exemplaire.ISBN;

                if (command.ExecuteNonQuery() == 0) {
                    throw new Exception(Messages.UpdateNonTraite);
                }
            }
        }
    }
}