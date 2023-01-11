using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationVoiture
{
    /// <summary>
    /// Classe créant un objet personne.
    /// </summary>
    internal class Person
    {
        #region personAttributs
        /// <summary>
        /// Attribut Name pour le nom de l'objet Person.
        /// </summary>
        private string Name;
        private string FirstName;
        private int Heigth;
        private int Weigth;
        private int Age;
        public List<Car> Cars = new List<Car>();
        #endregion
        /// <summary>
        /// Get de l'attribut Name
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>Nom de L'objet Person.</returns>
        public string GetName(string Name)
        {
            return Name;
        }
        /// <summary>
        /// Set de l'attribut Name.
        /// </summary>
        /// <param name="Name"></param>
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        /// <summary>
        /// Get de l'attribut Name
        /// </summary>
        /// <param name="FirstName"></param>
        /// <returns>Nom de L'objet Person.</returns>
        public string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public void SetFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }
        /// <summary>
        /// Get pour l'attribut Heigth de Person.
        /// </summary>
        /// <param name="Heigth"=></param>
        /// <returns>Heigth</returns>
        public string GetHeigth(string Heigth)
        {
            return Heigth;
        }
        /// <summary>
        /// Set de l'attribut Weigth.
        /// </summary>
        /// <param name="Weigth"></param>
        public void SetWeigth(int Weigth)
        {
            this.Weigth = Weigth;
        }



        //Get et Set pour lattribut Age.
        public string GetAge(string Age)
        {
            return Age;
        }
        /// <summary>
        /// Set de l'attribut Age.
        /// </summary>
        /// <param name="Age"></param>
        public void SetAge(int Age)
        {
            this.Age = Age;
        }



        //Fonction Print pour afficher les attribut de l'objet:
        public void Print()
        {
            //Fonction Print pour afficher les attribut de l'objet:

            //Affichage des attributs de l'objet Person avec la fonction Print.


            Console.WriteLine($"Nom:{Name}");
            Console.WriteLine($"Prénom:{FirstName}");
            Console.WriteLine($"taille:{Heigth}");
            Console.WriteLine($"poids:{Weigth}");
            Console.WriteLine($"age:{Age}");
            //Boucle pour afficher les éléments car  de la lise Cars.
            for (int i = 0; i < Cars.Count; i++)
            {
                this.Cars.ElementAt(i).Print();
            }


        }
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

