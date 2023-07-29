# EauClarieSalon.Solution
# HairSalon
#### An MVC web application for Hair Salons to track Stylists and their Clients

#### Hernan Verar

## Technologies Used

* C#
* Dotnet 6
* Entity Framework Core
* MySQL
* Html
* Css

## HairSalon is an MVC application for Eau Claire's Salon. Users can add Stylists to their Salon list and can add Clients for each Stylist to help keep track of their appointments. 

## Setup/Installation Requirements

* Open a terminal window and clone this repository by entering into the command line: 
git clone https://github.com/hernanverar/EauClarieSalon.Solution.git

* In the terminal, navigate to the console application with the command:
> cd Salon.Solution/HairSalon
* Once in the "HairSalon" directory, create a new file called appsettings.json
* Within appsettings.json, put in the following code, replacing the [YOURUSERNAME] and [YOURPASSWORD] values with your own username and password for MySQL.
>{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=hernan_verar;uid=[YOURUSERNAME];pwd=[YOURPASSWORD];
  }
}


To launch the application enter the following lines into the command line:
* dotnet restore
# then:
* dotnet build
# finally:
* dotnet run
# Known Bugs
none

License; MIT License

Copyright (c) [2023] [Hernan Verar]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
