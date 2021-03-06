# ToDoListWebApp
Automating [Angular ToDoMVC](https://todomvc.com/examples/angular2) website


Given below are some positive and negative scenarios: <hr />

## Positive Scenarios

1. Verify URL https://todomvc.com/examples/angular2/ is working, Verify window title is **'Angular.TodoMVC'**<br />

2. Verify availability of controls on the home page <br />
	<i>a. Header 'todos' </i><br />
	<i>b. Input TextBox 'What needs to be done?' </i><br />

3.  Verify footers information is present on ToDoMVC home page <br />
      <ul>
	<li><i>Double-click to edit a todo</i> </li>
	<li><i>Created by Sam Saccone and Colin Eberhardt using Angular2</i> </li>
	<li><i>Part of TodoMVC</i></li>
      </ul>
4.  Verify after clicking on footer hyperlink **'Sam Saccone'** user is navigated to "http://github.com/samccone" <br />

5.  Verify after clicking on footer hyperlink **'Colin Eberhardt'** user is navigated to "http://github.com/samccone" <br />

6.  Verify after clicking on footer hyperlink **'Angular2'** user is navigated to "http://angular.io" <br />

7.  Verify user is able to add their todo items from Input TextBox by pressing 'Enter' key from keyboard <br />
    e.g add following todo items <br />
      <i>a. Yoga Class </i><br />
      <i> b. Visit leh ladakh</i> <br />
      <i> c. Create accessibility app to help blind people </i><br />

    Verify list contains following todo items with radio button unchecked <br />
      <i> a. Yoga Class </i><br />
      <i> b. Visit leh ladakh </i><br />
      <i> c. Create accessibility app to help blind people </i><br />

8.  Verify existing todo item name is ~stikethough~ from the todo list after clicking on radio button <br />

9.  Verify todo item name is removed from the todo list when 'Clear Completed' is clicked <br />

10. Verify todo item name is removed from the todo list when 'remove' button is clicked <br />

11. Verify count of 'N Items left' increased by one when new todo item is added in the list <br />

12. Verify count of 'N Items left' decreased by one when radio button is checked for any existing todo item. <br />


## Negative Scenarios

1. Check radio button for any existing todo item and verify count of 'item left' is decreased by one, again uncheck same radio button and verify count of 'item left' is increased by one. <br />
2. Verify user is able to add todo item name conatins special character **e.g.#$%^%^##&^*^&*** <br />
3. Verify todo item can not be added with **blank** name <br />
4. Verify todo item cannot be added with name which contains only **spaces** and **no characters** <br />
5. Verify number of **character limit** for todo item name e.g (Consider maximum char limit 100 char). In this case the user should be able to add more than **100 characters** in ToDo list <br />
6. Verify todo items **data persists** when user hits **Refresh** on the web page or closes and launches the page again <br />
7. Verify **verticle scroll bar** is added to right corner of the page when user add more than **screen size todo items** <br />
8. Verify todo items with **duplicate names** are also allowed <br />
9. Verify **double click** on list item makes it **editable** and available for changing its values

# Automation of the above scenarios: <br />

<b>Technology used:</b>  C#, MSTest, Selenium, Extent Reports for Logging and Reporting <br />
<b>Design Patterns used:</b> POM, MVC, Single responsibility principle, DRY <br />
<b>Extent Report Output:</b>  <i><project_folder>\ToDoListWebApp\ToDoListWebAppTests\bin\Debug\Test_Execution_Reports</i> <br />
<b>Chrome driver version used:</b> 103.0.5060.53 <br />
<b>Git Hub Repository URL for cloning:</b> https://github.com/viveksingh98/ToDoListWebApp.git <br />
<b>Editor required to run the Automated Test Cases:</b> <a href="https://visualstudio.microsoft.com/vs/older-downloads/"> Microsoft Visual Studio Enterprise 2019</a>

	
 
## Automation Framework Skeletal Structure: <br />
<b>DataModel:</b> <br />
<ul>
	<li>ToDoListWebAppData
		<ul>
			<li>WhatNeedsToBeDoneInputData</li>
	</ul>
	</li>
</ul>
<br />
<b>ProductModel:</b> <br />
<ul>
	<li>ToDoListWebAppPages
		<ul>
			<li>ToDoMVCPage</li>
			<li>WebElements</li>
	</ul>
		</li>
</ul>
<br />
<b>ReportLogger:</b> <br />
<ul>
	<li>ExtentLogger
		<ul>
			<li>ReportLoggerBase</li>
			<li>ReportLogger</li>
	</ul>
		</li>
</ul>
<br />
<b>Functional Tests:</b> <br />
<ul>
	<li>ToDoListWebAppTests
		<ul>
			<li>ToDoMVCTests</li>
			<li>extent-config</li>
	</ul>
		</li>
</ul>
<br />
<b>Ulitlities:</b> <br />
<ul>
	<li>ToDoListWebAppHelpers
		<ul>
			<li>SeleniumHelper</li>
			<li>FrameworkUtility</li>
			<li>PageWebElements</li>
			<li>StepImageContext</li>
			<li>AppConfigManager</li>
	</ul>
		</li>
</ul>

<hr />

## How reporting works
Extent Reports contain two classes: <br />
<ol>
<li>
ExtentReports class </li> <br />
<li>ExtentTest class</li> </ol> <br />

<b>Syntax:</b> <br />
<pre><code>
ExtentReports reports = new ExtentReports("HTML File Path", true/false); <br />

ExtentTest test = reports.startTest("TestName"); <br />
</code></pre>
The ExtentReports class generates reports in HTML format on the path specified by the tester (Index.html). Based on the Boolean flag, the existing reportis either overwritten or a new report is generated. ???True??? is the default value which indicates that current reports will be overwritten. <br />

The ExtentTest class logs test steps onto the previously generated HTML report. <br />

Both classes can be used with the following built-in methods: <br /> <br />
<ol>
<li>startTest: Executes preconditions of a test case </li><br />
<li>endTest: Executes postconditions of a test case </li><br />
<li>Log: Logs the status of each test step onto the HTML report being generated </li><br />
<li>Flush: Erases any previous data on a relevant report and creates a whole new report </li><br /><br />

A Test Status may include following values or more: <br />
<ul>
	<li>PASS </li>
	<li>FAIL </li>
	<li>SKIP </li>
	<li>INFO </li>
</ul> <br />

I have used extent reports by customising it like how i wanted for this assignment: <br />

Here is the derived Report logger class which i customised it as per my requirement - <br />
<pre><code>
namespace ExtentLogger
{
    public class ReportLogger : ReportLoggerBase
    {

        
        public static void FlushExtent()
        {
            try
            {
                //Boolean boolFailFlag = false;
                extent.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured due to - {ex.Message}");
                throw ex;
            }
        }
    }
}
</code>
</pre>
	
<p>with the base class which looks something like this -</p><br />

<pre>
<code>
namespace ExtentLogger
{
    public class ReportLoggerBase
    {
        public static ExtentReports extent;
        public static string dirpath;
        
        public static void ReportLogger(string testcasename)
        {
            try
            {
                extent = new ExtentReports();
                var dir = AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\debug", "");

                Directory.CreateDirectory(dir + @"\Test_Execution_Reports");
                Random rand = new Random();
                string rndno = rand.Next(2000).ToString();
                dirpath = dir + @"\Test_Execution_Reports\Test_Execution_Reports" + "_" + testcasename;

                ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
                htmlReporter.Config.Theme = Theme.Dark;


                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("Host Name", System.Net.Dns.GetHostName());
                extent.AddSystemInfo("User Name", System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured due to - {ex.Message}");
                throw ex;
            }
        }
    }
}
</code>
</pre>

<p>In test cases this is how i made use of my customized extentlogger project:</p><br />

<pre>
<code>
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
	
</code>
</pre>

<p> Test cleanup and assembly cleanup will contain following definitions: </p>
<pre>
<code>
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
</code>
</pre>

<p>And in the test method the function is called like this -<p> <br />

<pre><code>
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
</code></pre>
