Console.WriteLine("Zadejte datum narození (ve formátu 1.1.2000)");

DateTime birthday = DateTime.Parse(Console.ReadLine());

CalculateAgeFromBirthday(birthday);

void CalculateAgeFromBirthday(DateTime birthday)
{
    Console.WriteLine(Math.Floor(DateTime.Today.Subtract(birthday).TotalDays / 365));
}