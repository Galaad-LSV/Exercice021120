using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Lampadaire
    {
		#region Attributs
		private static List<Lampadaire> CollClassLampadaire = new List<Lampadaire>();
		private int _id;
		private string _referenceInterne;
		private double _latitude;
		private double _longitude;
		private int _numero;
		private string _adresse;
		private int _leModele;
		private int _leTypeEmplacement;
		#endregion

		#region Constructeur
		public Lampadaire(int id, string referenceInterne, double latitude, double longtude, int numero, string adresse)
		{
			this._id = id;
			this._referenceInterne = referenceInterne;
			this._latitude = latitude;
			this._longitude = longtude;
			this._numero = numero;
			this._adresse = adresse;
			CollClassLampadaire.Add(this);

		}
		#endregion

		#region Getters-Setters
		public static List<Lampadaire> CollClassLampadaire1 { get => CollClassLampadaire; set => CollClassLampadaire = value; }
		public double Latitude { get => _latitude; set => _latitude = value; }
		public double Longitude { get => _longitude; set => _longitude = value; }
		public int Id { get => _id; set => _id = value; }
		public string ReferenceInterne { get => _referenceInterne; set => _referenceInterne = value; }
		public int Numero { get => _numero; set => _numero = value; }
		public string Adresse { get => _adresse; set => _adresse = value; }
		public int LeModele { get => _leModele; set => _leModele = value; }
		public int LeTypeEmplacement { get => _leTypeEmplacement; set => _leTypeEmplacement = value; }
		#endregion

		#region Méthodes
		/*
		* Les méthodes getStatut(), setStatut() et getLaPanne() 
		* sont juste des getters/setters présent ci-dessus
		* 
		*/
		#endregion
	}
}
