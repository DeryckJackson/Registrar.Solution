using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly RegistrarContext _db;
    
    public DepartmentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index ()
    {
      return View(_db.Departments.ToList());
    }

    public ActionResult Details (int deptId)
    {
      ViewBag.Students = _db.Students.Where(student => student.DepartmentId == deptId).ToList();
      ViewBag.Courses = _db.Courses.Where(course => course.DepartmentId == deptId).ToList();
      return View();
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department dept)
    {
      _db.Departments.Add(dept);
      _db.SaveChanges();
      return RedirectToAction("Index", "Students");
    }
  }
}