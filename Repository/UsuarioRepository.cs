using System.Collections.Generic;
using Dapper;
using Dapper_Mysql.Model;
using MySql.Data.MySqlClient;

namespace Dapper_Mysql.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Usuario> GetAll()
        {
            using MySqlConnection connection = new MySqlConnection(_connectionString);
            return connection.Query<Usuario>("SELECT * from usuario");
        }
    }
}