namespace Hangman.Web.Hangman
{
    public class MaskGenerator : IMaskGenerator
    {
        public string Mask(string word)
        {
            return "*".Repeat(word.Length);
        }
    }
}
