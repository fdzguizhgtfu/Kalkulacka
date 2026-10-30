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
    
    string[] operace = {};
    while (!spravne1 || !spravne2 || !spravne3)
    {
        Console.WriteLine("Zadejte operaci: ");
        operace = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        if (operace.Length == 3)
        {
            spravne1 = double.TryParse(operace[0], out cislo1);
            spravne3 = double.TryParse(operace[2], out cislo2);
            Console.Clear();
            if (moznosti.Contains(operace[1]))
            {
                spravne2 = true;
            }

            if (!spravne1)
            {
                Console.WriteLine("špatné 1. číslo");
            }

            if (!spravne2)
            {
                Console.WriteLine("špatné znaménko");
            }

            if (!spravne3)
            {
                Console.WriteLine("špatné 2. číslo");
            }

            if (operace[1] == "/" && cislo2 == 0)
            {
                Console.WriteLine("0 nelze dělit!");
                spravne2 = false;
            }
            
        }

        else
        {
            Console.WriteLine("neplatný formát");
        }
    }

    Console.WriteLine(Pocet.provedeni(cislo1, cislo2, operace[1]));

    string idk = "";
    while (idk != "y"  && idk != "n")
    { 
        Console.WriteLine("Chcete pokračovat? y/n");
        idk = Console.ReadLine().ToLower();
    }

    if (idk == "n")
    {
        pokracovani = false;
    }
}