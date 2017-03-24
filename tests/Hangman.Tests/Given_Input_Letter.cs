namespace Hangman.Tests
{
    using Web.Hangman;
    using Xunit;

    public abstract class BaseHangman
    {
        protected readonly Hangman Subject = new Hangman(new MaskGenerator());

        protected string BecauseOf(char letter, string word, string mask)
        {
            return Subject.TestLetter(letter, word, mask);
        }
    }

    public class Given_Input_Letter : BaseHangman
    {
        [Fact]
        public void It_Should_Unmask_At_Correct_Position()
        {
            var result = BecauseOf('a', "callum", null);

            Assert.Equal("*a****", result);
        }
    }

    public class Given_Multiple_Input_Letters : BaseHangman
    {
        [Fact]
        public void It_Should_Unmask_At_Correct_Positions()
        {
            var result = BecauseOf('a', "callum", null);
            var secondResult = BecauseOf('c', "callum", result);

            Assert.Equal("ca****", secondResult);
        }
    }
}
