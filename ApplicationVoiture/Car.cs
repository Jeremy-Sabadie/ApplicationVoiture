using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationVoiture
{
    /// <summary>
    /// Classe permetant de créer des cars.
    /// </summary>
    internal class Car
    {
        #region CarAttributs
        public string Registration;
        /// <summary>
        /// Attribut Model de type chaîne de charactères correspondant au modèle de lobjet Car
        /// </summary>
        public string Model;
        /// <summary>
        ///         /// Attribut Brand de type chaîne de charactères correspondant à la marque de lobjet Car

        /// </summary>
        public string Brand;
        /// <summary>
        /// Attribut de type integer des km de l'objet car.
        /// </summary>
        public Int32 KLM;
        /// <summary>
        /// Attribut de type integer du poids de l'objet car.
        /// </summary>
        public Int32 Weight;
        /// <summary>
        /// Attribut de type dateOnly correspondant au poids de l'objet car.
        /// </summary>
        public DateOnly OriginalServiceDate;

        /// <summary>
        /// Puissance de la voiture en chevaux Dine de l'objet Car. 
        /// </summary>
        public int Power;
        /// <summary>
        /// Nom du propriétaire  de l'objet Car de type string. 
        /// </summary>
        public Person Owner; 
        #endregion
        //Fonction Print.
        public void Print()
        {

        }
    }
}
