using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Bibliotheque.BOL;
using Bibliotheque.Repository;

namespace Bibliotheque.DALADO
{
    public class LivreADO : ILivreRepository
    {
        private static LivreADO _instance = null;
        private static object _verrou = new object();
        public static LivreADO Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new LivreADO();
                    }
                }
                return _instance;
            }
        }

        public Livre AjouterLivre(Livre nouveauLivre)
        {
            using (DbConnection cnx = DBDAO.Instance.GetDBConnection())
            using (DbCommand command = cnx.CreateCommand())
            {

                command.CommandText = "Livre_Insert";
                command.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres 
                DbParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@RETURN_VALUE";
                parameter.DbType = DbType.Int32;
                parameter.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(parameter);
                parameter = command.CreateParameter();
                parameter.ParameterName = "@ISBN";
                parameter.DbType = DbType.StringFixedLength;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 10;
                command.Parameters.Add(parameter);
                parameter = command.CreateParameter();
                parameter.ParameterName = "@Titre";
                parameter.DbType = DbType.String;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 150;
                command.Parameters.Add(parameter);

                // Passage des valeurs

                command.Parameters["@IdAdherent"].Value = nouveauLivre.Isbn;
                command.Parameters["@NomAdherent"].Value = nouveauLivre.Titre;

                command.ExecuteNonQuery();
            }

            return nouveauLivre;
        }

        public IList<Livre> ListerLivres()
        {
            IList<Livre> livres = null;
            using (DbConnection cnx = DBDAO.Instance.GetDBConnection())
            using (DbCommand cmd = cnx.CreateCommand())
            {
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        if (livres == null) livres = new List<Livre>();
                        livres.Add(new Livre()
                        {
                            Isbn = rd["ISBN"].ToString(),
                            Titre = rd["Titre"].ToString()
                        });
                    }
                }

                return livres;
            }
        }

        public Livre SelectionnerLivreByIsbn(string Isbn)
        {
            Livre livre = null;
            using (DbConnection cnx = DBDAO.Instance.GetDBConnection())
            using (DbCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                DbParameter pIsbn = cmd.CreateParameter();
                pIsbn.ParameterName = "@ISBN";
                pIsbn.DbType = DbType.StringFixedLength;
                pIsbn.Direction = ParameterDirection.InputOutput;
                pIsbn.Value = Isbn;
                cmd.Parameters.Add(pIsbn);
                cmd.CommandText = "Select ISBN,Titre from Livre where ISBN = @ISBN";
                using (DbDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        livre = new Livre();
                        livre.Isbn = rd["ISBN"].ToString();
                        livre.Titre = rd["Titre"].ToString();

                    }
                }
            }
            return livre;
        }
    }
}
