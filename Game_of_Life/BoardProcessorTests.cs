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
            Board initialBoard = new Board(0,0);
            Board expectedBoard = new Board(0,0);

            Board actualBoard = BoardProcessor.GetNextBoardIteration(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard); 
        }

        [Fact]
        public void TestBoardWithOneLiveCellReturnsOneDeadCell()
        {
            Board initialBoard = new Board(new[,] 
            {
                {true}
            });
            Board expectedBoard = new Board(new[,] 
            {
                {false}
            });

            Board actualBoard = BoardProcessor.GetNextBoardIteration(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard);
        }

        [Fact]
        public void TestBoardWithOneDeadCellReturnsOneDeadCell()
        {
            Board initialBoard = new Board(new[,] 
            {
                {false}
            });
            Board expectedBoard = new Board(new[,] 
            {
                {false}
            });

            Board actualBoard = BoardProcessor.GetNextBoardIteration(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard);
        }

        [Fact]
        public void TestBoardWithThreeLiveCellsReturnsOneLiveCell()
        {
            Board initialBoard = new Board(new[,] 
            {
                {true, true, true}
            });
            Board expectedBoard = new Board(new[,] 
            {
                {false, true, false}
            });

            Board actualBoard = BoardProcessor.GetNextBoardIteration(initialBoard);
            actualBoard.Should().BeEquivalentTo(expectedBoard);
        }
    }
}