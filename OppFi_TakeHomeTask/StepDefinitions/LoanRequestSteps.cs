using Newtonsoft.Json;
using NUnit.Framework;
using OppFI_Task.Modal;
using OppFI_Task.Utilties;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static OppFI_Task.Modal.LoanRequestModal;

namespace OppFI_Task.StepDefinitions
{
    [Binding]
    public class LoanRequestSteps
    {
        BaseLoanRequest BaseRequest;
        BaseResponse responseBody;
        RestResponse response;


        [Given(@"user creates request body using the following info")]
        public void GivenUserCreatesRequestBodyUsingTheFollowingInfo(Table table)
        {
            BaseLoanRequest createReaquest = table.CreateInstance<BaseLoanRequest>();
            BaseRequest = CreateRequest.CreateRequestToPost(createReaquest.socialSecurityNumber, createReaquest.stateCode, createReaquest.grossMonthlyIncome,
                createReaquest.requestedLoanAmount, createReaquest.leadOfferId, createReaquest.email);
        }

        [When(@"user send POST request to offer endpoint with valid APIkey")]
        public void WhenUserSendPOSTRequestToOfferEndpointWithValidAPIkey()
        {
            response = RestHelper.SendPOSTRequest(BaseRequest);
            responseBody = JsonConvert.DeserializeObject<BaseResponse>(response.Content.ToString());
        }

        [Then(@"verify status code is (.*)")]
        public void ThenVerifyStatusCodeIs(int expectedStatusCode)
        {
            HttpStatusCode statusCode = response.StatusCode;
            int actualResponseCode = (int)statusCode;
            Console.WriteLine("Response code : " + actualResponseCode);
            Console.WriteLine("Response ----->>>>>>>: " + response.Content);
            Assert.AreEqual(expectedStatusCode, actualResponseCode, "Status code is: " + actualResponseCode);
        }

        [Then(@"verify the correct response body")]
        public void ThenVerifyTheCorrectResponseBody()
        {
            Assert.Multiple(() =>
            {
                Assert.That(responseBody.accepted.Equals(true), "Loan Request is "+responseBody.accepted);
                Assert.That(responseBody.status.Equals("APPROVED"), "Loan request was not approved "+responseBody.status);
                Assert.That(responseBody.offers[0].description.Equals("Because you deserve more than a payday loan!"), "response body is "+ responseBody.offers[0].description);
                Assert.That(responseBody.offers[0].term.Equals(10), "term is not equal to "+ responseBody.offers[0].term);
            });
        }

        [Then(@"verify the declined correct response body")]
        public void ThenVerifyTheDeclinedCorrectResponseBody()
        {
            Assert.Multiple(() =>
            {
                Assert.That(responseBody.accepted.Equals(false), "Loan Request is " + responseBody.accepted);
                Assert.That(responseBody.status.Equals("DECLINED"), "Loan request was not approved " + responseBody.status);
            });
        }


        [When(@"user send POST request to offer endpoint with invalid APIkey")]
        public void WhenUserSendPOSTRequestToOfferEndpointWithInvalidAPIkey()
        {
            response = RestHelper.SendPOSTRequest(BaseRequest, "1234567890000");
        }

        [Then(@"error message is ""(.*)""")]
        public void ThenErrorMessageIs(string errorMessage)
        {
            Assert.AreEqual(response.Content, errorMessage);
        }







    }
}
