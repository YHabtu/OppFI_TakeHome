using System.Collections.Generic;
using static OppFI_Task.Modal.LoanRequestModal;

namespace OppFI_Task.Modal
{
    public class LoanRequestModal
    {

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string zip { get; set; }
            public string countryCode { get; set; }
        }

        public class BankInfo
        {
            public string bankName { get; set; }
            public string abaRoutingNumber { get; set; }
            public string accountNumber { get; set; }
            public int accountType { get; set; }
            public int accountLength { get; set; }
        }

        public class EmploymentInfo
        {
            public string employerName { get; set; }
            public string hireDate { get; set; }
        }

        public class IncomeInfo
        {
            public string incomeType { get; set; }
            public string payrollType { get; set; }
            public int payrollFrequency { get; set; }
            public string lastPayrollDate { get; set; }
        }

        public class PersonalInfo
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string dateOfBirth { get; set; }
            public Address address { get; set; }
            public string mobilePhone { get; set; }
            public string homePhone { get; set; }
        }

        public class BaseLoanRequest
        {
            public bool isProduction { get; set; }
            public string language { get; set; }
            public string currency { get; set; }
            public string campaignId { get; set; }
            public string socialSecurityNumber { get; set; }
            public string leadOfferId { get; set; }
            public string email { get; set; }
            public string stateCode { get; set; }
            public int grossMonthlyIncome { get; set; }
            public PersonalInfo personalInfo { get; set; }
            public BankInfo bankInfo { get; set; }
            public IncomeInfo incomeInfo { get; set; }
            public EmploymentInfo employmentInfo { get; set; }
            public int requestedLoanAmount { get; set; }
        }


    }

    public class Offer
    {
        public string url { get; set; }
        public int term { get; set; }
        public int monthlyPayment { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public int interestRate { get; set; }
        public string description { get; set; }
        public double representativeAPR { get; set; }
    }

    public class BaseResponse
    {
        public BaseLoanRequest request { get; set; }
        public bool accepted { get; set; }
        public int partnerId { get; set; }
        public string reference_id { get; set; }
        public int code { get; set; }
        public string status { get; set; }
        public string apiVersion { get; set; }
        public List<Offer> offers { get; set; }
    }
}
