using System;

namespace MWatcher.Core.Helper
{
    public class GlobalProcs
    {
        public static void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch(Exception ex) 
            {
                var JsonText = Newtonsoft.Json.JsonConvert.SerializeObject(ex);
               // nLogger.Log(NLog.LogLevel.Error, jsonText);
            }
        }
    }
}
