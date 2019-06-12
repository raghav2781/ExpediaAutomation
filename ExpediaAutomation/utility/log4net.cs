using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ExpediaAutomation.utility
{
    class Log4net
    {

       public static  ILog logger = LogManager.GetLogger("Task");
       public static void Log4Net() {
            FileInfo fi = new FileInfo("log.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            log4net.GlobalContext.Properties["host"] = Environment.MachineName;
        }
    }
}
