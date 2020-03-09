namespace TDDDoors
{
    public static class Doors
    {
        public static int[] checkDoors(int[] doors, int numberOfPasses)
        {
            for(int passNumber = 1; passNumber <= numberOfPasses; passNumber++)
            {
                doors = passThroughAllDoors(doors, numberOfPasses, passNumber);
            }

            return doors;
        }

        private static int[] passThroughAllDoors(int[] doors, int numberOfPasses, int passNumber)
        {
            for(int doorNumber = 0; doorNumber < doors.Length; doorNumber++)
            {
                switchDoor(doors, doorNumber, passNumber);
            }

            return doors;
        }

        private static int[] switchDoor(int[] doors, int doorNumber, int passNumber)
        {
            if( (doorNumber + 1) % passNumber == 0)
            {
                if (doors[doorNumber] == 0)
                {
                    doors[doorNumber] = 1;
                }else{
                    doors[doorNumber] = 0;
                }
            }

            int foo = 1;
            System.Console.WriteLine(foo);


            return doors;
        }
    }
}