// HovedAlgoritme

BrygTe();

static void BrygTe()
{
    Klargøring();
    Brygning();
    Tilvalg();

    Console.WriteLine("Teen er klar");
}



//klargøring subrutine
static void Klargøring()
{
    Console.WriteLine("Hæld 250 ml vand i elkedlen");

    string svar1 = "";
    while (svar1 != "ja" && svar1 != "nej")
    {
        Console.Write("Er elkedlens stik sat i stikkontakten? (ja/nej): ");
        svar1 = Console.ReadLine().ToLower();

        if (svar1 == "nej")
        {
            Console.WriteLine("Sæt stikket i stikkontakten");
        }
        else if (svar1 != "ja")
        {
            Console.WriteLine("Du skal skrive ja eller nej");
        }
    }

    Console.WriteLine("Kog vandet");

    string svar2 = "";
    while (svar2 != "ja" && svar2 != "nej")
    {
        Console.Write("Er der gammel te eller pose i koppen? (ja/nej): ");
        svar2 = Console.ReadLine().ToLower();

        if (svar2 == "ja")
        {
            Console.WriteLine("Tøm koppen og vask den");
        }
        else if (svar2 != "nej")
        {
            Console.WriteLine("Du skal skrive ja eller nej");
        }
    }

    Console.WriteLine("Læg en ny tepose");
}

// brygning subrutine
static void Brygning()
{
    Console.WriteLine("Hæld 250 ml vand i koppen");

    int valg = 0;
    int minutter = 0;

    while (valg != 1 && valg != 2 && valg != 3)
    {
        Console.WriteLine("Vælg te styrke:");
        Console.WriteLine("1 Mild = 2 min");
        Console.WriteLine("2 Mellem = 3 min");
        Console.WriteLine("3 Stærk = 5 min");

        valg = int.Parse(Console.ReadLine());

        if (valg == 1)
        {
            minutter = 2;
        }
        else if (valg == 2)
        {
            minutter = 3;
        }
        else if (valg == 3)
        {
            minutter = 5;
        }
        else
        {
            Console.WriteLine("Du skal angive tallet mellem 1 og 3");
        }
    }

    Console.WriteLine($"Venter i {minutter} minutter...");
    Thread.Sleep(minutter * 1000);

    Console.WriteLine("Fjern teposen");
}

// subrutine tilvalg
static void Tilvalg()
{
    string mælkSvar = "";
    while (mælkSvar != "ja" && mælkSvar != "nej")
    {
        Console.Write("Mælk? (ja/nej): ");
        mælkSvar = Console.ReadLine().ToLower();

        if (mælkSvar == "ja")
        {
            Console.WriteLine("+20ml mælk i koppen og rør rundt");
        }
        else if (mælkSvar != "nej")
        {
            Console.WriteLine("Du skal skrive ja eller nej");
        }
    }

    string sukkerSvar = "";
    while (sukkerSvar != "ja" && sukkerSvar != "nej")
    {
        Console.Write("Sukker? (ja/nej): ");
        sukkerSvar = Console.ReadLine().ToLower();

        if (sukkerSvar == "nej")
        {
            return; // Stopper metoden her
        }
        else if (sukkerSvar != "ja")
        {
            Console.WriteLine("Du skal skrive ja eller nej");
        }
    }

    string sukkerValg = "";
    while (sukkerValg != "1" && sukkerValg != "2" && sukkerValg != "3")
    {
        Console.WriteLine("Valgmuligheder:");
        Console.WriteLine("1 = 1 teske");
        Console.WriteLine("2 = 2 teske");
        Console.WriteLine("3 = 3 teske");

        sukkerValg = Console.ReadLine();

        if (sukkerValg != "1" && sukkerValg != "2" && sukkerValg != "3")
        {
            Console.WriteLine("Du skal angive tallet mellem 1 og 3");
        }
    }

    Console.WriteLine($"Læg {sukkerValg} teske af sukker i koppen og rør rundt");
}