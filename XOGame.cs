using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOGame
{
    class XOGame
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] nums = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };


            Console.WriteLine("Start game!");
            Console.WriteLine("Choose the row and column:");

            while (true)
            {
                Coordinates:
                string p = Console.ReadLine();
                string[] indexes = p.Split(',');
                int firstIndex = Convert.ToInt32(indexes[0]);
                int secondIndex = Convert.ToInt32(indexes[1]);

                //Console.WriteLine("Available?: " + CheckAvailable(nums, firstIndex, secondIndex));
                if (CheckAvailable(nums, firstIndex, secondIndex) == true )
                {
                    nums[firstIndex, secondIndex] = player;
                }
                else
                {
                    Console.WriteLine("This position is taken, choose again!");
                    Board(nums);
                    goto Coordinates;
                }

                

                CheckWin(nums, player);
                Board(nums);
                player = player == 'X' ? 'O' : 'X';
                bool full = CheckDraw(nums);
                //Console.WriteLine("Is it full?: " + full);
                if(full == true) Console.WriteLine("It's a draw! No winners this time.");
            }
        }

        static bool CheckDraw(char[,] arr)
        {
            foreach (char c in arr)
            {
                if (c == ' ')
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckWin(char[,] arr, char c)
        {
            bool win;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                char[] row = new char[3];
                char[] column = new char[3];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    row[j] = arr[i, j];
                    column[j] = arr[j, i];

                }

                win = true;
                foreach (char k in row)
                {
                    if (k != c)
                    {
                        win = false;
                    }
                }

                if (win)
                {
                    Console.WriteLine("Congratulations, player " + c + "! You Won!");
                    return win;
                }

                win = true;
                foreach (char k in column)
                {
                    if (k != c)
                    {
                        win = false;
                    }
                }

                if (win)
                {
                    Console.WriteLine("Congratulations, player " + c + "! You Won!");
                    return win;
                }
            }
            char[] diag1 = new char[3];
            char[] diag2 = new char[3];
            for (int m = 0; m < 3; m++)
            {
                diag1[m] = arr[m, m];
                diag2[m] = arr[m, 2-m];

            }
            win = true;
            foreach (char k in diag1)
            {
                if (k != c)
                {
                    win = false;
                }
            }

            if (win)
            {
                Console.WriteLine("Congratulations, player " + c + "! You Won!");
                return win;
            }
            win = true;
            foreach (char k in diag2)
            {
                if (k != c)
                {
                    win = false;
                }
            }

            if (win)
            {
                Console.WriteLine("Congratulations, player " + c + "! You Won!");
                return win;
            }
            return false;
        }

        static bool CheckAvailable(char[,] arr, int firstIndex, int secondIndex )
        {
            if (arr[firstIndex, secondIndex] == ' ') return true;
            return false;
        }

        private static void Board(char[,] arr)
        {
            for (int i = 0; i < 3 ; i++)
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[i, 0], arr[i, 1], arr[i, 2]);
                if(i==0 || i==1 )
                {
                    Console.WriteLine("_____|_____|_____ ");
                }
                else
                {
                    Console.WriteLine("     |     |      ");
                }
            }
            
        }
    }
}
