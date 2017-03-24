namespace Hangman.Web
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public static class ObjectExtensions
    {
        public static string Repeat(this string letter, int length)
        {
            var builder = new StringBuilder(length);
            Enumerable.Range(1, length).ToList().ForEach(x => builder.Append(letter));
            return builder.ToString();
        }

        public static string JoinToWord(this IEnumerable<char> chars)
        {
            return string.Join("", chars);
        }
    }
}
