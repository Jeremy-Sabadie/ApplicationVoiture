using System;
using System.Collections.Generic;
using System.Linq;
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
        public Int32 Height;
        public Int32 Weight;
        public Int32 Age;
        public List<Car> cars = new List<Car>(); 
        #endregion
        //Fonction Print:
        static public void Print()
        {

        }
    }
}
