using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly RegistrarContext _db;
    
    public StudentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index(string sortOrder, string searchString)
    {
      ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder)? "name_desc" : "";
      ViewBag.DateSortParm = sortOrder =="Date" ? "date_desc" : "Date";
      ViewBag.DepartmentSortParm = sortOrder == "Department" ? "department_desc" : "Department";
      // var students = from student in _db.Students select student;
      IQueryable<Student> students = _db.Students
        .Include(student => student.Courses)
        .ThenInclude(join => join.Course)
        .Include(student => student.Department);
      if (!String.IsNullOrEmpty(searchString))
      {
          students = students.Where(student => student.StudentName.Contains(searchString));
      }
      switch (sortOrder)
      {
        case "name_desc":
          students = students.OrderByDescending(student => student.StudentName);
          break;
        case "Date":
          students = students.OrderBy(student => student.EnrollmentDate);
          break;
        case "date_desc":
          students = students.OrderByDescending(student => student.EnrollmentDate);
          break;
        case "Department":
          students = students.OrderBy(student => student.Department.Name);
          break;
        case "department_desc":
          students = students.OrderByDescending(student => student.Department.Name);
          break;
        default:
          students = students.OrderBy(student => student.StudentName);
          break;
      }
      return View(students.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.DepartmentId = new SelectList(_db.Departments, "DepartmentId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student, int DepartmentId)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    public ActionResult Details(int id)
    {
      var thisStudent = _db.Students
      .Include(student => student.Courses)
      .ThenInclude(join => join.Course)
      .FirstOrDefault(student => student.StudentId == id);
      ViewBag.Completed = _db.CompletedCourses.Where(completedCourse => course.StudentId == id)
      return View(thisStudent);
    }

    public ActionResult Edit(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      ViewBag.Course = new SelectList(_db.Courses, "CourseId", "Name");
      ViewBag.DepartmentId = new SelectList(_db.Departments, "DepartmentId", "Name");
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult Edit(Student student, int CourseId)
    {
      if (CourseId !=0)
      {
        _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId });
      }
      _db.Entry(student).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      _db.Students.Remove(thisStudent);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCourse(int joinId)
    {
      var joinEntry = _db.CourseStudent.FirstOrDefault(entry => entry.CourseStudentId == joinId);
      _db.CourseStudent.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}