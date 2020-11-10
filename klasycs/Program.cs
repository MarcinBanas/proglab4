using System;

namespace klasycs
{
    class Program
    {



        static void Main(string[] args)
        {
            Ksiazka[,,] Biblioteka = new Ksiazka[3, 6, 10];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        Biblioteka[i, j, k] = new Ksiazka("Hobbit", "Tolkien", i, j, k);
                    }
                }
            }
            int a=0;
            Biblioteka[0, 0, 9].Autor = "Banas";
            Biblioteka[0, 0, 9].Tytul = "Marcin";
            Console.WriteLine("Podaj tytul lub autora ksiazki:");
            string x = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (Biblioteka[i, j, k].Autor.Contains(x) == true || Biblioteka[i, j, k].Tytul.Contains(x) == true)
                        {
                            Console.WriteLine("Tytul: " + Biblioteka[i, j, k].Tytul + " Autor: " + Biblioteka[i, j, k].Autor + " Nr regalu: " + Biblioteka[i, j, k].Regal + " Nr polki: " + Biblioteka[i, j, k].Polka + " Nr miejsca: " + Biblioteka[i, j, k].Miejsce);
                            a++;                        
                        }
                    }
                }
            }
            if (a == 0)
                Console.WriteLine("Podany tytul/autor nie pasuje do zadnej ksiazki.");
        }
    }
}
