using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roustabout.Tools.Chance
{

    public enum AgeRange
    {
        Child,
        Teen,
        Adult,
        Senior,
        All,
        Default,
    }

    public enum Gender
    {
        Male,
        Female,
        All,
    }

    public partial class ChanceGen
    {

        private const long MAX_INT = 9007199254740992;
        private const long MIN_INT = -9007199254740992;




  

      

      
        private const string NUMBERS = "0123456789";
        private const string CHARS_LOWER = "abcdefghijklmnopqrstuvwxyz";
        private const string CHARS_UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string HEX_POOL = NUMBERS + "abcdef";

        


        


        private LookupData data = new LookupData();

        public ChanceGen()
        {

        }







        #region


        #endregion

    }
}
