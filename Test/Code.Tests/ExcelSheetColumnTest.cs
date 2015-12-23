namespace Code.Tests
{
    using Xunit;

    public class ExcelSheetColumnTest
    {
        ExcelSheetColumn _excel = new ExcelSheetColumn();

        [FactAttribute]
        public void TestEmptyTitle()
        {
            Assert.Equal(0, _excel.TitleToNumber(""));
        }

        [FactAttribute]
        public void TestSingleCharTitle()
        {
            Assert.Equal(1, _excel.TitleToNumber("A"));
        }

        [FactAttribute]
        public void TestTitleZ()
        {
            Assert.Equal(26, _excel.TitleToNumber("Z"));
        }

        [FactAttribute]
        public void TestTwoCharTitle()
        {
            Assert.Equal(28, _excel.TitleToNumber("AB"));
        }

        [FactAttribute]
        public void TestTwoCharTitle2()
        {
            Assert.Equal(54, _excel.TitleToNumber("BB"));
        }

        [FactAttribute]
        public void TestThreeCharTitile()
        {
            Assert.Equal(703, _excel.TitleToNumber("AAA"));
        }

        [FactAttribute]
        public void TestTitleWithSpace()
        {
            Assert.Equal(27, _excel.TitleToNumber(" A A "));
        }

        [FactAttribute]
        public void TestTitleWithInvalidChar()
        {
            Assert.Equal(0, _excel.TitleToNumber("A@"));
        }

        [FactAttribute]
        public void TestMixLetterCase()
        {
            Assert.Equal(28, _excel.TitleToNumber("Ab"));
        }


    }
}