using System;
using System.IO;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace ExtentLogger
{
    public class ReportLogger : ReportLoggerBase
    {


        /// <summary>
        /// Flushes the Extent Report context
        /// </summary>
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
