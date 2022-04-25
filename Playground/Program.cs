Console.WriteLine("Zadejte číslo dne");

int dayNumber = int.Parse(Console.ReadLine());
string result = GetDayFromNumber(dayNumber);

Console.WriteLine($"Výsledek je: {result}");


string GetDayFromNumber(int dayNumber)
{
    switch (dayNumber)
    {
        case 1:
            return "Pondělí";
        case 2:
            return "Úterý";
        case 3:
            return "Středa";
        case 4:
            return "Čtvrtek";
        case 5:
            return "Pátek";
        case 6:
            return "Sobota";
        case 7:
            return "Neděle";
        default:
            return "Špatné číslo";
    }
}