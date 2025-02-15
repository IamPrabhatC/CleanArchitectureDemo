# Clean Architecture Demo (ASP.NET Core)

This project demonstrates the Clean Architecture approach in an ASP.NET Core Web API application, following best practices such as CQRS with MediatR, Repository Pattern, and Entity Framework Core.

## Project Structure

```
📁 CleanArchitectureDemo
 ├── 📁 CleanArchitectureDemo.API (Presentation Layer - Controllers)
 ├── 📁 CleanArchitectureDemo.Application (Business Logic - Use Cases, CQRS)
 ├── 📁 CleanArchitectureDemo.Domain (Entities, Interfaces)
 ├── 📁 CleanArchitectureDemo.Infrastructure (Persistence, EF Core, Repositories)
 └── CleanArchitectureDemo.sln (Solution File)
```

## Layers Explanation

- **API Layer**: Exposes RESTful endpoints and handles HTTP requests
- **Application Layer**: Contains business logic, CQRS commands/queries, and MediatR handlers
- **Domain Layer**: Defines core entities, aggregates, and repository interfaces
- **Infrastructure Layer**: Implements database persistence using Entity Framework Core and repository pattern

## Technologies Used

- ASP.NET Core Web API - Backend framework
- Entity Framework Core - ORM for database interactions
- MediatR - Implements CQRS pattern
- FluentValidation - Validates API requests
- Swagger - API documentation
- Docker & Kubernetes (optional) - Containerization and orchestration
- SQL Server - Database engine

## Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/IamPrabhatC/CleanArchitectureDemo.git
cd CleanArchitectureDemo
```

### 2. Setup Database Connection

Modify `appsettings.json` in CleanArchitectureDemo.API:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=CleanArchitectureDB;Trusted_Connection=True;"
  }
}
```

*Replace YOUR_SERVER_NAME with your SQL Server instance.*

### 3. Run Migrations

```bash
dotnet ef migrations add InitialCreate --project ./CleanArchitectureDemo.Infrastructure
dotnet ef database update --project ./CleanArchitectureDemo.Infrastructure
```

### 4. Run the Application

```bash
dotnet run --project ./CleanArchitectureDemo.API
```

Open Swagger UI at: http://localhost:5000/swagger

## Main Features Implemented

- CQRS with MediatR - Queries & Commands for handling requests
- Repository Pattern - Decouples database logic from application logic
- Entity Framework Core - Used for data persistence
- Dependency Injection - Ensures maintainability & testability
- Swagger API Documentation - Auto-generated API documentation

## Next Steps

- Add JWT Authentication & Authorization
- Implement Unit Testing with xUnit
- Add Docker Support

## Contributing

Feel free to submit pull requests or report issues!

## Contact

📧 Email: Prabhat.Chauhan.in@gmail.com

---

⭐ If you found this useful, give it a star! ⭐
