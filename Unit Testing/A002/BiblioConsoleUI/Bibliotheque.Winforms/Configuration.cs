﻿using Microsoft.Extensions.DependencyInjection;
using System;
using Bibliotheque.Repository;
using Bibliotheque.DALEF;
using Bibliotheque.DALADO;
using System.Linq;

public static class Configuration
{
    public static IServiceProvider _serviceProvider;
    internal static String TypeDAL { get; set; }
    internal static String TypeSGBD { get; set; }
    internal static void ConfigurerServices(string[] args)
    {
        string[] typesDAL = { "DALEF", "DALADO" };
        string[] typesSGBD = { "MySql", "SqlServer" };
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
                DBDAO.DbConnectionString = "Server=localhost;Database=Bibliotheque;User Id=sa;Password=yourStrong(!)Password";
                DBDAO.DbProviderName = "System.Data.SqlClient";
                DBDAO.TypeSGBD = "SqlServer";
            }
            if (TypeSGBD == "MySql")
            {
                DBDAO.DbConnectionString = "server=localhost;port=3306;database=Bibliotheque;user=root;password=passwd";
                DBDAO.DbProviderName = "MySql.Data.MySqlClient";
                DBDAO.TypeSGBD = "MySql";
            }
        }
        if (TypeDAL == "DALEF")
        {
            collection.AddTransient<IAdherentRepository, AdherentEF>();
            if (TypeSGBD == "SqlServer")
            {
                DBDAO.DbConnectionString = "Server=localhost;Database=Bibliotheque;User Id=sa;Password=yourStrong(!)Password";
                DBEF.DbProviderName = "System.Data.SqlClient";
            }
            if (TypeSGBD == "MySQL")
            {
                DBDAO.DbConnectionString = "server=localhost;port=33060;database=Bibliotheque;user=root;password=passwd";
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
