using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Tournee
    {
        #region attributs
        public static List<Tournee> CollLesTournees = new List<Tournee>();
        private DateTime dateHeureDebut;
        private List<Intervention> lesInterventions;
        private Technicien leTechnicien;
        #endregion

        #region constructeurs
        public Tournee(DateTime uneHeure, Technicien unTechnicien)
        {
            DateHeureDebut = uneHeure;
            LeTechnicien = unTechnicien;
            CollLesTournees.Add(this);
        }
        #endregion

        #region getters/setters
        public List<Intervention> LesInterventions { get => lesInterventions; set => lesInterventions = value; }
        public DateTime DateHeureDebut { get => dateHeureDebut; set => dateHeureDebut = value; }
        public Technicien LeTechnicien { get => leTechnicien; set => leTechnicien = value; }
        #endregion

        #region methodes
        public void ajoutIntervention(Intervention uneIntervention)
        {
            lesInterventions.Add(uneIntervention);
        }
        public void AffecteInterventionUrgente(Intervention uneIntervention)
        {
            lesInterventions.Insert(1, uneIntervention);
        }
        public List<Intervention> InterventionRestante()
        {
            List<Intervention> lesInterventionsRestantes = new List<Intervention>();
            foreach (Intervention uneInter in lesInterventions)
            {
                if (uneInter.Statut == "A")
                {
                    lesInterventionsRestantes.Add(uneInter);
                }
            }
            return lesInterventionsRestantes;
        }
        public Intervention InterventionCours()
        {
            return lesInterventions[1];
        }

        public Intervention GetIntervention(int i)
        {
            return lesInterventions[i];
        }
        #endregion
    }
}
