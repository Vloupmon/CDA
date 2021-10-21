using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheque.BLL
{
    public static class Config
    {
        public static bool DBConfigured { get; set; }
        public static string DbConnectionString { get; set; } = null;
        public static string DbProviderName { get; set; } = null;

        public static void ConfigureDB(string dbConnectionString, string dbProviderName)
        {
            DbConnectionString = DbConnectionString;

        }
    }
}
