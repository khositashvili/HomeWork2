using System;

public class TicTacToe
{
    private static char[,] board = new char[3, 3];
    private static char currentPlayer = 'X';

    public static void Main(string[] args)
    {
        InitializeBoard();
        PlayGame();
    }

    // Initialize the Tic-Tac-Toe board
    private static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' '; // Empty spaces
            }
        }
    }

    // Main game loop
    private static void PlayGame()
    {
        bool gameWon = false;
        int movesPlayed = 0;

        while (!gameWon && movesPlayed < 9)
        {
            PrintBoard();
            PlayerMove();
            gameWon = CheckForWinner();
            if (!gameWon)
            {
                SwitchPlayer();
            }
            movesPlayed++;
        }

        PrintBoard();
        if (gameWon)
        {
            Console.WriteLine($"Player {currentPlayer} wins!");
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }
    }

    // Switch between player X and O
    private static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    // Handle the player's move
    private static void PlayerMove()
    {
        int row = -1;
        int col = -1;
        bool moveValid = false;

        while (!moveValid)
        {
            Console.WriteLine($"Player {currentPlayer}, enter your move (row and column): ");
            Console.Write("Row (1-3): ");
            row = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Column (1-3): ");
            col = Convert.ToInt32(Console.ReadLine()) - 1;

            if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
                moveValid = true;
            }
            else
            {
                Console.WriteLine("Invalid move! Try again.");
            }
        }
    }

    // Print the Tic-Tac-Toe board
    private static void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine("  1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1} ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2)
                    Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2)
                Console.WriteLine("  -----");
        }
    }

    // Check if the current player has won
    private static bool CheckForWinner()
    {
        // Check rows, columns, and diagonals
        for (int i = 0; i < 3; i++)
        {
            // Check rows
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                return true;

            // Check columns
            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                return true;
        }

        // Check diagonals
        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            return true;

        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
            return true;

        return false;
    }
}

