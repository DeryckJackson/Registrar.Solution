using System.Collections.Generic;

namespace Registrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Students = new HashSet<DepartmentStudent>();
      this.Courses = new HashSet<CourseDepartment>();
    }

    public string Name { get; set; }
    public string Building { get; set; }
    public int DeparmentId { get; set; }
    
    public ICollection<DepartmentStudent> Students { get; set; }
    public ICollection<CourseDepartment> Courses { get; set; }
  }
}