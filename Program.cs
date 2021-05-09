using System;

namespace Plancher_Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration des variables
            const double taxRate = 0.15;
            double width = 0;
            double lenght = 0;
            double matTotal = 0;
            double labTotal = 0;
            double subTotal = 0;
            double taxTotal = 0;
            double Total = 0;
            double area = 0;

            //Déclaration et initialisation des tableaux.
            string[] floor = new string[] { "Tapis commercial", "Tapis de qualité", "Plancher de bois franc", "Plancher flottant", "Céramique" };
            double[] material = new double[] { 1.29, 3.99, 4.49, 1.99, 1.49 };
            double[] labor = new double[] { 2.00, 2.25, 3.25, 2.25, 3.25 };

            Console.WriteLine("  >>> Bienvenue chez Plancher Expert! <<<   ");

            //Boucle pour nouvelle estimation
            bool app = true;
            while (app == true)
            {
                //Reset des variables
                width = 0;
                lenght = 0;
                area = 0;
                matTotal = 0;
                labTotal = 0;
                subTotal = 0;
                taxTotal = 0;
                Total = 0;

                //Afficher message nouvelle estimation
                Console.WriteLine();
                Console.WriteLine("**************************************************");
                Console.WriteLine("************** Nouvelle Estimation ***************");
                Console.WriteLine("**************************************************");
                Console.WriteLine();

                //Saisir la longueur
                while (lenght <= 0)
                {
                    Console.Write("-> Entrez la longueur de la piece en pi. : ");
                    string lenght_str = Console.ReadLine();

                    try
                    {
                        lenght = double.Parse(lenght_str);
                        if (lenght <= 0)
                        {
                            Console.WriteLine("Dimension invalide! Vous devez entrer un nombre plus grand que 0");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Dimension invalide! Vous devez entrer un nombre plus grand que 0");
                    }
                }

                //Saisir la largeur
                while (width <= 0)
                {
                    Console.Write("-> Entrez la largeur de la piece en pi. : ");
                    string width_str = Console.ReadLine();

                    try
                    {
                        width = double.Parse(width_str);
                        if (width <= 0)
                        {
                            Console.WriteLine("Dimension invalide! Vous devez entrer un nombre plus grand que 0");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Dimension invalide! Vous devez entrer un nombre plus grand que 0");
                    }
                }

                //Calcule de la superficie de la pièce
                area = lenght * width;

                //Choix du couvre-plancher
                Console.WriteLine();
                Console.WriteLine("La superficie de votre pièce est de " + area + " pi2");
                Console.WriteLine();
                Console.WriteLine("********** Type de couvre-plancher **********");
                Console.WriteLine("*                                           *");
                Console.WriteLine("* > Entrez 0 pour : " + floor[0] + "        *");
                Console.WriteLine("* > Entrez 1 pour : " + floor[1] + "        *");
                Console.WriteLine("* > Entrez 2 pour : " + floor[2] + "  *");
                Console.WriteLine("* > Entrez 3 pour : " + floor[3] + "       *");
                Console.WriteLine("* > Entrez 4 pour : " + floor[4] + "               *");
                Console.WriteLine("*                                           *");
                Console.WriteLine("*********************************************");
                Console.WriteLine();

                //Validation du choix
                int choice = 5;
                while (choice < 0 || choice > 4)
                {
                    Console.Write("-> Entrez le type de couvre-plancher : ");
                    string choice_str = Console.ReadLine();

                    try
                    {
                        choice = int.Parse(choice_str);
                        if (choice < 0 || choice > 4)
                        {
                            Console.WriteLine("Choix invalide! Vous devez entrer un chiffre entre 0 - 4");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Choix invalide! Vous devez entrer un chiffre entre 0 - 4");
                    }
                }

                //Calcule des prix
                switch (choice)
                {
                    case 0:
                        matTotal = area * material[0];
                        labTotal = area * labor[0];
                        subTotal = matTotal + labTotal;
                        taxTotal = subTotal * taxRate;
                        Total = subTotal + taxTotal;
                        break;
                    case 1:
                        matTotal = area * material[1];
                        labTotal = area * labor[1];
                        subTotal = matTotal + labTotal;
                        taxTotal = subTotal * taxRate;
                        Total = subTotal + taxTotal;
                        break;
                    case 2:
                        matTotal = area * material[2];
                        labTotal = area * labor[2];
                        subTotal = matTotal + labTotal;
                        taxTotal = subTotal * taxRate;
                        Total = subTotal + taxTotal;
                        break;
                    case 3:
                        matTotal = area * material[3];
                        labTotal = area * labor[3];
                        subTotal = matTotal + labTotal;
                        taxTotal = subTotal * taxRate;
                        Total = subTotal + taxTotal;
                        break;
                    case 4:
                        matTotal = area * material[4];
                        labTotal = area * labor[4];
                        subTotal = matTotal + labTotal;
                        taxTotal = subTotal * taxRate;
                        Total = subTotal + taxTotal;
                        break;
                }

                //Afficher l'estimation
                Console.WriteLine();
                Console.WriteLine("******************************************");
                Console.WriteLine("********** ESTIMATION DES COÛTS **********");
                Console.WriteLine();
                Console.WriteLine("   Couvre-plancher :  " + floor[choice]);
                Console.WriteLine("   Superficie :       " + area + " pi2");
                Console.WriteLine("   ................................");
                Console.WriteLine();
                Console.WriteLine("   Matériaux :        $" + String.Format("{0:0.00}", matTotal));
                Console.WriteLine("   Main d'oeuvre :    $" + String.Format("{0:0.00}", labTotal));
                Console.WriteLine("                      ========");
                Console.WriteLine("   Sous-Total :       $" + String.Format("{0:0.00}", subTotal));
                Console.WriteLine("   Taxes(15%) :       $" + String.Format("{0:0.00}", taxTotal));
                Console.WriteLine("                      ========");
                Console.WriteLine("   Total :            $" + String.Format("{0:0.00}", Total));
                Console.WriteLine();
                Console.WriteLine("*****************************************");
                Console.WriteLine("*****************************************");

                //Recommencer ou quitter
                Console.WriteLine();
                Console.WriteLine(" > Entrez 1 pour : Nouvelle Estimation");
                Console.WriteLine(" > Entrez 0 pour : Quitter");
                Console.WriteLine();
                int action = 2;
                while (action == 2)
                {
                    Console.Write(" -> Que voulez-vous faire? : ");
                    string action_str = Console.ReadLine();

                    try
                    {
                        action = int.Parse(action_str);
                        if (action > 1 || action < 0)
                        {
                            Console.WriteLine("Choix invalide! Vous devez entrer un chiffre entre : 0 - 1");
                            action = 2;
                        }
                        else if (action == 0)
                        {
                            app = false;
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Choix invalide! Vous devez entrer un chiffre entre : 0 - 1");
                    }

                }

            }

        }





    }
}
