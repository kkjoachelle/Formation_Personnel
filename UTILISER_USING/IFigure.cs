namespace UTILISER_USING
{
    public interface IFigure
    {
        int Longueur { get; set; }
        int Largeur { get; set; }
        void AfficherProduit(string message);
        void AfficherSomme(string message );

        void AfficherDivide(string message);
    }
}
