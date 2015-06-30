using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{
    public partial class ChanceGen
    {
        public string AndroidID()
        {
            return "APA91" + this.String(pool: "0123456789abcefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_", length: 178);
        }

        public string AppleToken()
        {
            return this.String(pool: "abcdef1234567890", length: 64);
        }

        public string WP8_ANID2()
        {
            return Base64(this.Hash(length: 32));
        }

        public string WP7_ANID()
        {
            return "A=" + Guid.NewGuid().ToString().Replace("-", "").ToUpper() + "&E=" + this.Hash(length: 3) + "&W=" + this.Integer(min: 0, max: 9);
        }

        public string BB_Pin()
        {
            return this.Hash( length: 8 );
        }

    }
}
