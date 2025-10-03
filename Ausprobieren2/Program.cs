using System;

class MemoryGame
{
    static void Main()
    {
        const int size = 4; 
        char[,] board = new char[size, size];
        bool[,] revealed = new bool[size, size];
        
        char[] baseSymbols = { '*', '#', 'ç', '@', '^', '<', '>', '+' };
        
        char[] symbols = new char[16];
        int idx = 0;
        foreach (char c in baseSymbols)
        {
            symbols[idx++] = c;
            symbols[idx++] = c;
        }
        
        Random rnd = new Random();
        for (int i = symbols.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            char tmp = symbols[i];
            symbols[i] = symbols[j];
            symbols[j] = tmp;
        }
        
        idx = 0;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                board[row, col] = symbols[idx++];
            }
        }

        int remainingPairs = 8;
        int moves = 0;

        while (remainingPairs > 0)
        {
            PrintBoard(board, revealed);

            Console.Write("Eingabe (z.B. 1233) oder 0 für Exit: ");
            string input = Console.ReadLine();
            moves++;

            if (input == "0")
            {
                Console.WriteLine("Spiel beendet.");
                return;
            }

            if (input.Length != 4 || !int.TryParse(input, out _))
            {
                Console.WriteLine("Ungültige Eingabe!");
                continue;
            }

            int r1 = input[0] - '1';
            int c1 = input[1] - '1';
            int r2 = input[2] - '1';
            int c2 = input[3] - '1';

            if (!IsValid(r1, c1, size) || !IsValid(r2, c2, size) || (r1 == r2 && c1 == c2))
            {
                Console.WriteLine("Ungültige Positionen!");
                continue;
            }

            if (revealed[r1, c1] || revealed[r2, c2])
            {
                Console.WriteLine("Eine Karte ist schon aufgedeckt!");
                continue;
            }

            Console.Clear();
            PrintBoard(board, revealed, r1, c1, r2, c2);

            switch (board[r1, c1] == board[r2, c2])
            {
                case true:
                    Console.WriteLine("Treffer!");
                    revealed[r1, c1] = true;
                    revealed[r2, c2] = true;
                    remainingPairs--;
                    break;

                case false:
                    Console.WriteLine("Leider kein Treffer.");
                    Console.WriteLine("Drücke eine Taste, um weiterzumachen...");
                    Console.ReadKey();
                    break;
            }

            Console.Clear();
        }

        Console.Clear();
        PrintBoard(board, revealed);
        Console.WriteLine($"Gratulation. Spiel beendet! Du hast {moves} Versuche gebraucht.");
    }

    static void PrintBoard(char[,] board, bool[,] revealed, int r1 = -1, int c1 = -1, int r2 = -1, int c2 = -1)
    {
        int size = board.GetLength(0);
        Console.WriteLine("   1 2 3 4");
        for (int row = 0; row < size; row++)
        {
            Console.Write((row + 1) + "  ");
            for (int col = 0; col < size; col++)
            {
                switch (true)
                {
                    case true when revealed[row, col]:
                        Console.Write("  ");
                        break;
                    case true when (row == r1 && col == c1) || (row == r2 && col == c2):
                        Console.Write(board[row, col] + " ");
                        break;
                    default:
                        Console.Write("? ");
                        break;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static bool IsValid(int r, int c, int size)
    {
        return r >= 0 && r < size && c >= 0 && c < size;
    }
}
