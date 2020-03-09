using Xunit;
using FluentAssertions;
using TDDDoors;

namespace TDDDoorsTests
{
    public class DoorsTests
    {
        [Fact]
        public void test10Doors1PassesReturnsArrayOfOnes()
        {
            int[] expectedDoors = new int[10] {1,1,1,1,1,1,1,1,1,1};
            int[] doors = new int[10];
            int numberOfPasses = 1;

            doors = Doors.checkDoors(doors, numberOfPasses);
            doors.Should().BeEquivalentTo(expectedDoors);
        }
        
        [Fact]
        public void test10Doors2PassesReturnsCorrectArray()
        {
            int[] expectedDoors = new int[10] {1,0,1,0,1,0,1,0,1,0};
            int[] doors = new int[10];
            int numberOfPasses = 2;

            doors = Doors.checkDoors(doors, numberOfPasses);
            doors.Should().BeEquivalentTo(expectedDoors);
        }

        [Fact]
        public void test10Doors3PassesReturnsCorrectArray()
        {
            int[] expectedDoors = new int[10] {1,0,0,0,1,1,1,0,0,0};
            int[] doors = new int[10];
            int numberOfPasses = 3;

            doors = Doors.checkDoors(doors, numberOfPasses);
            doors.Should().BeEquivalentTo(expectedDoors);
        }
    }
}