// See https://aka.ms/new-console-template for more information

using courado.Classe;
using courado.DAO;

Contact contact = new Contact("kevin","ronsse","05164165455");
contact.Emails.Add(new Email() { Mail = "t@t.fr" }); 
contact.Emails.Add(new Email() { Mail = "t@t.com" });
ContactDAO contactDAO = new ContactDAO();
if (contactDAO.Save(contact))
{
    contact.Emails.ForEach(e => e.Save(contact.Id));

}

List<Contact> contacts = Contact.GetContactByPhone("0205");
contacts.ForEach(c => c.Emails = Email.GETEmails(contact.Id));


