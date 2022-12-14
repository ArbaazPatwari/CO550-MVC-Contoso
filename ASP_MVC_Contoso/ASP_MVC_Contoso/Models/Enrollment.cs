using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Contoso.Models
{
    public enum Grades
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Nullable<Grades> Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
