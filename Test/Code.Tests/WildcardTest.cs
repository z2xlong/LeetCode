using Xunit;

namespace Code.Tests
{
    public class WildCardTest
    {
        [FactAttribute]
        public void MatchTwice()
        {
            Assert.True(Wildcard.IsMatching("abefcdgiescdfimdf", "ab*cd?i*df"));
        }
    }
}