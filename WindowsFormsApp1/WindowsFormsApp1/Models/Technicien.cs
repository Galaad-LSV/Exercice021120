using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Technicien
    {
        #region attributs
        private static List<Technicien> CollClassStation = new List<Technicien>();
        private int _id;
        private string _nom;
        private string _prenom;
        public List<Tournee> lesTournees;
        #endregion

        #region constructeurs
        public Technicien(int id, string nom, string prenom)
        {
            this._id = id;
            this._nom = nom;
            this._prenom = prenom;
            CollClassStation.Add(this);
        }
        #endregion

        #region getters/setters
        public static List<Technicien> CollClassStation1 { get => CollClassStation; set => CollClassStation = value; }
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        #endregion

        #region methodes
        #endregion
    }
}
