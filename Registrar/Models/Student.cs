using System.Collections.Generic;
using System;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string StudentSocialScore { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department Department { get; set; }
    public ICollection<CourseStudent> Courses { get; set; }
  }
}