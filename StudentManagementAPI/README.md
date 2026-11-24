# StudentManagementAPI

ASP.NET Core Web API for managing student records using Entity Framework Core and SQL Server with Swagger/OpenAPI documentation.

## Project Details

| Configuration | Value |
| --- | --- |
| **Project Name** | StudentManagementAPI |
| **Project Type** | ASP.NET Core Web API |
| **Framework** | .NET 10 |
| **Database** | SQL Server (StudentDB) |
| **ORM** | Entity Framework Core |
| **API Documentation** | Swagger / OpenAPI |

---

## Database Table – Students

**Table Name:** `Students`

| Column Name | Data Type | Constraint |
| --- | --- | --- |
| `StudentId` | UNIQUEIDENTIFIER | Primary Key |
| `Name` | NVARCHAR(100) | NOT NULL |
| `Email` | NVARCHAR(100) | NOT NULL |
| `Phone` | NVARCHAR(15) | NOT NULL |
| `Age` | INT | NOT NULL |
| `Course` | NVARCHAR(100) | NOT NULL |
| `Address` | NVARCHAR(250) | NULL |

---

## CRUD Operations & API Endpoints

| HTTP Method | API Endpoint | Operation | Status Code |
| --- | --- | --- | --- |
| `GET` | `/api/students` | Get All Students | `200 OK` |
| `GET` | `/api/students/{id}` | Get Student by ID | `200 OK` / `404 Not Found` |
| `POST` | `/api/students` | Add Student | `201 Created` / `400 Bad Request` |
| `PUT` | `/api/students/{id}` | Update Student | `200 OK` / `404 Not Found` / `400 Bad Request` |
| `DELETE` | `/api/students/{id}` | Delete Student | `200 OK` / `404 Not Found` |

---

## Project Folder Structure

```text
StudentManagementAPI
│
├── Controllers
│   └── StudentsController.cs
│
├── Data
│   └── StudentDbContext.cs
│
├── Migrations
│   ├── 20261124155103_InitialMigration.cs
│   └── StudentDbContextModelSnapshot.cs
│
├── Models
│   ├── Entity
│   │   └── Student.cs
│   │
│   └── DTO
│       ├── AddStudentDto.cs
│       └── UpdateStudentDto.cs
│
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
└── README.md
```

---

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/) (.NET 8 or .NET 10)
- SQL Server LocalDB or full SQL Server instance

### Database Configuration
Ensure the connection string in `appsettings.json` points to your SQL Server instance:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

### Apply Migrations
```bash
dotnet ef database update
```

### Run the Application
```bash
dotnet run
```

### Access Swagger UI
When running in `Development`, open your browser at:
`http://localhost:5209/` or `https://localhost:7055/` (or navigate to `/swagger`)

---

## Sample Request Payloads

### POST `/api/students`
```json
{
  "name": "Jane Doe",
  "email": "jane.doe@example.com",
  "phone": "9876543210",
  "age": 21,
  "course": "Computer Science",
  "address": "456 College Road, City"
}
```

### PUT `/api/students/{id}`
```json
{
  "name": "Jane Doe",
  "email": "jane.doe@example.com",
  "phone": "9876543210",
  "age": 22,
  "course": "Software Engineering",
  "address": "789 Innovation Way, City"
}
```
