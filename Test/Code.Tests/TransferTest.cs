using System;
using Xunit;

namespace Code.Tests
{
    public class TransferTest
    {
        Transfer _trans = new Transfer();

        [FactAttribute]
        public void HundredNumber()
        {
            Assert.Equal("One Hundred Twenty Three", _trans.NumberToWords(123));
        }

        [FactAttribute]
        public void ThousandNumber()
        {
            Assert.Equal("Twelve Thousand Three Hundred Forty Five", _trans.NumberToWords(12345));
        }

        [FactAttribute]
        public void MillionNumber()
        {
            Assert.Equal("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven", _trans.NumberToWords(1234567));
        }

        [FactAttribute]
        public void NoneNegative()
        {
            Assert.Equal("", _trans.NumberToWords(1234567));
        }

        [FactAttribute]
        public void OneWordNumber()
        {
            Assert.Equal("One Thousand", _trans.NumberToWords(1000));
        }

        [FactAttribute]
        public void MiddleZeroNumber()
        {
            Assert.Equal("One Thousand and One", _trans.NumberToWords(1001));
        }

        [FactAttribute]
        public void CanModTen()
        {
            Assert.Equal("One Hundred Million", _trans.NumberToWords(100000000));
        }
    }
}