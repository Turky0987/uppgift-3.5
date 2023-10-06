using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange det första talet: ");
        double tal1;
        if (!double.TryParse(Console.ReadLine(), out tal1))
        {
            Console.WriteLine("Ogiltig inmatning. Ange ett giltigt tal.");
            return;
        }

        Console.Write("Ange det andra talet: ");
        double tal2;
        if (!double.TryParse(Console.ReadLine(), out tal2))
        {
            Console.WriteLine("Ogiltig inmatning. Ange ett giltigt tal.");
            return;
        }

        Console.WriteLine("Välj ett räknesätt:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");

        int val;
        if (!int.TryParse(Console.ReadLine(), out val) || val < 1 || val > 4)
        {
            Console.WriteLine("Ogiltigt val av operation.");
            return;
        }

        double resultat = 0;

        switch (val)
        {
            case 1:
                resultat = tal1 + tal2;
                break;
            case 2:
                resultat = tal1 - tal2;
                break;
            case 3:
                resultat = tal1 * tal2;
                break;
            case 4:
                if (tal2 != 0)
                {
                    resultat = tal1 / tal2;
                }
                else
                {
                    Console.WriteLine("Division med noll är inte tillåten.");
                    return;
                }
                break;
        }

        Console.WriteLine($"Resultatet av beräkningen är: {resultat}");
    }
}

