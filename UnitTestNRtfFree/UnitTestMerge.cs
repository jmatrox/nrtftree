using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net.Sgoliver.NRtfTree.Core;

namespace UnitTestNRtfFree
{
    [TestClass]
    public class UnitTestMerge
    {
        [TestMethod]
        public void TestMethod1()
        {
            RtfMerger merger = new RtfMerger("..\\..\\testdocs\\template.rtf");
            merger.AddPlaceHolder("$doc1$", "..\\..\\testdocs\\Test.rtf");
            merger.AddPlaceHolder("$doc2$", "..\\..\\testdocs\\Test2.rtf");

            //Assert.That(merger.Placeholders.Count, Is.EqualTo(2));

            //merger.AddPlaceHolder("$doc3$", "..\\..\\testdocs\\merge-doc2.rtf");

            //Assert.That(merger.Placeholders.Count, Is.EqualTo(3));

            //merger.RemovePlaceHolder("$doc3$");

            //Assert.That(merger.Placeholders.Count, Is.EqualTo(2));

            RtfTree tree = merger.Merge();
            tree.SaveRtf("..\\..\\testdocs\\merge-result-1.rtf");

            //StreamReader sr = null;
            //sr = new StreamReader("..\\..\\testdocs\\merge-result-1.rtf");
            //string rtf1 = sr.ReadToEnd();
            //sr.Close();

            //sr = new StreamReader("..\\..\\testdocs\\rtf3.txt");
            //string rtf3 = sr.ReadToEnd();
            //sr.Close();

            //Assert.That(rtf1, Is.EqualTo(rtf3));
        }
    }
}
