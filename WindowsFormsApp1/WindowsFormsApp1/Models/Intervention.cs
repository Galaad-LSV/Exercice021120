using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Intervention
    {
        #region attributs
        private static List<Intervention> _collInterventions = new List<Intervention>();

        private float _dureePrevue;
        private float _dureeReelle;
        private string _description;

        /*
         * Le statut peut-être :
         * 
         * N (Non affectée)
         * A (Affectée à la tournée)
         * E (En cours d'intervention)
         * T (Terminée)
         * 
         * */
        private string _statut;
        private Panne _laPanne;

        #endregion

        #region constructeurs
        public Intervention(float dureePrevue, string description, Panne unePanne)
        {
            this._dureePrevue = dureePrevue;
            this._description = description;
            this._laPanne = unePanne;
            this._dureeReelle = 0;
            this._statut = "N";
            _collInterventions.Add(this);
        }
        #endregion

        #region getters/setters
        public static List<Intervention> CollInterventions { get => _collInterventions; set => _collInterventions = value; }
        public float DureePrevue { get => _dureePrevue; set => _dureePrevue = value; }
        public float DureeReelle { get => _dureeReelle; set => _dureeReelle = value; }
        public string Description { get => _description; set => _description = value; }
        public string Statut { get => _statut; set => _statut = value; }
        public Panne LaPanne { get => _laPanne; set => _laPanne = value; }
        #endregion

        #region methodes

        /*
         * Les méthodes getStatut(), setStatut() et getLaPanne() 
         * sont juste des getters/setters présent ci-dessus
         * 
         */

        #endregion
    }
}
