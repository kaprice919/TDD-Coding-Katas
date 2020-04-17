using System;
using Xunit;
using FluentAssertions;
using GameOfLife;

namespace GameOfLifeTests
{
    public class BoardProcessorTests
    {
        [Fact]
        public void TestReturnsAnEmptyBoard()
        {
            bool[,] initialBoard = new bool[0,0];
            bool[,] expectedBoard = new bool[0,0];

            bool[,] actualBoard = BoardProcessor.GetNextBoardIteration(initialBoard);
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

            bool[,] actualBoard = BoardProcessor.GetNextBoardIteration(initialBoard);
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

            bool[,] actualBoard = BoardProcessor.GetNextBoardIteration(initialBoard);
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

            bool[,] actualBoard = BoardProcessor.GetNextBoardIteration(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard);
        }
    }
}