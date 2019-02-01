using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Démineur
{
    public partial class FWin : Form
    {
        public FWin()
        {
            InitializeComponent();
        }

        private void tbrecord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                FJeu.updateHighscore(tbrecord.Text);
                try
                {
                    Highscore.Serialize(FJeu.bestScoresPath, FJeu.highScore); // Enregistre le nouveau fichier
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Votre score n'a pu être enrgistré pour la raison suivante: \n" + ex.Message + "\n Votre score sera donc perdu à la fermeture du jeu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning); // En cas d'erreur
                }
                FHighscore bestScore = new FHighscore();
                bestScore.lb_name_easy.Text = FJeu.highScore.easy.name;
                bestScore.lb_time_easy.Text = FJeu.highScore.easy.time.ToString();
                bestScore.lb_date_easy.Text = FJeu.highScore.easy.date.ToString();
                bestScore.lb_name_medium.Text = FJeu.highScore.medium.name;
                bestScore.lb_time_medium.Text = FJeu.highScore.medium.time.ToString();
                bestScore.lb_date_medium.Text = FJeu.highScore.medium.date.ToString();
                bestScore.lb_name_hard.Text = FJeu.highScore.hard.name;
                bestScore.lb_time_hard.Text = FJeu.highScore.hard.time.ToString();
                bestScore.lb_date_hard.Text = FJeu.highScore.hard.date.ToString();
                bestScore.ShowDialog();
                bestScore.Dispose();
                this.Close();
            }
        }
    }
}
