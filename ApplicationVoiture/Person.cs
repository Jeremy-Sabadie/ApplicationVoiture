namespace ApplicationVoiture
{
    /// <summary>
    /// Classe créant un objet personne.
    /// </summary>
    public class Person
    {
        #region personAttributs

        private string _Name;
        private string _FirstName;
        // Propriété de classe pour une liste d'ages:
        private static List<int> _Ages = new List<int>();
        //Proptiété de classe pour avoir un compteur d'instance:
        private static int instanceCount;
        private int iD;

        private int _Age;

        private List<Car> Cars = new List<Car>();
        /// <summary>
        /// Attribut Name pour le nom de l'objet Person.
        /// </summary>
        public string Name { get => _Name; set => _Name = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public int Age { get => _Age; set => _Age = value; }
        public static int InstanceCount { get => instanceCount; private set => instanceCount = value; }
        private static List<int> Ages { get => _Ages; set => _Ages = value; }

        public Person(string name, string firstName, int age)
        {
            Name = name;
            FirstName = firstName;
            Age = age;
            iD = instanceCount;
            instanceCount++;
            Ages.Add(Age);
        }
        //Fonction Average qui calcule la moyenne des ages de la liste contenant les attributs des propriétaires Person.
        public static double Average()
        {
            //Ternaire equivalent à:
            //if (Ages.Count > 0) { Ages.Average()=0.0d; }
            return (Ages.Count > 0) ? Ages.Average() : 0.0d;
        }

        #endregion


        //Fonction Print pour afficher les attribut de l'objet:
        public void Print()
        {
            //Fonction Print pour afficher les attribut de l'objet:

            //Affichage des attributs de l'objet Person avec la fonction Print.


            Console.WriteLine($"Nom:{Name}");
            Console.WriteLine($"Prénom:{FirstName}");
            Console.WriteLine($"age:{Age}");
            //Boucle pour afficher les éléments car  de la lise Cars.
            for (int i = 0; i < Cars.Count; i++)
            {
                this.Cars.ElementAt(i).Print();
            }


        }
        //Fonction qui ajoute Car à la liste de voitures.
        public void AjouterVoiture(Car car)
        {
            this.Cars.Add(car);
        }
        public void SupprimerVoiture(Car car)
        {
            this.Cars.Remove(car);
        }

    }
}

