// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

string connectionString = @"Data Source=(LocalDb)\CoursDotNet;Integrated Security=True";
SqlConnection connection = new SqlConnection(connectionString);

string Contact = "CREATE TABLE(" +
    "id int PRIMARY KEY IDENTITY(1,1)" +
    "nom varchar(100)" +
    "prenom varchar(100)" +
    "telephone varchar(10)" + ")";

SqlCommand command = new SqlCommand(Contact, connection);
connection.Open();

try
{
    command.ExecuteNonQuery();
    Console.WriteLine("table créer");
}
catch (Exception ex)
{
    Console.WriteLine("Table existe");
}
finally
{
    command.Dispose();
}
Console.Write("Ajouter un nom :  ");
string nom = Console.ReadLine();
Console.Write("Ajouter un prenom : ");
string prenom = Console.ReadLine();
Console.Write("Ajouter un telephone");
string telephone = Console.ReadLine();

Contact = "INSERT INTO Contact (nom, prenom, prenom) " +
    "OUTPUT INSERTED.id" +
    "values(@nom,@prenom,@telephone)";

command = new SqlCommand(Contact, connection);
command.Parameters.Add(new SqlParameter("@nom", nom));
command.Parameters.Add(new SqlParameter("@prenom",prenom));
command.Parameters.Add(new SqlParameter("@telephone", telephone));

int nbligne = command.ExecuteNonQuery();
int id = (int)command.ExecuteScalar();
Console.WriteLine(nbligne);

Console.WriteLine(id);
command.Dispose();
connection.Close();
