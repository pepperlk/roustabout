using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {

        public int Age(AgeRange range = AgeRange.Default)
        {
            switch (range)
            {
                case AgeRange.Child:
                    return this.Natural(min: 1, max: 12);

                case AgeRange.Teen:
                    return this.Natural(min: 13, max: 19);

                case AgeRange.Adult:
                    return this.Natural(min: 18, max: 65);

                case AgeRange.Senior:
                    return this.Natural(min: 65, max: 100);

                case AgeRange.All:
                    return this.Natural(min: 1, max: 100);

                case AgeRange.Default:
                    return this.Natural(min: 18, max: 65);

                default:
                    return this.Natural(min: 18, max: 65);

            }
        }


        public object Birthday(int year = 0, AgeRange range = AgeRange.Default)
        {
            year = year > 0 ? year : DateTime.Now.Year - this.Age(range);


            return this.Date(year: year);
        }

        public string Gender()
        {
            return this.Pick(new string[] { "Male", "Female" });
        }

        public string First(Gender gen)
        {
            switch (gen)
            {
                case Chance.Gender.Male:
                    return Pick(data.FirstName.Male);

                case Chance.Gender.Female:
                    return Pick(data.FirstName.Female);
                default:
                    return "";
                    ;
            }
        }

        public string First()
        {
            return First(Pick((Gender[])Enum.GetValues(typeof(Gender))));
        }

        public string Last()
        {
            return Pick(data.LastNames);
        }

        public string Name()
        {
            var first = this.First();
            var last = this.Last();
            var name = "";

            //if (options.middle)
            //{
            //    name = first + ' ' + this.first(options) + ' ' + last;
            //}
            //else if (options.middle_initial)
            //{
            //    name = first + ' ' + this.character({ alpha: true, casing: 'upper'}) +'. ' + last;
            //}
            //else
            //{
            name = first + ' ' + last;
            //}

            //if (options.prefix)
            //{
            //    name = this.prefix(options) + ' ' + name;
            //}

            //if (options.suffix)
            //{
            //    name = name + ' ' + this.suffix(options);
            //}

            return name;
        }


        public string CPF()
        {
            //var n = this.n(this.natural, 9, { max: 9 });

            var n = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                n.Add(this.Natural(max: 9));
            }


            var d1 = n[8] * 2 + n[7] * 3 + n[6] * 4 + n[5] * 5 + n[4] * 6 + n[3] * 7 + n[2] * 8 + n[1] * 9 + n[0] * 10;
            d1 = 11 - (d1 % 11);
            if (d1 >= 10)
            {
                d1 = 0;
            }
            var d2 = d1 * 2 + n[8] * 3 + n[7] * 4 + n[6] * 5 + n[5] * 6 + n[4] * 7 + n[3] * 8 + n[2] * 9 + n[1] * 10 + n[0] * 11;
            d2 = 11 - (d2 % 11);
            if (d2 >= 10)
            {
                d2 = 0;
            }
            return "" + n[0] + n[1] + n[2] + '.' + n[3] + n[4] + n[5] + '.' + n[6] + n[7] + n[8] + '-' + d1 + d2;
        }

        //Chance.prototype.mrz = function(options)
        //{
        //    var checkDigit = function(input) {
        //        var alpha = "<ABCDEFGHIJKLMNOPQRSTUVWXYXZ".split(''),
        //            multipliers = [7, 3, 1],
        //            runningTotal = 0;

        //        if (typeof input !== 'string')
        //        {
        //            input = input.toString();
        //        }

        //        input.split('').forEach(function(character, idx) {
        //            var pos = alpha.indexOf(character);

        //            if (pos !== -1)
        //            {
        //                character = pos === 0 ? 0 : pos + 9;
        //            }
        //            else
        //            {
        //                character = parseInt(character, 10);
        //            }
        //            character *= multipliers[idx % multipliers.length];
        //            runningTotal += character;
        //        });
        //        return runningTotal % 10;
        //    };
        //    var generate = function(opts) {
        //        var pad = function(length) {
        //            return new Array(length + 1).join('<');
        //        };
        //        var number = ['P<',
        //                       opts.issuer,
        //                       opts.last.toUpperCase(),
        //                       '<<',
        //                       opts.first.toUpperCase(),
        //                       pad(39 - (opts.last.length + opts.first.length + 2)),
        //                       opts.passportNumber,
        //                       checkDigit(opts.passportNumber),
        //                       opts.nationality,
        //                       opts.dob,
        //                       checkDigit(opts.dob),
        //                       opts.gender,
        //                       opts.expiry,
        //                       checkDigit(opts.expiry),
        //                       pad(14),
        //                       checkDigit(pad(14))].join('');

        //        return number +
        //            (checkDigit(number.substr(44, 10) +
        //                        number.substr(57, 7) +
        //                        number.substr(65, 7)));
        //    };

        //    var that = this;

        //    options = initOptions(options, {
        //        first: this.first(),
        //    last: this.last(),
        //    passportNumber: this.integer({ min: 100000000, max: 999999999}),
        //    dob: (function() {
        //            var date = that.birthday({ type: 'adult'});
        //            return [date.getFullYear().toString().substr(2),
        //                    that.pad(date.getMonth() + 1, 2),
        //                    that.pad(date.getDate(), 2)].join('');
        //        } ()),
        //    expiry: (function() {
        //            var date = new Date();
        //            return [(date.getFullYear() + 5).toString().substr(2),
        //                    that.pad(date.getMonth() + 1, 2),
        //                    that.pad(date.getDate(), 2)].join('');
        //        } ()),
        //    gender: this.gender() === 'Female' ? 'F' : 'M',
        //    issuer: 'GBR',
        //    nationality:
        //        'GBR'
        //    });
        //    return generate(options);
        //};


        public IEnumerable<NameAbbreviation> Name_Prefixes(Gender gender = Chance.Gender.All)
        {
            var prefixes = new List<NameAbbreviation>() { new NameAbbreviation { Name = "Doctor", Abbreviation = "Dr." } };

            if (gender == Chance.Gender.Male || gender == Chance.Gender.All)
            {
                prefixes.Add(new NameAbbreviation { Name = "Mister", Abbreviation = "Mr." });
            }

            if (gender == Chance.Gender.Female || gender == Chance.Gender.All)
            {
                prefixes.Add(new NameAbbreviation { Name = "Miss", Abbreviation = "Miss" });
                prefixes.Add(new NameAbbreviation { Name = "Misses", Abbreviation = "Mrs." });
            }



            return prefixes;

        }

        public string Prefix(bool full = false, Gender gender = Chance.Gender.All)
        {
            return NamePrefix(full, gender);
        }

        public string NamePrefix(bool full = false, Gender gender = Chance.Gender.All)
        {
            return full ? this.Pick(this.Name_Prefixes(gender)).FirstOrDefault().Name : this.Pick(this.Name_Prefixes(gender)).FirstOrDefault().Abbreviation;
        }


        public string SSN(bool ssnFour = false, bool dashes = true)
        {
            var ssn_pool = "1234567890";
            var ssn = "";
            var dash = dashes ? "-" : "";

            if (ssnFour)
            {
                ssn = this.String(pool: ssn_pool, length: 3) + dash + this.String(pool: ssn_pool, length: 2) + dash + this.String(pool: ssn_pool, length: 4);
            }
            else
            {
                ssn = this.String(pool: ssn_pool, length: 4);
            }
            return ssn;
        }

        public IEnumerable<NameAbbreviation> NameSuffixes()
        {
            var suffixes = new NameAbbreviation[] {
             new NameAbbreviation{ Name = "Doctor of Osteopathic Medicine", Abbreviation = "D.O." },
             new NameAbbreviation{ Name = "Doctor of Philosophy", Abbreviation = "Ph.D." },
             new NameAbbreviation{ Name = "Esquire", Abbreviation = "Esq." },
             new NameAbbreviation{ Name = "Junior", Abbreviation = "Jr." },
             new NameAbbreviation{ Name = "Juris Doctor", Abbreviation = "J.D." },
             new NameAbbreviation{ Name = "Master of Arts", Abbreviation = "M.A." },
             new NameAbbreviation{ Name = "Master of Business Administration", Abbreviation = "M.B.A." },
             new NameAbbreviation{ Name = "Master of Science", Abbreviation = "M.S." },
             new NameAbbreviation{ Name = "Medical Doctor", Abbreviation = "M.D." },
             new NameAbbreviation{ Name = "Senior", Abbreviation = "Sr." },
             new NameAbbreviation{ Name = "The Third", Abbreviation = "III" },
             new NameAbbreviation{ Name = "The Fourth", Abbreviation = "IV" },
             new NameAbbreviation{ Name = "Bachelor of Engineering", Abbreviation = "B.E" },
             new NameAbbreviation { Name = "Bachelor of Technology", Abbreviation = "B.TECH" }
        };
            return suffixes;
        }


        public string Suffix(bool full = false)
        {
            return NamePrefix(full);
        }

        public string NameSuffix(bool full = false)
        {
            return full ? this.Pick(NameSuffixes()).FirstOrDefault().Name : this.Pick(NameSuffixes()).FirstOrDefault().Abbreviation;
        }


    }
}
