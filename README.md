# _The National Parks Service _

#### By _**Joseph Wahbeh**_

#### Project implements C# to an API and a client to go along with it where you can input data into a database using the endpoints.

## Technologies Used

* _C#_
* _Microsoft.NET.Sdk v6.0_
* _MySQL WorkBench v8.0_
* _Entity Framework v6.0.0_
* _Swagger_

## Description

_This is a web page application that allows a user to store information about various parks that they find. The web API has several endpoints to assist in the transmitting of data for the client._

## Setup/Installation Requirements

* _Clone `NationalParks.Solution` from the repository to desired location_
* _Navigate to cloned directory via your local terminal command line_

### To run the API

* _Navigate to this project's API directory called `NationalParksAPI` through the terminal_.
* _In the terminal, run the command `touch appsettings.json` and open the file using the command `code appsettings.json`_ 

* _Copy and paste the follwing code into the `appsettings.json` file_
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
    "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=joe_national_park_Api;uid=[user-id-Name];pwd=[user-password];"
  }
}
```
* _Replace `[user-id-Name]`, `[user-password]` Brackets included with the correct information_
* _Save and exit `appsettings.json`_

* _In the terminal, run the command `dotnet ef database update`_
* _In the terminal, run the command `dotnet restore`_
* _In the terminal, run the command `dotnet watch run`_


### To run the CLIENT

* _Navigate to this project's API directory called `NationalParksClient` through the terminal_.
* _In the terminal, run the command `touch appsettings.json` and open the file using the command `code appsettings.json`_ 

* _Copy and paste the follwing code into the `appsettings.json` file_

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```
* _In the terminal, run the command `dotnet restore`_
* _In the terminal, run the command `dotnet watch run`_


## Known Bugs

* _The random endpoint of the API works correctly but not yet implemented into the client side._


## Avaliable Endpoints

```
GET http://localhost:5000/api/Parks
GET http://localhost:5000/api/Parks/{id}
GET http://localhost:5000/api/Parks/random
POST http://localhost:5000/api/Parks
PUT http://localhost:5000/api/Parks/{id}
DELETE http://localhost:5000/api/Parks/{id}
```

Note: `{id}` is a variable and it should be replaced with the id number of the park you want to GET, PUT, or DELETE.

#### Optional Query String Parameters for GET Request

GET requests to `http://localhost:5000/api/Parks` can optionally include query strings to filter or search animals.

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| parkName        | String      | not required | Returns any parks with the same Name  |
| parkType        | String      | not required | Returns all parks that match the type of park |
| parkLocation    | String      | not required | Returns all parks within the same Location |
| ParkSize        | String      | not required | Returns all parks with the same size |
| parkDescription | String      | not required | Returns all parks with the same description, admittedly not very useful |

The following query will return all parks with a type value of "State":

```
GET http://localhost:5000/api/Parks?parkType=state
```


#### Additional Requirements for POST Request

When making a POST request to `http://localhost:5000/api/Parks`, you need to include a **body**. Here's an example body in JSON:

```json
  {
    "parkName": "Yellowstone",
    "parkType": "National",
    "parkLocation": "Wyoming",
    "parkSize": "2.2 million acres",
    "parkDescription": "a Massive park"
  }
```

#### Additional Requirements for PUT Request

When making a PUT request to `http://localhost:5000/api/animals/{id}`, you need to include a **body** that includes the animal's `animalId` property. Here's an example body in JSON:

```json
  {
    "parkId": 1,
    "parkName": "Not Yellowstone",
    "parkType": "Not National",
    "parkLocation": "Not Wyoming",
    "parkSize": "Not 2.2 million acres",
    "parkDescription": "maybe? a Massive park"
  }
```

#### Further Exploration: Pagination
_The client side version of this project features pagination - with 3 per a page._

## License
MIT License

Copyright (c) 2023 Joseph Wahbeh

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
