using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P_114_couteau_suisse_lucapardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            Console.ReadLine();
        }

        static void ShowMenu() 
        {
            Console.WriteLine("Veuillez choisir votre partie du couteau");
            Console.WriteLine("[1]: Conversion morse");
            Console.WriteLine("[2]: Conversion bases");
            Console.WriteLine("[3]: A venir");
            Console.WriteLine("[0]: Quitter");
            Console.Write("Votre choix: ");
            string choix = Console.ReadLine();
            switch (choix) 
            {
                case "1": Console.Clear(); CaracterBeep(ConvertionMorse()); break;
                case "2": Console.Clear(); ConvertionBases(); break;
                case "0": Environment.Exit(0); break;
                default: Console.WriteLine("Veuillez réessayer"); Thread.Sleep(500); Console.Clear(); ShowMenu(); break;

            }
        }
        static string ConvertionMorse() 
        {
            Console.Write("Veuillez entrer la phrase que vous voulez convertir en morse (sans accents):");
            string phraseCaracter = Console.ReadLine();
            phraseCaracter = phraseCaracter.ToUpper();
            string phraseMorse = " ";
            foreach (char caracter in phraseCaracter) 
            {
                switch (caracter)
                {
                    case 'A': phraseMorse += ".- "; break;
                    case 'B': phraseMorse += "-... "; break;
                    case 'C': phraseMorse += "-.-. "; break;
                    case 'D': phraseMorse += "-.. "; break;
                    case 'E': phraseMorse += ". "; break;
                    case 'F': phraseMorse += "..-. "; break;
                    case 'G': phraseMorse += "--. "; break;
                    case 'H': phraseMorse += ".... "; break;
                    case 'I': phraseMorse += ".. "; break;
                    case 'J': phraseMorse += ".--- "; break;
                    case 'K': phraseMorse += "-.- "; break;
                    case 'L': phraseMorse += ".-.. "; break;
                    case 'M': phraseMorse += "-- "; break;
                    case 'N': phraseMorse += "-."; break;
                    case 'O': phraseMorse += "--- "; break;
                    case 'P': phraseMorse += ".--. "; break;
                    case 'Q': phraseMorse += "--.- "; break;
                    case 'R': phraseMorse += ".-. "; break;
                    case 'S': phraseMorse += "... "; break;
                    case 'T': phraseMorse += "- "; break;
                    case 'U': phraseMorse += "..- "; break;
                    case 'V': phraseMorse += "...- "; break;
                    case 'W': phraseMorse += ".-- "; break;
                    case 'X': phraseMorse += "-..- "; break;
                    case 'Y': phraseMorse += "-.-- "; break;
                    case 'Z': phraseMorse += "--.. "; break;
                    case '0': phraseMorse += "----- "; break;
                    case '1': phraseMorse += ".---- "; break;
                    case '2': phraseMorse += "..--- "; break;
                    case '3': phraseMorse += "...-- "; break;
                    case '4': phraseMorse += "....- "; break;
                    case '5': phraseMorse += "..... "; break;
                    case '6': phraseMorse += "-.... "; break;
                    case '7': phraseMorse += "--... "; break;
                    case '8': phraseMorse += "---.. "; break;
                    case '9': phraseMorse += "----. "; break;
                    case ' ': phraseMorse += " / "; break;
                    default:Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Votre phrase contient une erreur -> '{caracter}'. Ce caractere a été ignoré"); Console.ResetColor(); break;
                }
            }
            return phraseMorse;
            
        }
        static void CaracterBeep(string phraseMorse) 
        {
            foreach (char morse in phraseMorse) 
            {
                Console.Write(morse);
                if (morse == '.')
                {
                    Console.Beep(700, 100);
                }
                else if (morse == '-')
                {
                    Console.Beep(700, 300);
                }
            }
        }

        static void ConvertionBases()
        {
            Console.WriteLine("Veuillez choisir la base de la valeur que vous voulez convertir:");
            Console.WriteLine("[1]: Base 2 à base 10");
            Console.WriteLine("[2]: Base 10 à base 2");
            Console.WriteLine("[3]: Base 16 à base 10");
            Console.WriteLine("[4]: Base 10 à base 16");
            Console.WriteLine("[5]: Base 8 à base 2");
            Console.WriteLine("[6]: Base 2 à base 8");

            Console.Write("Votre choix: ");
            string choixBaseValeur = Console.ReadLine();

            switch (choixBaseValeur)
                {
                    case "1":
                        {
                            Console.Write("Veuillez saisir une valeur en base 2 : ");
                            string valeur = Console.ReadLine();
                            int resultat = 0;
                            int puissance = 0;
                            for (int i = valeur.Length - 1; i >= 0; i--)
                            {
                                int bit = valeur[i] - '0';
                                resultat += bit * (int)Math.Pow(2, puissance);
                                puissance++;
                            }
                            Console.WriteLine("Résultat en base 10 : " + resultat);
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Veuillez saisir une valeur en base 10 : ");
                            int valeur = int.Parse(Console.ReadLine());
                            string resultat = "";
                            while (valeur > 0)
                            {
                                int reste = valeur % 2;
                                resultat = reste + resultat;
                                valeur = valeur / 2;
                            }
                        Console.WriteLine("Résultat en base 2 : " + resultat);
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Veuillez saisir une valeur en base 16 : ");
                            string valeur = Console.ReadLine().ToUpper();
                            int resultat = 0;
                            for (int i = 0; i < valeur.Length; i++)
                            {
                                    char chiffre = valeur[i];
                                    int nombre;

                                if (chiffre >= '0' && chiffre <= '9')
                                {
                                        nombre = chiffre - '0';
                                }
                                else 
                                { 
                                    nombre = chiffre - 'A' + 10;
                                }
                                    resultat = resultat * 16 + nombre;
                            }

                        Console.WriteLine("Résultat en base 10 : " + resultat);
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Veuillez saisir une valeur en base 10 : ");
                            string resultat = "";


                            Console.WriteLine("Résultat en base 16 : " + resultat);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Veuillez saisir une valeur en base 8 : ");
                            string valeur = Console.ReadLine();
                            string resultatBinaire = "";

                            Console.WriteLine("Résultat en base 2 : " + resultatBinaire);
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Veuillez saisir une valeur en base 2 : ");
                            string valeur = Console.ReadLine();
                            string resultatOctal = "";
                            Console.WriteLine("Résultat en base 8 : " + resultatOctal);
                            break;
                        }
                    default:
                        Console.WriteLine("Choix invalide, veuillez réessayer."); Thread.Sleep(500); Console.Clear(); ConvertionBases(); break;
                }
        }

    }
}
