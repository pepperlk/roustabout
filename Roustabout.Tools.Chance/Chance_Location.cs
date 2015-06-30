using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {

        public string Address()
        {
            return this.Natural(min: 5, max: 2000) + " " + this.Street();
        }


        public double Altitude()
        {
            return this.Floating(min: 0, max: 8848, _fixed: 5);
        }


        public string AreaCode(bool parens = true)
        {
            var areacode = this.Natural(min: 2, max: 9).ToString() + this.Natural(min: 0, max: 8).ToString() + this.Natural(min: 0, max: 9).ToString();

            return parens ? '(' + areacode + ')' : areacode;
        }


        public string City()
        {
            return this.Capitalize(this.Word(syllables: 3));
        }

        public string Coordinates(int _fixed = 5, double latmin = -90, double latmax = 90, double lngmin = -180, double lngmax = 180)
        {
            return this.Latitude(_fixed: _fixed, min: latmin, max: latmax) + ", " + this.Longitude(_fixed: _fixed, min: latmin, max: latmax);
        }

        public double Longitude(int _fixed = 5, double min = -180, double max = 180)
        {
            return this.Floating(min: min, max: max, _fixed: _fixed);
        }

        public double Latitude(int _fixed = 5, double min = -90, double max = 90)
        {
            return this.Floating(min: min, max: max, _fixed: _fixed);
        }

        public string Country(bool full = false)
        {

            var c = this.Pick(data.Countries);
            return full ? c.Name : c.Abbreviation;
        }

        public double Depth(int _fixed = 5, double min = -2550, double max = 0)
        {
            return this.Floating(min: min, max: max, _fixed: _fixed);
        }

        public string GeoHash(int length = 7)
        {
            return this.String(length: length, pool: "0123456789bcdefghjkmnpqrstuvwxyz");
        }

        public string GeoJson()
        {
            return this.Latitude() + ", " + this.Longitude() + ", " + this.Altitude();
        }

        public string Phone(bool formatted = true, string country = "us", bool mobile = false)
        {
            var phone = "";
            var numPick = "";
            switch (country)
            {
                case "fr":
                    if (!mobile)
                    {
                        numPick = this.Pick(
                            // Valid zone and département codes.
                            "01" + this.Pick("30", "34", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "53", "55", "56", "58", "60", "64", "69", "70", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83") + this.String(pool: "0123456789", length: 6),
                        "02" + this.Pick("14", "18", "22", "23", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "40", "41", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "56", "57", "61", "62", "69", "72", "76", "77", "78", "85", "90", "96", "97", "98", "99") + this.String(pool: "0123456789", length: 6),
                        "03" + this.Pick("10", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "39", "44", "45", "51", "52", "54", "55", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90") + this.String(pool: "0123456789", length: 6),
                        "04" + this.Pick("11", "13", "15", "20", "22", "26", "27", "30", "32", "34", "37", "42", "43", "44", "50", "56", "57", "63", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "88", "89", "90", "91", "92", "93", "94", "95", "97", "98") + this.String(pool: "0123456789", length: 6),
                        "05" + this.Pick("08", "16", "17", "19", "24", "31", "32", "33", "34", "35", "40", "45", "46", "47", "49", "53", "55", "56", "57", "58", "59", "61", "62", "63", "64", "65", "67", "79", "81", "82", "86", "87", "90", "94") + this.String(pool: "0123456789", length: 6),
                        "09" + this.String(pool: "0123456789", length: 8)
                    );
                        phone = formatted ? string.Join(" ", numPick) : numPick;
                    }
                    else
                    {
                        numPick = this.Pick("06", "07") + this.String(pool: "0123456789", length: 8);
                        phone = formatted ? string.Join(" ", numPick) : numPick;
                    }
                    break;
                case "uk":
                    //if (!mobile)
                    //{
                    //    numPick = this.pick([
                    //        //valid area codes of major cities/counties followed by random numbers in required format.
                    //    { area: "01" + this.character({ pool: "234569" }) +"1 ", sections: [3, 4] },
                    //    { area: "020 " + this.character({ pool: "378" }), sections: [3, 4] },
                    //    { area: "023 " + this.character({ pool: "89" }), sections: [3, 4] },
                    //    { area: "024 7", sections: [3, 4] },
                    //    { area: "028 " + this.pick(["25", "28", "37", "71", "82", "90", "92", "95"]), sections: [2, 4] },
                    //    { area: "012" + this.pick(["04", "08", "54", "76", "97", "98"]) +" ", sections: [5] },
                    //    { area: "013" + this.pick(["63", "64", "84", "86"]) +" ", sections: [5] },
                    //    { area: "014" + this.pick(["04", "20", "60", "61", "80", "88"]) +" ", sections: [5] },
                    //    { area: "015" + this.pick(["24", "27", "62", "66"]) +" ", sections: [5] },
                    //    { area: "016" + this.pick(["06", "29", "35", "47", "59", "95"]) +" ", sections: [5] },
                    //    { area: "017" + this.pick(["26", "44", "50", "68"]) +" ", sections: [5] },
                    //    { area: "018" + this.pick(["27", "37", "84", "97"]) +" ", sections: [5] },
                    //    { area: "019" + this.pick(["00", "05", "35", "46", "49", "63", "95"]) +" ", sections: [5] }
                    //]);
                    //    phone = options.formatted ? ukNum(numPick) : ukNum(numPick).replace(" ", "", "g");
                    //}
                    //else
                    //{
                    //    numPick = this.pick([
                    //      { area: "07" + this.pick(["4", "5", "7", "8", "9"]), sections: [2, 6] },
                    //    { area: "07624 ", sections: [6] }
                    //]);
                    //    phone = options.formatted ? ukNum(numPick) : ukNum(numPick).replace(" ", "");
                    //}
                    break;
                case "us":
                    var areacode = this.AreaCode().ToString();
                    var exchange = this.Natural(min: 2, max: 9).ToString() +
this.Natural(min: 0, max: 9).ToString() +
this.Natural(min: 0, max: 9).ToString();
                    var subscriber = this.Natural(min: 1000, max: 9999).ToString(); // this could be random [0-9]{4}
                    phone = formatted ? areacode + " " + exchange + "-" + subscriber : areacode + exchange + subscriber;


                    break;
                default:
                    break;
            }
            return phone;

        }


        public string Postal()
        {
            var pd = this.Character(pool: "XVTSRPNKLMHJGECBA");
            // Forward Sortation Area (FSA)
            var fsa = pd + this.Natural(max: 9) + this.Character(casing: "upper");
            // Local Delivery Unut (LDU)
            var ldu = this.Natural(max: 9) + this.Character(casing: "upper") + this.Natural(max: 9);

            return fsa + " " + ldu;
        }


        public string Province(bool full = false)
        {
            return full ?
            this.Pick(data.Provinces).Name :
            this.Pick(data.Provinces).Abbreviation;
        }


        public string State(bool full = false)
        {
            var state = this.Pick(data.us_states_and_dc);
            return full ? state.Name : state.Abbreviation;
        }

        public string Street(bool short_suffix = true)
        {
            var street = this.Word( syllables: 2);
            street = this.Capitalize(street);
            street += " ";
            street += short_suffix ?
                this.StreetSuffix().Abbreviation :
                this.StreetSuffix().Name;
            return street;
        }

        public NameAbbreviation StreetSuffix()
        {
            return this.Pick(data.street_suffixes);
        }

        public string Zip(bool plusfour = false)
        {
            //var zip = this.n(this.natural, 5, { max: 9});

            var zip = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                zip.Add(this.Natural(max: 9).ToString());
            }


            if (plusfour)
            {
                zip.Add("-");
                for (int i = 0; i < 4; i++)
                {
                    zip.Add(this.Natural(max: 9).ToString());
                }
            }

            return string.Join("", zip);
        }
    }
}
