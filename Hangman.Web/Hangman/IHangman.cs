namespace Hangman.Web.Hangman
{
    public interface IHangman
    {
        string TestLetter(char input, string word, string mask);
    }
}
