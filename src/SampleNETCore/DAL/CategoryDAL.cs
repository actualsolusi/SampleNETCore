using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.IO;
using SampleNETCore.Models;

namespace SampleNETCore.DAL
{
    public class CategoryDAL
    {
        public IConfigurationRoot Configuration { get; private set; }
        private string GetConnStr()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            return Configuration.GetConnectionString("DefaultConnectionString");
        }

        public IEnumerable<Category> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"select * from Categories order by CategoryName";
                var results = conn.Query<Category>(strSql);
                return results;
            }
        }
    }
}
