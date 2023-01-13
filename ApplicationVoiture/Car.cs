namespace ApplicationVoiture
{
    /// <summary>
    /// Classe permetant de créer des cars.
    /// </summary>
    public class Car
    {
        #region CarAttributs
        private string registration;
        /// <summary>
        /// Attribut Model de type chaîne de charactères correspondant au modèle de lobjet Car
        /// </summary>
        private string model;

        private string brand;
        /// <summary>
        /// Attribut de type integer des km de l'objet car.
        /// </summary>
        private Int32 kLM;
        /// <summary>
        /// Attribut de type integer du poids de l'objet car.
        /// </summary>
        private Int32 weight;
        /// <summary>
        /// Attribut de type dateOnly correspondant au poids de l'objet car.
        /// </summary>
        private DateOnly originalServiceDate;

        /// <summary>
        /// Puissance de la voiture en chevaux Dine de l'objet Car. 
        /// </summary>
        private int power;
        /// <summary>
        /// Nom du propriétaire  de l'objet Car de type string. 
        /// </summary>
        private Person? _Owner;

        public string Registration { get => registration; set => registration = value; }
        public string Model { get => model; set => model = value; }
        /// <summary>
        /// Attribut Brand de type chaîne de charactères correspondant à la marque de lobjet Car
        /// </summary>
        public string Brand { get => brand; set => brand = value; }
        public int KLM { get => kLM; set => kLM = value; }
        public int Weight { get => weight; set => weight = value; }
        public DateOnly OriginalServiceDate { get => originalServiceDate; set => originalServiceDate = value; }
        public int Power { get => power; set => power = value; }
        internal Person? Owner { get => _Owner; private set => _Owner = value; }
        #endregion
        //Fonction Print qui affiche les attributs de l'objet Car.
        public void Print()
        {
            Console.WriteLine($"marque: {Brand}");
            Console.WriteLine($"la puissance de{Brand} {Model} est de: {Power}");
            Console.WriteLine($"modèle: {Model}");
            Console.WriteLine($"kilométrage: {KLM}");
            Console.WriteLine($"poids: {Weight}");
            Console.WriteLine($"mise en service: {OriginalServiceDate}");
        }
        public void AjouterPropriétaire(Person owner)
        {
            this.Owner = owner;
        }
        public void SuprimerPropriétaire()
        {
            this.Owner = null;
        }


    }
}
