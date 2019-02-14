using System;

namespace DELEGATES_ESSAI
{
    public class InformationEtudiant
    {
        public void AfficherId(Etudiant etud)
        {
            Console.WriteLine("L'identifiant de l'etudiant est");
        }

        public void AfficherNom(Etudiant etud)
        {
            Console.WriteLine("Le nom  de l'etudiant est");
        }
        public void AfficherLastName (Etudiant etud)
        {
            Console.WriteLine("Le deuxieme nom de l'etudiant est");
        }

        public void AfficherNomComplet(Etudiant etud)
        {
            Console.WriteLine("Le nom complet de l'etudiant est");
        }
    }
}
