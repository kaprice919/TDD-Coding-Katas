using System;
using Xunit;
using FluentAssertions;

namespace GameOfLife
{
    public class GameOfLifeTests
    {
        [Fact]
        public void TestReturnsAnEmptyBoard()
        {
            bool[,] initialBoard = new bool[0,0];
            bool[,] expectedBoard = new bool[0,0];

            bool[,] actualBoard = GameOfLife.GetNextBoard(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard); 
        }

        [Fact]
        public void TestBoardWithOneLiveCellReturnsOneDeadCell()
        {
            bool[,] initialBoard = new bool[,]
            {
                {true}
            };

            bool[,] expectedBoard = new bool[,]
            {
                {false}
            };

            bool[,] actualBoard = GameOfLife.GetNextBoard(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard);
        }

        [Fact]
        public void TestBoardWithOneDeadCellReturnsOneDeadCell()
        {
            bool[,] initialBoard = new bool[,]
            {
                {false}
            };

            bool[,] expectedBoard = new bool[,]
            {
                {false}
            };

            bool[,] actualBoard = GameOfLife.GetNextBoard(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard);
        }

        [Fact]
        public void TestBoardWithThreeLiveCellsReturnsOneLiveCell()
        {
            bool[,] initialBoard = new bool[,]
            {
                {true, true, true}
            };

            bool[,] expectedBoard = new bool[,]
            {
                {false, true, false}
            };

            bool[,] actualBoard = GameOfLife.GetNextBoard(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard);
        }
    }
}