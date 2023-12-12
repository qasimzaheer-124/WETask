using System.ComponentModel.DataAnnotations;

namespace Assignment124.Data
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public int RoomNumber { get; set; }
        public int FacultyId { get; set; }

        // Navigation property
        public Faculty? Faculty { get; set; }
    }
}
