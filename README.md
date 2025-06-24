# Employee Admin Portal

A simple ASP.NET Core Web API for managing employee records. This project provides endpoints to create, read, update, and delete (CRUD) employee data.

## Features

- List all employees
- Get details of a specific employee by ID
- Add a new employee
- Update an existing employee
- Delete an employee

## Technologies Used

- .NET 8
- C# 12
- ASP.NET Core Web API
- Entity Framework Core

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server or another supported database (update `appsettings.json` as needed)

### Setup

1. **Clone the repository:**

2. **Configure the database connection:**
   - Edit `appsettings.json` and set your connection string under `ConnectionStrings:DefaultConnection`.

3. **Apply database migrations:**
4. **Run the application:**


The API will be available at `https://localhost:5001` or `http://localhost:5000` by default.

## API Endpoints

| Method | Endpoint                | Description                |
|--------|-------------------------|----------------------------|
| GET    | `/api/employees`        | Get all employees          |
| GET    | `/api/employees/{id}`   | Get employee by ID         |
| POST   | `/api/employees`        | Add a new employee         |
| PUT    | `/api/employees/{id}`   | Update an existing employee|
| DELETE | `/api/employees/{id}`   | Delete an employee         |

### Example Employee Object
## Project Structure

- `Controllers/EmployeesController.cs` – API endpoints for employee management
- `Models/Entities/Employee.cs` – Employee entity model
- `Models/AddEmployeeDto.cs` – DTO for adding employees
- `Data/ApplicationDbContext.cs` – Entity Framework Core DB context
- `Program.cs` – Application startup
