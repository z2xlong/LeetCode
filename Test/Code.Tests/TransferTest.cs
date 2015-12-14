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
            Assert.Equal(_trans.NumberToWords(123), "One Hundred Twenty Three");
        }

        [FactAttribute]
        public void ThousandNumber()
        {
            Assert.Equal(_trans.NumberToWords(12345), "Twelve Thousand Three Hundred Forty Five");
        }

        [FactAttribute]
        public void MillionNumber()
        {
            Assert.Equal(_trans.NumberToWords(1234567), "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven");
        }

        [FactAttribute]
        public void NoneNegative()
        {
            Assert.Equal(_trans.NumberToWords(-123),"");
        }
    }
}