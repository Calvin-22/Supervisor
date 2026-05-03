using System.ComponentModel;

namespace Supervisor.Model
{
    public class Logs
    {

        [DisplayName("N° d'accès")]
        public int IdAcces { get; set; }

        [DisplayName("Date d'entrée")]
        public DateTime Date_heure_entree { get; set; }

        [DisplayName("Résultat de la tentative")]
        public string Resultat_tentative { get; set; }

        [DisplayName("Quantité commandé")]
        public DateTime Date_heure_sortie { get; set; }

        [DisplayName("Présence")]
        public int Presence { get; set; }

        [DisplayName("Etat de la porte")]
        public int Etat_porte { get; set; }

        [DisplayName("Identifiant de l'utilisateur")]
        public int IdUser { get; set; }

        [DisplayName("Identifiant de la carte NFC")]
        public string UID { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="canal"></param>
        /// <param name="codeGéo"></param>
        /// <param name="produit"></param>
        /// <param name="date"></param>
        /// <param name="commandé"></param>
        /// <param name="manque"></param>
        /// <param name="motif"></param>
        public Logs(int idacces, DateTime date_heure_entree, string resultat_tentative, DateTime date_heure_sortie, int presence, int etat_porte,int idUser, string uid)
        {
            IdAcces = idacces;
            Date_heure_entree = date_heure_entree;
            Resultat_tentative = resultat_tentative;
            Date_heure_sortie = date_heure_sortie;
            Presence = presence;
            Etat_porte = etat_porte;
            IdUser = idUser;
            UID = uid;
        }
    }
}
