using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courado.DAO
{
    public abstract class BaseDAO<T>
    {
        protected static SqlConnection _connection;
        protected static SqlCommand _command;
        protected static SqlDataReader _reader;
        protected static string request;

        public abstract bool Save(T element);
        public abstract T Get(int id);
        public abstract List<T> GetAll();
    }
}
