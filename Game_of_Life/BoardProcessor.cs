namespace GameOfLife
{
    public static class BoardProcessor
    {
        public static bool[,] GetNextBoardIteration(bool[,] currentBoard)
        {
            if(currentBoard.Length > 0)
            {
                return new bool[,]
                {
                    {false}
                };
            }
            else
            {
                return new bool[0,0];
            }
        }
    }
}