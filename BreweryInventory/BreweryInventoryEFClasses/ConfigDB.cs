﻿using Microsoft.Extensions.Configuration;
/*
 * dotnet tool install --global dotnet-ef
 * Use nuget package manager to install efcore, efcore.analyzers, design, tools and mysql.data.efcore
 * -- Install-Package Microsoft.EntityFrameworkCore.Tools could do from the console too
 * Get-Help about_EntityFrameworkCore from the console
 */
namespace BreweryInventoryEFClasses
{
    public class ConfigDB
    {
        public static string GetMySqlConnectionString()
        {
            string folder = AppContext.BaseDirectory;
            var builder = new ConfigurationBuilder()
                .SetBasePath(folder)
                .AddJsonFile("mySqlSettings.json", optional: true, reloadOnChange: true);

            string connectionString = builder.Build().GetConnectionString("mySql");

            return connectionString;
        }
    }
}
