using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.Extensions.Configuration;
using System.IO;

namespace SampleNETCore.DAL
{
    public static class ConnectionHelper
    {
        public static IConfigurationRoot Configuration { get; private set; }
        public static string GetConnStr()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            return Configuration.GetConnectionString("DefaultConnectionString");
        }
    }
}
