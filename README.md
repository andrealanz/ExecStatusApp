# WWT Automation Team ExecStatusApp

### Author: Andrea Lanz

A project that contains the code for an AZURE App found at: <https://execstatusapp.azurewebsites.net>. This project creates and defines an API for a RESTful web app, which is deployed through AZURE app services. Note that the app interacts with a SQL Server database to store data related to the execution status of programs run by WWT's USACE Automation Team. Currently, the database contains one table to store data for execution status. The fields of the table are as follows:
  | **Field** | **Type** | **Description** |
  |-----------|----------|-----------------|
  | Id | String | The primary key of the table, represented as the time of execution in epoch time |
  | Time | DateTime | The time of execution in UTC |
  | AppName | String | Name of the application |
  | SourceMachine | string | The machine the program was run on |
  | Task | string | The type of activity |
  | Status | int | The status code |
  | prop1 | int | An additional property |
  | prop2 | int | An additional property |
  | prop3 | int | An additional property |
  
The basic URL endpoint for the API depends on the type of request and are in the following form:
* 'api/ExecStats' - (GET, POST)
* 'api/ExecStats/{id}' - (GET by id, PUT, DELETE)
* 'api/ExecStatsActivity/{task}' - (GET by task)

More information about how to call the API defined by this project can be found at <https://execstatusapp.azurewebsites.net/Help>. Example interaction with this API in three different languages (C#, PowerShell, and Python) can be found at <https://github.com/andrealanz/ExecStatusAppAPI>.
