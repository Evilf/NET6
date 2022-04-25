
do
{
    Console.Clear();

    Console.WriteLine("Napiš číslo dne a zmáčkni enter");
    int cisloDne = int.Parse(Console.ReadLine());

    if (cisloDne == 1)
        Console.WriteLine("1 = Pondělí");
    else if (cisloDne == 2)
        Console.WriteLine("2 = Úterý");
    else if (cisloDne == 3)
        Console.WriteLine("3 = Středa");
    else if (cisloDne == 4)
        Console.WriteLine("4 = Čtvrtek");
    else if (cisloDne == 5)
        Console.WriteLine("5 = Pátek");
    else if (cisloDne == 6)
        Console.WriteLine("6 = Sobota");
    else
        Console.WriteLine("7 = Neděle");

    Console.WriteLine("Chcete ukončit? y/n");
}
while (Console.ReadKey().KeyChar != 'y');