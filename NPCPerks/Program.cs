using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            Perks[] perks;
            string aux;
            int numNPCs;
            
            //Pedir ao user o nº de NPCs 
            Console.WriteLine("Insira nº de NPC: ");
            aux = Console.ReadLine();
            numNPCs = Convert.ToInt32(aux);
            perks = new Perks[numNPCs];

            //Pedir cada NPC, pedir caracteristicas
            for (int i = 0; i < numNPCs; i++)
            {
                Console.WriteLine($"NPC {i} tem Stealth (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= Perks.Stealth;
                }

                Console.WriteLine($"NPC {i} tem Combat (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= Perks.Combat;
                }

                Console.WriteLine($"NPC {i} tem Lockpick (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= Perks.Lockpick;
                }

                Console.WriteLine($"NPC {i} tem Luck (s/n)? ");
                aux = Console.ReadLine();
                if (aux.ToLower() == "s")
                {
                    perks[i] |= Perks.Luck;
                }

            }

            //Mostrar no ecr as caracteristicas
            Console.WriteLine();

            for (int i = 0; i < numNPCs; i++)
            {
                Perks p = Perks.Combat | Perks.Luck;
                Console.WriteLine($"Perks do NPC {i}: {perks[i]}");

                if ((perks[i] & p) == p)
                {
                    Console.WriteLine("\tYou shall win all figths");
                }
            }

        }
    }
}
