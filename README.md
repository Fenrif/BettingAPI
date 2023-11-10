# BettingAPI Project

## Overview

The .Net Core Web API project  revolves around two main entities ("Match" and "MatchOdds"), providing endpoints to perform CRUD operations on these entities. The project was written in Visual Studio Code with net7.0.

## Features

- **MVC Architecture**: The project follows the MVC pattern, providing a structured and modular approach to design, making it easier to manage and scale.

- **Dependency Injection (DI)**: Utilizes DI to promote loose coupling and improve the maintainability of the code. This allows for easy integration of new components and services.

- **Services**: Encapsulates business logic into services.

- **Entity Framework (EF)**: Uses EF for all the database interactions and follows the code-first logic.

- **DTOs (Data Transfer Objects)**: Utilizes DTOs to seperate the API layer and the underlying business logic, enhancing flexibility and security.

- **AutoMapper**: Used for the mapping between the Models and the DTOs.

- **Docker**: The project includes Docker support, allowing for easy containerization and deployment across different environments.

- **Seeder**: Implements a seeder to populate the database with initial data, making it convenient to test and showcase the application's capabilities.

- **SOLID Principles**:

    The project also follows the SOLID principles up to a point.

  - **Single Responsibility Principle (SRP)**: The use of Dependency Injection, services, and DTOs promote modularity and seperation of concerns.
  
  - **Open/Closed Principle (OCP)**: The use of Dependency Injection and services allows extensibility without modifying existing code.

  - **Liskov Substitution Principle (LSP)**: With the current requirements it wasn't really any opportunity to implement it.

  - **Interface Segregation Principle (ISP)**: Needed a project of a larger scale to demonstrate.

  - **Dependency Inversion Principle (DIP)**: The utilization of Dependency Injection is an implementation of the DIP.

## How to run it

1. **Prerequisites**: Ensure that you have .NET Core SDK and Docker installed on your machine.

2. **Clone the Repository**: Clone this repository to your local machine using the following command:
    ```bash
    git clone https://github.com/Fenrif/BettingAPI.git
    ```

3. **Database Setup**: Update the connection string in the `appsettings.json` file to point to your database. Run the following commands to apply migrations and seed the database:
    ```bash
    dotnet ef database update
    ```

4. **Run the Application with Docker**: Execute the following commands to build and run the web API using Docker:
    ```bash
    docker build -t mywebapi .
    docker run -p 8080:80 mywebapi
    ```

5. **Explore the API**: Access the API at `http://localhost:5012/api/` or `https://localhost:7078/api/`. Use tools like Postman or Swagger to make HTTP requests. I have include the file `BettingAPI.postman_collection.json` in the repository with HTTP requests for both entities. Those that require ID (Get (single), Update and Delete) will have to be sligtly altered, since I used Guid for all the Id's.

