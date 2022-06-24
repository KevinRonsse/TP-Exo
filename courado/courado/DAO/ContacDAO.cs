using courado.Classe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courado.DAO
{
    public class ContactDAO : BaseDAO<Contact>
    {

        private SqlDbType Phone;

        public SqlDbType FirstName { get; private set; }
        public SqlDbType LastName { get; private set; }

        public override Contact Get(int id)
        {
            Contact contact = null;
            request = "SELECT * FROM contact where id=@id";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@id", id));
            _connection.Open();
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                contact = new Contact(_reader.GetInt32(0), _reader.GetString(1), _reader.GetString(2), _reader.GetString(3));
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return contact;
        }

        public override List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Save(Contact element)
        {
            request = "INSERT INTO contact (first_name, lastname, phone) " +
                "OUTPUT INSERTED.ID values" +
                "(@firstName, @lastName, @phone)";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@firstname", FirstName));
            _command.Parameters.Add(new SqlParameter("@lastname", LastName));
            _command.Parameters.Add(new SqlParameter("@phone", Phone));
            _connection.Open();
            element.Id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return element.Id > 0;
        }

        public List<Contact> GetContactByPhone(string phone)
        {
            List<Contact> contacts = new List<Contact>();
            request = "SELECT * FROM contact where phone like @phone";
            _connection = DataBase.Connection;
            _command = new SqlCommand(request, _connection);
            _command.Parameters.Add(new SqlParameter("@phone", phone + "%"));
            _connection.Open();
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                Contact contact = new Contact(_reader.GetInt32(0), _reader.GetString(1), _reader.GetString(2), _reader.GetString(3));
                contacts.Add(contact);
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return contacts;
        }
    }
}
