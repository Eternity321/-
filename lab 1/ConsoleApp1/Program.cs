using System;

public enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class Date
{
    public int Day { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }
    public DayOfWeek DayOfWeek { get; private set; }

    public Date(int day, int month, int year)
    {
        if (!IsValidDate(day, month, year))
        {
            throw new ArgumentException("Недействительная дата.");
        }

        Day = day;
        Month = month;
        Year = year;
        DayOfWeek = CalculateDayOfWeek(day, month, year);
    }

    private bool IsValidDate(int day, int month, int year)
    {
        if (year < 1 || month < 1 || month > 12)
            return false;

        int[] daysInMonth = { 31, 28 + (IsLeapYear(year) ? 1 : 0), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return day >= 1 && day <= daysInMonth[month - 1];
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    private DayOfWeek CalculateDayOfWeek(int day, int month, int year)
    {
        int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
        year -= month < 3 ? 1 : 0;
        int dayOfWeek = (year + year / 4 - year / 100 + year / 400 + t[month - 1] + day) % 7;
        return (DayOfWeek)dayOfWeek;
    }

    public override string ToString()
    {
        return $"{Day:D2}.{Month:D2}.{Year:D4}";
    }

    public void AddDays(int days)
    {
        DateTime currentDate = new DateTime(Year, Month, Day);
        DateTime newDate = currentDate.AddDays(days);
        Day = newDate.Day;
        Month = newDate.Month;
        Year = newDate.Year;
        DayOfWeek = CalculateDayOfWeek(Day, Month, Year);
    }

    public void AddMonths(int months)
    {
        int yearsToAdd = months / 12;
        int monthsToAdd = months % 12;

        Year += yearsToAdd;
        Month += monthsToAdd;

        if (Month > 12)
        {
            Year += 1;
            Month -= 12;
        }
    }

    public void AddYears(int years)
    {
        Year += years;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите начальную дату в формате (день.месяц.год):");
            string[] initialDateParts = Console.ReadLine().Split('.');
            int day = int.Parse(initialDateParts[0]);
            int month = int.Parse(initialDateParts[1]);
            int year = int.Parse(initialDateParts[2]);

            Date date = new Date(day, month, year);
            Console.WriteLine($"Начальная дата: {date}");

            Console.Write("Введите количество дней, которое нужно добавить:");
            int daysToAdd = int.Parse(Console.ReadLine());
            date.AddDays(daysToAdd);

            Console.Write("Введите количество месяцев, которое нужно добавить:");
            int monthsToAdd = int.Parse(Console.ReadLine());
            date.AddMonths(monthsToAdd);

            Console.Write("Введите количество лет, которое нужно добавить:");
            int yearsToAdd = int.Parse(Console.ReadLine());
            date.AddYears(yearsToAdd);

            Console.WriteLine($"Новая дата: {date}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
