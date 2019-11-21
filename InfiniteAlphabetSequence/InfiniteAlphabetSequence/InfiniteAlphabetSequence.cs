using System.Collections.Generic;
using System.Linq;

namespace InfiniteAlphabetSequence
{
    public class InfiniteAlphabetSequence
    {
        private static char[] capitalAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public static string Generate(string current)
        {
            var capitalLetters = true;

            if (string.IsNullOrEmpty(current))
            {
                return capitalLetters ? capitalAlphabet[0].ToString() : alphabet[0].ToString();
            }

            capitalLetters = char.IsUpper(current[0]);

            return Base26Sequence(capitalLetters).SkipWhile(x => x != current).Skip(1).First();
        }

        private static IEnumerable<string> Base26Sequence(bool capitalLetters)
        {
            long i = 0L;
            while (true)
            {
                yield return Base26Encode(i++, capitalLetters);
            }
        }

        private static string Base26Encode(long value, bool capitalLetters)
        {
            string returnValue = null;

            do
            {
                returnValue = (capitalLetters ? capitalAlphabet[value % 26] : alphabet[value % 26]) + returnValue;
                value /= 26;
            } while (value-- != 0);

            return returnValue;
        }
    }
}