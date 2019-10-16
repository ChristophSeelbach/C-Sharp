using System;
using System.Text.RegularExpressions;

namespace ConnectGame
{
    class ConnectGame
    {
        int BoardRows { get; set; }
        int BoardCols { get; set; }
        char[,] Board { get; set; }
        public bool IsRunning { get; protected set; }
        public char ActivePlayer { get; protected set; }
        public char Winner { get; protected set; }

        public static Move ParseMove(string input)
        {
            var match = Regex.Match(input, "([0-9]+)\\s*,?;?([0-9]+)");
            if (!match.Success)
                throw new Exception("Invalid input");

            return new Move
            {
                Row = int.Parse(match.Groups[1].Value),
                Col = int.Parse(match.Groups[2].Value)
            };
        }

        public ConnectGame(int rows, int cols)
        {
            this.BoardCols = cols;
            this.BoardRows = rows;

            this.Board = new char[BoardRows, BoardCols];

            this.ActivePlayer = 'x';
            this.IsRunning = true;
        }

        public void DrawBoard()
        {
            Console.Clear();

            for (int r = 0; r < this.BoardRows; r++)
            {
                for (int c = 0; c < this.BoardCols; c++)
                {
                    if (this.Board[r, c] == 'x')
                        Console.ForegroundColor = ConsoleColor.Green;
                    if (this.Board[r, c] == 'o')
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(this.Board[r, c] == '\0' ? '#' : this.Board[r, c]);

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        public void AddMove(Move m)
        {
            if (!IsValidMove(m))
                throw new InvalidMoveException();

            Console.Beep();
            this.Board[m.Row, m.Col] = this.ActivePlayer;

            // Check for winning state in y-axis
            if (m.Row - 3 >= 0)
            {
                var checkSum = 0;
                for (int r = m.Row - 3; r <= m.Row; r++)
                    checkSum += this.Board[r, m.Col];
                if (checkSum == this.ActivePlayer * 4)
                    this.EndGame();
            }
            if (m.Row + 3 < this.BoardRows)
            {
                var checkSum = 0;
                for (int r = m.Row; r <= m.Row + 3; r++)
                    checkSum += this.Board[r, m.Col];
                if (checkSum == this.ActivePlayer * 4)
                    this.EndGame();
            }

            // Check for winning state in the x-axis
            if (m.Col - 3 >= 0)
            {
                var checkSum = 0;
                for (int c = m.Col - 3; c <= m.Col; c++)
                    checkSum += this.Board[m.Row, c];
                if (checkSum == this.ActivePlayer * 4)
                    this.EndGame();
            }
            if (m.Col + 3 < this.BoardCols)
            {
                var checkSum = 0;
                for (int c = m.Col; c <= m.Col + 3; c++)
                    checkSum += this.Board[m.Row, c];
                if (checkSum == this.ActivePlayer * 4)
                    this.EndGame();
            }

            // Check winning state from the top-left
            if (m.Row - 3 >= 0 && m.Col - 3 >= 0)
            {
                var checkSum = 0;
                for (int r = m.Row - 3, c = m.Col - 3; r <= m.Row; r++, c++)
                    checkSum += this.Board[r, c];
                if (checkSum == this.ActivePlayer * 4)
                    this.EndGame();
            }

            // Check winning state from the top-right
            if (m.Row - 3 >= 0 && m.Col + 3 < this.BoardCols)
            {
                var checkSum = 0;
                for (int r = m.Row - 3, c = m.Col + 3; r <= m.Row; r++, c--)
                    checkSum += this.Board[r, c];
                if (checkSum == this.ActivePlayer * 4)
                    this.EndGame();
            }

            // Check winning state from the bottom-left
            if (m.Row + 3 < this.BoardRows && m.Col - 3 >= 0)
            {
                var checkSum = 0;
                for (int r = m.Row - 3, c = m.Col + 3; r >= m.Row; r++, c--)
                    checkSum += this.Board[r, c];
                if (checkSum == this.ActivePlayer * 4)
                    this.EndGame();
            }

            // Check winning state from the bottom-right
            if (m.Row + 3 < this.BoardRows && m.Row + 3 < this.BoardCols)
            {
                var checkSum = 0;
                for (int r = m.Row + 3, c = m.Col + 3; r >= m.Row; r--, c--)
                    checkSum += this.Board[r, c];
                if (checkSum == this.ActivePlayer * 4)
                    this.EndGame();
            }

            this.ActivePlayer = this.ActivePlayer == 'x' ? 'o' : 'x';
        }

        public void EndGame()
        {
            this.Winner = this.ActivePlayer;
            this.IsRunning = false;
        }

        public bool IsValidMove(Move m)
        {
            if (m.Row >= this.BoardRows || m.Row < 0)
                return false;

            if (m.Col >= this.BoardCols || m.Col < 0)
                return false;

            return this.Board[m.Row, m.Col] == '\0';
        }
    }
}
