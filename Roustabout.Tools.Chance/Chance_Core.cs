using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {

        private char Character(string casing = "", string pool = "", string alpha = "", string symbols = "!@#$%^&*()[]")
        {


            var letters = "";


            if (casing == "lower")
            {
                letters = CHARS_LOWER;
            }
            else if (casing == "upper")
            {
                letters = CHARS_UPPER;
            }
            else
            {
                letters = CHARS_LOWER + CHARS_UPPER;
            }

            if (!string.IsNullOrEmpty(pool))
            {
                //pool = pool;
            }
            else if (!string.IsNullOrEmpty(alpha))
            {
                pool = letters;
            }
            else if (!string.IsNullOrEmpty(symbols))
            {
                pool = symbols;
            }
            else
            {
                pool = letters + NUMBERS + symbols;
            }


            return pool.ElementAt(this.Natural(max: (pool.Count() - 1)));
        }

        //public int Integer(int min = MIN_INT, int max = MAX_INT)
        //{
        //    if (min > max)
        //    {
        //        throw new ArgumentException("Chance: Min cannot be greater than Max.");
        //    }
        //    return new Random().Next(min, max);
        //    //return (int)Math.Floor((decimal)this.random() * (max - min + 1) + min);
        //}

        public bool Bool(int likelihood = 50)
        {
            if (likelihood < 0 || likelihood > 100)
            {
                throw new ArgumentException("Chance: Likelihood accepts values from 0 to 100.");
            }


            return this.Random() * 100 < likelihood;

        }


        public float Floating(double? min = null, double? max = null,  int _fixed = 4)
        {
            //var num = 0;
            var d_fixed = Math.Pow(10, _fixed);


             max = max.HasValue ? max : MAX_INT / d_fixed;
             min = min.HasValue ? min : -max;
            var num = this.Integer( min: (int)Math.Floor( min.GetValueOrDefault() * d_fixed), max: (int)Math.Floor(max.GetValueOrDefault() * d_fixed));


            var num_fixed =  Math.Round( (num / d_fixed), _fixed);

            return (float)num_fixed;

        }

        public double Random()
        {
            return new MersenneTwister().genrand_Int32() * (1.0 / 4294967296.0);

        }


        public T Pick<T>(params T[] arr)
        {
            return Pick(arr, 1).FirstOrDefault();
        }

        public IEnumerable<T> Pick<T>(IEnumerable<T> arr, int count = 1)
        {
            if (arr == null || arr.Count() == 0)
            {
                throw new ArgumentException("Chance: Cannot pick() from an empty array");
            }
            if (count == 1)
            {
                return new T[] { arr.ElementAt(this.Natural(max: arr.Count() - 1)) };
            }
            else
            {
                return this.Shuffle(arr).Take(count);
            }
        }

        public IEnumerable<T> Shuffle<T>(IEnumerable<T> arr)
        {
            var old_array = new List<T>(arr);
            var new_array = new List<T>(arr);
            var j = 0;
            var length = old_array.Count();

            for (var i = 0; i < length; i++)
            {
                // Pick a random index from the array
                j = this.Natural(max: old_array.Count() - 1);
                // Add it to the new array
                new_array[i] = old_array.ElementAt(j);
                // Remove that element from the original array
                old_array.RemoveAt(j);
                //old_array.splice(j, 1);
            }

            return new_array;
        }

        public int Natural(long min = 0, long max = MAX_INT)
        {

            if (min < 0)
            {
                throw new ArgumentException("Chance: Min cannot be less than zero.");
            }


            return this.Integer(min, max);
        }

        public int Integer(long min = MIN_INT, long max = MAX_INT)
        {
            if (min > max)
            {
                throw new ArgumentException("Chance: Min cannot be greater than Max.");
            }

            // i know there is abtter way in .net but this is a port
            return (int)Math.Floor((decimal)this.Random() * (max - min + 1) + min);
            
        }



        public string String(int length, string pool = "")
        {
          //  var length = options.length,
          //text = this.n(this.character, length, options);


            var text = new List<char>();
            for (int i = 0; i < length; i++)
            {
                text.Add(this.Character(pool: pool));
            }


            return string.Join("", text);
        }


    }
}
