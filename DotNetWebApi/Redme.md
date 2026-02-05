# DotNetWebApi

I spend most of my time with JavaScript/TypeScript, Node.js, Java, and Spring Boot. Here I am trying C# and .NET 10 to understand the ecosystem and test my fundamentals.

## Setup

I am on Debian 13 with XFCE

Install .NET 10 SDK:
https://learn.microsoft.com/en-us/dotnet/core/install/linux-debian?tabs=dotnet10

.NET CLI overview:
https://learn.microsoft.com/en-us/dotnet/core/tools/

VS Code C# tools:
https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp

## Run the Project

From the solution root:

```
dotnet run --project DotNetWebApi
```

Or from the project folder:

```
dotnet run
```

The terminal prints the local URL (example: http://localhost:5087).

## Endpoints

- GET /weatherforecast

This endpoint returns JSON with sample weather data.

## Notes

- `bin/` and `obj/` are not in git because they are generated on build.
- Keep secrets out of the repo. Use local settings or environment variables.
