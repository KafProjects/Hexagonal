# Setting up CQRS and the hexagonal architecure.

## What does the application do?

It is a console application that allows to:

      1. Show brands and employees of a company.
      2. Allows to create a brand by entering a name.
     
## How to run solution? 

      1. Assure the nugetpackages are loaded (if needed do a restore).
      2. Set the Hexagonal.Main as Start-up project, run the app and interact with the console.

## How is the application build?

The application is organised to use CQRS and the Hexagonal Architecure.
For this simple application the code seems to be a bit complex, but it allows us to understanding the patterns quickly.

      1. The presitence layer stores data into memory and uses a generic repository.It is a "server" project in the hex-architecure
      2. The console layer is library to help displaying messages, not that usefull, but it is a second "server" project. 
      3. The core application contains the ports , adapters, commands and requests.
      4. The main (user-console) application injects the dependencies (via unity) and start the application.
