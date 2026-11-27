# Employee Management MVC

Run the MVC employee directory from this folder:

```powershell
dotnet run --project .\EmployeeManagementMVC.csproj
```

The app uses SQL Server LocalDB and the `EmployeeDB` database. Apply the included initial migration with:

```powershell
dotnet ef database update --project .\EmployeeManagementMVC.csproj
```

The employee list is available at `/Employees`; use **Add employee** to create a record.