using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            char[,] matrix = new char[length, length];

            var currentPositionRow = 0;
            var currentPositionCol = 0;

            for (int row = 0; row < length; row++)
            {
                var initialization = Console.ReadLine().ToCharArray();

                for (int col = 0; col < initialization.Length; col++)
                {
                    matrix[row, col] = initialization[col];
                    if (matrix[row, col] == 'S')
                    {
                        currentPositionRow = row;
                        currentPositionCol = col;
                    }
                }
            }

            var money = 0;
            var isInTheBakery = true;

            while (!(money >= 50) && isInTheBakery)
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        if (currentPositionRow - 1 < 0)
                        {
                            isInTheBakery = false;
                            matrix[currentPositionRow, currentPositionCol] = '-';
                        }
                        else
                        {
                            matrix[currentPositionRow, currentPositionCol] = '-';
                            currentPositionRow--;
                            if (char.IsDigit(matrix[currentPositionRow, currentPositionCol]))
                            {
                                money += int.Parse(matrix[currentPositionRow, currentPositionCol].ToString());
                            }
                            else if (char.IsLetter(matrix[currentPositionRow, currentPositionCol]))
                            {
                                matrix[currentPositionRow, currentPositionCol] = '-';
                                for (int row = 0; row < length; row++)
                                {
                                    for (int col = 0; col < length; col++)
                                    {
                                        if (matrix[row, col] == 'O')
                                        {
                                            currentPositionRow = row;
                                            currentPositionCol = col;
                                        }
                                    }
                                }
                            }

                            matrix[currentPositionRow, currentPositionCol] = 'S';
                        }
                        break;

                    case "down":
                        if (currentPositionRow + 1 >= matrix.GetLength(0))
                        {
                            isInTheBakery = false;
                            matrix[currentPositionRow, currentPositionCol] = '-';
                        }
                        else
                        {
                            matrix[currentPositionRow, currentPositionCol] = '-';
                            currentPositionRow++;

                            if (char.IsDigit(matrix[currentPositionRow, currentPositionCol]))
                            {
                                money += int.Parse(matrix[currentPositionRow, currentPositionCol].ToString());
                            }
                            else if (char.IsLetter(matrix[currentPositionRow, currentPositionCol]))
                            {
                                matrix[currentPositionRow, currentPositionCol] = '-';
                                for (int row = 0; row < length; row++)
                                {
                                    for (int col = 0; col < length; col++)
                                    {
                                        if (matrix[row, col] == 'O')
                                        {
                                            currentPositionRow = row;
                                            currentPositionCol = col;
                                        }
                                    }
                                }
                            }

                            matrix[currentPositionRow, currentPositionCol] = 'S';
                        }
                        break;

                    case "left":
                        if (currentPositionCol - 1 < 0)
                        {
                            isInTheBakery = false;
                            matrix[currentPositionRow, currentPositionCol] = '-';
                        }
                        else
                        {
                            matrix[currentPositionRow, currentPositionCol] = '-';
                            currentPositionCol--;

                            if (char.IsDigit(matrix[currentPositionRow, currentPositionCol]))
                            {
                                money += int.Parse(matrix[currentPositionRow, currentPositionCol].ToString());
                            }
                            else if (char.IsLetter(matrix[currentPositionRow, currentPositionCol]))
                            {
                                matrix[currentPositionRow, currentPositionCol] = '-';
                                for (int row = 0; row < length; row++)
                                {
                                    for (int col = 0; col < length; col++)
                                    {
                                        if (matrix[row, col] == 'O')
                                        {
                                            currentPositionRow = row;
                                            currentPositionCol = col;
                                        }
                                    }
                                }
                            }

                            matrix[currentPositionRow, currentPositionCol] = 'S';
                        }
                        break;

                    case "right":
                        if (currentPositionCol + 1 >= matrix.GetLength(1))
                        {
                            isInTheBakery = false;
                            matrix[currentPositionRow, currentPositionCol] = '-';
                        }
                        else
                        {
                            matrix[currentPositionRow, currentPositionCol] = '-';
                            currentPositionCol++;

                            if (char.IsDigit(matrix[currentPositionRow, currentPositionCol]))
                            {
                                money += int.Parse(matrix[currentPositionRow, currentPositionCol].ToString());
                            }
                            else if (char.IsLetter(matrix[currentPositionRow, currentPositionCol]))
                            {
                                matrix[currentPositionRow, currentPositionCol] = '-';
                                for (int row = 0; row < length; row++)
                                {
                                    for (int col = 0; col < length; col++)
                                    {
                                        if (matrix[row, col] == 'O')
                                        {
                                            currentPositionRow = row;
                                            currentPositionCol = col;
                                        }
                                    }
                                }
                            }

                            matrix[currentPositionRow, currentPositionCol] = 'S';
                        }
                        break;
                }

            }

            if (isInTheBakery)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            else
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }

            Console.WriteLine($"Money: {money}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
