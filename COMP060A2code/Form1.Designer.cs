namespace COMP060A2code
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hangmanPic = new System.Windows.Forms.PictureBox();
            this.winLabel = new System.Windows.Forms.Label();
            this.lossLabel = new System.Windows.Forms.Label();
            this.winDisplay = new System.Windows.Forms.TextBox();
            this.lossDisplay = new System.Windows.Forms.TextBox();
            this.wordLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.wordBox = new System.Windows.Forms.TextBox();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.guessedLetters = new System.Windows.Forms.TextBox();
            this.guessedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPic)).BeginInit();
            this.SuspendLayout();
            // 
            // hangmanPic
            // 
            this.hangmanPic.Image = global::COMP060A2code.Properties.Resources.Hangman0;
            this.hangmanPic.InitialImage = global::COMP060A2code.Properties.Resources.Hangman0;
            this.hangmanPic.Location = new System.Drawing.Point(12, 12);
            this.hangmanPic.Name = "hangmanPic";
            this.hangmanPic.Size = new System.Drawing.Size(247, 195);
            this.hangmanPic.TabIndex = 0;
            this.hangmanPic.TabStop = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(12, 278);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(31, 13);
            this.winLabel.TabIndex = 1;
            this.winLabel.Text = "Wins";
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.Location = new System.Drawing.Point(97, 278);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(40, 13);
            this.lossLabel.TabIndex = 2;
            this.lossLabel.Text = "Losses";
            // 
            // winDisplay
            // 
            this.winDisplay.Location = new System.Drawing.Point(50, 278);
            this.winDisplay.Name = "winDisplay";
            this.winDisplay.ReadOnly = true;
            this.winDisplay.Size = new System.Drawing.Size(41, 20);
            this.winDisplay.TabIndex = 3;
            this.winDisplay.Text = "0";
            // 
            // lossDisplay
            // 
            this.lossDisplay.Location = new System.Drawing.Point(144, 278);
            this.lossDisplay.Name = "lossDisplay";
            this.lossDisplay.ReadOnly = true;
            this.lossDisplay.Size = new System.Drawing.Size(40, 20);
            this.lossDisplay.TabIndex = 4;
            this.lossDisplay.Text = "0";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(264, 42);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(36, 13);
            this.wordLabel.TabIndex = 5;
            this.wordLabel.Text = "Word:";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(264, 145);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(40, 13);
            this.guessLabel.TabIndex = 6;
            this.guessLabel.Text = "Guess:";
            // 
            // wordBox
            // 
            this.wordBox.Location = new System.Drawing.Point(307, 42);
            this.wordBox.Name = "wordBox";
            this.wordBox.ReadOnly = true;
            this.wordBox.Size = new System.Drawing.Size(100, 20);
            this.wordBox.TabIndex = 7;
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(307, 142);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(100, 20);
            this.guessBox.TabIndex = 8;
            // 
            // guessButton
            // 
            this.guessButton.Enabled = false;
            this.guessButton.Location = new System.Drawing.Point(307, 183);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 9;
            this.guessButton.Text = "Go";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(307, 278);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "New Game";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // guessedLetters
            // 
            this.guessedLetters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guessedLetters.Location = new System.Drawing.Point(267, 248);
            this.guessedLetters.Multiline = true;
            this.guessedLetters.Name = "guessedLetters";
            this.guessedLetters.ReadOnly = true;
            this.guessedLetters.Size = new System.Drawing.Size(179, 24);
            this.guessedLetters.TabIndex = 11;
            this.guessedLetters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guessedLabel
            // 
            this.guessedLabel.AutoSize = true;
            this.guessedLabel.Location = new System.Drawing.Point(307, 229);
            this.guessedLabel.Name = "guessedLabel";
            this.guessedLabel.Size = new System.Drawing.Size(87, 13);
            this.guessedLabel.TabIndex = 12;
            this.guessedLabel.Text = "Guessed Letters:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 334);
            this.Controls.Add(this.guessedLabel);
            this.Controls.Add(this.guessedLetters);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.lossDisplay);
            this.Controls.Add(this.winDisplay);
            this.Controls.Add(this.lossLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.hangmanPic);
            this.Name = "Form1";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangmanPic;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.TextBox winDisplay;
        private System.Windows.Forms.TextBox lossDisplay;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox wordBox;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox guessedLetters;
        private System.Windows.Forms.Label guessedLabel;
    }
}

