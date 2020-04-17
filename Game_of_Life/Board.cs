using System;
namespace GameOfLife
{
    public class Board
    {
        public bool[,] board { get; set; }

        public Board(int rows, int columns)
        {
            board = new bool[rows, columns];
        }

        public Board(bool[,] board)
        {
            this.board = board;
        }
    }
}