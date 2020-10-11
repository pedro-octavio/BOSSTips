# BOSSTIPS
An application to control game tips, more focused on bosses.
## PREREQUESITES
* [.Net Core](https://dotnet.microsoft.com/download);
* Some Database, in this case as using [MySql](https://www.mysql.com);
## CONFIGURING THE PROJECT
1) Install necessary packges:
> Executing the "Restore NuGet Packges" in Visual Studio, or dotnet restore in root directory
2) Insert your connectionstring in BOSSTips.API/appsettings.Development.json
3) Update database using this command:
> Visual Studio: Update-Database
> Some text editor: dotnet ef database update
4) Run the BUYList.API;
## MAKE WITH
* .Net Core
* Automapper
* EntityFramework
* Autofac
* Mediator
* MySql
## VERSIONS
* 1.0.0 - First Commit;
## CONTRIBUITORS
* [**Pedro Octávio**](https://github.com/pedro-octavio) - *desenvolviment of project*
