
do
{
    Console.Clear();

    Console.WriteLine("Napiš číslo dne a zmáčkni enter");

    int cisloDne = int.Parse(Console.ReadLine());
    bool jeVikend = false;

    switch (cisloDne)
    {
        case 1:
            Console.WriteLine("1 = Ponděl");
            break;
        case 2:
            Console.WriteLine("2 = Úterý");
            break;
        case 3:
            Console.WriteLine("3 = Středa");
            break;
        case 4:
            Console.WriteLine("4 = Čtvrtek");
            break;
        case 5:
            Console.WriteLine("5 = Pátek");
            break;
        case 6:
            Console.WriteLine("6 = Sobota");
            jeVikend = true;
            break;
        case 7:
            Console.WriteLine("7 = Neděle");
            jeVikend = true;
            break;
        default:
            Console.WriteLine("Špatné číslo!");
            break;
    }

    Console.WriteLine(jeVikend ? "Je víkend" : "Není víkend");

    Console.WriteLine("Chcete ukončit? y/n");
    Console.WriteLine(jeVikend ? "Je víkend" : "Není víkend");
}
while (Console.ReadKey().KeyChar != 'y');