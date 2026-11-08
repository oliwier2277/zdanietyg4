int i = 1;
// Petla while - od 1 do 10
Console.Write("While: ");
while (i <= 10)
{
    Console.Write(i + " ");
    i++;
}

Console.WriteLine();

// Petla do-while - od 1 do 10
i = 1;
Console.Write("Do-while: ");
do
{
    Console.Write(i + " ");
    i++;
} while (i <= 10);

Console.WriteLine();

// Petla for - od 1 do 10
Console.Write("rosnaco: ");
for (int j = 1; j <= 10; j++)
{
    Console.Write(j + " ");
}

Console.WriteLine();

// Liczby od 10 do 1
Console.Write("malejace: ");
for (int j = 10; j >= 1; j--)
{
    Console.Write(j + " ");
}

Console.WriteLine();

// Liczby parzyste od 0 do 20
Console.Write("parzyste: ");
for (int j = 0; j <= 20; j += 2)
{
    Console.Write(j + " ");
}

Console.WriteLine();

// komunikat na koniec
Console.WriteLine("Start!");