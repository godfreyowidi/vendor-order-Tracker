## Vendor & Order Tracker

## Description
_This web application that provides user vendors with the ability to make orders. The application enables the user to enter various orders under their respective name._

## Technologies Used
* _C#_
* _ASP.NET Core MVC_
* _dotnet script_
* _HTTP RESTful Routing_
* _Git/GitHub_

## Setup Requirements
* _Browser_
* _Text Editor (preferrably vsCode)_
* _ASP.NET Core installed_
* _Terminal_

## Installation

_Use the browser to navigate to [GitHub](https://github.com/godfreyowidi/vendor-order-Tracker) page respository_
_Click the Green Code button on the right and select Download Zip_
_Alternatively clone from Github via the terminal using ```git clone``` command_
_In your terminal, navigate to the directory where you would like to clone the project to_
_Clone this repo to your chosen directory using this link "https://github.com/godfreyowidi/vendor-order-Tracker" in terminal_

- **If you chose to download via zip:**

_Unzip the downloaded repository into your working directory_
_Open the working directory into your text editor using the command ```code .```_
_Once you have the program open in your text editor, run ```dotnet restore VendorOrder.Test.csproj``` in the terminal to set up the dependencies and tools for the project._
_After the project is sucessfully set up, navigate to the VendorOrder directory in the terminal._
_Then execute the command ```dotnet run``` or ```dotnet watch run``` to start server_

- **If you cloned via Git:**

_Using the terminal navigate to the directory the project is located using ```cd vendor-order-Tracker```_
_Open the working directory in your text editor using the ```code .``` command._
_From the terminal, run ```dotnet restore VendorOrder.Test.csproj``` in the terminal to set up the dependencies and tools for the project._
_After the dependencies and tools for the project are sucessfully set up, navigate to the vendor-order-Tracker directory in the terminal._
_Execute the commmand ```dotnet run``` or ```dotnet watch run``` to start the server._

- **Using the application:**

_Server is started on either :-_
  1. http://localhost:5000
  2. http://localhost:5001

_Copy and paste either of the above in the browser to experience the splash page_

_You can follow along and create a vendor and then list your orders under your name_

_You can also search for specific vendor or order using the unique ID and it will be displayed in the browser_

_The application is also able to update vendor and order details as well as clear list of vendors and orders and also delete/destroy vendor and order entries_

_Overally the application uses CRUD functionality as way to Create, Read, Update and Delete/Destroy information into persisent storage_

- run tests:

_Open the project repo in a preferred text editor._
_Navigate using the terminal to ```VendorOrder.Test/ModelTests.```_
_Execute the command ```dotnet test```._
_View tests results in the terminal._

## Known Bugs
no known bugs

## License
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Contact

[Email Contact](godfreyowiidi@gmail.com)