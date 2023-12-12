using System.ComponentModel.DataAnnotations;

namespace Assignment124.Data
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        public string? FacultyName { get; set; }
        public int DeptId { get; set; }
        public string? Standing { get; set; }
    }
}
