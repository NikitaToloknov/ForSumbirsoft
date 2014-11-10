using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SimbirsoftTestCSharp;

namespace UnitTestSimbirsoftCSharp
{
    [TestClass]
    public class UnitTestSimbirsoftCSharps
    {
        List<string> test = new List<string>();
        [TestMethod]
        public void testFindWordTrue()
        {
            SimbirsoftTestCSharp.Logic logical = new Logic();
            test.Clear();
//--------------------------------------------------------------------
            test.Add("Helloy");
            test.Add("Very");
            test.Add("Good");
//--------------------------------------------------------------------
            string true_line = "Good";
            Assert.IsTrue(logical.findWord(test, true_line));
        }

        [TestMethod]
        public void testFindWordFalse()
        {
            SimbirsoftTestCSharp.Logic logical = new Logic();
            test.Clear();
            //--------------------------------------------------------------------
            test.Add("Helloy");
            test.Add("Very"); 
            test.Add("Good");
            //--------------------------------------------------------------------
            string false_line = "false";
            Assert.IsFalse(logical.findWord(test, false_line));
        }
        [TestMethod]
        public void testlineTag()
        {
            SimbirsoftTestCSharp.Html_Method html = new Html_Method("path_of");
            string line_rez = "<br>No</br>";
            string send = "No";
            Assert.AreEqual(line_rez,html.lineTag(send));
        }
        [TestMethod]
        public void testprocessingLine()
        {
            SimbirsoftTestCSharp.Html_Method html = new Html_Method("path_of");
            test.Clear();
            //--------------------------------------------------------------------
            test.Add("Helloy");
            test.Add("Very");
            test.Add("Good");
            //--------------------------------------------------------------------
            string line = "Good";
            string line_rez = "<br><em>Good</em> </br>";
            Assert.AreEqual(html.processingLine(test,line,Html_Method.Style.Italic),line_rez);
        }
    }
}
