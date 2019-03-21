using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net.Sgoliver.NRtfTree.Core;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RtfTree tree = new RtfTree();
            tree.LoadRtfFile(@"D:\TFS-ALMA\TEControl\Branches\16.00\Source-16.0.0\Solution\UnitTestTEControl\Files\Relazione.rtf");

            tree.GetFontTable();
            //tree.SaveRtf(@"d:\pippo.rtf");
            Assert.IsTrue(true);
        }
    }
}
