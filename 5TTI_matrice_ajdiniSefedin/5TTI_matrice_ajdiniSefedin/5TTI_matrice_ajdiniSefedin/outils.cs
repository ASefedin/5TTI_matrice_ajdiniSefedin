using System;

namespace _5TTI_ajdinSefedin_matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            outils mesOutils = new outils();
            int choix; /// choix du type de matrice choisis
            int[,] grille; /// creation grille
            string stringTab; /// afficher le tab
            int[,] tab1;
            int[,] tab2;
            int[,] tab3;
            bool addition;
            int[,] tabMulti;
            bool test; /// recommencer le programme
            int nbLigne;
            int nbColonne;
            do
            {
                mesOutils.LireReel("quel choix choississez-vous ? \n   1 = Generation_Tableau\n   2 = Addition_Matrices\n   3 = multiplicationMatrice \n ", out choix);

                if (choix == 1) /// Generation_Tableau
                {
                    mesOutils.LireReel("veuillez saisir le nombre de ligne", out nbLigne);
                    mesOutils.LireReel("veuillez saisir le nombre de colonne", out nbColonne);
                    mesOutils.Generation_Tableau(out grille, nbLigne, nbColonne);
                    mesOutils.String_Tableau(grille, out stringTab);
                    Console.WriteLine(stringTab);
                }
                if (choix == 2) /// Addition_Matrices
                {
                    mesOutils.LireReel("veuillez saisir le nombre de ligne", out nbLigne);
                    mesOutils.LireReel("veuillez saisir le nombre de colonne", out nbColonne);
                    mesOutils.Generation_Tableau(out tab1, nbLigne, nbColonne);
                    mesOutils.String_Tableau(tab1, out stringTab);
                    Console.WriteLine(stringTab);

                    mesOutils.LireReel("veuillez saisir le nombre de ligne", out nbLigne);
                    mesOutils.LireReel("veuillez saisir le nombre de colonne", out nbColonne);
                    mesOutils.Generation_Tableau(out tab2, nbLigne, nbColonne);
                    mesOutils.String_Tableau(tab2, out stringTab);
                    Console.WriteLine(stringTab);
                    if (nbLigne == nbColonne)
                    {
                        mesOutils.Addition_Matrices(tab1, tab2, out tab3, out addition, nbLigne, nbColonne);
                        mesOutils.String_Tableau(tab3, out stringTab);
                        Console.WriteLine(stringTab);
                    }
                    else
                    {
                        Console.WriteLine("impossible");
                    }
                }

                if (choix == 3) /// multiplicationMatrice
                {
                    mesOutils.LireReel("veuillez saisir le nombre de ligne", out nbLigne);
                    mesOutils.LireReel("veuillez saisir le nombre de colonne", out nbColonne);
                    mesOutils.Generation_Tableau(out tab1, nbLigne, nbColonne);
                    mesOutils.String_Tableau(tab1, out stringTab);
                    Console.WriteLine(stringTab);

                    mesOutils.LireReel("veuillez saisir le nombre de ligne", out nbLigne);
                    mesOutils.LireReel("veuillez saisir le nombre de colonne", out nbColonne);
                    mesOutils.Generation_Tableau(out tab2, nbLigne, nbColonne);
                    mesOutils.String_Tableau(tab2, out stringTab);
                    Console.WriteLine(stringTab);

                    if (nbLigne == nbColonne)
                    {
                        mesOutils.multiplicationMatrice(tab1, tab2, out tabMulti, out test, nbLigne, nbColonne);
                        mesOutils.String_Tableau(tabMulti, out stringTab);
                        Console.WriteLine(stringTab);
                    }
                    else
                    {
                        Console.WriteLine("impossible");
                    }
                }
            } while (true);
        }
    }
}
