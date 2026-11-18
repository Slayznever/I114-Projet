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
            Console.WriteLine("[2]: A venir");
            Console.WriteLine("[3]: A venir");
            Console.WriteLine("[0]: Quitter");
            Console.Write("Votre choix: ");
            string choix = Console.ReadLine();
            switch (choix) 
            {
                case "1": Console.Clear(); CaracterBeep(ConvertionMorse()); break;
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
    }
}
