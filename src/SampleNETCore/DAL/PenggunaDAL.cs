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
    //coba contoh sql injection
    public class PenggunaDAL
    {
        public void Registrasi(Pengguna pengguna)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionHelper.GetConnStr()))
            {

            }
        }
    }
}
