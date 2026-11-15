// Zad 4
int tury = 0;

while (true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");

    string tekst = Console.ReadLine();

    // Sprawdzamy, czy wpisano liczbę całkowitą
    if (!int.TryParse(tekst, out tury))
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    // Sprawdzamy, czy liczba jest mniejsza od 1
    if (tury < 1)
    {
        Console.WriteLine("Liczba jest za mała.");
        continue;
    }

    // Sprawdzamy, czy liczba jest większa od 10
    if (tury > 10)
    {
        Console.WriteLine("Liczba jest za duża.");
        continue;
    }

    // Jeśli liczba jest poprawna, kończymy pętlę
    break;
}

Console.WriteLine("Rozpoczynam grę na " + tury + " tur.");

// Odliczamy tury
for (int i = tury; i >= 1; i--)
{
    Console.WriteLine("Pozostało tur: " + i);
}

Console.WriteLine("Koniec gry!");
