﻿using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace SimInformation.UWP.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var simInfo = new SimInformation();

            var details = simInfo.GetSimCards();
        }
    }
}
