namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // True = X turn, false = O turn
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Caden", "About");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) // Clears the board and textbox
        {
            // Clear all text in the playing field
            R1C1.Text = ""; // First row
            R1C2.Text = "";
            R1C3.Text = "";
            R2C1.Text = ""; // Second row
            R2C2.Text = "";
            R2C3.Text = "";
            R3C1.Text = ""; // Third row
            R3C2.Text = "";
            R3C3.Text = "";

            // Reset the turn counter
            turnCount = 0;

            // Clear the textbox
            textOutput.Text = "Round: " + turnCount;

            // Reanble all playing field buttons
            R1C1.Enabled = true; // First row
            R1C2.Enabled = true;
            R1C3.Enabled = true;
            R2C1.Enabled = true; // Second row
            R2C2.Enabled = true;
            R2C3.Enabled = true;
            R3C1.Enabled = true; // Third row
            R3C2.Enabled = true;
            R3C3.Enabled = true;
        } // End of newGame

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turn == true && button.Text != " " && button.Text != "X" && button.Text != "O")
            {
                button.Text = "X";
                turn = !turn; // Turn will become false
                turnCount = turnCount + 1;
                textOutput.Text = "Round: " + turnCount;
            }
            else if (turn == false && button.Text != " " && button.Text != "X" && button.Text != "O")
            {
                button.Text = "O";
                turn = !turn; // Turn will become true
                turnCount = turnCount + 1;
                textOutput.Text = "Round: " + turnCount;
            }
            else
            {
                textOutput.Text = "That spot has already been taken."; // Do not use button.Enabled = false, it looks ugly!
            }

            endGame(checkForWinner("X"));
            endGame(checkForWinner("O"));
        } // End of button_click

        private bool checkForWinner(string playerPiece)
        {
            bool hasPlayerWon = false;

            if ((R1C1.Text == playerPiece) && (R1C2.Text == playerPiece) && (R1C3.Text == playerPiece)) // First Row Horizontal Win
            {
                hasPlayerWon = true;
            }
            else if ((R2C1.Text == playerPiece) && (R2C2.Text == playerPiece) && (R2C3.Text == playerPiece)) // Second Row Horizontal Win
            {
                hasPlayerWon = true;
            }
            else if ((R3C1.Text == playerPiece) && (R3C2.Text == playerPiece) && (R3C3.Text == playerPiece)) // Third Row Horizontal Win
            {
                hasPlayerWon = true;
            }
            else if ((R1C1.Text == playerPiece) && (R2C1.Text == playerPiece) && (R3C1.Text == playerPiece)) // First Vertical Column Win
            {
                hasPlayerWon = true;
            }
            else if ((R1C2.Text == playerPiece) && (R2C2.Text == playerPiece) && (R3C2.Text == playerPiece)) // Second Vertical Column Win
            {
                hasPlayerWon = true;
            }
            else if ((R1C3.Text == playerPiece) && (R2C3.Text == playerPiece) && (R3C3.Text == playerPiece)) // Third Vertical Column Win
            {
                hasPlayerWon = true;
            }
            else if ((R1C1.Text == playerPiece) && (R2C2.Text == playerPiece) && (R3C3.Text == playerPiece)) // Top Left Diagonal Win
            {
                hasPlayerWon = true;
            }
            else if ((R1C3.Text == playerPiece) && (R2C2.Text == playerPiece) && (R3C1.Text == playerPiece)) // Top Right Diagonal Win
            {
                hasPlayerWon = true;
            }



            // Check to see if the game has concluded
            if (hasPlayerWon == true)
            {
                textOutput.Text = playerPiece + " has won!";
                return hasPlayerWon;
            }
            else if (turnCount == 9)
            {
                textOutput.Text = "It's a draw partner.";
                return hasPlayerWon;
            }
            else
            {
                return hasPlayerWon; // In other words, the player has not won
            }
        } // End of checkForWinner()

        private void endGame(bool gameComplete) // At the end of the game this method disables all playing field buttons to prevent players from using the board
        {
            if (gameComplete == true)
            {
                R1C1.Enabled = false; // First row
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false; // Second row
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false; // Third row
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
        } // End of endGame()
    }
}