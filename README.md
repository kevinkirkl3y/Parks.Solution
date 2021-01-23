# Park API

#### Epicodus C# API Practice 1.22.2021

#### by _**Kevin Kirkley**_

## Description
Park API is a program designed to hold data in a MySQL database for future use in MVC or terminal based programs. It holds data for two types of objects, National Parks and State Parks. The information is fairly basic consisting of the park Name, State of location, Address or GPS coordinates, webpage url and approximate size in square miles. Parks are queryable based on Name or State and through the use of a "Random" request users can find a randomly selected park. The program utilizes Swashbuckler to provide Swagger Documentation and has Versioning functionality. 

## Known Bugs
* No known bugs at this time. 1.22.2021

## Setup/Installation Requirements

### Software Requirements
1. Internet Browser
2. A code editor such as VSCode in order to view or edit codebase. 
3. netcore2.2
4. MySQL
5. MySQLWorkbench.

### Open by downloading:
1. Download the [repository](https://github.com/kevinkirkl3y/Parks.Solution.git) onto your computer by clicking the 'clone or download button'.
2. Open within your text editor and navigate to the `Parks.Solution/ParkAPI` folder and run `dotnet restore` in your console.

### Open with Bash/GitBash:
1. Clone this repository onto your computer: 
```
git clone https://github.com/kevinkirkl3y/Parks.Solution.git
```
2. Navigate into the `Parks.Solution` directory and open in VSCode or preferred text editor using `code .` in your terminal.
3. Open within your text editor and navigate to the `Parks.Solution/ParkAPI` folder and run `dotnet restore` in your console.

### AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main ParkAPI file following the format below. Use your unique password that you created duing MySQLWorkbench installation:

```  
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parkapi;uid=<YourId>;pwd=<YourPassword>;"
  }
}
```
* Update the Server, Port and User Id as needed.
### Setup of MySQL Database 
* To set up database using existing migrations, navigate to `Parks.Solution/ParkAPI` and run `dotnet ef database update`.
* To make a adjustments to the databases after changing models, navigate to `Parks.Solution/ParkAPI` and type `dotnet ef migrations add <MigrationName>` into the terminal. 
* Then, type `dotnet ef database update` into the terminal to update database tables to reflect any changes you have made.

### Launch the API
* Navigate to `Parks.Solution/ParkAPI` and run the command `dotnet run`, this wil allow you access to the API through Postman or the browser.
* If changes are made to the controller files you will need to run `dotnet build` before `dotnet run` to make sure the changes are live.

## API Documentation
Explore the API endpoints using Postman of a browser. 

### Using Swagger Documentation

To Explore `ParkAPI` with Swashbuckle, launch the project using `dotnet run` and open you local server in your browser. Use the following URL to navigate to the Swagger Documentation: `http://localhost:5000/swagger`

#### Example Query

```
http://localhost:5000/api/2.0/nationalparks?name=death%20valley%20national%20park
```

### Endpoints
Base URL: `https://localhost:5000`

### National Parks
Access information for National Parks

#### HTTP Request
```
GET api/nationalparks
GET api/nationalParks/random
POST api/nationalparks
GET api/nationalparks/{id}
PUT api/nationalparks/{id}
DELETE api/nationalparks/{id}
GET api/2.0/nationalparks?{parameter}={query}
```

### State Parks
Access information for State Parks

#### HTTP Request
```
GET api/stateparks
GET api/stateParks/random
POST api/stateparks
GET api/stateparks/{id}
PUT api/stateparks/{id}
DELETE api/stateparks/{id}
GET api/2.0/stateparks?{parameter}={query}
```

## Support and contact detail

_Contact Kevin Kirkley at [kevinmkirkley@gmail.com](mailto:kevinmkirkley@gmail.com) with and questions, concerns or additions._


## Technologies Used 

* _C#/.NET_
* _MVC_
* _VSCode_
* _netcore2.2_
* _MySQL_
* _MySQLWorkbench_
* _Entity Framework Core_
* _Swagger_
* _Mcv.Versioning 4.1.0_


### License

Copyright (c) 2020 **_Kevin Kirkley_**
This software is licensed under the MIT license.

Copyright 2021 Kevin Kirkley

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.