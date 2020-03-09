using Xunit;
using FluentAssertions;
using EightQueens;

namespace EightQueensTests
{
    public class QueensTests
    {
        [Fact]
        public void Test0Queens3x3BoardReturnsTrue()
        {
            int[,] gameBoard = new int[3,3];
            Queens.IsGameBoardValid(gameBoard, 3, 3).Should().BeTrue();
        }

        [Fact]
        public void Test1Queen3x3BoardReturnsTrue()
        {
            int[,] gameBoard = new int[3,3]{
                {1,0,0},
                {0,0,0},
                {0,0,0}
            };

            Queens.IsGameBoardValid(gameBoard, 3, 3).Should().BeTrue();
        }

        [Fact]
        public void Test2QueenSameRow3x3BoardReturnsFalse()
        {
            int[,] gameBoard = new int[3,3]{
                {1,1,0},
                {0,0,0},
                {0,0,0}
            };

            Queens.IsGameBoardValid(gameBoard, 3, 3).Should().BeFalse();
        }
        
        [Fact]
        public void Test2QueenSameColumn3x3BoardReturnsFalse()
        {
            int[,] gameBoard = new int[3,3]{
                {1,0,0},
                {1,0,0},
                {0,0,0}
            };

            Queens.IsGameBoardValid(gameBoard, 3, 3).Should().BeFalse();
        }

        [Fact]
        public void Test2QueenSameDiagonal3x3BoardReturnsFalse()
        {
            int[,] gameBoard = new int[3,3]{
                {1,0,0},
                {0,0,0},
                {0,0,1}
            };

            Queens.IsGameBoardValid(gameBoard, 3, 3).Should().BeFalse();
        }

        [Fact]
        public void Test8QueenValid8x8BoardReturnsTrue()
        {
            int[,] gameBoard = new int[8,8]{
                {0,0,1,0,0,0,0,0},
                {0,0,0,0,0,1,0,0},
                {0,0,0,0,0,0,0,1},
                {1,0,0,0,0,0,0,0},
                {0,0,0,1,0,0,0,0},
                {0,0,0,0,0,0,1,0},
                {0,0,0,0,1,0,0,0},
                {0,1,0,0,0,0,0,0},
            };

            Queens.IsGameBoardValid(gameBoard, 8, 8).Should().BeTrue();
        }
    }
}
