using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES_ESSAI
{
    class Program
    {
        static void Main(string[] args)
        {
            var contientDelegate = new ContientDelegate();

            var infoEtud = new InformationEtudiant();

            ContientDelegate.EnsembleDFonction DelegateFine = infoEtud.AfficherId;
            DelegateFine += infoEtud.AfficherLastName;
            DelegateFine += infoEtud.AfficherNom;
            DelegateFine += infoEtud.AfficherNomComplet;

            contientDelegate.Execute("errt", DelegateFine);

            Console.ReadKey();



        }
    }
}
