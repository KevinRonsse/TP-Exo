using comptebancaire.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comptebancaire.DAO
{
    public abstract class BaseDAO<T> : BaseDAOBase
    {
        public BaseDAO()
        {

        }
        public BaseDAO(SqlConnection connection, SqlTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;

        }
    }
}
