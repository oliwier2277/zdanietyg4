// Zad 2
int dni = 0;
int suma = 0;
int udaneDni = 0;

while (dni < 1 || dni > 7)
{
    Console.Write("Ile dni trwa wyprawa? ");
    dni = int.Parse(Console.ReadLine());
}

for (int i = 1; i <= dni; i++)
{
    Console.Write("Złoto w dniu " + i + ": ");
    int zloto = int.Parse(Console.ReadLine());

    suma = suma + zloto;

    if (zloto > 10)
    {
        udaneDni = udaneDni + 1;
    }
}

Console.WriteLine();
Console.WriteLine("Łącznie znaleziono: " + suma + " sztuk złota.");
Console.WriteLine("Dni z wynikiem powyżej 10: " + udaneDni);
