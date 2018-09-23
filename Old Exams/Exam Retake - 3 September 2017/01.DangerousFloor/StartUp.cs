namespace DangerousFloor
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[][] matrix = new string[8][];
            Pawn pawn = new Pawn();
            Queen queen = new Queen();
            Bishop bishop = new Bishop();
            Rook rook = new Rook();
            King king = new King();

            for (int i = 0; i < 8; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            string[] command = Console.ReadLine()
                .Split("-", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (!command[0].Equals("END"))
            {
                char figure = command[0][0];

                int[] currentPosition = new[]
                {
                    int.Parse(command[0][1].ToString()),
                    int.Parse(command[0][2].ToString())
                };
                int[] futurePosition = new[]
                {
                    int.Parse(command[1][0].ToString()),
                    int.Parse(command[1][1].ToString())
                };

                if (!matrix[currentPosition[0]][currentPosition[1]].Equals(figure.ToString()))
                {
                    Console.WriteLine("There is no such a piece!");
                }
                else
                {
                    if (figure.Equals('K'))
                    {
                        king.Position = currentPosition;

                        if (king.ValidHorizontallMoves(futurePosition) == false &&
                            king.ValidDiagonallMoves(futurePosition) == false &&
                            king.ValidVerticallMoves(futurePosition) == false)
                        {
                            Console.WriteLine("Invalid move!");
                        }
                        else if (futurePosition[0] < 8 && futurePosition[1] < 8)
                        {
                            rook.Position = futurePosition;
                            ChangePosition(figure, matrix, currentPosition, futurePosition);
                        }
                        else
                        {
                            Console.WriteLine("Move go out of board!");
                        }
                    }
                    else if (figure.Equals('R'))
                    {
                        rook.Position = currentPosition;

                        if (rook.ValidHorizontallMoves(futurePosition) == false &&
                            rook.ValidVerticallMoves(futurePosition) == false)
                        {
                            Console.WriteLine("Invalid move!");
                        }
                        else if (futurePosition[0] < 8 && futurePosition[1] < 8)
                        {
                            rook.Position = futurePosition;
                            ChangePosition(figure, matrix, currentPosition, futurePosition);
                        }
                        else
                        {
                            Console.WriteLine("Move go out of board!");
                        }
                    }
                    else if (figure.Equals('B'))
                    {
                        bishop.Position = currentPosition;

                        if (bishop.ValidDiagonallMoves(futurePosition) == false)
                        {
                            Console.WriteLine("Invalid move!");
                        }
                        else if (futurePosition[0] < 8 && futurePosition[1] < 8)
                        {
                            bishop.Position = futurePosition;
                            ChangePosition(figure, matrix, currentPosition, futurePosition);
                        }
                        else
                        {
                            Console.WriteLine("Move go out of board!");
                        }
                    }
                    else if (figure.Equals('Q'))
                    {
                        queen.Position = currentPosition;

                        if (queen.ValidHorizontallMoves(futurePosition) == false &&
                            queen.ValidVerticallMoves(futurePosition) == false &&
                            queen.ValidDiagonallMoves(futurePosition) == false)
                        {
                            Console.WriteLine("Invalid move!");
                        }
                        else if (futurePosition[0] < 8 && futurePosition[1] < 8)
                        {
                            queen.Position = futurePosition;
                            ChangePosition(figure, matrix, currentPosition, futurePosition);
                        }
                        else
                        {
                            Console.WriteLine("Move go out of board!");
                        }
                    }
                    else if (figure.Equals('P'))
                    {
                        pawn.Position = currentPosition;

                        if (pawn.ValidOnceMove(futurePosition) == false)
                        {
                            Console.WriteLine("Invalid move!");
                        }
                        else if (futurePosition[0] < 8 && futurePosition[1] < 8)
                        {
                            pawn.Position = futurePosition;
                            ChangePosition(figure, matrix, currentPosition, futurePosition);
                        }
                        else
                        {
                            Console.WriteLine("Move go out of board!");
                        }
                    }
                }

                command = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }

        private static void ChangePosition(char figure, string[][] matrix, int[] currentPosition, int[] futurePosition)
        {
            matrix[currentPosition[0]][currentPosition[1]] = "x";
            matrix[futurePosition[0]][futurePosition[1]] = figure.ToString();
        }
    }
}