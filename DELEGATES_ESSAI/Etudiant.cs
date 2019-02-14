namespace DELEGATES_ESSAI
{
    public class Etudiant
    {
        public int IdEtudian  { get; set; }
        public string NameEtudiant { get; set; }
        public string LastName { get; set; }
        public string NomComplet { get; set; }

        public static Etudiant Load(string etu)
        {
            return new Etudiant();
        }
    }
}
