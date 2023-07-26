using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Text;

namespace Rname
{
    public partial class Form1 : MetroForm
    {
        #region declaration
        string folderPath;
        FileInfo[] fichiers;
        int nbfichiers;
        string check1 = "@", check2 = "#", check3 = "&", check4, check5, check6, check7, check8;
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            // init gridcontrol principal
            gridControl3.ColCount = 3;
            gridControl3.SetColWidth(1, 2, 440);
            gridControl3.SetColWidth(3, 3, 128);
            this.gridControl3.AutoScrolling = ScrollBars.Vertical;
            this.gridControl3.VScrollPixel = true;
            this.gridControl3.HScrollPixel = false;
            // init gridcontrol parametre
            gridControl2.SetColWidth(1, 1, 254);
            //gridControl2.SetColWidth(3, 3, 141);
            this.gridControl3.AutoScrolling = ScrollBars.Vertical;
            this.gridControl3.VScrollPixel = true;
            this.gridControl3.HScrollPixel = false;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            {
                DirectoryInfo dir2 = new DirectoryInfo(folderPath);
                FileInfo[] test = dir2.GetFiles();

                foreach (FileInfo fichier in test)
                {

                    listBox_tampon.Items.Add(Path.GetExtension(fichier.Name));
                }

                if (MessageBox.Show(this, "Etes-vous sûr de renomer le fichier  Verifier List aprés renomage?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    int compteur;
                    var t = listBox_tampon.Items.Count.ToString();
                    for (compteur = 0; compteur < Convert.ToInt32(t); compteur++)
                    {
                        string k = Convert.ToString(listBox_origine.Items[compteur]);
                        string a = Convert.ToString(listBox_apercu.Items[compteur]);
                        string o = Convert.ToString(listBox_extension.Items[compteur]);
                        //Action si l'utilisateur est sûr
                        string oldFilePath = folderPath + "\\" + k + o; // Full path of old file
                        string newFilePath = folderPath + "\\" + a + o; // Full path of new file
                        string tampon = folderPath + "\\tampon" + a + o;
                        //
                        bool fichierExiste = File.Exists(newFilePath);
                        if (!fichierExiste)
                        {
                            try
                            {
                                FileSystem.Rename(oldFilePath, newFilePath);
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }
        }

        private void metroButton_supprimer_Click(object sender, EventArgs e)
        {
            int length = metroTextBox_supp_valeur.Text.Length;
            if (length < 1)
            {
                //code erreur
                metroLabel_erreur.Text = "Vous devez renseigner une valeur à effacer";
                metroLabel_erreur.ForeColor = Color.IndianRed;
            }
            else
            {
                metroLabel_erreur.Text = "";
                int increment1 = 0;
                increment1++;
                this.gridControl2.Rows.InsertRange(1, 1);
                this.gridControl2[increment1, 1].CellValue = "SUPPRIMER " + metroTextBox_supp_valeur.Text;
                listBox_parametre.Items.Add("S" + metroTextBox_supp_valeur.Text);
                Processus();
            }

            //

        }

        private void metroButton_v_remplacer_Click(object sender, EventArgs e)
        {
            int length = metroTextBox_rempl_new.Text.Length;
            int length2 = metroTextBox_rempl_base.Text.Length;
            if (length < 1)
            {
                // code erreur
                metroLabel_erreur.Text = "Vous devez renseigner la valeur de remplacement";
                metroLabel_erreur.ForeColor = Color.IndianRed;
            }
            else if (length2 < 1)
            {
                // code erreur
                metroLabel_erreur.Text = "Vous devez renseigner une valeur à remplacer";
                metroLabel_erreur.ForeColor = Color.IndianRed;
            }
            else
            {
                metroLabel_erreur.Text = "";
                int increment1 = 0;
                increment1++;
                this.gridControl2.Rows.InsertRange(1, 1);
                this.gridControl2[increment1, 1].CellValue = "REMPLACER " + metroTextBox_rempl_base.Text + " par " + metroTextBox_rempl_new.Text;
                listBox_parametre.Items.Add("R" + metroTextBox_rempl_base.Text + "!@tk@!" + metroTextBox_rempl_new.Text);
                Processus();
            }
            //

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            startChargement();



        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel_erreur.Text = "";
        }

        void afficherResult()
        {
            // renvoi resultat dans gridcontrol col 1 et 2
            gridControl3.RowCount = nbfichiers;
            int compteur4 = 0;
            int compteur3;
            for (compteur3 = 0; compteur3 < nbfichiers; compteur3++)
            {
                compteur4++;
                this.gridControl3[compteur4, 1].CellValue = (listBox_origine.Items[compteur3].ToString());
                this.gridControl3[compteur4, 2].CellValue = (listBox_apercu.Items[compteur3].ToString());
            }
        }

        void remplacerValeur(string Valeur1, string Valeur2)
        {
            //
            //MessageBox.Show(Valeur1);
            //MessageBox.Show(Valeur2);
            //
            listBox_apercu.Items.Clear();
            //
            foreach (var listboxItem in listBox_tampon.Items)
            {
                int i = 1;
                i++;
                string test = i.ToString();
                test = listboxItem.ToString().Replace(Valeur1, Valeur2);
                //
                listBox_apercu.Items.Add(test);
            }
            //
            copieApercu();
        }

        void supprimerValeur(string Valeur1, string Valeur2)
        {
            //
            listBox_apercu.Items.Clear();
            //
            foreach (var listboxItem in listBox_tampon.Items)
            {
                int i = 1;
                i++;
                string test = i.ToString();
                test = listboxItem.ToString().Replace(Valeur1, string.Empty);
                //
                listBox_apercu.Items.Add(test);
            }
            //
            copieApercu();
        }

        void copieOriginal()
        {
            // copie liste origine vers liste tampon
            foreach (var copie in listBox_origine.Items)
            {
                listBox_tampon.Items.Add(copie);
            }
        }

        void copieApercu()
        {
            //
            listBox_tampon.Items.Clear();
            // copie liste apercu dans la liste tampon
            foreach (var copie in listBox_apercu.Items)
            {
                listBox_tampon.Items.Add(copie);
            }
        }

        void copieTampon()
        {
            //
            listBox_apercu.Items.Clear();
            // copie liste apercu dans la liste tampon
            foreach (var copie in listBox_tampon.Items)
            {
                listBox_apercu.Items.Add(copie);
            }
        }

        void Processus()
        {
            // remise a zero des listes
            copieOriginal();
            // applications des parametres
            foreach (string valeur in listBox_parametre.Items)
            {
                // si remplace
                if (valeur.Trim().StartsWith("R"))
                {
                    int nbcaract = valeur.Length;
                    nbcaract = nbcaract - 1;
                    string champs = valeur.Substring(1, nbcaract);
                    String pattern = @"!@tk@!";
                    String[] champsdecoupe = Regex.Split(champs, pattern);
                    // test
                    //MessageBox.Show(champsdecoupe[0]);
                    //MessageBox.Show(champsdecoupe[1]);
                    //
                    remplacerValeur(champsdecoupe[0], champsdecoupe[1]);
                }
                // si supprime
                if (valeur.Trim().StartsWith("S"))
                {
                    //
                    int nbcaract = valeur.Length;
                    nbcaract = nbcaract - 1;
                    string champs = valeur.Substring(1, nbcaract);
                    supprimerValeur(champs, "A");
                }
                // si transform

                // si special

                // si ...
            }
            //
            afficherResult();
        }


        void startChargement()
        {
            try
            {
                // vidage
                listBox_apercu.Items.Clear();
                listBox_tampon.Items.Clear();
                listBox_extension.Items.Clear();
                listBox_parametre.Items.Clear();
                listBox_origine.Items.Clear();
                //MessageBox.Show(folderPath);
                DirectoryInfo dir = new DirectoryInfo(folderPath);
                fichiers = dir.GetFiles();
                nbfichiers = fichiers.Count();
                MessageBox.Show(nbfichiers.ToString());
                //
                foreach (FileInfo fichier in fichiers)
                {
                    listBox_origine.Items.Add(Path.GetFileNameWithoutExtension(fichier.Name));
                    listBox_apercu.Items.Add(Path.GetFileNameWithoutExtension(fichier.Name));
                    listBox_extension.Items.Add(Path.GetExtension(fichier.Name));
                }
                // lancer la méthode afficheresult
                afficherResult();
                // copie list
                copieOriginal();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
