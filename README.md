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

* _Clone or download this repository located at https://github.com/HBeinstein/BakedGoods.Solution_
* _TO CREATE DATABASE: Run $ dotnet ef database update in your root directory._
* _Run $ dotnet restore in your root directory to download all dev dependencies._
* _Run $ dotnet run in your root directory to create project._

## Known Bugs

_No known bugs_

## Support and contact details

_{Please contact me at with any known bugs or support issues.}_

## Technologies Used

* _GitHub_
* _C#_

### License

*Copyright (c) 2020 **_Hannah Beinstein MIT License_**