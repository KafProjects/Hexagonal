# Setting Up with CQRS and the hexagonal architecure.

## Before we start, what does the application do?

It is a console application that allows to:

      1. Show brands and employees of a company.
      2. Allows to create a brand by entering a name.
     
## How to run solution. 

      1. Assure the nugetpackages are loaded (if needed do a restore).
      2. Start the Hexagonal.Main project and interact with the console.

## How is the application build.

The application is organized to use CQRS and the Hexagonal Architecure.
For this simple application the code seems to be a bit complex, but it allows us to understanding the patterns quickly.

      1. The presitence layer stores data into memory and uses a generic repository.It is a "server" project in the hex-architecure
      2. The console layer is library to help displaying messages, not that usefull, but it is a second "server" project. 
      3. The core application contains the ports , adapters, commands and requests.
      4. The startup main (console) application, which injects (Unity) the dependencies, is the "user-driver" project.
