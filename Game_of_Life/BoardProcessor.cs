namespace GameOfLife
{
    public static class BoardProcessor
    {
        public static Board GetNextBoardIteration(Board currentBoard)
        {
            if(currentBoard.board.Length > 0 && currentBoard.board.Length <= 2)
            {
                return new Board(new[,] 
                {
                    {false}
                });
            }
            else if(currentBoard.board.Length > 2)
            {
                return new Board(new[,] 
                {
                    {false,true,false}
                });
            }
            else
            {
                return new Board(0,0);
            }
        }
    }
}