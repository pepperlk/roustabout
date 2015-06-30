using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {
        public string AMPM()
        {
            return this.Bool() ? "am" : "pm";
            
        }


        public string DateString()
        {
            return Date().ToString();
        }

        public DateTime Date(int year = -1, DateTime? min = null, DateTime? max = null, bool american = true, bool isstring = false)
        {

            var date_string = "";
                DateTime? date = null;

            // If interval is specified we ignore preset
            //if (min.HasValue || max.HasValue)
           // {
            
                var minint = min.HasValue ? min.Value.Ticks : 1;
                // 100,000,000 days measured relative to midnight at the beginning of 01 January, 1970 UTC. http://es5.github.io/#x15.9.1.1
                var maxint = max.HasValue ? max.Value.Ticks : 8640000000000000;

                return new DateTime(this.Natural( min: minint, max: maxint ));
            //}
            //else
            //{
            //    var m = this.month({ raw: true});
            //    var daysInMonth = m.days;

            //    if (options && options.month)
            //    {
            //        // Mod 12 to allow months outside range of 0-11 (not encouraged, but also not prevented).
            //        daysInMonth = this.get('months')[((options.month % 12) + 12) % 12].days;
            //    }

            //    options = initOptions(options, {
            //        year: parseInt(this.year(), 10),
            //    // Necessary to subtract 1 because Date() 0-indexes month but not day or year
            //    // for some reason.
            //    month: m.numeric - 1,
            //    day: this.natural({ min: 1, max: daysInMonth}),
            //    hour: this.hour(),
            //    minute: this.minute(),
            //    second: this.second(),
            //    millisecond: this.millisecond(),
            //    american: true,
            //    string: false
            //    });

            //    date = new Date(options.year, options.month, options.day, options.hour, options.minute, options.second, options.millisecond);
            //}

            //if (options.american)
            //{
            //    // Adding 1 to the month is necessary because Date() 0-indexes
            //    // months but not day for some odd reason.
            //    date_string = (date.getMonth() + 1) + '/' + date.getDate() + '/' + date.getFullYear();
            //}
            //else
            //{
            //    date_string = date.getDate() + '/' + (date.getMonth() + 1) + '/' + date.getFullYear();
            //}

            //return options.string? date_string : date;

        }

        public long HammerTime()
        {
            return this.Date().Ticks;
        }

        public int Hour(bool twentyfour = false, int min = 1, int max = 12 )
        {
            if (twentyfour)
            {
                max = 24;
            }

            return this.Natural(min: min, max: max);
        }

        public int Minute(int min = 0, int max = 59)
        {
            return this.Natural(min: min, max: max);
        }

        public string Month(int min = 1, int max = 12, bool raw = false)
        {
            var pick = this.Natural(min: min, max: max);
            var month = data.months.FirstOrDefault(i => i.numeric == pick);
            return month.name;

        }

        public int Second(int min = 0, int max = 59)
        {
            return this.Natural(min: min, max: max);
        }

        public long Timestamp()
        {
            return this.Natural( min: 1, max: DateTime.Now.Ticks / 1000);
        }

        public int Year(int min = -1, int max = 59)
        {
            if(min == -1)
            {
                min = DateTime.Now.Year;
                max = min + 100;
            }

            return this.Natural(min: min, max: max);
        }

    }
}
