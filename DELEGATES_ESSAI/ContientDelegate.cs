namespace DELEGATES_ESSAI
{
    public class ContientDelegate
    {
        public delegate void EnsembleDFonction(Etudiant etud);

        public void Execute (string et , EnsembleDFonction del)
        {
            var res = Etudiant.Load(et);

            del(res);

        }


    }
}
