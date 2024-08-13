
using Microsoft.AspNetCore.Mvc;
using Example.Models;
using Example.Entities;

public class DepartmentController : Controller
{
    private readonly DataContext _context;

    public DepartmentController(DataContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var departments = _context.Departments.ToList();
        return View(departments);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Department department)
    {
        if (ModelState.IsValid)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(department);
    }

    public IActionResult Edit(int id)
    {
        var department = _context.Departments.Find(id);
        if (department == null)
        {
            return NotFound();
        }
        return View(department);
    }

    [HttpPost]
    public IActionResult Edit(Department department)
    {
        if (ModelState.IsValid)
        {
            _context.Departments.Update(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(department);
    }

    public IActionResult Delete(int id)
    {
        var department = _context.Departments.Find(id);
        if (department == null)
        {
            return NotFound();
        }
        return View(department);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var department = _context.Departments.Find(id);
        if (department != null)
        {
            _context.Departments.Remove(department);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
