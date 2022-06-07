using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Public.Services
{
    public class DataService<T>
    {
        public static string DefaultConnectionString = "Persist Security Info=False;Initial Catalog=YourDataBase;Data Source=.";

        public static T GetObject(string query)
        {
            using IDbConnection con = new SqlConnection(DefaultConnectionString);
            var _objs = con.Query<T>(query).ToList();
            if (_objs != null && _objs.Any())
            {
                return _objs.FirstOrDefault();
            }

            return default(T);
        }

        public static List<T> GetList(string query)
        {
            var objects = new List<T>();
            using IDbConnection con = new SqlConnection(DefaultConnectionString);
            var _objs = con.Query<T>(query).ToList();
            if (_objs != null && _objs.Any())
            {
                objects=_objs;
            }

            return objects;

        }

        public static void Execuet(string query)
        {

        }

    }
}
