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

        private void guessButton_Click(object sender, EventArgs e)
        {
            if (guessBox.Text.Length == 0)
                MessageBox.Show("You need to enter a guess!");

            else
            {
                guessAsArray = guessBox.Text.ToLower().ToCharArray();
                foreach (char letter in guessAsArray)
                {
                    if (!newGame.gameActive)
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
                    break;
            }
        }

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
