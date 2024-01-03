# Travel API

#### An application that allows a user to view and write reviews about various travel destinations.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* MySQL
* Swagger

## Description

This application has full CRUD (Create, Read, Update, Delete) functionality, and allows users to GET, POST, PUT, and DELETE reviews about various travel destinations. Users can GET (Read) and POST (Create) reviews about travel destinations. To POST a review, they enter a city, country, message, rating, and their name.

They can also GET reviews by entering a country, city, ID, rating, or by entering a "random" query. A user can also PUT (Edit) and DELETE (Delete) reviews, but only if they wrote them. The "author" name for the review must match the input for the "author" query in the request.

## Setup Instructions

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-1-5-getting-started-with-c/3-0-0-01-welcome-to-c).

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

```
dotnet tool install --global dotnet-ef --version 6.0.0
```

### Set Up and Run Project

1. Select the green button that says "Code", and clone this repository to your desktop.
2. Open the terminal and navigate to this project's production directory called `TravelApi`.
2. Inside this production directory, create two new files: `appsettings.json` and `appsettings.Development.json`.
4. In the `appsettings.json` file, enter the following code. Make sure to replace the `uid` and `pwd` values in the MySQL database connection string with your own username and password for MySQL. For the LearnHowToProgram.com lessons, always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=root;pwd=epicodus;"
  }
}
```

5. In the `appsettings.Development.json` file, add the following code:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

6. Create the database by using the `Migrations` folder in the `TravelApi` production directory. In the `TravelApi` directory, run the command `dotnet ef database update`. This will create the database in MySQL.
    * If you want to create a migration, run the command `dotnet ef migrations add MigrationName`. `MigrationName` is your custom name for the migration and should be written in UpperCamelCase.

## Testing API Endpoints

Within the production directory `TravelApi`, run the command `dotnet watch run` to start making API calls using Swagger. This will automatically direct you to the domain _https://localhost:7245_.

You can also make API calls by using the [Postman](https://www.postman.com/) app, and running the command `dotnet run`. If you make API calls using Postman, use the domain _http://localhost:5063_. The available API endpoints will be shown below.

### Available API Endpoints

These API Endpoint examples use the domain _https://localhost:7245_, which is listed above. You can use the other domain name if you prefer to use Postman.

```
GET http://localhost:7245/api/Reviews/
GET http://localhost:7245/api/Reviews/{id}
POST http://localhost:7245/api/Reviews/
PUT http://localhost:7245/api/Reviews/{id}
DELETE http://localhost:7245/api/Reviews/{id}
```

Note: `{id}` is a variable and should be replaced with the id number of the review that you want to GET, PUT, or DELETE. The id will be automatically created when you POST a review.