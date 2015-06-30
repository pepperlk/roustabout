using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roustabout.Tools.Chance.Tests
{
    [TestClass]
    public class Text
    {
        [TestMethod]
        public void Text_Syllable()
        {
            var chance = new ChanceGen();
            var syllable = chance.Syllable();
            Assert.IsTrue(syllable.Length >= 2 && syllable.Length <= 3);
        }

        [TestMethod]
        public void Text_Word()
        {
            var chance = new ChanceGen();
            var word = chance.Word();
            Assert.IsTrue(word.Length >= 2 && word.Length <= 9);
        }



        [TestMethod]
        public void Text_WordSyllables()
        {
            var chance = new ChanceGen();
            var word = chance.Word(syllables: 3);
            Assert.IsTrue(word.Length >= 6 && word.Length <= 9);
        }

        [TestMethod]
        public void Text_WordLength()
        {
            var chance = new ChanceGen();
            var word = chance.Word(length: 5);
            Assert.IsTrue(word.Length == 5);
        }


        [TestMethod]
        public void Text_Sentance()
        {
            var chance = new ChanceGen();
            var str = chance.Sentence();
            Assert.IsTrue(str.Length >= 12 && str.Length <= 18);
        }

        [TestMethod]
        public void Text_Paragraph()
        {
            var chance = new ChanceGen();
            var str = chance.Paragraph();
            //Assert.IsTrue(str.Length >= 12 && str.Length <= 18);
        }



    }
}
