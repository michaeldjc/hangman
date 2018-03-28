using System;
using System.Windows.Forms;

namespace COMP060A2code
{
    public partial class Form1 : Form
    {
        int wrongTracker, guessedPos, wins = 0, losses = 0;
        int wordChoice;
        bool letterFound, alreadyGuessed;
        string guessedWord;
        char[] guessAsArray;
        char[] usedLetters;
        Random random;
        Game newGame;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            if (guessBox.Text.Length == 0)
                MessageBox.Show("You need to enter a guess!");
            else
            {
                guessAsArray = guessBox.Text.ToLower().ToCharArray();
                foreach (char letter in guessAsArray)
                {
                    alreadyGuessed = CheckForRepeat(letter);

                    if (alreadyGuessed && newGame.gameOver == false)
                        MessageBox.Show("You Already Guessed the letter: " + letter.ToString());
                    else
                    {
                        if (newGame.gameOver == false)
                        {
                            usedLetters[guessedPos] = letter;
                            guessedLetters.Text = String.Join(" ", usedLetters);
                            guessedPos++;
                        }

                        letterFound = newGame.GuessLetter(letter);

                        if (letterFound)
                        {
                            guessedWord = new string(newGame.toShow);
                            wordBox.Text = guessedWord;
                            CheckWin();
                        }
                        else
                        {
                            wrongTracker++;
                            CheckWrongs(wrongTracker);
                        }
                    }

                }
                guessBox.Text = "";

                
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usedLetters  = new char[26];
            wordChoice = random.Next(9);
            wrongTracker = 0;
            guessedPos = 0;
            newGame = new Game(wordChoice);
            CheckWrongs(wrongTracker);
            guessedWord = new string(newGame.toShow);
            wordBox.Text = guessedWord;
            guessedLetters.Text = "";
            guessButton.Enabled = true;
        }
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
                    EndGame(false);
                    break;
            }
        }
        public bool CheckForRepeat(char currentGuess)
        {
            bool usedBefore = false;
            foreach (char checker in usedLetters)
            {
                if (currentGuess == checker)
                {
                    usedBefore = true;
                    break;
                }
            }
            return usedBefore;
        }
        public void CheckWin()
        {
            bool didWin = true;
            foreach (char letter in guessedWord)
            {
                if (letter == '*')
                {
                    didWin = false;
                    break;
                }

            }
            if (didWin)
                EndGame(true);
        }
        public void EndGame(bool wonLost)
        {
            newGame.gameOver = true;
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
