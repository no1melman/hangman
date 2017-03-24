namespace Hangman.Web.Hangman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Hangman : IHangman
    {
        private readonly IMaskGenerator maskGenerator;

        public Hangman(IMaskGenerator maskGenerator)
        {
            this.maskGenerator = maskGenerator;
        }


        public string TestLetter(char input, string word, string mask)
        {
            if (string.IsNullOrWhiteSpace(mask))
            {
                mask = this.maskGenerator.Mask(word);
            }

            var dict = word
                        .ToCharArray()
                        .Select((m, i) => new { letter = m, index =  i })
                        .Aggregate(new Dictionary<char, List<int>>(), (f, c) => {

                            if (!f.ContainsKey(c.letter))
                            {
                                f.Add(c.letter, new List<int>());
                            }

                            f[c.letter].Add(c.index);

                            return f;
                        });
        
            Console.WriteLine(dict);

            return RevealLetter(input, mask, dict);
        }

        private string RevealLetter(char input, string mask, Dictionary<char, List<int>> dict)
        {
            var ind = dict[input];

            mask = ind.Aggregate(mask, (f, i) => ChangeCharacter(f, i, input));

            return mask;
        }

        private string ChangeCharacter(string mask, int ind, char input)
        {
            char[] maskChars = mask.ToCharArray();
            return maskChars.Select((s, i) => i == ind ? input : maskChars[i]).JoinToWord();
        }
    }
}
