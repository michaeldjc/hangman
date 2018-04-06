using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP060A2code
{
    /// <summary>
    /// creates an instance of the game when called. Contains the full word to be guessed, and the word with the letters
    /// the player has revealed so far.
    /// </summary>
    public class Game
    {
        public string fullWord, guessedWord;
        public char[] hiddenWord, toShow;
        public bool gameActive;

        string[] possibleWords = {"jalapeno", "waterloo", "banana", "hippopotamus", "washington", "ferarri", "chocolate",
                                    "diamond", "dragon"};

        public Game(int wordChoice)
        {
            fullWord = possibleWords[wordChoice];
            hiddenWord = new char[fullWord.Length];
            toShow = new char[fullWord.Length];

            hiddenWord = fullWord.ToCharArray();
            toShow = fullWord.ToCharArray();

            for(int index = 0; index < fullWord.Length; index++)
            {
                toShow[index] = '*';
            }
            guessedWord = new string(toShow);
            gameActive = true;
        }
    }
}
