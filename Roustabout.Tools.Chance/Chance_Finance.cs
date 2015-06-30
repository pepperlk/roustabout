using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {

        public string CC()
        {
            //options = initOptions(options);

            //var type,
            //    number,
            //    to_generate;

            var type = this.Pick(data.cc_types);

            var number = type.prefix.ToList();
            var to_generate = type.length - type.prefix.Length - 1;

            // Generates n - 1 digits
           // number = number.concat(this.n(this.integer, to_generate, { min: 0, max: 9}));

            for (int i = 0; i < to_generate; i++)
            {
                number.Add(this.Integer(min: 0, max: 9).ToString()[0]);
            }

            // Generates the last digit according to Luhn algorithm
            //number.push(this.luhn_calculate(number.join("")));

            number.Add(this.Integer(min: 0, max: 9).ToString()[0]);

            return string.Join("", number);// number.join("");
        }



       

    }
}
