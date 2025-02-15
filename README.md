Clean Architecture Demo (ASP.NET Core)This project demonstrates the Clean Architecture approach in an ASP.NET Core Web API application, following best practices such as CQRS with MediatR, Repository Pattern, and Entity Framework Core.
🚀 Project Structure📁 CleanArchitectureDemo
 ├── 📁 CleanArchitectureDemo.API (Presentation Layer - Controllers)
 ├── 📁 CleanArchitectureDemo.Application (Business Logic - Use Cases, CQRS)
 ├── 📁 CleanArchitectureDemo.Domain (Entities, Interfaces)
 ├── 📁 CleanArchitectureDemo.Infrastructure (Persistence, EF Core, Repositories)
 ├── CleanArchitectureDemo.sln (Solution File)Layers ExplanationAPI Layer: Exposes RESTful endpoints and handles HTTP requests.
Application Layer: Contains business logic, CQRS commands/queries, and MediatR handlers.
Domain Layer: Defines core entities, aggregates, and repository interfaces.
Infrastructure Layer: Implements database persistence using Entity Framework Core and repository pattern.
🛠 Technologies Used✅ ASP.NET Core Web API - Backend framework✅ Entity Framework Core - ORM for database interactions✅ MediatR - Implements CQRS pattern✅ FluentValidation - Validates API requests✅ Swagger - API documentation✅ Docker & Kubernetes (optional) - Containerization and orchestration✅ SQL Server - Database engine
📌 Installation & Setup1️⃣ Clone the Repositorygit clone https://github.com/IamPrabhatC/CleanArchitectureDemo.git
cd CleanArchitectureDemo2️⃣ Setup Database ConnectionModify appsettings.json in CleanArchitectureDemo.API:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=CleanArchitectureDB;Trusted_Connection=True;"
  }
}✅ Replace YOUR_SERVER_NAME with your SQL Server instance.
3️⃣ Run Migrationsdotnet ef migrations add InitialCreate --project ./CleanArchitectureDemo.Infrastructure
dotnet ef database update --project ./CleanArchitectureDemo.Infrastructure4️⃣ Run the Applicationdotnet run --project ./CleanArchitectureDemo.APIOpen Swagger UI at: http://localhost:5000/swagger
📌 Main Features Implemented✅ CQRS with MediatR - Queries & Commands for handling requests✅ Repository Pattern - Decouples database logic from application logic✅ Entity Framework Core - Used for data persistence✅ Dependency Injection - Ensures maintainability & testability✅ Swagger API Documentation - Auto-generated API documentation
📌 Next Steps✅ Add JWT Authentication & Authorization
✅ Implement Unit Testing with xUnit
✅ Add Docker Support
🤝 ContributingFeel free to submit pull requests or report issues!
📧 Contact: Prabhat.Chauhan.in@gmail.com
⭐ If you found this useful, give it a star! ⭐