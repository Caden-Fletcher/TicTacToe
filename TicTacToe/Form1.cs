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

            checkForWinner(); // Checks for 3 in a row and returns a boolean
            endGame(checkForWinner()); // Checks if checkForWinner has returned a boolean that is true, if so it disables all playing field buttons
        } // End of button_click

        private bool checkForWinner()
        {
            bool hasOWon = false;
            bool hasXWon = false;

            // Check for O Victory
            if ((R1C1.Text == "O") && (R1C2.Text == "O") && (R1C3.Text == "O")) // First Row Horizontal Win [O]
            {
                hasOWon = true;
            }
            else if ((R2C1.Text == "O") && (R2C2.Text == "O") && (R2C3.Text == "O")) // Second Row Horizontal Win [O]
            {
                hasOWon = true;
            }
            else if ((R3C1.Text == "O") && (R3C2.Text == "O") && (R3C3.Text == "O")) // Third Row Horizontal Win [O]
            {
                hasOWon = true;
            }
            else if ((R1C1.Text == "O") && (R2C1.Text == "O") && (R3C1.Text == "O")) // First Vertical Column Win [O]
            {
                hasOWon = true;
            }
            else if ((R1C2.Text == "O") && (R2C2.Text == "O") && (R3C2.Text == "O")) // Second Vertical Column Win [O]
            {
                hasOWon = true;
            }
            else if ((R1C3.Text == "O") && (R2C3.Text == "O") && (R3C3.Text == "O")) // Third Vertical Column Win [O]
            {
                hasOWon = true;
            }
            else if ((R1C1.Text == "O") && (R2C2.Text == "O") && (R3C3.Text == "O")) // Top Left Diagonal Win [O]
            {
                hasOWon = true;
            }
            else if ((R1C3.Text == "O") && (R2C2.Text == "O") && (R3C1.Text == "O")) // Top Right Diagonal Win [O]
            {
                hasOWon = true;
            }



            // Check for X Victory
            if ((R1C1.Text == "X") && (R1C2.Text == "X") && (R1C3.Text == "X")) // First Row Horizontal Win [X]
            {
                hasXWon = true;
            }
            else if ((R2C1.Text == "X") && (R2C2.Text == "X") && (R2C3.Text == "X")) // Second Row Horizontal Win [X]
            {
                hasXWon = true;
            }
            else if ((R3C1.Text == "X") && (R3C2.Text == "X") && (R3C3.Text == "X")) // Third Row Horizontal Win [X]
            {
                hasXWon = true;
            }
            else if ((R1C1.Text == "X") && (R2C1.Text == "X") && (R3C1.Text == "X")) // First Vertical Column Win [X]
            {
                hasXWon = true;
            }
            else if ((R1C2.Text == "X") && (R2C2.Text == "X") && (R3C2.Text == "X")) // Second Vertical Column Win [X]
            {
                hasXWon = true;
            }
            else if ((R1C3.Text == "X") && (R2C3.Text == "X") && (R3C3.Text == "X")) // Third Vertical Column Win [X]
            {
                hasXWon = true;
            }
            else if ((R1C1.Text == "X") && (R2C2.Text == "X") && (R3C3.Text == "X")) // Top Left Diagonal Win [X]
            {
                hasXWon = true;
            }
            else if ((R1C3.Text == "X") && (R2C2.Text == "X") && (R3C1.Text == "X")) // Top Right Diagonal Win [X]
            {
                hasXWon = true;
            }



            // Declare winner
            if (hasOWon == true)
            {
                textOutput.Text = "O has won!";
                return true;
            }
            else if (hasXWon == true)
            {
                textOutput.Text = "X has won!";
                return true;
            }
            else if (turnCount == 9)
            {
                textOutput.Text = "It's a draw partner.";
                return true;
            }
            else
            {
                return false;
            }
        } // End of checkForWinner

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