using System;

namespace FORCA_GAME
{
    public class ScreenUI
    {
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\t----------- MENU ------------");
            Console.WriteLine("\t   1 - PLAY");
            Console.WriteLine("\t   2 - ABOUT");
            Console.WriteLine("\t   3 - EXIT");
            Console.WriteLine("\t-----------------------------");
            Console.WriteLine("\t Enter option: ");
            Console.WriteLine("\t-----------------------------");
            Console.Write("\t >> ");
        }
        
        ///<sumary>
        ///Represents the main screen of the game
        ///</sumary>
        ///<param name="p">The player of the match</param>
        ///<param name="word">Represents the word to be guessed</param>
        ///<param name="size">Number of letters in the word</param>
        ///<param name="attemps">Remaining attempts</param>
        ///<param name="typedLetters">Typed letters</param>
        public void DisplayGame(Player p, string word, int size, int attemps,
            string typedLetters)
        {
            Console.Clear();
            Console.WriteLine("\n\t+------------------------- FORCA//GAME -------------------------+");
            Console.WriteLine($"\tROUND {1}     TIP: FRUIT");
            Console.WriteLine($"\tPLAYER: {p.Name.ToUpper()}    POINTS: {p.Points}");

            Console.WriteLine($"\n\t                SECRET WORD:   {word}");

            Console.WriteLine($"\n\tThe word contains {size} letters");
            Console.WriteLine($"\tTyped letters: {typedLetters}");
           
            Console.WriteLine($"\n\tYou have {attemps} attemps...");
            Console.WriteLine("\t+--------------------------------------------------------------+");
            Console.Write("\t::Try a letter >> ");

        }

        ///<sumary>
        /// Show information about the rules of the game.
        ///</sumary>
        public void Description()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\n\t ABOUT");
            Console.WriteLine("\t----------------------------------------------------------------");
            Console.WriteLine("\n\t :: The basic premise of the game is to guess the secret word.");

            Console.WriteLine("\n\t :: Each sorted word or player has 5 attempts to hit a word. \n"
            + "\t    Each corresponding letter is worth 1 point.");

            Console.WriteLine("\n\t :: The game ends at the end of the rounds or when the match is"
            + "\n\t    canceled.");
            Console.WriteLine("\t----------------------------------------------------------------");
            Console.WriteLine("\n\t\t\t>> PRESS A KEY TO BACK MENU <<");

            Console.ReadLine();
        }

    }
}