using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
    static class Extension
    {
        public static bool CustomContain(this string str, string word)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (str[i] == word[j])
                    {
                        result.Append(str[i]);
                    }

                }
            }
            if (result.Length != word.Length)
            {
                //burada ilişdim
            }
            return false;
        }
    }
}
