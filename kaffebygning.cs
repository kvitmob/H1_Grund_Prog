brygkaffe();

static void brygkaffe()
{
    Klargøring();
    Tilvalg();
    Brygning();
}

static void Klargøring()
{
    string brugtfilter = "";
    while (brugtfilter != "ja" && brugtfilter != "nej")
    {
        Console.WriteLine("Er der brugt filter i maskine? ja/nej?");
        brugtfilter = Console.ReadLine().ToLower();

        if (brugtfilter != "ja" && brugtfilter != "nej")
        {
        Console.WriteLine("Du SKAL indtaste ja eller nej");     
        }
    }

    if (brugtfilter == "ja")
    {
        Console.WriteLine("Klargør filterholder og udskift filter");     
     
    }

    string gammelKaffe = "";
    while (gammelKaffe != "ja" && gammelKaffe != "nej")
    {
        Console.WriteLine("Er der gammel kaffe  i kanden? ja/nej?");
        gammelKaffe = Console.ReadLine().ToLower();

        if (gammelKaffe!= "ja" && gammelKaffe!= "nej")
        {
        Console.WriteLine("Du SKAL indtaste ja eller nej");     
        }
    }

    if (gammelKaffe ==  "ja") 
    {
        Console.WriteLine("Tømme kanden, vask den og retur tilbage");     
     
    }

    string stik = "";
    while (stik != "ja" && stik != "nej")
    {
        Console.WriteLine("Er stik sat i stikkontakten? ja/nej?");
        stik = Console.ReadLine().ToLower();

        if (stik!= "ja" && stik != "nej")
        {
        Console.WriteLine("Du SKAL indtaste ja eller nej");     
        }
    }

    if (stik ==  "nej") 
    {
        Console.WriteLine("Stikket er i stikkontakt nu");     
     
    }
}

static (int kop, int styrkeValg) Tilvalg()
{
    int kop = 0;

    while (kop < 1 || kop >10)
    {
        Console.WriteLine("Hvor mange kop skal du have? (1-10)");
        string svar = (Console.ReadLine() ?? "").Trim();

        if (int.TryParse(svar, out int parsed) && parsed >= 1 && parsed <=10) 
        {
            kop = parsed;
        }

        else
        {
            Console.WriteLine("Du skal indtaste tallet mellem 1-10");
        } 
    }

     int StyrkeValg = 0;

    while (StyrkeValg < 1 || StyrkeValg > 3)
    {
        Console.WriteLine("Valg kaffe styrke? (1-3)");
        string StyrkeSvar = (Console.ReadLine() ?? "").Trim();

        if (int.TryParse(StyrkeSvar, out int parsed) && parsed >= 1 && parsed <=3) 
        {
            StyrkeValg = parsed;
        }

        else
        {
            Console.WriteLine("Du skal indtaste tallet mellem 1-4");
        } 
    }

}                       

static void Brygning(int kop, int styrkeVlag)
{
    int Vand = kop * 200;
    int Styrke = StyrkeValg * kop;
    Console.WriteLine($"Hæld {Vand} ml vand i vandbeholderen \n Læg {Styrke}gr kaffe i filter \n Tryk på start knappen på kaffemaskine");

    Console.WriteLine("Er brygningen færdig?");
    string result = (Console.ReadLine() ?? "").Trim().ToLower();
    while (result != ja && result != nej)
    {
        if (result == "ja")
        {
            Console.WriteLine("Kaffen er klar");
        }
        while (result == "nej")
        {
            Console.WriteLine("Vent lidt");
            Thread.Sleep(1000);
            Console.WriteLine("Er brygningen færdig?");

        }

    }
}
