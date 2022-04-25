
Console.WriteLine("Napiš teplotu v celsiu a zmáčkni enter");

string? vstupCelsius = Console.ReadLine();
int convertedToFarenheit = ((int)Math.Round((int.Parse(vstupCelsius) * 1.8) + 32));


Console.WriteLine($"Výsledek: {convertedToFarenheit}");