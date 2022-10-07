
using NUnit.Framework;

namespace OppFI_Task.Utilties
{
    public class EnvConfig
    {
        
        public static string TargetURL = TestContext.Parameters["TargetURL"];
        public static string APIKey = TestContext.Parameters["APIKey"];

    }
}
