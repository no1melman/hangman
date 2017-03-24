namespace Hangman.Tests
{
    using Xunit;
    using Web.Hangman;

    public class Given_Word
    {
        protected MaskGenerator Subject = new MaskGenerator();

        [Theory]
        [InlineData("******", "callum")]
        [InlineData("***", "hey")]
        public void It_Should_Generate_Correct_Word(string expected, string word)
        {
            var result = Subject.Mask(word);

            Assert.Equal(expected, result);
        }
    }
}
