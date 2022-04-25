int cislo = int.Parse(Console.ReadLine());
int vysledek = 0;

for (int i = 1; i <= cislo; i++)
{
    vysledek += i;
}

Console.WriteLine($"Výsledek je: {vysledek}");