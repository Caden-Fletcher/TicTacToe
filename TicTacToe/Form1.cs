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

            ConcludeGame(ContinueRound("X"));
            ConcludeGame(ContinueRound("O"));
        } // End of button_click

        private byte ContinueRound(string playerPiece)
        {
            // Returning a boolean works for checking if a player has won or not, but if there is a draw it causes problems for me
            // Return 0 = Next Round
            // Return 1 = Draw
            // Return 2 = Current Player Has Won

            if ((R1C1.Text == playerPiece) && (R1C2.Text == playerPiece) && (R1C3.Text == playerPiece)) // First Row Horizontal Win
            {
                textOutput.Text = playerPiece + " has won!";
                return 2; // Current Player Has Won
            }
            else if ((R2C1.Text == playerPiece) && (R2C2.Text == playerPiece) && (R2C3.Text == playerPiece)) // Second Row Horizontal Win
            {
                textOutput.Text = playerPiece + " has won!";
                return 2; // Current Player Has Won
            }
            else if ((R3C1.Text == playerPiece) && (R3C2.Text == playerPiece) && (R3C3.Text == playerPiece)) // Third Row Horizontal Win
            {
                textOutput.Text = playerPiece + " has won!";
                return 2; // Current Player Has Won
            }
            else if ((R1C1.Text == playerPiece) && (R2C1.Text == playerPiece) && (R3C1.Text == playerPiece)) // First Vertical Column Win
            {
                textOutput.Text = playerPiece + " has won!";
                return 2; // Current Player Has Won
            }
            else if ((R1C2.Text == playerPiece) && (R2C2.Text == playerPiece) && (R3C2.Text == playerPiece)) // Second Vertical Column Win
            {
                textOutput.Text = playerPiece + " has won!";
                return 2; // Current Player Has Won
            }
            else if ((R1C3.Text == playerPiece) && (R2C3.Text == playerPiece) && (R3C3.Text == playerPiece)) // Third Vertical Column Win
            {
                textOutput.Text = playerPiece + " has won!";
                return 2; // Current Player Has Won
            }
            else if ((R1C1.Text == playerPiece) && (R2C2.Text == playerPiece) && (R3C3.Text == playerPiece)) // Top Left Diagonal Win
            {
                textOutput.Text = playerPiece + " has won!";
                return 2; // Current Player Has Won
            }
            else if ((R1C3.Text == playerPiece) && (R2C2.Text == playerPiece) && (R3C1.Text == playerPiece)) // Top Right Diagonal Win
            {
                textOutput.Text = playerPiece + " has won!";
                return 2; // Current Player Has Won
            }
            else if (turnCount == 9)
            {
                textOutput.Text = "It's a draw partner.";
                return 1; // Draw
            }
            else
            {
                return 0; // Next Round
            }
        } // End of ContinueRound

        private void ConcludeGame(int gameState)
        {
            // Return 0 = Next Round
            // Return 1 = Draw
            // Return 2 = Current Player Has Won

            if (gameState == 2 || gameState == 1) // The board will be disabled if a player has won or if the game ends in a draw
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
        } // End of ConcludeGame
    }
}