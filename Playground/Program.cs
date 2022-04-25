
Console.WriteLine("Napiš teplotu v celsiu a zmáčkni enter");

string? vstup = Console.ReadLine();
int converted = ((int)Math.Round((int.Parse(vstup) * 1.8) + 32));


Console.WriteLine($"Výsledek: {converted}");