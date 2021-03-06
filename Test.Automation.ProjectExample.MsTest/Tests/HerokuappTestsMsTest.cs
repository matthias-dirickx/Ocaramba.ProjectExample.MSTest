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
    public class HerokuappTestsMsTest : ProjectTestBase
    {
        [TestMethod]
        public void TickCheckboxTest()
        {
            var checkboxes = new InternetPage(this.DriverContext)
                .OpenHomePage()
                .GoToCheckboxesPage()
                .TickCheckboxOne();

            Assert.IsTrue(checkboxes.IsCheckmarkOneTicked, "Checkbox1 is unticked!");
        }

        [TestMethod]
        public void UnTickCheckboxTest()
        {
            var checkboxes = new InternetPage(this.DriverContext)
                .OpenHomePage()
                .GoToCheckboxesPage()
                .UnTickCheckboxTwo();

            Assert.IsFalse(checkboxes.IsCheckmarkTwoTicked, "Checkbox2 is ticked!");
        }
    }
}
