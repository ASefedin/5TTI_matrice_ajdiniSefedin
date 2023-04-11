using System;
using System.Collections.Generic;
using System.Text;

namespace _5TTI_ajdinSefedin_matrice
{
    public struct outils
    {
        /// <summary>
        /// permet de lire un nombre 
        /// </summary>
        /// <param name="question">c'est ce qui va etre demande a l'utilisateur</param>
        /// <param name="n">valeur resultat</param>
        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention ! vous devez taper un nombre réel !");
                nUser = Console.ReadLine();
            }
        }
        /// <summary>
        /// elle genere un tableau
        /// </summary>
        /// <param name="grille">creation de la grille</param>
        /// <param name="nbLigne">le nombre de ligne desire</param>
        /// <param name="nbColonne">le nombre de colonne desire</param>
        public void Generation_Tableau(out int[,] grille, int nbLigne, int nbColonne)
        {
            Random alea = new Random();
            grille = new int[nbLigne, nbColonne];
            for (int ligne = 0; ligne < nbLigne; ligne++)
            {
                for (int colonne = 0; colonne < nbColonne; colonne++)
                {
                    grille[ligne, colonne] = alea.Next(0, 20);
                }
            }
        }
        /// <summary>
        /// afficher le tableau
        /// </summary>
        /// <param name="grille">creation de la grille</param>
        /// <param name="stringTab">affichage de cette fameuse grille</param>
        public void String_Tableau(int[,] grille, out string stringTab)
        {
            stringTab = "";
            for (int ligne = 0; ligne < grille.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < grille.GetLength(1); colonne++)
                {
                    stringTab += grille[ligne, colonne] + "|";
                }
                stringTab += "\n";
            }
        }
        /// <summary>
        /// additionner des matrices 1 et 2
        /// </summary>
        /// <param name="tab1">tableau numero 1</param>
        /// <param name="tab2">tableau numero 2</param>
        /// <param name="tab3">tableau numero 1 + tableau numero 2 = tableau numero 3</param>
        /// <param name="addition">recommencer </param>
        /// <param name="nbLigne">le nombre de ligne desire</param>
        /// <param name="nbColonne">le nombre de colonne desire</param>
        public void Addition_Matrices(int[,] tab1, int[,] tab2, out int[,] tab3, out bool addition, int nbLigne, int nbColonne)
        {
            tab3 = new int[nbLigne, nbColonne];
            addition = true;
            if (tab1.GetLength(0) == tab2.GetLength(0) && tab1.GetLength(1) == tab2.GetLength(1))
            {
                for (nbLigne = 0; nbLigne <= tab1.GetLength(0) - 1; nbLigne++)
                {
                    for (nbColonne = 0; nbColonne <= tab1.GetLength(1) - 1; nbColonne++)
                    {
                        tab3[nbLigne, nbColonne] += tab1[nbLigne, nbColonne] += tab2[nbLigne, nbColonne];
                    }
                }
            }
            addition = false;
        }
        /// <summary>
        /// multiplication des matrices 1 et 2
        /// </summary>
        /// <param name="tab1">tableau numero 1</param>
        /// <param name="tab2">tableau numero 2</param>
        /// <param name="tabmulti">tableau numero 1 * tableau numero 2 = tabmulti</param>
        /// <param name="test">recommencer</param>
        /// <param name="nbLigne">le nombre de ligne desire</param>
        /// <param name="nbColonne">le nombre de colonne desire</param>
        public void multiplicationMatrice(int[,] tab1, int[,] tab2, out int[,] tabmulti, out bool test, int nbLigne, int nbColonne)
        {
            tabmulti = new int[nbLigne, nbColonne];
            test = true;
            if (tab1.GetLength(1) == tab2.GetLength(0))
            {
                for (int ligne = 0; ligne <= tab1.GetLength(0) - 1; ligne++)
                {
                    for (int colonne = 0; colonne <= tab1.GetLength(1) - 1; colonne++)
                    {
                        tabmulti[ligne, colonne] = 0;
                        for (int i = 0; i <= tab1.GetLength(1) - 1; i++)
                        {
                            tabmulti[ligne, colonne] += tab1[ligne, i] * tab2[i, colonne];
                        }
                    }
                }
            }
            test = false;
        }
    }
}
