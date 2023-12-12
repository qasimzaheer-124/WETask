using System.ComponentModel.DataAnnotations;

namespace Assignment124.Data
{
    public class Enroll
    {
        [Key]
        public int EnrollId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        // Navigation properties
        public Student? Student { get; set; }
        public Class? Class { get; set; }
    }
}
