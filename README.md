# Baked Goods Tracker

#### _A .NET Core MVC App to track baked goods and their flavors including authentication, 7/14/2020_

#### By _**Hannah Beinstein**_

## Description

_This project is an program created to practice MVC web app design, many-to-many relationships, and authentication using Identity. The program contains two classes, one for Flavors and one for Pastries. The program can display a list of flavors and their associated pastries, a list of pastries and their associated flavors, and also includes functionality to add and remove both flavors and pastries. A user can view a list of all current pastries and flavors from the project home-page, but must register and log in to access any other CRUD methods._

## Specs

| Spec | Input | Output |
| :-------------      | :------------- | :------------- |
| 1. Program will display an error message if no pastries have been added to database | -- | "No pastries have been added yet!" |
| 2. Program will display an error message if no flavors have been added to database | -- | "No flavors have been added yet!" |
| 3. Program will add new pastry type to database | "add pastry type" | "Baguette" |
| 4. Program will add new flavor to database | "add flavor" | "Cheddar" |
| 5. Program will display a list of all pastry types | -- | "Baguette, Bagel, Scone, Muffin" |
| 6. Program will display a list of all flavors | -- | "Cheddar, Berry, Plain, Maple" |
| 7. Program will display a list of all flavors belonging to a pastry type | Pastry Types: "Bagel" | Flavors: "Blueberry, Maple, Plain" |
| 8. Program will display a list of all pastry types belonging to a flavor| Flavors: "Blueberry" | Pastry Types: "Bagel, Scone, Muffin" |

## Setup/Installation Requirements
```
* Make sure you have .NET Core installed. If you don't, it can be found here https://dotnet.microsoft.com/download/dotnet-core/2.2
* Mac users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484914
* Windows users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484919
```

* _Clone or download this repository located at https://github.com/HBeinstein/BakedGoods.Solution_
* _TO CREATE DATABASE: Navigate to appsettings.json and replace "YOURDBNAMEHERE" with the name of your database, and "YOURPWDHERE" with the the password you use for SQL (or any other DB program). Run $ dotnet ef database update in your root directory to create your database._
* _Run $ dotnet restore in your root directory to download all dev dependencies._
* _Run $ dotnet run in your root directory to build project and launch server._
* _Open your server in your browser of choice_

## Technologies Used

* _EFC_
* _C#_
* ASP.NET Core

### License

*Copyright (c) 2020 **_Hannah Beinstein MIT License_**