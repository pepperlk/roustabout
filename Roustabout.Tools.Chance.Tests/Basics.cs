using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roustabout.Tools;
using System.Collections;
using System.Collections.Generic;

namespace Roustabout.Tools.Chance.Tests
{
    [TestClass]
    public class Basics
    {
        [TestMethod]
        public void Data_GetData()
        {
            var chance = new ChanceGen();
            //var data = chance.GetLastNames();
            //Assert.IsTrue(data is IEnumerable<string>);
        }

        [TestMethod]
        public void Bool_IsRandomBounds()
        {
            var chance = new ChanceGen();
            var true_count = 0;
            for (int i = 0; i < 1000;  i++)
            {
                if (chance.Bool() == true)
                {
                    true_count++;
                }
            }

            Assert.IsTrue(true_count >= 200 && true_count <= 800);

        }



        [TestMethod]
        public void Integer_NegAndPositive()
        {
            var chance = new ChanceGen();
            var true_count = 0;
            for (int i = 0; i < 1000; i++)
            {
                var inte = chance.Integer();
                if (inte > 0)
                {
                    true_count++;
                }
            }

            Assert.IsTrue(true_count >= 200 && true_count <= 800);

        }



        }
}
