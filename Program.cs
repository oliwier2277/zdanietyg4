// Zad 3
int wysokosc = 0;

while (wysokosc < 2 || wysokosc > 10)
{
    Console.Write("Podaj wysokość choinki (2-10): ");
    wysokosc = int.Parse(Console.ReadLine());
}

for (int i = 1; i <= wysokosc; i++)
{
    for (int j = 1; j <= wysokosc - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = 1; i < wysokosc; i++)
{
    Console.Write(" ");
}

Console.WriteLine("*");


