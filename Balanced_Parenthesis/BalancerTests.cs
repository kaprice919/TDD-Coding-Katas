using Xunit;
using FluentAssertions;
using BalancedParenthesis;

namespace BalancedParenthesisTests
{
    public class BalancerTests
    {

        [Fact]
        public void TestClosedParenthesisBeforeOpenParenthesisReturnsFalse()
        {
            string testString = "(";
            Balancer.isBalanced(testString).Should().BeFalse();

            testString = "{{)(}}";
            Balancer.isBalanced(testString).Should().BeFalse();

            testString = "({)}";
            Balancer.isBalanced(testString).Should().BeFalse();
        }
        

        [Fact]
        public void TestBalancedStringReturnsTrue()
        {
            string testString = "()";
            Balancer.isBalanced(testString).Should().BeTrue();

            testString = "[({})]";
            Balancer.isBalanced(testString).Should().BeTrue();

            testString = "{}([])";
            Balancer.isBalanced(testString).Should().BeTrue();

            testString = "{()}[[{}]]";
            Balancer.isBalanced(testString).Should().BeTrue();
        }
    }
}
