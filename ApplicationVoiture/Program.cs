
using ApplicationVoiture;
//Création d'un objet de type person.
Person P1 = new Person();
P1.Name = "Doe";
P1.FirstName = "John";



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
C1.Owner = P1;
C2.Owner = P1;
//Ajout des objets voitures dans la liste de leur propriétaire.
P1.cars.Add(C1);
P1.cars.Add(C2);

C1.Print();
P1.Print();
