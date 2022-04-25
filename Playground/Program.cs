
Console.WriteLine("Napiš první číslo a zmáčkni enter");
int cislo1 = int.Parse(Console.ReadLine());

Console.WriteLine("Napiš druhé číslo a zmáčkni enter");
int cislo2 = int.Parse(Console.ReadLine());

Console.WriteLine("Napiš třetí číslo a zmáčkni enter");
int cislo3 = int.Parse(Console.ReadLine());

if (cislo1 > cislo2 && cislo1 > cislo3)
    Console.WriteLine($"Největší je číslo: {cislo1}");
else if (cislo2 > cislo1 && cislo2 > cislo3)
    Console.WriteLine($"Největší je číslo: {cislo2}");
else
    Console.WriteLine($"Největší je číslo: {cislo3}");