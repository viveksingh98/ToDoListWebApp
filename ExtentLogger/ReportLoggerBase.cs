using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.IO;

namespace ExtentLogger
{
    public class ReportLoggerBase
    {
        public static ExtentReports extent;
        public static string dirpath;
        /// <summary>
        /// Extent Logger Configuration
        /// </summary>
        /// <param name="testcasename">Accepts test case name as parameter</param>
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