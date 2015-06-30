using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {

        public string Avatar()
        {
            var url = "";
            var URL_BASE = "//www.gravatar.com/avatar/";
            var PROTOCOLS = new
            {
                http = "http",
                https =
            "https"
            };
            var FILE_TYPES = new
            {
                bmp = "bmp",
                gif = "gif",
                jpg = "jpg",
                png = "png"
            };
            var FALLBACKS = new
            {
                _404 = "404", // Return 404 if not found
                mm = "mm", // Mystery man
                identicon = "identicon", // Geometric pattern based on hash
                monsterid = "monsterid", // A generated monster icon
                wavatar = "wavatar", // A generated face
                retro = "retro", // 8-bit icon
                blank = "blank" // A transparent png
            };
            var RATINGS = new
            {
                g = "g",
                pg = "pg",
                r = "r",
                x = "x"
            };
            //var opts = new {
            //    protocol= "",
            //    email= "",
            //    fileExtension= "",
            //    size= "",
            //    fallback= "",
            //    rating = ""
            //};

            //        if (true) {
            //            // Set to a random email
            //            opts.email = this.Email();

            //        }
            //        else if (typeof options === 'string') {
            //            opts.email = options;
            //            options = {};
            //        }
            //        else if (typeof options !== 'object') {
            //            return null;
            //        }
            //        else if (options.constructor === 'Array') {
            //            return null;
            //        }

            //        opts = initOptions(options, opts);

            //        if (!opts.email) {
            //            // Set to a random email
            //            opts.email = this.email();
            //}

            // Safe checking for params
            //opts.protocol = PROTOCOLS[opts.protocol] ? opts.protocol + ':' : '';
            //opts.size = parseInt(opts.size, 0) ? opts.size : '';
            //opts.rating = RATINGS[opts.rating] ? opts.rating : '';
            //opts.fallback = FALLBACKS[opts.fallback] ? opts.fallback : '';
            //opts.fileExtension = FILE_TYPES[opts.fileExtension] ? opts.fileExtension : '';

            url =
                        PROTOCOLS.http + ":" +
                        URL_BASE +
                        this.MD5(this.Email()) +
                        ('.' + FILE_TYPES.png) +
                        //(opts.size || opts.rating || opts.fallback ? '?' : '') +
                        ("&s=200") +
                        ("&r=" + RATINGS.pg) +
                        ("&d=" + FALLBACKS.blank)
                        ;

            return url;
        }


        public string Email()
        {
            return this.Word() + '@' + this.Domain();
        }

        public string Domain()
        {
            return this.Word() + '.' + this.Tld();
        }

        public string Tld()
        {
            return this.Pick(new string[] { "com", "org", "edu", "gov", "co.uk", "net", "io" });
        }

        public string Gray(string value, string delimiter = "")
        {
            return string.Join(delimiter, (new string[] { value, value, value })); //.join(delimiter || '');
        }

        public string Color(bool isGrayscale = false)
        {


            // options = initOptions(options, {
            var format = this.Pick(new string[] { "hex", "shorthex", "rgb", "rgba", "0x" });
            //grayscale: false,
            //casing:
            //    'lower'
            // });

            //var isGrayscale = options.grayscale;
            var colorValue = "";

            if (format == "hex")
            {
                colorValue = '#' + (isGrayscale ? Gray(this.Hash(length: 2)) : this.Hash(length: 6));

            }
            else if (format == "shorthex")
            {
                colorValue = '#' + (isGrayscale ? Gray(this.Hash(length: 1)) : this.Hash(length: 3));

            }
            else if (format == "rgb")
            {
                if (isGrayscale)
                {
                    colorValue = "rgb(" + Gray(this.Natural(max: 255).ToString(), ",") + ")";
                }
                else
                {
                    colorValue = "rgb(" + this.Natural(max: 255) + "," + this.Natural(max: 255) + "," + this.Natural(max: 255) + ")";
                }
            }
            else if (format == "rgba")
            {
                if (isGrayscale)
                {
                    colorValue = "rgba(" + Gray(this.Natural(max: 255).ToString(), ",") + "," + this.Floating(min: 0, max: 1) + ")";
                }
                else
                {
                    colorValue = "rgba(" + this.Natural(max: 255) + "," + this.Natural(max: 255) + "," + this.Natural(max: 255) + "," + this.Floating(min: 0, max: 1) + ")";
                }
            }
            else if (format == "0x")
            {
                colorValue = "0x" + (isGrayscale ? Gray(this.Hash(length: 2)) : this.Hash(length: 6));
            }
            else
            {
                throw new Exception("Invalid format provided. Please provide one of \"hex\", \"shorthex\", \"rgb\", \"rgba\", or \"0x\".");
            }

            //if (options.casing == "upper")
            //{
            //    colorValue = colorValue.toUpperCase();
            //}

            return colorValue;
        }


        public string FBID()
        {
            return string.Join("", ("10000" + this.Natural(max: 1000000000)).Take(10));
        }

        public string GoogleAnalytics()
        {
            var account = this.Pad(this.Natural(max: 999999), 6);
            var property = this.Pad(this.Natural(max: 99), 2);

            return "UA-" + account + '-' + property;
        }

        public string HashTag()
        {
            return '#' + this.Word();
        }

        public string IP()
        {
            return "" +this.Natural(max: 255) + '.' + this.Natural(max: 255) + '.' + this.Natural(max: 255) + '.' + this.Natural(max: 255);
        }

        public string IPv6()
        {
            var ol = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                ol.Add(this.Hash(length: 4));
            }

            return string.Join(":", ol);
        }

        public int klout()
        {
            return this.Natural( min: 1, max: 99);
        }

        public string TwitterUser()
        {
            return "@" + this.Word();
        }


        public string Url(string domain = "", string protocol = "", string path = "", string ext = "")
        {
            domain = string.IsNullOrEmpty(domain) ? this.Domain() : domain;
            protocol = string.IsNullOrEmpty(protocol) ? this.Pick(new string[] { "http", "https" }) : protocol;
            path = string.IsNullOrEmpty(path) ? this.Word() : path;

            return protocol + "://" + domain + "/" + path + ext;
        }


    }
}
