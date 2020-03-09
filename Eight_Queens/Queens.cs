
using System;
using System.Collections.Generic;

namespace EightQueens
{
    public class Queens
    {
        public static bool IsGameBoardValid(int[,] gameBoard, int rows, int columns)
        {
            List<Tuple<int,int>> queenCoordinates = getCoordinates(gameBoard, rows, columns);
            if(queenCoordinates.Count <= 1)
            {
                return true;
            }
                
            return isRowSafe(queenCoordinates) && isColumnSafe(queenCoordinates) && isDiagonalSafe(queenCoordinates);
        }

        private static bool isRowSafe(List<Tuple<int,int>> queenCoordinates)
        {
            Dictionary<int, int> queenRowCounts = new Dictionary<int, int>();

            foreach(var coordinate in queenCoordinates)
            {
                if(queenRowCounts.ContainsKey(coordinate.Item1))
                {
                    return false;
                }
                queenRowCounts.Add(coordinate.Item1, 1);
            }
            return true;
        }

        private static bool isColumnSafe(List<Tuple<int,int>> queenCoordinates)
        {
            Dictionary<int, int> queenColumnCounts = new Dictionary<int, int>();

            foreach(var coordinate in queenCoordinates)
            {
                if(queenColumnCounts.ContainsKey(coordinate.Item2))
                {
                    return false;
                }
                queenColumnCounts.Add(coordinate.Item2, 1);
            }
            return true;
        }

        private static bool isDiagonalSafe(List<Tuple<int,int>> queenCoordinates)
        {
            foreach(var coordinate1 in queenCoordinates)
            {
                foreach(var coordinate2 in queenCoordinates)
                {
                    //skip self
                    if(coordinate1.Item1 == coordinate2.Item1)
                    {
                        continue;
                    }

                    var deltaRow = Math.Abs(coordinate1.Item1 - coordinate2.Item1);
                    var deltaCol = Math.Abs(coordinate1.Item2 - coordinate2.Item2);

                    if(deltaRow == deltaCol)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static List<Tuple<int,int>> getCoordinates(int[,] gameBoard, int rows, int columns)
        {
            List<Tuple<int,int>> coordinates = new List<Tuple<int,int>>();

            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    if(gameBoard[row, column] == 1)
                    {
                        coordinates.Add(new Tuple<int, int>(row,column));
                    }
                }
            }

            return coordinates;
        }
    }
}





