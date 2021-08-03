using BuildersChallenge.Domain.Service;
using Xunit;

namespace BuildersChallenge_Test
{
    public class ChallengerUnitTest
    {
        [Fact]
        public void Send_Text_ReturnBool()
        {
            var t1 = "ana";

            var valorAwait = true;

            var valueBool = new PalindromeService().IsPalindom(t1).IsPalindrom;

            Assert.Equal(valorAwait, valueBool);
        }
    }
}
