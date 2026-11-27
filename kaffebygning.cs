using System.Globalization;

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

        if (stik!= "ja" && stick != "nej")
        {
        Console.WriteLine("Du SKAL indtaste ja eller nej");     
        }
    }

    if (stik ==  "nej") 
    {
        Console.WriteLine("Stikket er i stikkontakt nu");     
     
    }
}

static void Tilvalg()
{
    int kop = 0;

    while (kop <= 0)
    {
        Console.WriteLine("Hvor mange kop skal du have?");
        string svar = (Console.ReadLine() ?? "").Trim();

        if (int.TryParse(svar, out int parsed) && parsed > 0)
        {
            kop = parsed;
        }

        else
        {
            
        } 
        
    }

}