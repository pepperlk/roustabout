using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roustabout.Tools.Chance.Tests
{
    [TestClass]
    public class Person
    {
        [TestMethod]
        public void Person_Age()
        {
            var chance = new ChanceGen();
            var age = chance.Age();
        }

        [TestMethod]
        public void Person_Birthday()
        {
            var chance = new ChanceGen();
            var val = chance.Birthday();
        }

        [TestMethod]
        public void Person_Gender()
        {
            var chance = new ChanceGen();
            var val = chance.Gender();
        }


        [TestMethod]
        public void Person_First()
        {
            var chance = new ChanceGen();
            var val = chance.Name();
        }

    }
}
