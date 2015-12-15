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
            Assert.Matches("One Hundred Twenty Three", _trans.NumberToWords(123));
        }

        [FactAttribute]
        public void ThousandNumber()
        {
            Assert.Matches("Twelve Thousand Three Hundred Forty Five", _trans.NumberToWords(123));
        }

        [FactAttribute]
        public void MillionNumber()
        {
            Assert.Matches("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven", _trans.NumberToWords(1234567));
        }

        [FactAttribute]
        public void NoneNegative()
        {
            Assert.Matches("", _trans.NumberToWords(1234567));
        }

        [FactAttribute]
        public void OneWordNumber()
        {
            Assert.Matches("One Thousand", _trans.NumberToWords(1000));
        }

        [FactAttribute]
        public void MiddleZeroNumber()
        {
            Assert.Matches("One Thousand and One", _trans.NumberToWords(1001));
        }
    }
}