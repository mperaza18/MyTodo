# MyTodo Application

A clean architecture implementation of a Todo application in .NET 9.

## Project Structure

```
MyTodo/
├─ src/
│  ├─ TodoApp.Domain/                # Core domain entities and interfaces
│  ├─ TodoApp.Application/           # Application services and DTOs
│  ├─ TodoApp.Infrastructure/        # Repository implementations (in-memory)
│  ├─ TodoApp.Console/               # Console UI application
│  └─ TodoApp.Api/                   # Minimal API
└─ tests/
   └─ TodoApp.Tests/                 # Unit tests using xUnit
```

## Clean Architecture

This project implements Clean Architecture principles:

1. **Domain Layer**: Contains entities and repository interfaces
2. **Application Layer**: Contains services, DTOs, and application logic
3. **Infrastructure Layer**: Contains repository implementations
4. **UI Layer**: Console application and Web API

## Getting Started

### Prerequisites

- .NET 9 SDK

### Running the Console Application

```bash
cd MyTodo/src/TodoApp.Console
dotnet run
```

### Running the API

```bash
cd MyTodo/src/TodoApp.Api
dotnet run
```

Then navigate to `https://localhost:5001/swagger` to use the Swagger UI.

### Running Tests

```bash
cd MyTodo
dotnet test
```

## Clean Code Principles

This project follows these clean code principles:

- **Single Responsibility Principle**: Each class has only one reason to change
- **Dependency Inversion**: High-level modules don't depend on low-level modules
- **Interface Segregation**: Clients depend only on the methods they use
- **Encapsulation**: Internal state is protected using private setters
- **Domain-Driven Design**: The domain model is at the center of the application