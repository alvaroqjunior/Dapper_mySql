using System.Collections.Generic;
using Dapper_Mysql.Model;
namespace Dapper_Mysql.Repository
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetAll();
    }
}