using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.UI.Console.Core
{
    /// <summary>
    /// Classe qui représente le joueur / la joueuse 
    /// </summary>
    public class Player
    {
        #region Fields
        private string email;
        private string pseudo;
        private DateOnly dateDeNaissance;

        private Player[] Amis = new Player[3]; // Autre classe, il ne peut avoir que 3 amis max
        #endregion

        #region Constructeur
        public Player(string pseudo, DateOnly dateNaissance) 
        {
            this.Pseudo = pseudo;
            this.dateDeNaissance = dateNaissance;   
        }

        public Player(String pseudo)
        {
            this.Pseudo = pseudo;

        }

        public Player(DateOnly dateNaissance)
        {
            this.dateDeNaissance = dateNaissance;

        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Méthode qui permet de changer la position du joueur
        /// </summary>
        public void SeDeplacer() 
        {
            System.Console.WriteLine("Je me déplace");
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Méthode qui permet d'attaquer
        /// </summary>
        public void Attaquer(dynamic ennemy)
        {
            System.Console.WriteLine("J'attaque l'ennemie {0}", ennemy);
        }
        #endregion

        #region Propriétés
        public DateOnly DateDeNaissance
        { 
            get 
            {
                return this.dateDeNaissance; // attribut de ma classe
            }
            set 
            {
                if(value == DateOnly.MinValue)
                {
                    throw new ArgumentException("dateDeNaissance");
                }
                this.dateDeNaissance = value;  // mot clé C# qui permet de récupérer la valeur saisie
            }
        }
        public string Email { get => email; set => email = value; }

        public string Pseudo { get; set; } = "Hermione";

        #endregion
    }
}
