using System;

namespace FORCA_GAME
{
    /// <sumary>
    /// class containing the methods that implement the messages that will be used during the game.
    /// </sumary>
    public class MessageUI
    {
        public static void InitialMensage()
        {
            Console.Clear();
            Console.WriteLine("\n\t=======================================");
            Console.WriteLine("\t  * * *  WELCOME A FORCA//GAME  * * *");
            Console.WriteLine("\t=======================================\n");

            Console.WriteLine("\tDevelop by: Snntthree");
            Console.WriteLine("\tJanuary 2020");

            Console.WriteLine("\n\t         >> PRESS A KEY <<");

            Console.ReadKey();
        }

        public static void WelcomePlayer(string name)
        {
            Console.Clear();
            Console.WriteLine($"\n\tLET'S GO {name.ToUpper()}!");
            Console.WriteLine("\t------------------------------------------");
            Console.WriteLine("\n\tDo you what prepared to be a genius of words?");
            Console.WriteLine("\n\t\t>> Press Enter <<");
            Console.ReadLine();
        }

        public static void HitTheWord(string name)
        {
            Console.WriteLine("\n\n\t\t\t   * * *  FINISH GAME  * * *");
                    
            Console.WriteLine("\n\n\t+--------------------------------------------------------------+");
            Console.WriteLine($"\t\t  :: CONGRATULATIONS {name.ToUpper()} !!! YOU GUESSED THE WORD");
            Console.WriteLine("\t+--------------------------------------------------------------+");
                    
            Console.ReadLine();
        }

        public static void MissedTheWord(string word)
        {
            Console.WriteLine("\n\n\t\t\t   * * *  FINISH GAME  * * *");

            Console.WriteLine("\n\t+--------------------------------------------------------------+");
            Console.WriteLine("\t               :: SORRY. YOUR ATTEMPS JUST BE ENDED! ");
            Console.WriteLine("\t+--------------------------------------------------------------+");
            Console.WriteLine($"\n\tThe secret word was {word}");

            Console.ReadLine();
        }
    }
}