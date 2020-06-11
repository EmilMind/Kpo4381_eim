using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.eim.Utility;

namespace Kpo4381.eim.Lib
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        public static string logPath
        {
            get { return _logPath; }
        }

        private static string _dataFileName;
        public static string dataFileName
        {
            get { return _dataFileName; }
        }
                
        public static void Initialize()
        {
            AppConfigUtility appConfigUtility = new AppConfigUtility();
            _logPath = appConfigUtility.AppSettings("logPath");
            _dataFileName = appConfigUtility.AppSettings("dataFileName");
        }
    }
}
