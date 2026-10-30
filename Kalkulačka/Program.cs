using Kalkulačka;

bool pokracovani = true;
while (pokracovani)
{
    bool spravne1 = false;
    bool spravne2 = false;
    bool spravne3 = false;
    string[] moznosti = { "+", "-", "/", "*" };
    double cislo1 = 0;
    double cislo2 = 0;
    
    Console.WriteLine("Zadejte operaci: ");
    string[] operace = {};
    while (!spravne1 && !spravne2 && !spravne3)
    {
        operace = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        spravne1 = double.TryParse(operace[0], out cislo1);
        spravne2 = double.TryParse(operace[2], out cislo2);
        if (moznosti.Contains(operace[1]))
        {
            spravne3 = true;
        }
    }

    Console.WriteLine(Pocet.provedeni(cislo1, cislo2, operace[1]));
}