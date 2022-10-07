using static OppFI_Task.Modal.LoanRequestModal;

namespace OppFI_Task.Modal
{
    public class CreateRequest
    {
        public static BaseLoanRequest CreateRequestToPost(string aSocialSecurityNumber, string astateCode, int GrossMonthlyIncome, int RequestedAmount, string leadOffId, string aEmail)
        {
            var quoteJson = new BaseLoanRequest
            {
                isProduction = false,
                language = "en",
                currency = "USD",
                campaignId = "11-50-newhope",
                leadOfferId = leadOffId,
                email = aEmail,
                stateCode = astateCode,
                socialSecurityNumber = aSocialSecurityNumber,
                grossMonthlyIncome = GrossMonthlyIncome,

                personalInfo = new PersonalInfo
                {
                    firstName = "Jennifer",
                    lastName = "Smith",
                    dateOfBirth = "19451009",
                    mobilePhone = "3224340098",
                    homePhone = "4523452232",
                    address = new Address
                    {
                        streetAddress = "123 Main Street",
                        city = "Miami",
                        zip = "33125",
                        countryCode = "US"
                    }

                },
                bankInfo = new BankInfo
                {
                    bankName = "Chase",
                    abaRoutingNumber = "123456789",
                    accountNumber = "012345789",
                    accountType = 1,
                    accountLength = 6,
                },
                incomeInfo = new IncomeInfo
                {
                    incomeType = "Employment",
                    payrollType = "DirectDeposit",
                    payrollFrequency = 1,
                    lastPayrollDate = "20160915",
                },

                employmentInfo = new EmploymentInfo
                {
                    employerName = "ToysRUs",
                    hireDate = "20110516",
                },

                requestedLoanAmount = RequestedAmount
            };
            return quoteJson;
        }
    }
}
