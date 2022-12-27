using System.ComponentModel.DataAnnotations;

namespace astroNerds.Models
{
    public enum ZodiacSign
    {
        Aries, Libra, Sagittarius, Pisces, Cancer, Gemini, Aquarius, Capricorn, Virgo, Scorpio, Taurus, Leo
    }

    public class Zodiac
    {
        [Key]
        public ZodiacSign ZodiacSign { get; set; }

        [Required]
        public DateTime dateFrom { get; set; }

        [Required]
        public DateTime dateTo { get; set; }
       
    }
}
