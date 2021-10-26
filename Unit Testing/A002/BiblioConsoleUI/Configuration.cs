using Microsoft.Extensions.DependencyInjection;
using System;
using Bibliotheque.Repository;
using Bibliotheque.DALEF;
using Bibliotheque.DALADO;
using System.Linq;

public static class Configuration
{
    internal static IServiceProvider _serviceProvider;
    internal static String TypeDAL { get; set; }
    internal static String TypeSGBD { get; set; }
    internal static void ConfigurerServices(string[] args)
    {
        string[] typesDAL = { "DALEF", "DALADO" };
        string[] typesSGBD = { "MySQL", "SqlServer" };
        if (args.Length != 2)
        {
            throw new ApplicationException($"Nombre de paramètres {args.Length} invalide.\r\nL'application ne peut être exécutée");
        }
        if (!typesDAL.Any(td => td == args[0]) || !typesSGBD.Any(ts => ts == args[1]))
        {
            throw new ApplicationException($"L'un des arguments passé en paramètre est invalide.\r\nL'application ne peut être exécutée");
        }
        Configuration.TypeDAL = args[0];
        Configuration.TypeSGBD = args[1];
        var collection = new ServiceCollection();


        if (TypeDAL == "DALADO")
        {
            collection.AddTransient<IAdherentRepository, AdherentADO>();
            if (TypeSGBD == "SqlServer")
            {
                DBDAO.DbConnectionString = "Server=localhost;Database=Bibliotheque;Trusted_Connection=True;";
                DBDAO.DbProviderName = "System.Data.SqlClient";
                DBDAO.TypeSGBD = "SqlServer";
            }
            if (TypeSGBD == "MySQL")
            {
                DBDAO.DbConnectionString = "server=localhost;database=Bibliotheque;user=96GB011;password=Wince1301";
                DBDAO.DbProviderName = "MySql.Data.MySqlClient";
                DBDAO.TypeSGBD = "MySQL";
            }
        }
        if (TypeDAL == "DALEF")
        {
            collection.AddTransient<IAdherentRepository, AdherentEF>();
            if (TypeSGBD == "SqlServer")
            {
                DBEF.DbConnectionString = "Server=localhost;Database=Bibliotheque;Trusted_Connection=True;";
                DBEF.DbProviderName = "System.Data.SqlClient";
            }
            if (TypeSGBD == "MySQL")
            {
                DBEF.DbConnectionString = "server=localhost;database=Bibliotheque;user=96GB011;password=Wince1301";
                DBEF.DbProviderName = "MySql.Data.MySqlClient";
            }
        }

        _serviceProvider = collection.BuildServiceProvider();


    }
    internal static void DisposeServices()
    {
        if (_serviceProvider == null)
        {
            return;
        }
        if (_serviceProvider is IDisposable)
        {
            ((IDisposable)_serviceProvider).Dispose();
        }
    }

}
