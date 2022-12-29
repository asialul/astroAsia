namespace astroNerds.Models
{
    public interface IDbMethods
    {
        //porównanie podanej daty urodzenia (miesiąc, dzień) z dateFrom i dateTo z tabeli Zodiac
        //(chyba, że się uda znaleźć jakąś lepszą bazę danych)
        ZodiacSign GetSign { get; }

    }
}
