using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System.IO;
using NLog;
using OppFI_Task.StepDefinitions;

namespace EchoRestAPI.Steps
{
    [Binding]
    class Hooks
    {

        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extentReport;
        private static ExtentHtmlReporter htmlReporter;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            string filepath = TestContext.CurrentContext.WorkDirectory + "\\TestResult\\";
            htmlReporter = new ExtentHtmlReporter(filepath + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".html");
            extentReport = new ExtentReports();
            extentReport.AddSystemInfo("Environment", TestContext.Parameters["Environment"]);
            extentReport.AttachReporter(htmlReporter);
            EnvironmentManager.GetEnvironment(TestContext.Parameters["Environment"]);


            logger.Info("******************************************");
            logger.Info("\nNew Test Cycle :");
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            logger.Info("[Feature] : {0}", featureContext.FeatureInfo.Title);
            featureName = extentReport.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }



        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            logger.Info("[Scenario] : {0}", scenarioContext.ScenarioInfo.Title);
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);

        }


        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            var stepStatus = scenarioContext.ScenarioExecutionStatus.ToString();


            if (stepStatus == "OK")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);

                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "But")
                    scenario.CreateNode<But>(ScenarioStepContext.Current.StepInfo.Text);

                logger.Info("[Step passed]: " + ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (stepStatus == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "But")
                    scenario.CreateNode<But>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

                logger.Warn("[Step not implemented]: " + ScenarioStepContext.Current.StepInfo.Text);

            }
            else if (stepStatus == "TestError")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail("Message: " + scenarioContext.TestError.Message);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail("Message: " + scenarioContext.TestError.Message);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail("Message: " + scenarioContext.TestError.Message);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail("Message: " + scenarioContext.TestError.Message);
                else if (stepType == "But")
                    scenario.CreateNode<But>(ScenarioStepContext.Current.StepInfo.Text).Fail("Message: " + scenarioContext.TestError.Message);

                logger.Error("[Step Failed]: " + ScenarioStepContext.Current.StepInfo.Text + "[Error message: ]" + scenarioContext.TestError.Message
                    + "[Stack trace: ]" + scenarioContext.TestError.StackTrace);
            }
        }

        [AfterScenario]
        public static void AfterScenario(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            logger.Info("[Scenario Finished] : {0}", scenarioContext.ScenarioInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            logger.Info("[Feature Completed] : {0}", FeatureContext.Current.FeatureInfo.Title);
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            logger.Info("******************************************");
            logger.Info("\nTest Run Complete");
            logger.Info("******************************************");
            extentReport.Flush();
        }

    }
}

