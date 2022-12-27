using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace astroNerds.Models
{
    public enum HoroscopeType
    {
        Love, General, Birthday, Career, Wellness
    }

    public class HResult
    {
        [Key]
        public int HoroscopeID { get; set; }
        public HoroscopeType? HoroscopeType { get; set; }

        [Required]
        public string HoroscopeText { get; set; }

        [Required]
        public ZodiacSign ZodiacSign { get; set; }
    }
}
