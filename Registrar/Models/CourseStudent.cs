namespace Registrar.Models
{
  public class CourseStudent
  {
    public int CourseStudentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
  }
}

// StudentId - CourseId
// Student - Course

// CourseId - DepartmentId
// Course - Department

// StudentId - DepartmentId
// Student - Department

// StudentId - CompletedCourseId
// Student - Course