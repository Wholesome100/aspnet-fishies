# ASP.NET Fishies

This is a small project to get familiar with **C#**, **ASP.NET Core**, **Entity Framework Core**, and **PostgreSQL** (via [Neon](https://neon.tech)).

This backend exposes a REST API allowing users to create, read, update and delete records revolving around fish.

---

## Prerequisites
Before running this project, you’ll need:

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download)
- A free [Neon](https://neon.tech) Postgres account
- Your Neon **connection string** (from the Neon dashboard)

## Environment
Clone the project into Visual Studio Community 2022.

## .NET User Secrets
This project uses the [.NET Secret Manager](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets) to keep credentials safe.

Within your Neon account, make a new database and copy the connection string. 
Your string will look similar to this: `Host=ep-xxx.us-east-2.aws.neon.tech;Database=neondb;Username=neonuser;Password=yourpassword;SSL Mode=Require`

Take this string and run the following commands within the Visual Studio 2022 developer console:
`dotnet user-secrets init`
`dotnet user-secrets set "ConnectionStrings:DefaultConnection" "YOUR_CONNECTION_STRING"`

## Running the App
With the connection string set in user-secrets, set the build target to https from the dropdown next to the solid green play icon in Visual Studio.
Run the application from this button and use the https: url in the console for reference.


## Endpoints

### GET Endpoints

These can all be accessed from the browser by typing the URL into the search bar or by using curl commands.

### POST, PUT, DELETE Endpoints

The easiest way to test these is with curl. Simply change <PORT> to the port number the app is running on locally, and paste the command into the terminal:

**POST**
`curl -X POST https://localhost:<PORT>/fish \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Barramundi",
    "scientificName": "Lates calcarifer",
    "description": "A tropical fish prized for its mild flavor.",
    "habitat": "Saltwater",
    "location": "Northern Australia",
    "status": "LeastConcern",
    "averageWeightKg": 3.2,
    "marketValue": 18.0,
    "seasonality": "Spring",
    "imageUrl": "https://example.com/barramundi.jpg",
    "lastUpdated": "2025-09-01T10:59:00Z"
  }' -k
`

**PUT**
`
curl -X PUT https://localhost:<PORT>/fish/1 \
  -H "Content-Type: application/json" \
  -d '{
    "id": 1,
    "name": "Atlantic Salmon",
    "scientificName": "Salmo salar",
    "description": "Updated description for Atlantic Salmon.",
    "habitat": "Saltwater",
    "location": "North Atlantic Ocean",
    "status": "LeastConcern",
    "averageWeightKg": 4.8,
    "marketValue": 17.0,
    "seasonality": "Spring-Summer",
    "imageUrl": "https://example.com/salmon.jpg",
    "lastUpdated": "2025-09-01T16:09:00Z"
  }' -k
`

**DELETE**
`curl -X DELETE https://localhost:<PORT>/fish/1 -k`
