# Travel API

#### An application that allows a user to view and write reviews about various travel destinations.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* MySQL

## Description

<!-- This application has full CRUD (Create, Read, Update, Delete) functionality, and allows users to GET, POST, PUT, and DELETE reviews about various travel destinations. Users can GET (Read) and POST (Create) reviews about travel destinations. To POST a review, they enter a city, country, message, rating, and their name.

They can also GET reviews by entering a country, city, ID, rating, or by entering a "random" query. A user can also PUT (Edit) and DELETE (Delete) reviews, but only if they wrote them. The "author" name for the review must match the input for the "author" query in the request. -->

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
3. Inside this production directory, create two new files: `appsettings.json` and `appsettings.Development.json`.
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
GET http://localhost:7245/api/reviews/
GET http://localhost:7245/api/reviews/{id}
POST http://localhost:7245/api/reviews/
PUT http://localhost:7245/api/reviews/{id}
DELETE http://localhost:7245/api/reviews/{id}
```

Note: `{id}` is a variable and should be replaced with the id number of the review that you want to GET, PUT, or DELETE. The id will be automatically created when you POST a review.

#### Optional Query String Parameters for GET Request

GET requests to `http://localhost:7245/api/reviews/` can optionally include query strings to filter reviews by different criteria.

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| city    | String      | not required | Returns reviews with a matching city value. |
| country        | String      | not required | Returns reviews with a matching country value. |
| rating  | Number      | not required | Returns reviews that have a rating value that is greater than or equal to the specified rating value. Sorts filtered reviews from highest rated to lowest. |
| random    | String      | not required | Returns a single random review. |
| pageNumber       | Number      | not required | Returns five reviews from a specified page number. |

The following query will return all reviews with a city value of "Dublin":

```
GET http://localhost:7245/api/reviews?city=dublin
```

The following query will return all reviews with a country value of "Tunisia":

```
GET http://localhost:7245/api/reviews?country=tunisia
```

The following query will return all reviews with a rating of 7 and higher (ratings can only be from 0 to 10):

```
GET http://localhost:7245/api/reviews?rating=7
```

The following query will return a single random review:

```
GET http://localhost:7245/api/reviews?random=random
```

The following query will return five reviews from page three of the reviews list:

```
GET http://localhost:7245/api/reviews?pageNumber=3
```

You can include multiple query strings by separating them with an `&`:

```
GET http://localhost:7245/api/reviews?country=tunisia&rating=7
```

#### Additional Requirements for POST Request

When making a POST request to `http://localhost:7245/api/reviews/`, your request needs to include a "body". Example below:

```json
{
  "city": "Cairo",
  "country": "Egypt",
  "message": "Historic and hot!",
  "rating": 8,
  "author": "Christopher"
}
```

#### Additional Requirements for PUT Request

PUT requests can only be made if the review was written by the person who wrote it. In other words, the author's name in the query must match the `author` property in the review.

When making a PUT request such as `http://localhost:7245/api/reviews/{id}?author=Christopher`, your request needs to include a "body" that includes the review's `reviewId` property, and the review's `author` property. Example below:

```json
{
  "reviewId": 1,
  "city": "Cape Town",
  "country": "South Africa",
  "message": "Warm, beautiful and great beaches!",
  "rating": 10,
  "author": "Christopher"
}
```

#### Additional Requirements for DELETE Request

Just like PUT requests, DELETE requests can only be made if the review was written by the person who wrote it. In other words, the author's name in the query must match the `author` property in the review. The `reviewId` property must match as well.

For example, making a DELETE request such as `http://localhost:7245/api/reviews/{id}?author=Christopher` will successfully delete a review, as long as the id and author name match the values for the review's id and author properties.

## Known Bugs

None.

## License

MIT

Copyright(c) 2024 Brian Scherner



