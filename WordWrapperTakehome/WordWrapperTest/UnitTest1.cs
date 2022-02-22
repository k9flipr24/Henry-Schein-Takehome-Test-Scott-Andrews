using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordWrapperTest
{
    [TestClass]
    public class UnitTest1
    {

        const string shortString = "This is a test";
        const string longString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam molestie est eget nunc vulputate gravida. Mauris eu urna nisi. Suspendisse potenti.";
        const int shortColumn = 3;
        const int longColumn = 30;
        const int zero = 0;
        const int edgeColumn = 7;
        [TestMethod]
        public void SmallStringSmallColumnLength()
        {
            Assert.AreEqual("This\nis\na\ntest", WordWrapperTakehome.WordWrapper.wrap(shortString, shortColumn));
        }

        [TestMethod]
        public void LargeStringSmallColumnLength()
        {
            Assert.AreEqual("Lorem\nipsum\ndolor\nsit\namet,\nconsectetur\nadipiscing\nelit.\nEtiam\nmolestie\nest\neget\nnunc\nvulputate\ngravida.\nMauris\neu\nurna\nnisi.\nSuspendisse\npotenti.", WordWrapperTakehome.WordWrapper.wrap(longString, 3)); //Find and replace made this string easy to generate
        }

        [TestMethod]
        public void EdgeCase()
        {
            Assert.AreEqual("This is\na test", WordWrapperTakehome.WordWrapper.wrap(shortString, edgeColumn));
        }

        [TestMethod]
        public void SmallStringLongColumnLength()
        {
            Assert.AreEqual("This is a test", WordWrapperTakehome.WordWrapper.wrap(shortString, longColumn));
        }

        [TestMethod]
        public void LongStringLongColumnLength()
        {
            Assert.AreEqual("Lorem ipsum dolor sit amet,\nconsectetur adipiscing elit.\nEtiam molestie est eget nunc\nvulputate gravida. Mauris eu\nurna nisi. Suspendisse\npotenti.", WordWrapperTakehome.WordWrapper.wrap(longString, longColumn));
        }

        [TestMethod]
        public void CheckBounds()
        {
           try
            {
                WordWrapperTakehome.WordWrapper.wrap(shortString, zero);
                Assert.Fail("Exception expected but not seen");
            }
            catch(Exception e)
            {
                Assert.AreEqual("ERROR: Cannot have column width less than 1", e.Message);
            }
            try
            {
                WordWrapperTakehome.WordWrapper.wrap(string.Empty, longColumn);
                Assert.Fail("Exception expected but not seen");
            }
            catch (Exception e)
            {
                Assert.AreEqual("ERROR: Cannot accept empty string", e.Message);
            }
        }
    }
}
