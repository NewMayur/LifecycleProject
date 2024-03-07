using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifecycleLibrary
{
    public class SimpleDataAccess
    {
        private readonly IConfiguration _config;

        public SimpleDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public string GetConnectionString(string name = "UserDatabase")
        {
            string connectionString = _config.GetConnectionString(name);
            return connectionString;
        }

        public List<PersonModel> LoadPeople()
        {
            string sql = "select * from dbo.Person";

            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var people = cnn.Query<PersonModel>(sql).ToList();
                return people;

            }
        }
    }
}
