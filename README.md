# web API with ASP.NET Core

Create a RESTful service with ASP.NET Core that supports Create, Read, Update, Delete (CRUD) operations.

## Prerequisites
Local installations of the [.NET SDK](https://dotnet.microsoft.com/download). 

## Usage

```c#
dotnet run
```
On Platform for API Development (Postman, for example), you can use: 
```c ​
// Used to creat a new record.
POST {string Name, bool IsGlutenFree}

// Used to return records on database.
GET {Id}

// Used to delete a record.
Delete {Id}
```

## Microsoft Course
[Create a web API with ASP.NET Core](https://docs.microsoft.com/en-us/learn/modules/build-web-api-aspnet-core/?WT.mc_id=docs-dotnet-learn)
