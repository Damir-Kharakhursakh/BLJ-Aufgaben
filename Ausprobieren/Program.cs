using System;
using System.Collections.Generic;

class MemoryGame
{
    static void Main()
    {
        const int size = 4; // 4x4 Spielfeld
        char[,] board = new char[size, size];
        bool[,] revealed = new bool[size, size];
        
        // Symbole vorbereiten (8 Paare, deine Wunsch-Zeichen)
        char[] baseSymbols = { '☺', '#', '♦', '♠', '♥', '♣', '♫', '☼' };

        List<char> symbols = new List<char>();
        foreach (char c in baseSymbols)
        {
            symbols.Add(c);
            symbols.Add(c); // jedes Zeichen doppelt für ein Paar
        }

        // Symbole zufällig mischen
        Random rnd = new Random();
        for (int i = symbols.Count - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            char tmp = symbols[i];
            symbols[i] = symbols[j];
            symbols[j] = tmp;
        }

        // Symbole ins Board legen
        int index = 0;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                board[row, col] = symbols[index++];
            }
        }

        int remainingPairs = 8;

        while (remainingPairs > 0)
        {
            PrintBoard(board, revealed);

            Console.Write("Eingabe (z.B. 1233 = Zeile1Spalte1Zeile2Spalte2): ");
            string input = Console.ReadLine();

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

            // Karten aufdecken
            Console.Clear();
            PrintBoard(board, revealed, r1, c1, r2, c2);

            if (board[r1, c1] == board[r2, c2])
            {
                Console.WriteLine("Treffer!");
                revealed[r1, c1] = true;
                revealed[r2, c2] = true;
                remainingPairs--;
            }
            else
            {
                Console.WriteLine("Leider kein Treffer.");
                Console.WriteLine("Drücke eine Taste, um weiterzumachen...");
                Console.ReadKey();
            }

            Console.Clear();
        }

        Console.Clear();
        PrintBoard(board, revealed);
        Console.WriteLine("Gratulation. Spiel beendet!");
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
                if (revealed[row, col])
                    Console.Write("  ");
                else if ((row == r1 && col == c1) || (row == r2 && col == c2))
                    Console.Write(board[row, col] + " ");
                else
                    Console.Write("? ");
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