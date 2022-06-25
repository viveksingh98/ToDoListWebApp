/* ***************************************************************
* Test Automation Framework - Functional Tests
* Author: Vivek Singh
* Date/Time: 06/24/2022
*****************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtentLogger;
using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using System.Xml.Linq;

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
        public void BeforeTest()
        {
            Console.WriteLine("Before Script");
        }
        [TestMethod]
        [TestCategory("ExtentTest")]
        [Owner("vivek.singh")]
        [Description("")]
        public void ExtentTestCasePass()
        {
            // ReportLoggerBase.ReportLogger(TestContext.TestName);
            exParentTest = ReportLoggerBase.extent.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Provide Parameters");
            exChildTest.Log(AventStack.ExtentReports.Status.Pass, "Passed");
            int a = 10;
            int b = 15;
            _ = a + b;
            exChildTest = exParentTest.CreateNode("Add Parameters1");
            exChildTest.Log(AventStack.ExtentReports.Status.Fail, "Passed1");

        }

        [TestMethod]
        [TestCategory("ExtentTest")]
        [Owner("vivek.singh")]
        [Description("")]
        public void ExtentTestCaseFail()
        {
            //ReportLoggerBase.ReportLogger(TestContext.TestName);
            exParentTest = ReportLoggerBase.extent.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Provide Parameters2");
            exChildTest.Log(AventStack.ExtentReports.Status.Pass, "Passed2");
            int a = 10;
            int b = 15;
            _ = a + b;
            exChildTest = exParentTest.CreateNode("Add Parameters 2");
            exChildTest.Log(AventStack.ExtentReports.Status.Fail, "Failed");
            //ReportLoggerBase.exChildTest.Log(Status.Info, MediaEntityModelProvider.CreateScreenCaptureFromPath)
            Assert.Fail();
        }

        /* ------------ Positive Scenarios   ------------*/
        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify URL https://todomvc.com/examples/angular2/ is working")]
        public void VerifyURLWorking()
        {

        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify window tile is 'Angular.TodoMVC'")]
        public void VerifyWindowTitle()
        {

        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify footers information present angular2 home page")]
        public void VerifyFooterInformationPresent()
        {

        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify after clicking on footer hyperlink 'Sam Saccone' user is navigated to 'http://github.com/samccone'")]
        public void VerifyFooterLinkSamSacconeWorking()
        {

        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify after clicking on footer hyperlink 'Colin Eberhardt' user is navigated to 'http://github.com/samccone'")]
        public void VerifyFooterLinkColinEberhardtWorking()
        {

        }

        [TestMethod]
        [TestCategory("SmokeTest")]
        [Owner("vivek.singh")]
        [Description("Verify after clicking on footer hyperlink 'Angular2' user is navigated to 'http://angular.io'")]
        public void VerifyFooterLinkAngular2Working()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify user is able to add their todo items from Input TextBox by pressing 'Enter' key from keyboard")]
        public void VerifyTodoTextboxAddsTasksOnEnter()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify after adding Todo Items the items are not selected hence checked immediately after entry")]
        public void VerifyItemsNotSelectedAfterEntry()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify existing todo item name is stikethough from the todo list after clicking on radio button")]
        public void VerifyItemsCrossedOnSelection()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify existing todo item name stikethough is removed from the todo list after unchecking the radio button on ToDo List")]
        public void VerifyItemsUnCrossedOnSelectionRemoval()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo item name is removed from the todo list when 'Clear Completed' is clicked")]
        public void VerifyItemsRemovedOnClearCompletedClick()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo item name is removed from the todo list when Remove X button' is clicked")]
        public void VerifyItemsRemovedOnRemoveXButtonClick()
        {

        }


        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify count of 'N Items left' increases by one when new todo item is added in the list")]
        public void VerifyItemLeftIncrementCounter()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify count of 'N Items left' decreases by one when radio button is checked for any existing todo item.")]
        public void VerifyItemLeftDecrementCounter()
        {

        }

        /* ------------ Negative Scenarios   ------------*/

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Check radio button for any existing todo item and verify count of 'item left' is decreased by one, again uncheck same radio button and verify count of 'item left' is increased by one at random.")]
        public void VerifyItemCounterByCheckingUncheckingRadioButtonRandomly()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify user is able to add todo item name conatins special character e.g. #$%^%^##&^*^&*")]
        public void VerifySpecialCharacterEntryToTodoList()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo item can not be added with blank name")]
        public void VerifyBlankNameEntryToTodoList()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo item can not be added with name which conatins only spaces and no characters")]
        public void VerifyNamesWithOnlySpacesEntryToTodoList()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify number of character limit for todo item name e.g (Consider maximum char limit 100 char). The user should not be able to add more than 100 characters in ToDo list")]
        public void VerifyCharacterLimitEntryToTodoList()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify todo items data persist when user refresh the page")]
        public void VerifyNamesPersistOnBrowserRefresh()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify verticle scroll bar is added to right corner of the page when user add more than 6 todo items")]
        public void VerifyVerticalScrollbarPresentWhenItemCountExceeds6()
        {

        }

        [TestMethod]
        [TestCategory("RegressionTest")]
        [Owner("vivek.singh")]
        [Description("Verify ToDo item with duplicate names can not be added")]
        public void VerifyRedundentItemsNotAddedToToDoList()
        {

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
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            ReportLogger.FlushExtent();
            Boolean boolFailFlag = false;

            //string newFileName = "";
            //if (boolFailFlag == true || !(TestContext.CurrentTestOutcome == UnitTestOutcome.Failed))
            //{
            //    extent.("fail", "Test Outcome: " + _testContext.CurrentTestOutcome)
            //}
        }
    }
}
