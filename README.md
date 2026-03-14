Factory Management System API

A production-style ASP.NET Core Web API built using Clean Architecture principles to manage factory data efficiently.

This project demonstrates how to build a scalable backend service using Repository Pattern, Service Layer, DTOs, AutoMapper, Entity Framework Core, and Pagination.

The API exposes REST endpoints to create, retrieve, update, delete, and paginate factory data.

Project Architecture

This project follows a layered architecture to maintain separation of concerns.

Controller Layer
        ↓
Service Layer
        ↓
Repository Layer
        ↓
Entity Framework Core
        ↓
SQL Server Database
Controller Layer

Handles HTTP requests and responses.

Service Layer

Contains business logic and handles DTO ↔ Entity mapping.

Repository Layer

Handles database operations using Entity Framework Core.

Data Layer

Contains DbContext and database configurations.

Technologies Used

ASP.NET Core Web API

Entity Framework Core

SQL Server

AutoMapper

Repository Pattern

Service Layer Pattern

REST API Design

Pagination

Dependency Injection

Features

Create Factory

Get Factory By Id

Get All Factories with Pagination

Update Factory

Delete Factory

DTO based architecture

AutoMapper object mapping

Clean layered architecture

RESTful API design

API Endpoints
Get All Factories (Paginated)
GET /api/Factory/GetAllFactories?pageNumber=1&pageSize=10

Returns a paginated list of factories.

Get Factory By Id
GET /api/Factory/{id}

Returns factory details for the specified ID.

Create Factory
POST /api/Factory/CreateFactory
Request Body
{
  "factoryName": "Tata Motors",
  "establishDate": "1999-03-10T00:00:00",
  "city": "Sambalpur",
  "isOpened": true
}
Update Factory
PUT /api/Factory/{id}

Updates the factory details.

Delete Factory
DELETE /api/Factory/{id}

Deletes the factory record.

Project Structure
Dotnet_API_25
│
├── Controllers
│       FactoryController.cs
│
├── Data
│       FactoryDbContext.cs
│
├── Entities
│   ├── Models
│   │       Factory.cs
│   │
│   └── DTOs
│           CreateFactoryDto.cs
│           UpdateFactoryDto.cs
│           GetFactoryByIdDto.cs
│           GetAllFactoriesDto.cs
│
├── Mapping
│       FactoryMappingProfile.cs
│
├── Repositories
│       IFactoryRepository.cs
│       FactoryRepository.cs
│
├── Services
│       IFactoryService.cs
│       FactoryService.cs
│
├── Migrations
│
├── Program.cs
│
└── appsettings.json
Pagination Implementation

Pagination is implemented using Skip and Take in Entity Framework Core.

Example:

pageNumber = 1
pageSize = 10

This returns the first 10 records.

AutoMapper Usage

AutoMapper is used to convert between DTOs and Entity models.

Mappings used in the project:

CreateFactoryDto → Factory
UpdateFactoryDto → Factory
Factory → GetFactoryByIdDto
Factory → GetAllFactoriesDto

This keeps the controllers clean and prevents manual mapping logic.

Running the Project
Clone the repository
git clone https://github.com/tapan0810/Dotnet_API_25.git
Navigate to project directory
cd Dotnet_API_25
Run the application
dotnet run

The API will start at:

https://localhost:7010
API Documentation

You can test the API using the built-in OpenAPI interface.

Swagger / Scalar UI:

https://localhost:7010/swagger

or

https://localhost:7010/scalar
Future Improvements

JWT Authentication

Global Exception Handling Middleware

Logging using Serilog

API Versioning

Unit Testing

Redis Caching

Docker Support

Author

Tapan Ray

Software Developer | .NET Developer | Backend Engineer Enthusiast
