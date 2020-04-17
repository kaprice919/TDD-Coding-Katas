namespace GameOfLife
{
    public static class GameOfLife
    {
        public static bool[,] GetNextBoard(bool[,] currentBoard)
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