# OppFI_TakeHome

Extensions to be added: To add extension, go to menu `Extensions --> Manage Extensions ---> online` and search for the extension you wish to add.
NUnit3 Test Adapter and Specflow For Visual Studio 2019.

The second step is to restore Nuget Packages by `right clicking on OppFI_TakeHomeTask.sln and Restore Nuget` so it can restore all dependecies.

## Framework Description:
The project framework consists of 4 folders Features, StepDefs, Models, and Utilities.

## Features:
Contains all the specflow feature files. There is one feature file `LoanRequest.feature`.
The feature file which is written in Gherkin language has a detailed step on how to reproduce the test.

## StepDefs:
Contains 1 step definitions file, LoanRequestSteps. This contains feature implementation from the feature files.

## Models:
This folder contains 1 file, LoanRequestModal. This class contains models (deserialized objects) for base 'CreateLoanRequest' request.
#Utilities:
This has all the helper methods that are used throughout the project. It contains EncryptionHelper, EnvironmentManager, EnvironmentConfig, and RestHelper. 
EncryptionUtilities folder has EncryptionHelper class that contains methods to encrypt and decrypt data. It used to encrypt sensitive information to avoid pushing credentials to repo in plain text leaving it vulnerable.
CreateLoanRequest class creates quote requests with several different payload types.

## test.runsettings:
It is present at the project level folder. It contains all the information about the environment and parameters that will be used during the run. The file should be selected under Test>ConfigureRunSettings>test.runsettings file

![image](https://user-images.githubusercontent.com/78940196/194466383-fc201298-f5b2-45ff-ab75-b5bbbea7743e.png)



## How to Run the test cases:
 1. First thing to run the application is to insert the Encryption key to decrypt API Key which will be sent with the project.
 1. Build the solution. Make sure the build is successful.
 2. Open Test Explorer. Test>Test Explorer. Filter by traits.
 3. Open test.runsettings file and set/update the environment to run the test against. Note: If this step is skipped, running the case in the next step wont find any case and will result in failure.
 4. Right Click on a test and click Run.
