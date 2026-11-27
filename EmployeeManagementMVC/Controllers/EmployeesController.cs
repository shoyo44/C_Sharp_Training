using EmployeeManagementMVC.Data;
using EmployeeManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementMVC.Controllers;

public class EmployeesController(ApplicationDbContext dbContext) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var employees = await dbContext.Employees
            .AsNoTracking()
            .OrderBy(employee => employee.Name)
            .ToListAsync();

        return View(employees);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(new AddEmployeeDto());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(AddEmployeeDto employeeDto)
    {
        if (!ModelState.IsValid)
        {
            return View(employeeDto);
        }

        var employee = new Employee
        {
            Id = Guid.NewGuid(),
            Name = employeeDto.Name,
            Email = employeeDto.Email,
            Phone = employeeDto.Phone,
            Salary = employeeDto.Salary
        };

        dbContext.Employees.Add(employee);
        await dbContext.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}