using Bibliotheque.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace Bibliotheque.DALADO
{
    public class DBDAO
    {
        public static string DbConnectionString { get; set; } = null;
        public static string DbProviderName { get; set; } = null;
        public static string TypeSGBD { get; set; } = null;
        private static DBDAO _instance = null;
        private DbConnection _dbCon = null;
        private static readonly object _verrou = new object();

        public static DBDAO Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new DBDAO();
                    }
                }
                return _instance;
            }
        }
        /// <summary>
        /// Fournit une connexion à la base de données valide
        /// Les informations de connexion sont extraites du fichier de configuration
        /// cette méthode fait appel à une fabrique pattern Factory
        /// </summary>
        /// <returns></returns>
        public DbConnection GetDBConnection()
        {

            if (TypeSGBD== "MySql")
            {
                DbProviderFactories.RegisterFactory(DBDAO.DbProviderName, MySql.Data.MySqlClient.MySqlClientFactory.Instance);
            }
            if (TypeSGBD == "SqlServer")
            {
                DbProviderFactories.RegisterFactory(DBDAO.DbProviderName, SqlClientFactory.Instance);
            }

            DbProviderFactory fabrique = DbProviderFactories.GetFactory(DBDAO.DbProviderName);

            if (_dbCon == null)
            {
                _dbCon = fabrique.CreateConnection();
            }
            if (_dbCon.State == ConnectionState.Closed)
            {
                _dbCon.ConnectionString = DBDAO.DbConnectionString;
                _dbCon.Open();
            }
            return _dbCon;
        }
       
    }
}
