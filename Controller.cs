using System;

namespace FORCA_GAME
{
    /// <sumary>
    /// Class responsible to mechanics  in the game.
    /// </sumary>
    public class Controller
    {
        private ScreenUI _screen;
        private Player _player;
        
        /// <sumary>
        /// Basic constructor of the controller class. At instantiation, 
        /// it also creates an instance of the Screen class. 
        ///  </sumary>
        public Controller()
        {
            _screen = new ScreenUI();
        }
        
        bool exitMenu = false;
        /// <sumary>
        /// Method responsible for starting the game
        /// </sumary>
        public void start()
        {
            MessageUI.InitialMensage();
            
            while(!exitMenu)
            {
                _screen.ShowMenu();
                WorkingOptions();
            }
        }
        
        private void WorkingOptions()
        {
            int opt = 0;
            try
            {
                opt = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("\n\t::INVALID OPTION >> "+e.Message.ToUpper());
                Console.ReadLine();
                return;
            }
            
            switch(opt)
            {
                case (int) Option.PLAY:
                    SetPlayer();
                    MessageUI.WelcomePlayer(_player.Name);
                    StartGame(_player);
                    break;

                case (int) Option.ABOUT:
                    _screen.Description();
                    break;

                case (int) Option.EXIT:
                    exitMenu  = true;
                    Console.WriteLine("\n\t >> FINISH GAME!");
                    break;

                default:
                    Console.WriteLine("\n\t::ENTER A NUMBER >> 1, 2 or 3");
                    Console.ReadLine();
                    break;
            }
        }
        
        private void SetPlayer()
        {
            Console.Clear();
            Console.WriteLine("\n\t--------------------");
            Console.WriteLine("\t WHATS IS YOUR NAME?");
            Console.WriteLine("\t--------------------\n");
            Console.Write("\t >> ");

            var name = Console.ReadLine();

            if (name.Equals(""))
            {
                Console.WriteLine("\n\tI'M SORRY! NAME CANNOT BE BLANK");
                Console.ReadLine();
                SetPlayer();
            }
            else
            {
                _player.Name = name;
            }
            
        }

        private void StartGame(Player player)
        {
            var secretWord = Helper.RaffleWord().ToUpper();
            
            var attemps = 6;
            var letter="";
            var typedLetters ="";
            var label = "";
            var sizeWord = secretWord.Length;
            var sumLetters = 0;
            string[] word = new string[sizeWord];

            //---------- CREATE A LABEL -------------
            for(int i = 0; i < word.Length; i++)
            {
                word[i] = " _ ";
                label+= word[i];
            }
            //---------------------------------------

            while(attemps != 0)
            { 
                _screen.DisplayGame(player, label, sizeWord, attemps, typedLetters);
                
                if (letter.Equals(secretWord))
                {
                    //UPDATES THE DISPLAY WITH THE WORD
                    _screen.DisplayGame(player, letter, sizeWord, attemps, typedLetters);
                    MessageUI.HitTheWord(player.Name);
                    break;
                }
                else if (sumLetters == sizeWord)
                {
                    MessageUI.HitTheWord(player.Name);
                    break;
                }
                
                letter = Console.ReadLine().ToUpper();

                //----------- COMPARE LETTERS ------------
                if(secretWord.Contains(letter))
                {
                    label = ""; //Reset label
                    for(int i = 0; i < word.Length; i++)
                    {
                        if (secretWord[i].ToString().Equals(letter))
                        {
                            word[i] = letter;
                            sumLetters++;
                        }

                       label+= " "+word[i]+" "; 
                    }
                    player.Points += 1;
                    continue;
                }
                //------------------------------------------
                
                typedLetters += letter.ToUpper()+" | ";
                attemps--;
  
                if (attemps == 0)
                    MessageUI.MissedTheWord(secretWord);
            }

        }

    }

}