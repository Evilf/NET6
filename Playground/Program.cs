//Console.WriteLine("Zadejte datum narození (ve formátu 1.1.2000)");

//DateTime birthday = DateTime.Parse(Console.ReadLine());

//CalculateAgeFromBirthday(birthday);

//void CalculateAgeFromBirthday(DateTime birthday)
//{
//    Console.WriteLine(Math.Floor(DateTime.Today.Subtract(birthday).TotalDays / 365));
//}

Console.WriteLine("Zadejte číslo dne");

int dayNumber = int.Parse(Console.ReadLine());

GetDayFromNumber(dayNumber);

void GetDayFromNumber(int dayNumber)
{
    Console.WriteLine((DaysOftheWeek)dayNumber);
}

enum DaysOftheWeek
{
    Pondělí = 1,
    Úterý = 2,
    Středa = 3,
    Čtvrtek = 4,
    Pátek = 5,
    Sobota = 6,
    Neděle = 7
}