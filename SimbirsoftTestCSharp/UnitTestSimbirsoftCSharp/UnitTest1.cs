using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SimbirsoftTestCSharp;

namespace UnitTestSimbirsoftCSharp
{
    [TestClass]
    public class UnitTestSimbirsoftCSharps
    {
        [TestMethod]
        public void testFindWordTrue()
        {
            SimbirsoftTestCSharp.Logic logical = new Logic();
            List<string> test = new List<string>();
//--------------------------------------------------------------------
            test.Add("Helloy");
            test.Add("Very");
            test.Add("Good");
//--------------------------------------------------------------------
            string true_line = "Good";
            string false_line = "false";

            Assert.IsTrue(logical.findWord(test, true_line));
        }
        [TestMethod]
        public void testFindWordFalse()
        {
            SimbirsoftTestCSharp.Logic logical = new Logic();
            List<string> test = new List<string>();
            //--------------------------------------------------------------------
            test.Add("Helloy");
            test.Add("Very");
            test.Add("Good");
            //--------------------------------------------------------------------
            string true_line = "Good";
            string false_line = "false";

            Assert.IsFalse(logical.findWord(test, false_line));
        }
    }
}
