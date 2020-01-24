using System;

namespace FORCA_GAME
{
    /// <sumary>
    /// Contains static methods to aid in game mechanics
    /// </sumary>
    public class Helper
    {
        private static string[] _words = {"melon", "apple", "banana", "pineapple"};
        
        /// <sumary>
        /// Returns a random word
        /// </sumary>
        public static string RaffleWord()
        {
            Random rand = new Random();

            int position = rand.Next(_words.Length); 

            return _words[position];
        }
    }

}