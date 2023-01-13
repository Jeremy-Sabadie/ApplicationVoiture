
using ApplicationVoiture;
//Création d'un objet de type person.
Person P1 = new Person("Doe", "John", 35);




P1.Age = 35;
//Création de objet voiture C1:
Car C1 = new Car();
C1.Model = "TT";
C1.Brand = "Audi";
C1.KLM = 0;
C1.Registration = "AV48CE";
C1.OriginalServiceDate = new DateOnly(2012, 2, 21);
C1.Power = 211;

//Création de objet voiture C2:
Car C2 = new Car();
C2.Model = "X5";
C2.Brand = "BMW";
C2.Registration = "FH55EE";
C2.OriginalServiceDate = new DateOnly(2012, 3, 22);
C2.Power = 255;


//Liaison des voitures à leur propriaire.
C1.AjouterPropriétaire(P1);
C2.AjouterPropriétaire(P1);
//Ajout des objets voitures dans la liste de leur propriétaire.
P1.AjouterVoiture(C1);
P1.AjouterVoiture(C2);

//C1.Print();
Console.WriteLine("Affichage P1 possédant les 2 voitures : ");
P1.Print();


Console.WriteLine("Affichage de P1 après la suppression d'une des 2 voitures :");
Console.WriteLine($"la moyenne des ages des propriétaires des voitures est de: {Person.Average()}");

P1.SupprimerVoiture(C1);
P1.Print();