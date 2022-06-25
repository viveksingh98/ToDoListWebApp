/* ***************************************************************
* Test Automation Framework - Functional Tests
* Author: Vivek Singh
* Date/Time: 06/24/2022
*****************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtentLogger;
using System;
using AventStack.ExtentReports;
using ToDoListWebAppHelpers;
using ToDoListWebAppPages;
using AventStack.ExtentReports.Model;
using System.Xml.Linq;
using System.Collections.Generic;

namespace ToDoListWebApp
{
    [TestClass]
    public class ToDoMVCTests
    {
        public TestContext TestContext { get; set; }

        //public static ExtentReports extent;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;


        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContexts)
        {
            ReportLoggerBase.ReportLogger("UITest");
        }

        [TestInitialize]
        public void TestInitializeMethod()
        {
            SeleniumHelper.launchBrowser("Chrome");
            SeleniumHelper.navigateToUrl(ToDoMVCPage.GetURL());
            SeleniumHelper.maximizeBrowser();
            System.Threading.Thread.Sleep(3 * 1000);
        }
        /* ------------ Positive Scenarios   ------------*/
        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify URL https://todomvc.com/examples/angular2/ is working")]
        public void VerifyURLWorking()
        {
            try
            {
                GenerateExtentReport($"Verify URL {ToDoMVCPage.GetURL()} is working");
                string toDosHeaderText = ToDoMVCPage.GetToDosHeader();
                Assert.IsTrue(toDosHeaderText.Equals("todos"), "The URL is working");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify window tile is 'Angular.TodoMVC'")]
        public void VerifyWindowTitle()
        {
            try
            {
                GenerateExtentReport("Verify window tile is 'Angular.TodoMVC'");
                string windowTitle = ToDoMVCPage.GetWindowTitle();
                Assert.IsTrue(windowTitle.Equals("Angular2 • TodoMVC"), "The window tile is 'Angular.TodoMVC'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify availability of controls on the home page")]
        public void VerifyAvailibilityOfControlsPresentOnThePage()
        {
            try
            {
                GenerateExtentReport("Verify availability of controls on the home page");
                Assert.IsTrue(ToDoMVCPage.WhatNeedsToBeDoneTextControlVisible(), "Textbox control is present on the page");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify footers information present on ToDoMVC home page")]
        public void VerifyFooterInformationPresent()
        {
            GenerateExtentReport("Verify footers information present on ToDoMVC home page");
            Assert.IsTrue(ToDoMVCPage.CheckDoubleClickInfoPresentOnFooter().Contains("Double-click to edit a todo"), "Verify after clicking on footer hyperlink 'Sam Saccone' user is navigated to 'http://github.com/samccone'");
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("ToDoMVCPage")]
        public void VerifyFooterLinkSamSacconeWorking()
        {
            try
            {
                GenerateExtentReport("Verify after clicking on footer hyperlink 'Sam Saccone' user is navigated to 'http://github.com/samccone'");
                Assert.IsTrue(ToDoMVCPage.VerifyFooterLinksWorking(ToDoMVCPage.FooterLinks.SamSaccone), "Verify after clicking on footer hyperlink 'Sam Saccone' user is navigated to 'http://github.com/samccone'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify after clicking on footer hyperlink 'Colin Eberhardt' user is navigated to 'http://github.com/samccone'")]
        public void VerifyFooterLinkColinEberhardtWorking()
        {
            try
            {
                GenerateExtentReport("Verify after clicking on footer hyperlink 'Colin Eberhardt' user is navigated to 'http://github.com/samccone'");
                Assert.IsTrue(ToDoMVCPage.VerifyFooterLinksWorking(ToDoMVCPage.FooterLinks.ColinEberhardt), "Verify after clicking on footer hyperlink 'Colin Eberhardt' user is navigated to 'http://github.com/samccone'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify after clicking on footer hyperlink 'Angular2' user is navigated to 'http://angular.io'")]
        public void VerifyFooterLinkAngular2Working()
        {
            try
            {
                GenerateExtentReport("Verify after clicking on footer hyperlink 'Angular2' user is navigated to 'http://angular.io'");
                Assert.IsTrue(ToDoMVCPage.VerifyFooterLinksWorking(ToDoMVCPage.FooterLinks.Angular2), "Verify after clicking on footer hyperlink 'Angular2' user is navigated to 'http://angular.io'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify after clicking on footer hyperlink 'TodoMVC' user is navigated to 'https://todomvc.com/'")]
        public void VerifyFooterLinkTodoMVCWorking()
        {
            try
            {
                GenerateExtentReport("Verify after clicking on footer hyperlink 'TodoMVC' user is navigated to 'https://todomvc.com/'");
                Assert.IsTrue(ToDoMVCPage.VerifyFooterLinksWorking(ToDoMVCPage.FooterLinks.TodoMVC), "Verify after clicking on footer hyperlink 'TodoMVC' user is navigated to 'https://todomvc.com/");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify user is able to add their todo items from Input TextBox by pressing 'Enter' key from keyboard")]
        public void VerifyTodoTextboxAddsTasksOnEnter()
        {
            try
            {
                List<string> li = new List<string>() { "Yoga Class", "Visit leh ladakh", "Create accessibility app to help blind people" };
                GenerateExtentReport("Verify user is able to add their todo items from Input TextBox by pressing 'Enter' key from keyboard");
                Assert.IsTrue(ToDoMVCPage.EnterDataInToDoList(li), "Verify user is able to add their todo items from Input TextBox by pressing 'Enter' key from keyboard");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }


        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify existing todo item name is stikethough from the todo list after clicking on radio button")]
        public void VerifyItemsCrossedOnSelection()
        {
            try
            {
                List<string> li = new List<string>() { "Yoga Class", "Visit leh ladakh", "Create accessibility app to help blind people" };
                GenerateExtentReport("Verify existing todo item name is stikethough from the todo list after clicking on radio button");
                Assert.IsTrue(ToDoMVCPage.ToDoCounterDecementsOnRadioButtonClick(li), "Verify existing todo item name is stikethough from the todo list after clicking on radio button");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify existing todo item name stikethough is restored after clicking on the radio button again on ToDo List")]
        public void VerifyStrikeThroughItemRestored()
        {
            try
            {
                List<string> li = new List<string>() { "Yoga Class", "Visit leh ladakh", "Create accessibility app to help blind people" };
                GenerateExtentReport("Verify existing todo item name stikethough is restored after clicking on the radio button again on ToDo List");
                Assert.IsTrue(ToDoMVCPage.ToDoCounterRestoredOnRadioButtonClickAgain(li), "Verify existing todo item name stikethough is restored after clicking on the radio button again on ToDo List");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo item name is removed from the todo list when 'Clear Completed' is clicked")]
        public void VerifyItemsRemovedOnClearCompletedClick()
        {
            try
            {
                List<string> li = new List<string>() { "Yoga Class", "Visit leh ladakh", "Create accessibility app to help blind people" };
                GenerateExtentReport("Verify todo item name is removed from the todo list when 'Clear Completed' is clicked");
                Assert.IsFalse(ToDoMVCPage.ClickClearCompletedButtonAndVerifyItemRemoved(li), "Verify todo item name is removed from the todo list when 'Clear Completed' is clicked");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo item name is removed from the todo list when Remove X button' is clicked")]
        public void VerifyItemsRemovedOnRemoveXButtonClick()
        {
            try
            {
                List<string> li = new List<string>() { "Yoga Class", "Visit leh ladakh", "Create accessibility app to help blind people" };
                GenerateExtentReport("Verify todo item name is removed from the todo list when Remove X button' is clicked");
                Assert.IsFalse(ToDoMVCPage.ClickXButtonToRemoveListItem(li), "Verify todo item name is removed from the todo list when Remove X button' is clicked");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }


        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify count of 'N Items left' increases by one when new todo item is added in the list")]
        public void VerifyItemLeftIncrementCounter()
        {
            try
            {
                List<string> li = new List<string>() { "Yoga Class", "Visit leh ladakh", "Create accessibility app to help blind people" };
                GenerateExtentReport("Verify count of 'N Items left' increases by one when new todo item is added in the list");
                Assert.IsTrue(ToDoMVCPage.CheckTheToDoCounterIncrementOnItemAddition(li), "Verify count of 'N Items left' increases by one when new todo item is added in the list");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify count of 'N Items left' decreases by one when radio button is checked for any existing todo item.")]
        public void VerifyItemLeftDecrementCounter()
        {
            try
            {
                List<string> li = new List<string>() { "Yoga Class", "Visit leh ladakh", "Create accessibility app to help blind people" };
                GenerateExtentReport("Verify count of 'N Items left' decreases by one when radio button is checked for any existing todo item.");
                Assert.IsTrue(ToDoMVCPage.CheckTheToDoCounterDecrementOnItemChecked(li), "Verify count of 'N Items left' decreases by one when radio button is checked for any existing todo item.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        /* ------------ Negative Scenarios   ------------*/

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify user is able to add todo item name conatins special character e.g. #$%^%^##&^*^&*")]
        public void VerifySpecialCharacterEntryToTodoList()
        {
            try
            {
                string data = "#$%^%^##&^*^&*";
                GenerateExtentReport("Verify user is able to add todo item name conatins special character e.g. #$%^%^##&^*^&*");
                Assert.IsTrue(ToDoMVCPage.EnterSpecialCharacters(data), "Verify user is able to add todo item name conatins special character e.g. #$%^%^##&^*^&*");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo item cannot be added with blank name")]
        public void VerifyBlankNameEntryToTodoList()
        {
            try
            {
                GenerateExtentReport("Verify user is able to add todo item name conatins special character e.g. #$%^%^##&^*^&*");
                Assert.IsFalse(ToDoMVCPage.EnterBlankData(), "Verify user is able to add todo item name conatins special character e.g. #$%^%^##&^*^&*");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo item can not be added with name which conatins only spaces and no characters")]
        public void VerifyNamesWithOnlySpacesEntryToTodoList()
        {
            try
            {
                string data = "                ";
                GenerateExtentReport("Verify todo item can not be added with name which conatins only spaces and no characters");
                Assert.IsFalse(ToDoMVCPage.EnterSpacesAndNoCharacters(data), "Verify todo item can not be added with name which conatins only spaces and no characters");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify number of character limit for todo item name e.g (Consider maximum char limit 100 char). In this case the user should be able to add more than 100 characters in ToDo list")]
        public void VerifyCharacterLimitEntryToTodoList()
        {
            try
            {
                string CharLen100 = "dknadsfhoasdasdjpajdk;ajsdlkahlisdhalksdklqelrkqbwklelkdnlkasndl;asndkasldnkasasdbaksjddasdbjkasdfg";
                GenerateExtentReport("Verify todo item can be added with name which conatins only spaces and no characters");
                Assert.IsTrue(ToDoMVCPage.Enter100CharDataToCheckBoundryLimit(CharLen100), "Verify user is able to add todo item name conatins special character e.g. #$%^%^##&^*^&*");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo items data persist when user refresh the page")]
        public void VerifyNamesPersistOnBrowserRefresh()
        {
            try
            {
                string yogaClassText = "Yoga Class";
                GenerateExtentReport("Verify todo items data persist when user refresh the page");
                Assert.IsTrue(ToDoMVCPage.ConfirmDataPersistOnRefresh(yogaClassText), "Verify todo items data persist when user refresh the page");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo items with duplicate names are also allowed")]
        public void VerifyRedundentItemsAllowedInToToDoList()
        {
            try
            {
                List<string> li = new List<string>() { "Yoga Class", "Yoga Class", "Yoga Class" };
                GenerateExtentReport("Verify todo items with duplicate names are also allowed");
                Assert.IsTrue(ToDoMVCPage.CheckDuplicateEntryAllowed(li), "Verify todo items with duplicate names are also allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify double click on list item makes it editable and available for changing its values")]
        public void VerifyListItemEditableOnDoubleClick()
        {
            try
            {
                string yogaClassText = "Yoga Class";
                GenerateExtentReport("Verify double click on list item makes it editable and available for changing its values");
                Assert.IsTrue(ToDoMVCPage.CheckListItemEditableOnDoubleClick(yogaClassText), "Verify double click on list item makes it editable and available for changing its values");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test case failed due to {ex.Message}");
                throw ex;
            }
        }

        public void GenerateExtentReport(string nodeName)
        {
            try
            {
                exParentTest = ReportLoggerBase.extent.CreateTest(TestContext.TestName);
                exChildTest = exParentTest.CreateNode(nodeName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [TestCleanup]
        public void CleanupFile()
        {
            var status = TestContext.CurrentTestOutcome;
            Status logstatus;

            switch (status)
            {
                case UnitTestOutcome.Failed:
                    logstatus = Status.Fail;
                    break;
                case UnitTestOutcome.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case UnitTestOutcome.Passed:
                    logstatus = Status.Pass;
                    break;
                default:
                    logstatus = Status.Error;
                    break;

            }

            if (exChildTest != null)
            {
                exChildTest.Log(logstatus, "Test ended with " + logstatus);
            }
            System.Threading.Thread.Sleep(3 * 1000);
            ToDoMVCPage.driver.Quit();
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            ReportLogger.FlushExtent();
            Boolean boolFailFlag = false;
            SeleniumHelper.getDriver().Quit();
        }
    }
}
