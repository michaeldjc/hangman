using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP060A2code
{
    public class Game
    {
        public string fullWord;
        public char[] hiddenWord, toShow;
        public bool gameOver;

        string[] possibleWords = {"jalapeno", "waterloo", "banana", "hippopotamus", "washington", "ferarri", "chocolate",
                                    "diamond", "dragon"};

        public Game(int wordChoice)
        {
            fullWord = possibleWords[wordChoice];
            gameOver = false;
            hiddenWord = new char[fullWord.Length];
            toShow = new char[fullWord.Length];

            hiddenWord = fullWord.ToCharArray();
            toShow = fullWord.ToCharArray();

            for(int index = 0; index < fullWord.Length; index++)
            {
                toShow[index] = '*';
            }
        }
       
        public bool GuessLetter(char userGuess)
        {
            bool letterFound;

            int keepTrack = 0;
            for(int index = 0; index < fullWord.Length; index++)
            {
                if (userGuess == hiddenWord[index])
                {
                    toShow[index] = hiddenWord[index];
                    keepTrack = 1;
                }
            }
            if (keepTrack == 0)
                letterFound = false;
            else
                letterFound = true;
            return letterFound;
        }
    }
}
