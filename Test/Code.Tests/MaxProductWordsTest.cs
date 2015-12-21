namespace Code.Tests
{
    using Xunit;

    public class MaxProductWordsTest
    {
        MaxProductWords _algo = new MaxProductWords();

        [FactAttribute]
        public void ContinuousWords()
        {
            string[] array = new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" };
            Assert.Equal(16, _algo.MaxProduct(array));
        }

        [FactAttribute]
        public void UncontinuousWords()
        {
            string[] array = new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" };
            Assert.Equal(4, _algo.MaxProduct(array));
        }
		
        [FactAttribute]
		public void DuplicatedWords()
		{
            string[] array = new string[] { "a", "aa", "aaa", "aaaa" };
            Assert.Equal(0, _algo.MaxProduct(array));
		}
    }
}