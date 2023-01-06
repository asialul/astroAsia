using astroNerds.Models;
using astroNerds.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace astroNerds.Services
{
    public class HoroscopeService
    {
        private readonly AppDbContext _context;

        public HoroscopeService(AppDbContext context)
        {
            _context = context;
        }

        //GetHoroscopeById
        //public async Task<IActionResult> Chart(int hID)
        //{
        //    if (hID == null)
        //    {
        //        return NotFound();
        //    }
        //    var dailyHoroscope = _context.HResults
        //                   .FirstOrDefault(d => d.HoroscopeID == hID);


        //    return View(dailyHoroscope);

        //}

        ////Get ZodiacSign by dateOfBirth

        //public async Task<IActionResult> GetSign(DateOnly myDateOfBirth)
        //{
        //    var sign = from dat in _context.Zodiac
        //               where (myDateOfBirth.CompareTo(dat.DateFrom) == 1 || myDateOfBirth.Equals(dat.DateFrom))
        //               && (myDateOfBirth.CompareTo(dat.DateTo) == -1 || myDateOfBirth.Equals(dat.DateTo))
        //               select dat.ZodiacSign;

        //    return View(sign);


        //}
        //GetHoroscopeByType
        //GetHoroscopeByZodiacSign
        //GetDescriptionById
        //GetDescriptionByZodiacSign
        //AddHoroscope
        //RemoveHoroscope
        //etc
    }
}
