using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ContosoUniversity.Models
{
    public class CourseAssignment
    {
        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        [ValidateNever]
        public Instructor Instructor { get; set; }
        
        [ValidateNever]
        public Course Course { get; set; }
    }
}
