string produktNavn = "Trådløst Tastatur";

decimal prisEksklMoms = 799.99m;
decimal momsSats = 0.25m;
decimal momsBeløb = prisEksklMoms * momsSats;
decimal prisInklMoms = prisEksklMoms + momsBeløb;

Console.WriteLine(" =================================");
Console.WriteLine("   ((         PRODUKT INFO      ))");
Console.WriteLine(" =================================");
Console.WriteLine($"Produkt: {produktNavn}");
Console.WriteLine($"Pris (ekskl. moms): {prisEksklMoms:N2} kr"); 
Console.WriteLine($"Moms ({momsSats:P}): {momsBeløb:N2} kr"); //:P = procentformat, N2 = to decimal places
Console.WriteLine($"Pris (inkl. moms): {prisInklMoms:N2} kr");
Console.WriteLine(" =================================");
Console.WriteLine("   ((         FINISH          ))");
Console.WriteLine(" =================================");