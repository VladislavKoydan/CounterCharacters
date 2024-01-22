using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharacters
{
    public class CharacterCounter
    {
        private string _input;


        public CharacterCounter(string input)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(input);

            _input = input;

        }
        public Dictionary<char, int> StringCounter()
        {

            Dictionary<char, int> dict = _input.ToLower()
                                    .Where(c => char.IsLetter(c))
                                    .GroupBy(c => c)
                                    .Select(gr => (Letter: gr.Key, Count: gr.Count()))
                                    .OrderByDescending(c => c.Count)
                                    .ToDictionary(p => p.Letter, p => p.Count);


            return dict;
        }
    }
}
