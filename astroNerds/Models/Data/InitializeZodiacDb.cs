namespace astroNerds.Models.Data
{ // + to wszystko jeszcze w Program.cs - 'CreateHostBuilder', 'CreateDbIfNotExists'
    public static class InitializeZodiacDb
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Zodiac.Any()) { return; }

            var zodiacs = new Zodiac[] //daty wpisac
            {
                new Zodiac{ZodiacSign=ZodiacSign.Aries,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Libra,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Sagittarius,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Pisces,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Cancer,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Gemini,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Aquarius,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Capricorn,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Virgo,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Scorpio,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Taurus,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")},
                new Zodiac{ZodiacSign=ZodiacSign.Leo,dateFrom=DateTime.Parse(""),dateTo=DateTime.Parse("")}
            };

            foreach (Zodiac z in zodiacs)
            {
                context.Zodiac.Add(z);
            }
            context.SaveChanges();
        }
    }
}
