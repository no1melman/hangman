namespace Hangman.Web.Hangman
{
    public interface IMaskGenerator
    {
        string Mask(string word);
    }
}
