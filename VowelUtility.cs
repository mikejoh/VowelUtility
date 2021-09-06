using System;

namespace VowelUtility
{
    public static class Vowel
    {
        public static int Count(string sentence)
        {
            int total = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]  == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    total++;
                }
            }

            return total;
        }
    }
}
