using System.ComponentModel.DataAnnotations;

namespace lab11_3.Models
{
    namespace StudentApi.Models
    {
        public class Student
        {
            public int StudentId { get; set; }   // PK
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }
            public string? Email { get; set; }
        }
    }

}
