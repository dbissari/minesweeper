using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Démineur
{
    /// <summary>
    /// Bouton spécial représentant une cellule du jeu
    /// </summary>
    public class Cel : Button
    {
        #region Attributs de la cellule

        private bool _isBomb = false;
        /// Booléen indiquant si la cellule est une bombe
        public bool isBomb
        {
            get { return this._isBomb; }
            set { this._isBomb = value; }
        }

        private int bombs;

        /// Liste des cellules voisines
        private List<Cel> neighbors = null;

        private bool _isClicked = false;
        /// Booléen indiquant si la cellule a déjà été sélectionnée
        public bool isClicked
        {
            get { return this._isClicked; }
            set { this._isClicked = value; }
        }

        #endregion

        #region Methodes propres aux cellules

        /// <summary>
        /// Actualise le nombre de bombes voisines
        /// </summary>
        public void HowManyBombs()
        {
            bombs = 0;
            for (int i = 0; i < neighbors.Count; i++)
                if (neighbors[i].isBomb)
                    bombs++;
        }

        /// <summary>
        /// Affichage dans le cas d'une cellule non piégée
        /// </summary>
        public void DisplayNotBomb()
        {
            if (!this.isClicked)
            {
                this.BackColor = Color.White;
                this.FlatAppearance.MouseOverBackColor = Color.White;
                this.FlatAppearance.MouseDownBackColor = Color.White;
                this.ImageIndex = -1;
                this.Text = "";
                this.isClicked = true;
                if (this.bombs == 0)
                {
                    foreach (Cel move in neighbors)
                    {
                        if (!move.isBomb)
                            move.DisplayNotBomb();
                    }
                }
                else
                {
                    this.Text = bombs.ToString();
                    if (this.bombs == 1)
                        this.ForeColor = Color.Green;
                    else if (this.bombs == 2)
                        this.ForeColor = Color.Blue;
                    else if (this.bombs == 3)
                        this.ForeColor = Color.Orange;
                    else if (this.bombs == 4)
                        this.ForeColor = Color.OrangeRed;
                    else if (this.bombs > 4)
                        this.ForeColor = Color.Red;
                    this.FlatAppearance.BorderColor=Color.Black;
                }
            }
        }

        /// <summary>
        /// Permet d'ajouter une cellule à la liste des cellules voisines
        /// </summary>
        /// <param name="value">Cellule à ajouter à la liste</param>
        public void addNeighbor(Cel value)
        {
            if (neighbors == null)
                neighbors = new List<Cel>();
            neighbors.Add(value);
        }

        #endregion

    }

    public class Highscore
    {
        /// <summary>
        /// Créer le fichier de de sauvegarde des meilleurs scores
        /// </summary>
        /// <param name="fileName"> Le fichier dans lequel on écrit </param>
        /// <param name="highscore"> Les scores à enregistrer </param>
        public static void Serialize(string fileName, Score highscore)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Score));
            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, highscore);
            writer.Close();
        }

        /// <summary>
        ///  Lit le fichier de sauvegarde des meilleurs scores
        /// </summary>
        /// <param name="fileName"> Le fichier où on lit. </param>
        /// <returns> Les meilleurs scores </returns>
        public static Score Deserialize(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Score));
            FileStream fs = new FileStream(fileName, FileMode.Open);
            Score highscore = (Score)serializer.Deserialize(fs);
            fs.Close();
            return highscore;
        }
    }

    /// <summary>
    /// Classe pour l'enregistrement des scores
    /// </summary>
    public  class Score
    {
        #region Attributs
        [XmlElement("Easy")]
        private Save _easy;
        /// Score du niveau débutant
        public Save easy
        {
            get{ return _easy; }
            set{ _easy=value; }
        }

        [XmlElement("Medium")]
        private Save _medium;
        /// Score du niveau intermédiaire
        public Save medium
        {
            get{ return _medium; }
            set{ _medium=value; }
        }

        [XmlElement("Hard")]
        private Save _hard;
        /// Score du niveau expert
        public Save hard
        {
            get{ return _hard; }
            set{ _hard=value; }
        }
        #endregion

        #region Constructeurs
        public Score()
        {
            easy = new Save();
            medium = new Save();
            hard = new Save();
        }

        public Score(string nameE, int timeE, string nameM, int timeM, string nameH, int timeH)
        {
            easy = new Save(nameE,timeE);
            medium = new Save(nameM,timeM);
            hard = new Save(nameH,timeH);
        }
        #endregion
    }

    /// <summary>
    /// Classe pour l'enregistrement d'un score
    /// </summary>
    public class Save
    {
        #region Attributs
        private string _name = "";
        /// Nom de l'auteur du score
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _time = 0;
        /// Temps du score
        public int time
        {
            get { return _time; }
            set { _time = value; }
        }

        private DateTime _date;
        /// Date du score
        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur sans paramètres
        /// </summary>
        public Save()
        {
            name = "";
            time = 0;
            date = DateTime.MinValue;
        }

        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        /// <param name="nameE">Nom de l'auteur du score</param>
        /// <param name="timeE">Temps mis</param>
        public Save(string nameE, int timeE)
        {
            name = nameE;
            time = timeE;
            date = DateTime.Now;
        }
        #endregion
    }

}
