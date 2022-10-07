using OppFI_Task.StepDefinitions;
using RestSharp;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static OppFI_Task.Modal.LoanRequestModal;

namespace OppFI_Task.Utilties
{
    class RestHelper
    {
        EnvironmentManager EnvManager = new EnvironmentManager();
        public static RestResponse SendPOSTRequest(BaseLoanRequest quoteJson)
        {
            RestClient client = new RestClient(EnvironmentManager.CurrentEnvironment.TargetURL);
            RestRequest request = new RestRequest("/offer", Method.Post);
            request.AddHeader("x-api-key", EnvironmentManager.CurrentEnvironment.APIKey);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(quoteJson);
            RestResponse response =  client.Execute(request);
            return response;
        }

        public static RestResponse SendPOSTRequest(BaseLoanRequest quoteJson, string APIKey)
        {
            RestClient client = new RestClient(EnvironmentManager.CurrentEnvironment.TargetURL);
            RestRequest request = new RestRequest("/offer", Method.Post);
            request.AddHeader("x-api-key", APIKey);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(quoteJson);
            RestResponse response = client.Execute(request);
            return response;
        }

        public static Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }
            return dictionary;
        }
    }
}
