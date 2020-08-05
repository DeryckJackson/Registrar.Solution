# <h1 align = "center"> Registrar

## <h3 align = "center"> Entity Framework in ASP.NET MVC, 8.4.20

## <h2 align = "center"> About

<p align = "center"> This is an application for a university registrar.

## **✅REQUIREMENTS**
* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)

## **💻SETUP**
* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* in MySql Workbench select _Data Import/Restore_ from the Administration tab
* in import options select _Import from Self-Contained File_, and navigate to registrar.sql in the root directory of this project
* The following is the code snippet from the registrar.sql file <br>

CREATE DATABASE  IF NOT EXISTS `registrar`;
USE `registrar`;

DROP TABLE IF EXISTS `clients`;
CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `ClientPhone` int DEFAULT NULL,
  `StylistId` int DEFAULT '0',
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `stylists`;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Details` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
* click _Start Import_
* in your code editor create a .gitignore file and store the bin and obj folders in .gitignore
* navigate to the HairSalon directory and type dotnet build in the command line to compile the code
* type dotnet run in the command line to run the program
__

## Specs

| Behavior    | Input | Output |
| :---------- | ----- | -----: |
| Program can create a student object | none | none |
| Student object holds student name and date of enrollment | none | none |
| Program can create a Course object | none | none |
| Course object holds course name and number | none | none |
| Student => Course reflect many to many relationship | none | none |


Departments, Departments => students, Department => course

## Known Bugs

_No known bugs_

## **❤️Contributors**
* Ian Scott
* Christine Augustine
* Megan Hepner
* Sean Downs
* Kate Skorija
* Deryck Jackson

## Support and contact details

Contact : Megan Hepner

## Technologies Used

* C#
* ASP.NET MVC
* Entity


## **📘 License**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)