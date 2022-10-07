using Microsoft.Extensions.Configuration;
using OppFI_Task.Utilties;
using System;

namespace OppFI_Task.StepDefinitions
{
    public class EnvironmentManager
    {
        public string APIKey;
        public string TargetURL;

        public static EnvironmentManager CurrentEnvironment;
        public static EnvironmentManager EnvironmentQa1()
        {
            return new EnvironmentManager()
            {
                TargetURL = EnvConfig.TargetURL,
                APIKey = EncryptionHelper.Decrypt(EnvConfig.APIKey)          
            };

        }

       public static EnvironmentManager GetEnvironment(string aEnvironmentName)
        {
            EnvironmentManager result; 
            switch (aEnvironmentName.Trim().ToUpper())
            {
                case "DEV1":
                    result = EnvironmentQa1();
                    break;
                case "QA1":
                    result = EnvironmentQa1();
                    break;
                case "PROD":
                    result = EnvironmentQa1();
                    break;
                default:
                    throw new Exception(aEnvironmentName + "Invalid String, unable to select environment");
            }
                CurrentEnvironment = result;
                return result;
        }
    }
}


