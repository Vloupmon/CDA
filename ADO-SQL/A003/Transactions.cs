using System.Data;
using System.Data.SqlClient;

namespace A003 {

    internal static class Transactions {

        internal static SqlConnection CreerConnection(string connectionString) {
            SqlConnection oConnection = new SqlConnection(connectionString);
            return oConnection;
        }

        internal static SqlCommand CreerCommandeMere(SqlConnection oConnection) {
            SqlCommand cmd = oConnection.CreateCommand();
            cmd.CommandText = "dbo.psMere_insert";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter;
            parameter = new SqlParameter {
                ParameterName = "@RETURN_VALUE",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter {
                ParameterName = "@IdMere",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter {
                ParameterName = "@NomMere",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Size = 50
            };
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter {
                ParameterName = "@TS",
                SqlDbType = SqlDbType.Timestamp,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(parameter);
            return (cmd);
        }

        internal static SqlCommand CreerCommandeFille(SqlConnection oConnection) {
            SqlCommand cmd = oConnection.CreateCommand();
            cmd.CommandText = "dbo.psFille_insert";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter;
            parameter = new SqlParameter {
                ParameterName = "@RETURN_VALUE",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter {
                ParameterName = "@IdMere",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter {
                ParameterName = "@IdFille",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter {
                ParameterName = "@NomFille",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Size = 50
            };
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter {
                ParameterName = "@TS",
                SqlDbType = SqlDbType.Timestamp,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(parameter);

            return (cmd);
        }

        internal static int ExecuterCommandeMere(SqlCommand cmd, params object[] parametres) {
            cmd.Parameters["@NomMere"].Value = parametres[0];
            return (cmd.ExecuteNonQuery());
        }

        internal static int ExecuterCommandeFille(SqlCommand cmd, params object[] parametres) {
            cmd.Parameters["@IdMere"].Value = parametres[0];
            cmd.Parameters["@IdFille"].Value = parametres[1];
            cmd.Parameters["@NomFille"].Value = parametres[2];
            return (cmd.ExecuteNonQuery());
        }
    }
}