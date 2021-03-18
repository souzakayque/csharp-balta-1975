Useful commands to create the project step by step:

Create the folders with the following command in the terminal: 
 - md PaynentContext.Domain
 - md PaynentContext.Shared
 - md PaymentContext.Tests

Create the sln in the root path:
 - dotnet new sln

Enter in each folder and run the following command to transform the folder in Class Library
 - dotnet new classLib

Enter in Tests folder to transform this one in a MSTest
 - dotnet new mstest

Add the sln in each project, run the command in the root path:
 - dotnet sln add PaymentContext.Domain/PaymentContext.Domain.csproj
 - dotnet sln add PaymentContext.Shared/PaymentContext.Shared.csproj
 - dotnet sln add PaymentContext.Tests/PaymentContext.Tests.csproj

Restore the nugets package:
 - dotnet restore
 - dotnet clean
 - dotnet build

Add the reference as needed:
 - dotnet add reference ..\PaymentContext.Shared\PaymentContext.Shared.csproj

Add the Flunt nuget package in the needed project (Shared as below example):
 - cd PaymentContext.Shared
 - dotnet add package flunt;

Run the tests into Test Context
 - dotnet test