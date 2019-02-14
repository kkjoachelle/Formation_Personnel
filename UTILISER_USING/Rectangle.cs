namespace UTILISER_USING
{
    public class Rectangle
    {
        //constructeur , injection par constructeur
        private readonly IFigure figurer;


        public Rectangle(IFigure figure)
        {
            this.figurer = figure;
        }
        public void Resultat()
        {
            figurer.Largeur = 12;
            figurer.Longueur = 30;
            

            figurer.AfficherProduit("Voici le produit " + figurer.Longueur * figurer.Largeur);
            figurer.AfficherSomme("Voici la somme " + figurer.Largeur + figurer.Longueur);

            figurer.AfficherDivide("Voici le quptient " + figurer.Largeur / figurer.Longueur);
        } 

    }
}
