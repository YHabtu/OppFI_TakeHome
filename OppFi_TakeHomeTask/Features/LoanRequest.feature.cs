﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OppFi_TakeHomeTask.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LoanRequest")]
    public partial class LoanRequestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "LoanRequest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "LoanRequest", "\tThis test covers where users send Loan request and Gets accepted or declined.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Send Post request to offer endpoint where request got accpeted")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public void SendPostRequestToOfferEndpointWhereRequestGotAccpeted()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send Post request to offer endpoint where request got accpeted", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "attribute",
                            "value"});
                table1.AddRow(new string[] {
                            "socialSecurityNumber",
                            "123456780"});
                table1.AddRow(new string[] {
                            "stateCode",
                            "FL"});
                table1.AddRow(new string[] {
                            "grossMonthlyIncome",
                            "100000"});
                table1.AddRow(new string[] {
                            "requestedLoanAmount",
                            "4000"});
                table1.AddRow(new string[] {
                            "leadOfferId",
                            "kgj25sdd2"});
                table1.AddRow(new string[] {
                            "email",
                            "test@example.com"});
#line 6
 testRunner.Given("user creates request body using the following info", ((string)(null)), table1, "Given ");
#line hidden
#line 14
 testRunner.When("user send POST request to offer endpoint with valid APIkey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("verify status code is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.Then("verify the correct response body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Send Post request to offer endpoint where request got declined")]
        [NUnit.Framework.CategoryAttribute("Negative")]
        public void SendPostRequestToOfferEndpointWhereRequestGotDeclined()
        {
            string[] tagsOfScenario = new string[] {
                    "Negative"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send Post request to offer endpoint where request got declined", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "attribute",
                            "value"});
                table2.AddRow(new string[] {
                            "socialSecurityNumber",
                            "123450000"});
                table2.AddRow(new string[] {
                            "stateCode",
                            "IL"});
                table2.AddRow(new string[] {
                            "grossMonthlyIncome",
                            "2800"});
                table2.AddRow(new string[] {
                            "requestedLoanAmount",
                            "4000"});
                table2.AddRow(new string[] {
                            "leadOfferId",
                            "kgj25sdd2"});
                table2.AddRow(new string[] {
                            "email",
                            "test@example.com"});
#line 20
 testRunner.Given("user creates request body using the following info", ((string)(null)), table2, "Given ");
#line hidden
#line 28
 testRunner.When("user send POST request to offer endpoint with valid APIkey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("verify status code is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.Then("verify the declined correct response body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Send request with missing required field")]
        [NUnit.Framework.CategoryAttribute("MissingField")]
        public void SendRequestWithMissingRequiredField()
        {
            string[] tagsOfScenario = new string[] {
                    "MissingField"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send request with missing required field", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 34
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "attribute",
                            "value"});
                table3.AddRow(new string[] {
                            "socialSecurityNumber",
                            "123450000"});
                table3.AddRow(new string[] {
                            "stateCode",
                            "IL"});
                table3.AddRow(new string[] {
                            "grossMonthlyIncome",
                            "2800"});
                table3.AddRow(new string[] {
                            "requestedLoanAmount",
                            "4000"});
                table3.AddRow(new string[] {
                            "leadOfferId",
                            "kgj25sdd2"});
                table3.AddRow(new string[] {
                            "email",
                            "test@example.com"});
#line 35
 testRunner.Given("user creates request body using the following info", ((string)(null)), table3, "Given ");
#line hidden
#line 43
 testRunner.When("user send POST request to offer endpoint with invalid APIkey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("verify status code is 403", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.And("error message is \"Valid API Key required\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Send request with missing required data")]
        [NUnit.Framework.CategoryAttribute("MissingField")]
        public void SendRequestWithMissingRequiredData()
        {
            string[] tagsOfScenario = new string[] {
                    "MissingField"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send request with missing required data", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "attribute",
                            "value"});
                table4.AddRow(new string[] {
                            "socialSecurityNumber",
                            "\"\""});
                table4.AddRow(new string[] {
                            "stateCode",
                            "\"\""});
                table4.AddRow(new string[] {
                            "grossMonthlyIncome",
                            "\"\""});
                table4.AddRow(new string[] {
                            "requestedLoanAmount",
                            "\"\""});
                table4.AddRow(new string[] {
                            "leadOfferId",
                            "\"\""});
                table4.AddRow(new string[] {
                            "email",
                            "test@example.com"});
#line 50
 testRunner.Given("user creates request body using the following info", ((string)(null)), table4, "Given ");
#line hidden
#line 58
 testRunner.When("user send POST request to offer endpoint with valid APIkey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.Then("verify status code is 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.Then("verify the declined correct response body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
