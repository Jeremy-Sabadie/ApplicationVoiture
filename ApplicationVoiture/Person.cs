using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public string Name;
        public string FirstName;
        public Int32 Heigth;
        public Int32 Weigth;
        public Int32 Age;
        public List<Car> cars = new List<Car>(); 
        #endregion
        //Fonction Print pour afficher les attribut de l'objet:
        public void Print()
        {
            //Affichage des attributs de l'objet Person avec la fonction Print.
            Console.WriteLine($"Nom:{Name}");
            Console.WriteLine($"Prénom:{FirstName}");
            Console.WriteLine($"taille:{Heigth}");
            Console.WriteLine($"poids:{Weigth}");
            Console.WriteLine($"age:{Age}");
        }
        
    }
}
