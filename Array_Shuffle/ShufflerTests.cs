using Xunit;
using FluentAssertions;
using ArrayShuffle;

namespace ArrayShuffleTests
{
    public class ShufflerTests
    {
        [Fact]
        public void TestShufflingArrayOf6ReturnsAnEquivalentArrayButNotEqual()
        {
            var unshuffledArray = new int[10]{
                1,2,3,4,5,6,7,8,9,10
            };

            var shuffledArray = Shuffler.ShuffleArray(new int[10]{
                1,2,3,4,5,6,7,8,9,10
            });
            shuffledArray.Should().BeSubsetOf(unshuffledArray).And.NotBeInAscendingOrder();
        }
    }
}
