using System.ComponentModel.DataAnnotations;

namespace Assignment124.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? Major { get; set; }
        public string? Standing { get; set; }
    }
}
