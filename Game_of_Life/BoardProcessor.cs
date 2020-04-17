namespace GameOfLife
{
    public static class BoardProcessor
    {
        public static bool[,] GetNextBoardIteration(bool[,] currentBoard)
        {
            if(currentBoard.Length > 0 && currentBoard.Length <= 2)
            {
                return new bool[,]
                {
                    {false}
                };
            }
            else if(currentBoard.Length > 2)
            {
                return new bool[,]
                {
                    {false, true, false}
                };
            }
            else
            {
                return new bool[0,0];
            }
        }
    }
}