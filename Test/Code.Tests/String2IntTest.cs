namespace Code.Tests
{
    using Xunit;

    public class String2IntTest
    {
        String2Int _atoi = new String2Int();

        [FactAttribute]
        public void TestEmptyStr()
        {
            Assert.Equal(0, _atoi.MyAtoi(""));
        }

        [FactAttribute]
        public void TestOneNum()
        {
            Assert.Equal(1, _atoi.MyAtoi("1"));
        }

        [FactAttribute]
        public void TestUnTrim()
        {
            Assert.Equal(54, _atoi.MyAtoi("  54  "));
        }

        [FactAttribute]
        public void TestNegativeSymbo()
        {
            Assert.Equal(-621, _atoi.MyAtoi("-621"));
        }

        [FactAttribute]
        public void TestPositiveSymbol()
        {
            Assert.Equal(635, _atoi.MyAtoi("+635"));
        }

        [FactAttribute]
        public void TestMultiSymbol()
        {
            Assert.Equal(0, _atoi.MyAtoi("-+77"));
        }

        [FactAttribute]
        public void TestComplexitySymbol()
        {
            Assert.Equal(-7809, _atoi.MyAtoi("  -7809 "));
        }

        [FactAttribute]
        public void TestComplexitySymbol2()
        {
            Assert.Equal(-7809, _atoi.MyAtoi("  -7809 0 "));
        }

        [FactAttribute]
        public void TestMaxValue()
        {
            Assert.Equal(2147483647, _atoi.MyAtoi("  +2147483649 "));
        }

        [FactAttribute]
        public void TestMinValue()
        {
            Assert.Equal(-2147483648, _atoi.MyAtoi("  -2147483658 "));
        }
        
        [FactAttribute]
        public void TestNegativeMaxValue()
        {
            Assert.Equal(-2147483647, _atoi.MyAtoi("  -2147483647 "));
        }

        [FactAttribute]
        public void TestWithOtherCharAsTail()
        {
            Assert.Equal(-12, _atoi.MyAtoi("  -0012a42"));
        }
    }
}