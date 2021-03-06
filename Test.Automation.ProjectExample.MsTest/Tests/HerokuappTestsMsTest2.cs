﻿// <copyright file="HerokuappTestsMsTest.cs" company="Objectivity Bespoke Software Specialists">
// Copyright (c) Objectivity Bespoke Software Specialists. All rights reserved.
// </copyright>
// <license>
//     The MIT License (MIT)
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//     SOFTWARE.
// </license>

using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Objectivity.Test.Automation.Common;
using Objectivity.Test.Automation.Tests.MsTest;
using Objectivity.Test.Automation.Tests.PageObjects.PageObjects.TheInternet;
using Test.Automation.ProjectExample.MsTest.PageObjects.TheInternet;

namespace Test.Automation.ProjectExample.MsTest.Tests
{
    /// <summary>
    /// Tests to verify checkboxes tick and Untick.
    /// </summary>
    [TestClass]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public class HerokuappTestsMsTest3 : ProjectTestBase
    {
        [TestMethod]
        public void VerifyTest()
        {
            Verify.That(this.DriverContext, () => Assert.AreEqual(1, 1), () => Assert.AreEqual(2, 2), () => Assert.AreEqual(3, 3));
            Verify.That(this.DriverContext, () => Assert.IsFalse(false), enableScreenShot: true, enableSavePageSource: true);
            Verify.That(this.DriverContext, () => Assert.IsTrue(true));
        }

        [TestMethod]
        public void ToByTest()
        {
            string expectedDescription = @"Also known as split testing. This is a way in which businesses are able to simultaneously test and learn different versions of a page to see which text and/or functionality works best towards a desired outcome (e.g. a user action such as a click-through).";

            new InternetPage(this.DriverContext)
                .OpenHomePage()
                .GoToPage("abtest");

            var abeTestingPage = new AbTestingPage(this.DriverContext);
            Assert.AreEqual(expectedDescription, abeTestingPage.GetDescriptionUsingBy);
        }

        [TestMethod]
        public void GetElementTest()
        {
            string expectedDescription = @"Also known as split testing. This is a way in which businesses are able to simultaneously test and learn different versions of a page to see which text and/or functionality works best towards a desired outcome (e.g. a user action such as a click-through).";

            new InternetPage(this.DriverContext)
                .OpenHomePage()
                .GoToPage("abtest");

            var abeTestingPage = new AbTestingPage(this.DriverContext);
            Assert.AreEqual(expectedDescription, abeTestingPage.GetDescription);
        }

        [TestMethod]
        public void GetElementTestWithCustomTimeoutTest()
        {
            string expectedDescription = @"Also known as split testing. This is a way in which businesses are able to simultaneously test and learn different versions of a page to see which text and/or functionality works best towards a desired outcome (e.g. a user action such as a click-through).";

            new InternetPage(this.DriverContext)
                .OpenHomePage()
                .GoToPage("abtest");

            var abeTestingPage = new AbTestingPage(this.DriverContext);
            Assert.AreEqual(expectedDescription, abeTestingPage.GetDescriptionWithCustomTimeout);
        }

        [TestMethod]
        public void WaitElementDissapearsTest()
        {
            new InternetPage(this.DriverContext)
                 .OpenHomePage()
                 .GoToPage("disappearing_elements");

            var disappearingElements = new DisappearingElementsPage(this.DriverContext);
            disappearingElements.RefreshAndWaitLinkNotVisible("NotExistingLink");
        }

        [TestMethod]
        public void GetElementWithCustomConditionTest()
        {
            new InternetPage(this.DriverContext)
                 .OpenHomePage()
                 .GoToPage("disappearing_elements");

            var disappearingElementsPage = new DisappearingElementsPage(this.DriverContext);
            var currentTagName = disappearingElementsPage.GetLinkTitleTagName("Home");
            Assert.AreEqual("a", currentTagName);
        }

        [TestMethod]
        public void GetElementWithCustomTimeoutAndConditionTest()
        {
            new InternetPage(this.DriverContext)
                 .OpenHomePage()
                 .GoToPage("disappearing_elements");

            var disappearingElementsPage = new DisappearingElementsPage(this.DriverContext);
            var currentIsSelected = disappearingElementsPage.IsLinkSelected("Home");
            Assert.AreEqual(false, currentIsSelected);
        }
    }
}
