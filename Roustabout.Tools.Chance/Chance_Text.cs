using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {
        public string Syllable(int min = 2, int max = 3)
        {
            var length = this.Natural(min, max);
            var consonants = "bcdfghjklmnprstvwz"; // consonants except hard to speak ones
            var vowels = "aeiou"; // vowels
            var all = consonants + vowels; // all
            var text = "";
            var chr = ' ';

            for (var i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    // First character can be anything
                    chr = this.Character(pool: all);
                }
                else if (consonants.IndexOf(chr) == -1)
                {
                    // Last character was a vowel, now we want a consonant
                    chr = this.Character(pool: consonants);
                }
                else
                {
                    // Last character was a consonant, now we want a vowel
                    chr = this.Character(pool: vowels);
                }

                text += chr;
            }

            return text;

        }

        public string Sentence(int words = -1)
        {
            words = words > 0 ? words : this.Natural(min: 12, max: 18);
            var text = "";
            //var word_array = this.n( () => this.word, words);

            //text = word_array.join(' ');
            var word_array = new List<string>();

            for (int i = 0; i < words; i++)
            {
                word_array.Add(this.Word());
            }

            text = string.Join(" ", word_array);


            // Capitalize first letter of sentence, add period at end
            text = this.Capitalize(text) + '.';

            return text;
        }

        public string Word(int syllables = -1, int length = -1)
        {
            syllables = syllables > 0 ? syllables : this.Natural(min: 1, max: 3);
            var text = "";

            if (length > 0)
            {
                // Either bound word by length
                do
                {
                    text += this.Syllable();
                } while (text.Length < length);
                text = text.Substring(0, length);
            }
            else
            {
                // Or by number of syllables
                for (var i = 0; i < syllables; i++)
                {
                    text += this.Syllable();
                }
            }
            return text;
        }

        public string Paragraph(int sentences = -1)
        {
            sentences = sentences > 0 ? sentences : this.Natural(min: 3, max: 7);
            var sentence_array = new List<string>();
            for (int i = 0; i < sentences; i++)
            {
                sentence_array.Add(this.Sentence());
            }


            return string.Join(" ", sentence_array);
        }

     
    }
}
