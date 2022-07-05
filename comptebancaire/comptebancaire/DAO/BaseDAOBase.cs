using comptebancaire.Classes;
using System.Data.SqlClient;

namespace comptebancaire.DAO
{
    public abstract class BaseDAOBase
    {
        protected static SqlConnection _connection;
        protected static SqlTransaction _transaction;
        protected static SqlCommand _command;
        protected static SqlDataReader _reader;
        protected static string request;

        public override Account Get(int id)
        {
            Account account = null;
            int customerId = 0;
            request = "SELECT account_number, total_amount, customer_id from account where id=@id";
            _connection = DataBase.Connection;
            _connection.Open();
            _transaction = _connection.BeginTransaction();
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@id", id));
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                account = new Account()
                {
                    Id = id,
                    TotalAmount = _reader.GetDecimal(1),
                    AccountNumber = _reader.GetInt32(0),
                };
                account.Customer = new CustomerDAO(_connection, _transaction).Get(_reader.GetInt32(2));
            }
            _reader.Close();
            _command.Dispose();
            _transaction.Commit();
            _connection.Close();
            if (account != null)
            {
                account.Operations = new OperationDAO().getAll(account.Id);
            }
            return account;
        }

        public override List<Account> getAll()
        {
            throw new NotImplementedException();
        }

        public override bool Save(Account element)
        {
            request = "INSERT INTO account (account_number, total_amount, customer_id) " +
                "OUTPUT INSERTED.ID values " +
                "(@accountNumber, @totalAmount, @customerId)";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@accountNumber", element.AccountNumber));
            _command.Parameters.Add(new SqlParameter("@totalAmount", element.TotalAmount));
            _command.Parameters.Add(new SqlParameter("@customerId", element.Customer.Id));
            _connection.Open();
            element.Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return element.Id > 0;
        }
    }
}