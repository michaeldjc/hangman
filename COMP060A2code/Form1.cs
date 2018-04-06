using System;
using System.Windows.Forms;

namespace COMP060A2code
{
    public partial class Form1 : Form
    {
        int wrongTracker, guessedPos, wins, losses;
        int wordChoice;
        char[] guessAsArray, usedLetters;
        Random random;
        Game newGame;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            wins = 0;
            losses = 0;
        }
        /// <summary>
        /// takes the user guess and checks it for validity, whether its been used, and then if it is in the target
        /// word, shows the position of said letter(s) where * had been before, and adds it to the guessed words list
        /// if not in, calls CheckWrongs. checks if game is over (word is guessed or six wrong guesses)
        /// --allows player to enter more than one guess at a time, but tries each character individually--
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guessButton_Click(object sender, EventArgs e)
        {
            if (guessBox.Text.Length == 0)
                MessageBox.Show("You need to enter a guess!");

            else
            {
                guessAsArray = guessBox.Text.ToLower().ToCharArray();
                foreach (char letter in guessAsArray)
                {
                    if (!newGame.gameActive) //will break the loop if the game is over to prevent problems/ irrelevant pop-ups
                        break;
                    if (!char.IsLetter(letter))
                        MessageBox.Show(letter + " is not a valid guess");
                    else if (guessedLetters.Text.Contains(letter.ToString()))
                        MessageBox.Show("You Already Guessed the letter: " + letter.ToString());
                    else
                    {
                        usedLetters[guessedPos] = letter;
                        guessedLetters.Text = String.Join(" ", usedLetters);
                        guessedPos++;
                        if (newGame.fullWord.Contains(letter.ToString()))
                        {
                            for (int index = 0; index < newGame.fullWord.Length; index++)
                            {
                                if (letter == newGame.hiddenWord[index])
                                    newGame.toShow[index] = newGame.hiddenWord[index];
                            }
                            newGame.guessedWord = new string(newGame.toShow);
                            wordBox.Text = newGame.guessedWord;
                            if (!newGame.guessedWord.Contains("*"))
                                EndGame(true);
                        }
                        else
                        {
                            wrongTracker++;
                            CheckWrongs(wrongTracker);
                            if(wrongTracker == 6)
                               EndGame(false);
                        }
                    }
                }
                guessBox.Text = "";             
            }
        }
        /// <summary>
        /// initializes a new instance of Game and resets all boxes and values that need to be
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            usedLetters = new char[26];
            wordChoice = random.Next(9);
            wrongTracker = 0;
            guessedPos = 0;
            newGame = new Game(wordChoice);
            hangmanPic.Image = Properties.Resources.Hangman0;
            wordBox.Text = newGame.guessedWord;
            guessedLetters.Text = "";
            guessButton.Enabled = true;
            guessBox.MaxLength = newGame.fullWord.Length; // allows player to guess multiple characters at a time, up to the length of the word
        }
        /// <summary>
        /// changes image depending on how many wrong responses the user has given
        /// </summary>
        /// <param name="wrongGuesses"></param>
        public void CheckWrongs(int wrongGuesses)
        {
            switch (wrongGuesses)
            {
                case 0:
                    hangmanPic.Image = Properties.Resources.Hangman0;
                    break;
                case 1:
                    hangmanPic.Image = Properties.Resources.Hangman1;
                    break;
                case 2:
                    hangmanPic.Image = Properties.Resources.Hangman2;
                    break;
                case 3:
                    hangmanPic.Image = Properties.Resources.Hangman3;
                    break;
                case 4:
                    hangmanPic.Image = Properties.Resources.Hangman4;
                    break;
                case 5:
                    hangmanPic.Image = Properties.Resources.Hangman5;
                    break;
                case 6:
                    hangmanPic.Image = Properties.Resources.Hangman6;
                    break;
            }
        }
        /// <summary>
        /// when called, increments wins xor losses depending on which parameter is sent
        /// gives the message of whether the user won or lost, disables the guess button.
        /// </summary>
        /// <param name="wonLost"></param>
        public void EndGame(bool wonLost)
        {
            newGame.gameActive = false;
            if (wonLost)
            {
                MessageBox.Show("You've won the game. Aren't you clever.");
                wins++;
                winDisplay.Text = wins.ToString();
            }
            else
            {
                wordBox.Text = newGame.fullWord;
                MessageBox.Show("You've lost the game. Better Luck Next Time.");
                losses++;
                lossDisplay.Text = losses.ToString();
            }
            guessButton.Enabled = false;
        }
    }
}
