using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenateurProcStoc
{
    public static class GenerateurProcStoc
    {
        #region Champs Privés
        private static string _connectionString;
        private static string _serverName = "local";
        private static string _pathModeles;
        private static string _catalog;
        private static string _InsertPSModele;
        private static string _UpdatetPSModele;
        private static string _DeletetPSModele;
        private static bool initialisationOK = false;
        private static string _EnteteModele;
        private static string _DropPSModele;
        private static HashSet<Table> _tables = new HashSet<Table>();

        private static string _OutputPath;
        #endregion
        #region Propriétés
        public static string ConnectionString { get => _connectionString; }
        public static string ServerName { get => _serverName; set => _serverName = value; }
        public static string PathModeles { get => _pathModeles; set => _pathModeles = value; }
        public static string InsertPSModele { get => _InsertPSModele; set => _InsertPSModele = value; }
        public static string UpdatetPSModele { get => _UpdatetPSModele; set => _UpdatetPSModele = value; }
        public static string DeletetPSModele { get => _DeletetPSModele; set => _DeletetPSModele = value; }
        public static string OutputPath { get => _OutputPath; set => _OutputPath = value; }
        public static string Catalog { get => _catalog; set => _catalog = value; }
        public static string EnteteModele { get => _EnteteModele; set => _EnteteModele = value; }
        public static string DropPSModele { get => _DropPSModele; set => _DropPSModele = value; }
        public static HashSet<Table> Tables { get => _tables; }
        #endregion
        /// <summary>
        /// Tests de la connexion à la base de données
        /// Initialisation si OK
        /// </summary>
        public static bool Initialize()
        {
            Tables.Clear();
            if (!TesterConnexion())
            {
                throw new Exception("Impossible de se connecter avec les paramètres actuels");
            }
            if (!ChargerModeles(PathModeles))
            {
                throw new Exception("Impossible de charger les modèles des procédures stockées");
            }
            ChargerTables();
            initialisationOK = true;
            return initialisationOK;

        }
        /// <summary>
        /// Initialisation des informations de la table
        /// </summary>
        public static void InitializeTable(Table table)
        {
            ChargerColonnes(table);
            ChargerCle(table);

        }
        private static bool TesterConnexion()
        {
            SqlConnection dbCon;
            bool OK = true;
            if (string.IsNullOrEmpty(_serverName)
                || string.IsNullOrEmpty(_catalog))
            { return !OK; }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                DataSource = _serverName,
                IntegratedSecurity = true,
                InitialCatalog = _catalog
            };
            _connectionString = builder.ConnectionString;
            try
            {
                using (dbCon = new SqlConnection(_connectionString))
                {
                    dbCon.Open();
                }
            }
            catch (Exception e)
            {
                OK = false;

            }
            return OK;
        }
        private static bool ChargerModeles(string pathModeles)
        {

            bool OK = true;
            try
            {
                GenerateurProcStoc.EnteteModele = ChargementContenuModele($@"{pathModeles}\EntetePS.Modele");
                GenerateurProcStoc.DropPSModele = ChargementContenuModele($@"{pathModeles}\DropPS.Modele");
                GenerateurProcStoc.InsertPSModele = ChargementContenuModele($@"{pathModeles}\InsertPS.Modele");
                GenerateurProcStoc.UpdatetPSModele = ChargementContenuModele($@"{pathModeles}\UpdatePS.Modele");
                GenerateurProcStoc.DeletetPSModele = ChargementContenuModele($@"{pathModeles}\DeletePS.Modele");

            }
            catch (Exception)
            {
                OK = false;

            }

            return OK;
        }

        private static string ChargementContenuModele(string pathModele)
        {
            if (File.Exists(pathModele))
            {
                using (StreamReader sr = File.OpenText(pathModele))
                {
                    return sr.ReadToEnd();
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// Chargement de la liste des tables
        /// </summary>
        private static void ChargerTables()
        {
            using (SqlConnection dbCon = new SqlConnection(_connectionString))
            {
                dbCon.Open();
                using (SqlCommand cmd = dbCon.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT TABLE_SCHEMA,TABLE_NAME ";
                    cmd.CommandText += " FROM information_schema.tables ";
                    cmd.CommandText += " where table_type = 'BASE TABLE' And TABLE_NAME != 'sysdiagrams'";
                    AlimenterListeTables(cmd);
                }
            }

        }
        /// <summary>
        /// Charger la liste des colonnes d'une table
        /// </summary>
        /// <param name="table"></param>
        private static void ChargerColonnes(Table table)
        {
            using (SqlConnection dbCon = new SqlConnection(_connectionString))
            {
                dbCon.Open();
                using (SqlCommand cmd = dbCon.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = @"SELECT  c.ORDINAL_POSITION, c.COLUMN_NAME, c.DATA_TYPE, c.CHARACTER_MAXIMUM_LENGTH, c.IS_NULLABLE,";
                    cmd.CommandText += " COLUMNPROPERTY(OBJECT_ID(t.TABLE_SCHEMA + '.' + t.TABLE_NAME), c.COLUMN_NAME, 'isIdentity') as IsIdentity ";
                    cmd.CommandText += "from INFORMATION_SCHEMA.COLUMNS AS c ";
                    cmd.CommandText += "INNER JOIN INFORMATION_SCHEMA.TABLES AS t ";
                    cmd.CommandText += "ON c.TABLE_SCHEMA = t.TABLE_SCHEMA AND c.TABLE_NAME = t.TABLE_NAME ";
                    cmd.CommandText += "Where t.Table_Name = @Name and t.TABLE_SCHEMA = @schema ";
                    cmd.CommandText += "order by c.ORDINAL_POSITION";
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Name",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 128,
                        Value = table.Name
                    });
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@schema",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 128,
                        Value = table.Schema
                    });
                    AlimenterListeColonnes(cmd, table);
                }
            }
        }

        private static void AlimenterListeColonnes(SqlCommand cmd, Table table)
        {
            table.Columns.Clear();
            using (SqlDataReader rd = cmd.ExecuteReader())
            {

                while (rd.Read())
                {
                    Column colonne = new Column();
                    colonne.OrdinalPos = (int)rd["ORDINAL_POSITION"];
                    colonne.Name = rd["COLUMN_NAME"].ToString();
                    colonne.Type = rd["DATA_TYPE"].ToString();
                    colonne.Length = string.IsNullOrEmpty(rd["CHARACTER_MAXIMUM_LENGTH"].ToString()) ? 0 : (int)rd["CHARACTER_MAXIMUM_LENGTH"];
                    colonne.AcceptNull = rd["IS_NULLABLE"].ToString() == "NO" ? false : true;
                    colonne.IsIdentity = (int)rd["IsIdentity"] == 0 ? false : true;
                    table.Columns.Add(colonne);
                }

            }
        }

        /// <summary>
        /// Charger la liste des colonnes consituant la clé d'une table
        /// </summary>
        /// <param name="table"></param>
        private static void ChargerCle(Table table)
        {
            using (SqlConnection dbCon = new SqlConnection(_connectionString))
            {
                dbCon.Open();
                using (SqlCommand cmd = dbCon.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " select tc.name as ColumnName, Cast(ic.key_ordinal as int) as KeyOrderNr ";
                    cmd.CommandText += " from sys.schemas s inner join sys.tables t on s.schema_id = t.schema_id";
                    cmd.CommandText += " inner join sys.indexes i  on t.object_id = i.object_id";
                    cmd.CommandText += " inner join sys.index_columns ic on i.object_id = ic.object_id and i.index_id = ic.index_id";
                    cmd.CommandText += " inner join sys.columns tc on ic.object_id = tc.object_id and ic.column_id = tc.column_id";
                    cmd.CommandText += " where i.is_primary_key = 1";
                    cmd.CommandText += " and t.Name = @Name and s.Name = @schema ";
                    cmd.CommandText += "order by ic.key_ordinal";

                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@Name",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 128,
                        Value = table.Name
                    });
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@schema",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 128,
                        Value = table.Schema
                    });
                    AlimenterListeColonnesCle(cmd, table);
                }
            }
        }
        private static void AlimenterListeColonnesCle(SqlCommand cmd, Table table)
        {
            table.Key.Clear();
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    KeyColumn cle = new KeyColumn();
                    cle.OrdinalPosKey = (int)rd["KeyOrderNr"];
                    cle.Name = rd["ColumnName"].ToString();
                    table.Key.Add(cle);
                }

            }
        }



        private static void AlimenterListeTables(SqlCommand cmd)
        {
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    _tables.Add(new Table() { Schema = rd["TABLE_SCHEMA"].ToString(), Name = rd["TABLE_NAME"].ToString() });
                }

            }
          
        }
        /// <summary>
        /// Génération de la procédure stockée Insert
        /// </summary>
        /// <param name="table"></param>
        /// <param name="auteur"></param>
        /// <param name="suppressionObjets"></param>
        /// <param name="MajConcur"></param>
        /// <returns></returns>
        public static string GenererInsertion(Table table, string auteur, bool suppressionObjets, bool MajConcur)
        {
            Dictionary<string, string> donnees = new Dictionary<string, string>();

            StringBuilder script = new StringBuilder();
            string procedureName =  $"[{table.Schema}].[{table.Name}_Insert]";
            donnees.Add("procedureName", procedureName);

            // Script de suppression

            if (suppressionObjets)
            {
                script.Append(ReplaceString(DropPSModele, donnees));
                script.Append("\n");
            }

            // Script entête

            string tableName = $"[{table.Schema}].[{table.Name}]";
            string description = $"Procédure stockée de l'opération Insertion sur la table {table.Schema}.{table.Name}";
          
            donnees.Add("tableName", tableName);
            donnees.Add("AutorName", auteur);
            donnees.Add("Description", description);
            donnees.Add("CreationDate", DateTime.Now.ToLongDateString());

            script.Append(ReplaceString(EnteteModele, donnees));
            script.Append("\n");

            string parametersList = string.Empty;
            string columnsList = string.Empty;
            string valuesList = string.Empty;
            string selectStatement = string.Empty;
            string scopeIdentity = string.Empty;
            string whereList = string.Empty;
            string selectList = string.Empty;


            foreach (Column colonne in table.Columns)
            {
                if (!string.IsNullOrEmpty(parametersList))
                {
                    parametersList += ",\n";
                }
                parametersList += $"@{colonne.Name} AS {colonne.Type}";
                // pas de définition de longueur pour les champs BLOB
                if (colonne.Length != 0 && colonne.Length<=8000)
                {
                    parametersList += $"({colonne.Length})";
                }
                if (colonne.AcceptNull)
                {
                    parametersList += "=null";
                }

                // Colonnes identité et TimeStamp déclarées en sortie

                if (colonne.IsIdentity || colonne.Type == "timestamp")
                {
                    parametersList += " OUT";
                }

                // Colonnes identité et TimeStamp non retenues dans la liste des valeurs insérées

                if (!colonne.IsIdentity && colonne.Type != "timestamp")
                {
                    if (!string.IsNullOrEmpty(columnsList))
                    {
                        columnsList += ",\n";
                    }
                    columnsList += colonne.Name;
                    if (!string.IsNullOrEmpty(valuesList))
                    {
                        valuesList += ",\n";
                    }
                    valuesList += $"@{colonne.Name}";
                }
            }
            /// Récupération dernière valeur de clé généré si identité
            Column identite = table.Columns.Where(c => c.IsIdentity).FirstOrDefault();

            if (identite != null)
            {
                scopeIdentity = $"SET @{identite.Name} = SCOPE_IDENTITY() \n";
            }

            // Génération de la sélection de valeurs
            // Permet de mettre à jour les valeurs générées par défaut, les timeStamp, ....

            foreach (Column colonne in table.Columns)
            {
                if (!string.IsNullOrEmpty(selectList))
                {
                    selectList += ",\n";
                }
                selectList += $"@{colonne.Name} = {colonne.Name}";
            }

            foreach (KeyColumn colonne in table.Key)
            {
                if (!string.IsNullOrEmpty(whereList))
                {
                    whereList += " AND ";
                }
                whereList += $"@{colonne.Name} = {colonne.Name}";
            }
            donnees.Add("parametersList", parametersList);
            donnees.Add("columnsList", columnsList);
            donnees.Add("valuesList", valuesList);
            donnees.Add("scopeIdentity", scopeIdentity);
            donnees.Add("selectList", selectList);
            donnees.Add("whereList", whereList);

            script.Append(ReplaceString(InsertPSModele, donnees));
            return script.ToString();
        }
        public static string GenererModification(Table table, string auteur, bool suppressionObjets, bool MajConcur)
        {
            Dictionary<string, string> donnees = new Dictionary<string, string>();

            StringBuilder script = new StringBuilder();
            string procedureName = $"[{table.Schema}].[{table.Name}_Update]";
            donnees.Add("procedureName", procedureName);

            // Script de suppression

            if (suppressionObjets)
            {
                script.Append(ReplaceString(DropPSModele, donnees));
                script.Append("\n");
            }

            // Script entête

            string tableName = $"[{table.Schema}].[{table.Name}]";
            string description = $"Procédure stockée de l'opération Modification sur la table {table.Schema}.{table.Name}";
            donnees.Add("tableName", tableName);
            donnees.Add("AutorName", auteur);
            donnees.Add("Description", description);
            donnees.Add("CreationDate", DateTime.Now.ToLongDateString());

            script.Append(ReplaceString(EnteteModele, donnees));
            script.Append("\n");

            string parametersList = string.Empty;
            string setList = string.Empty;
            string whereList = string.Empty;


            foreach (Column colonne in table.Columns)
            {
                if (!string.IsNullOrEmpty(parametersList))
                {
                    parametersList += ",\n";
                }
                parametersList += $"@{colonne.Name} AS {colonne.Type}";
                if (colonne.Length != 0 && colonne.Length <= 8000)
                {
                    parametersList += $"({colonne.Length})";
                }
                if (colonne.AcceptNull)
                {
                    parametersList += "=null";
                }

                // Pas de mise à jour des clés
                // et des colonnes de type timestamp

                if (table.Key.Where(k => k.Name == colonne.Name).FirstOrDefault() == null && colonne.Type != "timestamp") 
                {
                    if (!string.IsNullOrEmpty(setList))
                    {
                        setList += ",\n";
                    }
                    setList += $"{colonne.Name}=@{colonne.Name}";
                }

            }

            // Mise à jour clause Where liste des colonnes de clé
            foreach (KeyColumn clePartie in table.Key)
            {
                if (!string.IsNullOrEmpty(whereList))
                {
                    whereList += " AND ";
                }
                whereList += $"{clePartie.Name}=@{clePartie.Name}";
            }

            // Utilisation de la colonne TimeStamp si gestion de la MAJ Concurentielle

            if (MajConcur)
            {
                Column colTimeStamp = table.Columns.Where(c => c.Type == "timestamp").FirstOrDefault();
                if (colTimeStamp != null)
                {
                    if (!string.IsNullOrEmpty(whereList))
                    {
                        whereList += " AND ";
                    }
                    whereList += $"{colTimeStamp.Name}=@{colTimeStamp.Name}";
                }
                
            }


            donnees.Add("parametersList", parametersList);
            donnees.Add("setList", setList);
            donnees.Add("whereList", whereList);

            script.Append(ReplaceString(UpdatetPSModele, donnees));

            return script.ToString();
        }
        public static string GenererSuppression(Table table, string auteur, bool suppressionObjets, bool MajConcur)
        {
            Dictionary<string, string> donnees = new Dictionary<string, string>();

            StringBuilder script = new StringBuilder();
            string procedureName = string.Format("[{0}].[{1}_Delete]", table.Schema, table.Name);
            donnees.Add("procedureName", procedureName);

            // Script de suppression

            if (suppressionObjets)
            {
                script.Append(ReplaceString(DropPSModele, donnees));
                script.Append("\n");
            }

            // Script entête

            string tableName = $"[{table.Schema}].[{table.Name}]";
            string description = $"Procédure stockée de l'opération Suppresion sur la table {table.Schema}.{table.Name}";
            donnees.Add("tableName", tableName);
            donnees.Add("AutorName", auteur);
            donnees.Add("Description", description);
            donnees.Add("CreationDate", DateTime.Now.ToLongDateString());

            script.Append(ReplaceString(EnteteModele, donnees));
            script.Append("\n");

            string parametersList = string.Empty;
            string whereList = string.Empty;


            foreach (KeyColumn clePartie in table.Key)
            {
                if (!string.IsNullOrEmpty(parametersList))
                {
                    parametersList += ",\n";
                }
                Column colonne = table.Columns.Where(c => c.Name == clePartie.Name).First();

                parametersList += string.Format("@{0} AS {1}", colonne.Name, colonne.Type);
                if (colonne.Length != 0)
                {
                    parametersList += string.Format("({0})", colonne.Length);
                }
                
                    if (!string.IsNullOrEmpty(whereList))
                    {
                        whereList += " AND ";
                    }
                    whereList += string.Format("{0}=@{1}", clePartie.Name, clePartie.Name);
            }
            // Utilisation de la colonne TimeStamp si gestion de la MAJ Concurentielle

            if (MajConcur)
            {
                Column colTimeStamp = table.Columns.Where(c => c.Type == "timestamp").FirstOrDefault();
                if (colTimeStamp != null)
                {
                    if (!string.IsNullOrEmpty(whereList))
                    {
                        whereList += " AND ";
                        parametersList += ",\n";
                    }
                    whereList += $"{colTimeStamp.Name}=@{colTimeStamp.Name}";
                    parametersList += $"@{colTimeStamp.Name} AS {colTimeStamp.Type}";
                }

            }
            donnees.Add("parametersList", parametersList);
            donnees.Add("whereList", whereList);

            script.Append(ReplaceString(DeletetPSModele, donnees));

            return script.ToString();
        }
        /// <summary>
        /// Remplacement des paramètres du modèle par les valeurs
        /// </summary>
        /// <param name="modele"></param>
        /// <param name="replaceInModele"></param>
        /// <returns></returns>
        public static string ReplaceString(string modele, Dictionary<string, string> replaceInModele)
        {

            foreach (KeyValuePair<string, string> kvp in replaceInModele)
            {
                modele = modele.Replace($"<%{kvp.Key}%>", kvp.Value);
            }

            return modele;

        }
        public static bool ExecuterScript(string script,Table table,string operation,Histo histo )
        { 
            
            Histo.Entree entree = new Histo.Entree();
            entree.TableName = table.Name;
            entree.Operation = operation;
            entree.Resultat = true;

            try
            { 
            using (SqlConnection dbCon = new SqlConnection(_connectionString))
            {
                dbCon.Open();
                    // Boucle pour pouvoir exécuter plusieurs scripts 
                    // Go n'est pas accepté au sein d'une commande 
                    // La chaine est découpée et les GO sont éliminés
                    // Une autre solution consiste à utiliser SMO  voir le lien suivant
                //     https://smehrozalam.wordpress.com/2009/05/12/c-executing-batch-t-sql-scripts-with-go-statements/

                    Regex regex = new Regex(@"\r{0,1}\nGO\r{0,1}\n");
                    string[] commands = regex.Split(script);

                    for (int i = 0; i < commands.Length; i++)
                    {
                        if (commands[i] != string.Empty)
                        {
                            using (SqlCommand command = new SqlCommand(commands[i], dbCon))
                            {
                                command.ExecuteNonQuery();
                                command.Dispose();
                            }
                        }
                    }
               
            }
            }
            // Le traitement se poursuit
            catch (Exception ex)
            {
                entree.Resultat = false;
                entree.ErreurText = ex.Message;
            }

            histo.Entrees.Add(entree);
            return entree.Resultat;
        }
    }
}
