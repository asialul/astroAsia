using System.ComponentModel.DataAnnotations;

namespace astroNerds.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public DateTimeOffset BirthDate { get; set; }

        public string? UserName { get; set; }

    }
}
