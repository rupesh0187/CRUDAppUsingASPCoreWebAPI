using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingASPCoreWebAPI.Models
{
    public class Student
    {
        [Key]
            public int id { get; set; }
            [Required]
            public string? name { get; set; }
            [Required]
            public string? course { get; set; }
            [Required]
            public int age { get; set; }
            [Required]
            public long phoneno { get; set; }
        

    }
}
