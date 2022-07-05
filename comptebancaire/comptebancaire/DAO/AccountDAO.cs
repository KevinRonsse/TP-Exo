using comptebancaire.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comptebancaire.DAO
{
    public class AccountDAO : BaseDAO<Account>
    {
        public AccountDAO()
        {

        }
        public AccountDAO(SqlConnection connection, SqlTransaction transaction) : base(connection, transaction)
        {
        }

        public Account GetWithAccountNumber(int id)
        {
            Account account = null;
            int customerId = 0;
            request = "SELECT id, total_amount, customer_id from account where account_number=@id";
            _connection = DataBase.Connection;
            _connection.Open();
            _transaction = _connection.BeginTransaction();
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@id", id));
            _command.Transaction = _transaction;
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                account = new Account()
                {
                    Id = _reader.GetInt32(0),
                    TotalAmount = _reader.GetDecimal(1),
                    AccountNumber = id,
                };
                customerId = _reader.GetInt32(2);
            }
            _reader.Close();
            _command.Dispose();
            account.Customer = new CustomerDAO(_connection, _transaction).Get(customerId);

            _connection.Close();
            if (account != null)
            {
                account.Operations = new OperationDAO().getAll(account.Id);
            }
            return account;
        }

        public bool Update(Account element)
        {
            request = "update account set total_amount=@totalAmount " +
                "where id=@id";
            bool isOpen = _connection.State == ConnectionState.Open;
            _connection = (isOpen) ? _connection : DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            if (isOpen && _transaction != null)
            {
                _command.Transaction = _transaction;
            }
            _command.Parameters.Add(new SqlParameter("@totalAmount", element.TotalAmount));
            _command.Parameters.Add(new SqlParameter("@id", element.Id));
            if (!isOpen)
                _connection.Open();
            int rowNb = (int)_command.ExecuteNonQuery();
            _command.Dispose();
            if (!isOpen)
                _connection.Close();
            return rowNb == 1;
        }
    }
}
