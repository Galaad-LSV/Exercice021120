using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Panne
    {
		#region Attributs
		private static List<Panne> collClassPanne = new List<Panne>();
		private int _id;
		private DateTime _dateHeurePanne;
		private char _statut;
		private bool _urgent;
		private Lampadaire _leLampadaire;
		private List<Intervention> _lesIntervention;
		#endregion

		#region Constructeur
		public Panne(int idPanne, Lampadaire referenceInterne, bool urgent)
		{
			this._id = idPanne;
			this._leLampadaire = referenceInterne;
			this._urgent = urgent;
			CollClassPanne.Add(this);
		}
		#endregion

		#region Getters-Setters
		public static List<Panne> CollClassPanne { get => collClassPanne; set => collClassPanne = value; }
		public char Statut { get => _statut; set => _statut = value; }
		public Lampadaire LeLampadaire { get => _leLampadaire; set => _leLampadaire = value; }
		public int Id { get => _id; set => _id = value; }
		public DateTime DateHeurePanne { get => _dateHeurePanne; set => _dateHeurePanne = value; }
		public bool Urgent { get => _urgent; set => _urgent = value; }
		public List<Intervention> LesIntervention { get => _lesIntervention; set => _lesIntervention = value; }
		#endregion

		#region Méthodes
		public void AjouteInterventionUrgente(int dureePrevue, string description)
		{
			TourneePlusProche(this)/*Affecte cette intervention où l'intervention la plus proche du lampadaire est en panne */.AffecteInterventionUrgent(new Intervention(dureePrevue, description, this));// Création d'une intervention et on affecte l'intervention 
		}

		#endregion
	}
}
