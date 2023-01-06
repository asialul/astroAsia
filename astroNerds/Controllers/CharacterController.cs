using astroNerds.Models;
using astroNerds.Models.Data;
using astroNerds.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using astroNerds.Controllers;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace astroNerds.Controllers
{
    public class CharacterController : Controller
    {
        private readonly AppDbContext _context;


        public CharacterController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Zodiac> basicList = _context.Zodiac;

            return View(basicList);
        }

        public IActionResult Aries()
        {
            var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Aries);
                
			var descriptionL = description.ToList();
			return View(descriptionL);
        }

		public IActionResult Libra()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Libra);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Sagittarius()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Sagittarius);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Pisces()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Pisces);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Cancer()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Cancer);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Gemini()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Gemini);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Aquarius()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Aquarius);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Capricorn()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Capricorn);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Virgo()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Virgo);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Scorpio()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Scorpio);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Taurus()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Taurus);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}

		public IActionResult Leo()
		{
			var description = _context.Zodiac.Where(d => d.ZodiacSign == ZodiacSign.Leo);

			var descriptionL = description.ToList();
			return View(descriptionL);
		}



		//[HttpPost]
		//      [ValidateAntiForgeryToken]
		//      public IActionResult Index(BirthChartViewModel mojchart)
		//      {
		//          string s = mojchart.Day + "-" + mojchart.Month + "-" + mojchart.Year;
		//          string s2000 = mojchart.Day + "-" + mojchart.Month + "-2000";
		//          DateOnly myDateOfBirth = DateOnly.Parse(s);
		//          DateOnly myDate2000 = DateOnly.Parse(s2000);

		//          var sign = _context.Zodiac.Where(s => s.DateTo.Date.CompareTo(myDate2000) <= 0)
		//              .Intersect(_context.Zodiac.Where(z => z.DateFrom.Date.CompareTo(myDate2000) >= 0));

		//          return View(sign);

		//var character = from charact in _context.Zodiac.AsQueryable()
		//                where charact.ZodiacSign.Equals(sign)
		//                select charact;


		//return View(character);


		//    public async Task<IActionResult> GetSign(DateOnly myDate2000)
		//{

		//    var sign = from dat in _context.Zodiac
		//               where (myDate2000.CompareTo(dat.DateFrom) == 1 || myDate2000.Equals(dat.DateFrom))
		//               && (myDate2000.CompareTo(dat.DateTo) == -1 || myDate2000.Equals(dat.DateTo))
		//               select dat.ZodiacSign;

		//                return View(sign);
		//}

		//GET HOROSCOPE - CLICK

	}
}


