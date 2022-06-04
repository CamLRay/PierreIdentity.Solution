# Pierre's Sweet & Savory Treats

#### By **Cameron Ray**

#### An Authenticated and Authorized MVC application

## Technologies Used

* C#
* .NET 5.0
* ASP.Net Core
* Entity Framework Core
* ASP.Net Core Identity
* Razor
* MySQL
* HTML
* CSS

## Description
A showcase of ASP.Net Core Identity for an MVC web application with Many-to-many relationships. Pierre's Sweet & Savory Treats has full CRUD behavior for authorized users(anyone signed in), and read only capabilities for anonymous users.

## Setup/Installation Requirements

* Requires MySQL for the database
* Clone the repository
* navigate to PierreIdentity.Solution
* Create an appsettings.json file in the root of the PierreIdentity folder.
```
$ cd PierreIdentity/
$ touch appsettings.json
```
* Add the following to the appsettings.json file with the bracketed username and password replaced with your mysql username and password.
```JSON
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=cameron_ray;uid=[username];pwd=[password];"
  }
}
```
* restore and build the project
```
$ dotnet restore
$ dotnet build
```
* import the database located in the root of PierreIdentity.Solution using MySQL Workbench. 
1. From the Navigator section click the Administration tab at the bottom of the section.
2. Click Data Import/Restore and select "Import from Self-Contained File."
3. select the path to import from. In this case it should be the clonedlocation/PierreIdentity.Solution/cameron_ray.sql

* alternatively run the following command in the terminal to build a database for running the app.
```
$ dotnet ef database update
```
* start the project fomr the PierreIdentity directory using
```
$ dotnet run
```
* open `http://localhost:5000` in the browser to try it out.

## Known Bugs
* No known bugs, feel free to contact me here if any are found.

## License

[MIT](LICENSE)

Copyright (c) June 2022 Cameron Ray