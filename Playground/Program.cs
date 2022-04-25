Console.WriteLine("Zadejte počet řádků.");

int rowCount = int.Parse(Console.ReadLine());
string result = "";

for (int i = 1; i <= rowCount; i++)
{
    for(int j = 1; j <= i; j++)
    {
        result += i.ToString();
    }
    result += "\n";
}

Console.WriteLine($"Výsledek je: {result}");