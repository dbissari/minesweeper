using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Démineur
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                FJeu.highScore = Highscore.Deserialize(FJeu.bestScoresPath); // Chargement du fichier
            }
            catch (Exception)
            {
                FJeu.highScore = new Score(); // En cas d'erreur
            }
            Application.Run(new FJeu());
        }
    }
}
