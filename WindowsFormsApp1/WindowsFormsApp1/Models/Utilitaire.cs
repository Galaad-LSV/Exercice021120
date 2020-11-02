using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Device.Location;
using WindowsFormsApp1.Models;

namespace lun02nov
{
    public abstract class Utilitaire
    {

        #region methodes
        public static List<Tournee> TourneesEnCours()
        {// Permet de connaitre la liste des tournée en cours
            List<Tournee> TourneesEnCours = new List<Tournee>();

            foreach(Tournee uneTournee in Tournee.CollLesTournees)
            {
                foreach(Intervention uneIntervention in uneTournee.LesInterventions)
                {
                    if (uneTournee.DateHeureDebut <= DateTime.Now && uneIntervention.Statut == "E")
                    {
                        TourneesEnCours.Add(uneTournee);
                    }
                }
            }
            return TourneesEnCours;
        }

        public static int DistanceDeuxLampadaire(Lampadaire lampadaire1, Lampadaire lampadaire2)
        {//calcul entre la distance de deux lampadaire
            var sCoord = new GeoCoordinate(lampadaire1.Latitude, lampadaire1.Longitude);
            var eCoord = new GeoCoordinate(lampadaire2.Latitude, lampadaire2.Longitude);

            int res = (int)sCoord.GetDistanceTo(eCoord);
            return res;
        }

        public static Tournee TourneePlusProche(Panne unePanne)
        {// Peremt de returné la tourné qui est en cours où se trouve la prochaine panne la plus proche
            int distance = Int32.MaxValue;
            Tournee maTournee;

            foreach (Tournee uneTournee in Tournee.CollLesTournees)
            {
                foreach (Intervention uneIntervention in uneTournee.LesInterventions)
                {
                   if ( distance >= DistanceDeuxLampadaire(uneIntervention.LaPanne.LeLampadaire, unePanne.LeLampadaire))
                   {
                        distance = DistanceDeuxLampadaire(uneIntervention.LaPanne.LeLampadaire, unePanne.LeLampadaire);
                        maTournee = uneTournee;
                   }
                }
            }
            return maTournee;
        }

        //public static int NouvelIdPanne()
        //{//Permet de nous donner l'id affecter à un nouveau lampadaire

        //}
        #endregion
    }
}