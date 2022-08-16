using Entityframwordcore;

DataContext d = new DataContext();

Personne p = new Personne()
{
    Name = "toto",
    Age = 22
};

d.Personnes.Add(p);



//List<Personne> list = d.Personnes.ToList();
//Personne p = d.Personnes.FirstOrDefault(p => p.Name == "titi");


Console.WriteLine(p);