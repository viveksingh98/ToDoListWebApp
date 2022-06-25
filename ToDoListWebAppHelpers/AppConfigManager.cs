using System;
using System.Configuration;

namespace ToDoListWebAppHelpers
{
    public class AppConfigManager
    {
      public static String GetBrowserConfigForKey(String key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
