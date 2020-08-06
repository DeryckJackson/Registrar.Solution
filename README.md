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
* In the project folder (Registrar) enter the following terminal commands:
  1. dotnet restore
  2. dotnet ef database update
* To launch the program run the following:
  1. dotnet run
* Open http://localhost:5000/ in your web browser to access the application

## Specs

| Behavior    | Input | Output |
| :---------- | ----- | -----: |
| Program can create a student object | none | none |
| Student object holds student name and date of enrollment | none | none |
| Program can create a Course object | none | none |
| Course object holds course name and number | none | none |
| Student => Course reflect many to many relationship | none | none |

## User Stories

_Implemented Functionality_
* As a registrar, I want to enter a student, so I can keep track of all students enrolled at this University. I should be able to provide a name and date of enrollment.
* As a registrar, I want to enter a course, so I can keep track of all of the courses the University offers. I should be able to provide a course name and a course number (ex. HIST100).
* As a registrar, I want to be able to assign students to a course, so that teachers know which students are in their course. A course can have many students and a student can take many courses at the same time.
* As a registrar, I want to be able to create departments. A student can be assigned to a department when they declare their major and a course can be assigned to a department when it is created.
* As a registrar, I want to be able to list out all of the courses or all of the students in a particular department, so that I can inform the counselors which departments need more students and which need more courses.
* As a registrar, I want to change a student's file to show that they have completed a course, so that I can see if they need to take the course again.
* As a registrar, I want to list out all of the courses a student has taken, so that I can see if they have met their degree requirements.

_Not Yet Implemented Functionality_
* As a registrar, I want to see how many students have not completed courses in any particular departments, so that I can tell the administration which departments need help.

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