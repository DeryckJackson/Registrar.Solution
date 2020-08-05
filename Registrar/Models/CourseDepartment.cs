namespace Registrar.Models
{
  public class CourseDepartment
  {
    public int CourseDepartmentId { get; set; }
    public int DepartmentId { get; set; }
    public int CourseId { get; set; }
    public Department Department { get; set; }
    public Course Course { get; set; }
  }
}