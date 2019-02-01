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
    public partial class FJeu : Form
    {
        public FJeu()
        {
            InitializeComponent();
        }

        /// Nombre de mines du jeu
        private int bombs = 10;

        /// Taille de la grille de jeu
        private static  int size = 9;

        /// Taille d'une case
        private static int celSize = 40;

        /// Liste des cellules du jeu
        private Cel[,] celsList;

        /// Nombre de drapeaux bien placés
        private int goodFlags = 0;

        /// Temps mis pour gagner la partie
        public static int time = 0;

        /// Meilleurs scores
        public static Score highScore = null;

        /// Chemin du fichier contenant les scores
        public static readonly string bestScoresPath = Application.StartupPath + "\\" + "scores.xml";

        public void meilleursScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHighscore bestScore = new FHighscore();
            bestScore.lb_name_easy.Text = highScore.easy.name;
            bestScore.lb_time_easy.Text = highScore.easy.time.ToString();
            bestScore.lb_date_easy.Text = highScore.easy.date.ToString();
            bestScore.lb_name_medium.Text = highScore.medium.name;
            bestScore.lb_time_medium.Text = highScore.medium.time.ToString();
            bestScore.lb_date_medium.Text = highScore.medium.date.ToString();
            bestScore.lb_name_hard.Text = highScore.hard.name;
            bestScore.lb_time_hard.Text = highScore.hard.time.ToString();
            bestScore.lb_date_hard.Text = highScore.hard.date.ToString();
            bestScore.ShowDialog();
            bestScore.Dispose();
        }

        private void aProposToolStripMenuItem_Click(object sender, MouseEventArgs e)
        {
            FAbout about = new FAbout();
            about.ShowDialog();
            about.Dispose();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3.Enabled = true;
            toolStripMenuItem3.Text = "&Pause";
            time = 0;
            ModifyPanel();
            CreateTable();
            tb_time.Text = "0";
            goodFlags = 0;
            tb_flags.Text = bombs.ToString();
            timer.Enabled = true;
        }

        /// <summary>
        /// Crée la grille de jeu
        /// </summary>
        private void CreateTable()
        {
            // Création des cellules
            Cel btn;
            celsList = new Cel[size, size];
            game_panel.Controls.Clear();
            for (int i=0; i<size; i++)
            {
                for (int j=0; j<size; j++)
                {
                    btn = new Cel();
                    btn.Text = "";
                    btn.Size = new Size(celSize, celSize);
                    game_panel.Controls.Add(btn);
                    btn.Location = new Point(i * celSize, j * celSize);
                    btn.ImageList = images;
                    btn.isBomb = false;
                    btn.isClicked = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Silver;
                    btn.FlatAppearance.MouseOverBackColor = Color.Beige;
                    btn.MouseClick += new MouseEventHandler(_Click);
                    btn.MouseDown += new MouseEventHandler(_Click);
                    celsList[i, j] = btn;
                }
            }
            AjustForm();
            // Placement des mines
            Random r = new Random();
            int bombPlaced = 0;
            while (bombPlaced<bombs)
            {
                int rand1 = 0, rand2 = 0;
                rand1 = r.Next(0, size-1);
                rand2 = r.Next(0, size-1);
                if (!celsList[rand1,rand2].isBomb)
                {
                    celsList[rand1, rand2].isBomb = true;
                    bombPlaced++;
                }
            }
            // Remplissage des liste de voisinage des cellules
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0)
                    {
                        celsList[i, j].addNeighbor(celsList[i + 1, j]);
                    }
                    if (j == 0)
                    {
                        celsList[i, j].addNeighbor(celsList[i, j + 1]);
                    }
                    if (i == size - 1)
                    {
                        celsList[i, j].addNeighbor(celsList[i - 1, j]);
                    }
                    if (j == size - 1)
                    {
                        celsList[i, j].addNeighbor(celsList[i, j - 1]);
                    }
                    if (i == 0 && j == 0)
                    {
                        celsList[i, j].addNeighbor(celsList[i + 1, j + 1]);
                    }
                    else if (i == 0 && j == size - 1)
                    {
                        celsList[i, j].addNeighbor(celsList[i + 1, j - 1]);
                    }
                    else if (i == size - 1 && j == size - 1)
                    {
                        celsList[i, j].addNeighbor(celsList[i - 1, j - 1]);
                    }
                    else if (i == size - 1 && j == 0)
                    {
                        celsList[i, j].addNeighbor(celsList[i - 1, j + 1]);
                    }
                    else if (i == 0 && j > 0)
                    {
                        celsList[i, j].addNeighbor(celsList[i + 1, j - 1]);
                        celsList[i, j].addNeighbor(celsList[i + 1, j + 1]);
                        celsList[i, j].addNeighbor(celsList[i , j + 1]);
                        celsList[i, j].addNeighbor(celsList[i , j - 1]);
                    }
                    else if (i == size - 1 && j > 0)
                    {
                        celsList[i, j].addNeighbor(celsList[i - 1, j - 1]);
                        celsList[i, j].addNeighbor(celsList[i - 1, j + 1]);
                        celsList[i, j].addNeighbor(celsList[i, j + 1]);
                        celsList[i, j].addNeighbor(celsList[i, j - 1]);
                    }
                    else if (j == 0 && i > 0)
                    {
                        celsList[i, j].addNeighbor(celsList[i - 1, j + 1]);
                        celsList[i, j].addNeighbor(celsList[i + 1, j + 1]);
                        celsList[i, j].addNeighbor(celsList[i + 1, j]);
                        celsList[i, j].addNeighbor(celsList[i - 1, j]);
                    }
                    else if (j == size - 1 && i > 0)
                    {
                        celsList[i, j].addNeighbor(celsList[i + 1, j - 1]);
                        celsList[i, j].addNeighbor(celsList[i - 1, j - 1]);
                        celsList[i, j].addNeighbor(celsList[i + 1, j]);
                        celsList[i, j].addNeighbor(celsList[i - 1, j]);
                    }
                    else
                    {
                        celsList[i, j].addNeighbor(celsList[i - 1, j - 1]);
                        celsList[i, j].addNeighbor(celsList[i - 1, j]);
                        celsList[i, j].addNeighbor(celsList[i - 1, j + 1]);
                        celsList[i, j].addNeighbor(celsList[i, j - 1]);
                        celsList[i, j].addNeighbor(celsList[i, j + 1]);
                        celsList[i, j].addNeighbor(celsList[i + 1, j - 1]);
                        celsList[i, j].addNeighbor(celsList[i + 1, j]);
                        celsList[i, j].addNeighbor(celsList[i + 1, j + 1]);
                    }
                }
            }
            // Enregistrement du nombre de mines dans le voisinage
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    celsList[i,j].HowManyBombs();
            }
        }

        /// <summary>
        /// Ce qui se produit lors d'un clic sur une cellule
        /// </summary>
        private void _Click(object sender, MouseEventArgs e)
        {
            Cel btn = (Cel)sender;
            if (e.Button==MouseButtons.Left)
            {
                if (!(btn.ImageIndex==2))
                {
                if (btn.isBomb)
                    Lost(btn);
                else
                {
                    btn.DisplayNotBomb();
                    int test = 0;
                    for (int i=0; i<size; i++)
                    {
                        for (int j=0; j<size; j++)
                        {
                            if (celsList[i, j].isClicked && !celsList[i, j].isBomb)
                                test++;
                        }
                    }
                    if (test == (size * size) - bombs)
                        Win();
                }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (btn.ImageIndex == 2)
                {
                    btn.ImageIndex = -1;
                    btn.Text = "";
                    tb_flags.Text = (int.Parse(tb_flags.Text) + 1).ToString();
                    if (btn.isBomb)
                        goodFlags--;
                }
                else if (btn.Text == "" && !btn.isClicked)
                {
                    if (tb_flags.Text != "0")
                    {
                        btn.ImageIndex = 2;
                        tb_flags.Text = (int.Parse(tb_flags.Text) - 1).ToString();
                        if (btn.isBomb)
                            goodFlags++;
                    }
                }
                if (goodFlags == bombs)
                    Win();
            }
        }

        /// <summary>
        /// Ce qui se produit lorqu'on perd la partie
        /// </summary>
        /// <param name="btn">Cellule sur laquelle on a cliqué</param>
        private void Lost(Cel btn)
        {
            toolStripMenuItem3.Enabled = false;
            timer.Enabled = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (celsList[i, j].isBomb)
                    {
                        celsList[i, j].ImageIndex = 0;
                        celsList[i, j].BackColor = Color.WhiteSmoke;
                        celsList[i, j].FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
                        celsList[i, j].FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
                    }
                     else
                        celsList[i, j].DisplayNotBomb();
                    celsList[i,j].MouseClick -= _Click;
                    celsList[i, j].MouseDown -= _Click;
                    celsList[i, j].FlatStyle = FlatStyle.Flat;
                    celsList[i, j].BackColor = Color.White;
                }
            }
            btn.ImageIndex = 1;
            btn.Enabled = true;
            (new FLost()).ShowDialog();
        }

        private void facileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facileToolStripMenuItem.Checked = true;
            intermédiaireToolStripMenuItem.Checked = false;
            difficileToolStripMenuItem.Checked = false;
            ModifyPanel();
            nouveauToolStripMenuItem_Click(null, null);
        }

        private void intermédiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facileToolStripMenuItem.Checked = false;
            intermédiaireToolStripMenuItem.Checked = true;
            difficileToolStripMenuItem.Checked = false;
            ModifyPanel();
            nouveauToolStripMenuItem_Click(null, null);
        }

        private void difficileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facileToolStripMenuItem.Checked = false;
            intermédiaireToolStripMenuItem.Checked = false;
            difficileToolStripMenuItem.Checked = true;
            ModifyPanel();
            nouveauToolStripMenuItem_Click(null, null);
        }

        /// <summary>
        /// Ajuste la fenêtre
        /// </summary>
        private void AjustForm()
        {
            game_panel.Size = new Size((celSize * size) +4, (celSize * size) +4);
            this.Size = new Size(game_panel.Width + 38, game_panel.Height + 138);
        }

        /// <summary>
        /// Modifie la grille de jeu en fonction de la difficulté
        /// </summary>
        private void ModifyPanel()
        {
            game_panel.Controls.Clear();
            if (facileToolStripMenuItem.Checked)
            {
                size = 9;
                bombs = 10;
            }
            else if (intermédiaireToolStripMenuItem.Checked)
            {
                size = 12;
                bombs = 22;
            }
            else if (difficileToolStripMenuItem.Checked)
            {
                size = 16;
                bombs = 40;
            }
            tb_time.Text = "0";
            tb_flags.Text = bombs.ToString();
            timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tb_time.Text = (int.Parse(tb_time.Text) + 1).ToString();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FAbout()).ShowDialog();
        }

        /// <summary>
        /// Ce qui se produit lorsqu'on gagne la partie
        /// </summary>
        private void Win()
        {
            toolStripMenuItem3.Enabled = false;
            timer.Enabled = false;
            time = int.Parse(tb_time.Text);
            FWin win = new FWin();
            win.label.Text += time + " secondes";
            win.Size = new Size(301, 102);
            if ((facileToolStripMenuItem.Checked && (time < highScore.easy.time || highScore.easy.time==0)) || (intermédiaireToolStripMenuItem.Checked && (time < highScore.medium.time || highScore.medium.time==0)) || (difficileToolStripMenuItem.Checked && (time < highScore.hard.time || highScore.hard.time==0)))
            {
                win.Size = new Size(301, 164);
                win.tbrecord.Text = "";
            }
            win.ShowDialog();
        }

        /// <summary>
        /// Mise à jour des meilleurs scores
        /// </summary>
        public static void updateHighscore(string nameE)
        {
            if (size==9)
            {
                highScore.easy.name = nameE;
                highScore.easy.time = time;
                highScore.easy.date = DateTime.Now;
            }
            else if (size==12)
            {
                highScore.medium.name = nameE;
                highScore.medium.time = time;
                highScore.medium.date = DateTime.Now;
            }
            else if (size==16)
            {
                highScore.hard.name = nameE;
                highScore.hard.time = time;
                highScore.hard.date = DateTime.Now;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            game_panel.Enabled = !game_panel.Enabled;
            if (timer.Enabled)
                toolStripMenuItem3.Text = "&Pause";
            else
                toolStripMenuItem3.Text = "Re&prendre";
        }
    }

}
