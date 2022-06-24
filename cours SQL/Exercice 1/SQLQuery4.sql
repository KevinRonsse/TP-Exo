INSERT INTO personne (titre,prenom,nom,email,telephone) 
OUTPUT inserted.id values
('Mlle','Tata','Toto','tatatoto@monemail.com','0987654321'),
('Mr','Minet','Gros','grosminet@monemail.com','0612345678'),
('Mme','Jane','Doe','janedoe@gmail.com','0987654321'),
('Mr','Bernard','Minet','bernardminet@','0614762345'),
('Mlle','Jessica','Rabbit','jr@gmail.com','0677777777'),
('Mr','Zoro','Legrand','zoro@monemail.com','0987654321'),
('Mme','Foo','Bar','foo@bar.com','0913243546');
