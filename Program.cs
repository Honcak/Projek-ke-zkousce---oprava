using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //vytvoření listu
            LinkedList<Zaznam> pojistnici = new LinkedList<Zaznam>();
            string prikaz = "";

            do
            {
                //zobrazení menu, počet pojištěných a zadání příkazu
                VytiskniMenu();
                Console.WriteLine("Počet pojištěných: {0}", pojistnici.Count);
                Console.Write("Zadej příkaz: ");
                prikaz = Console.ReadLine();

                // podle zmáčknutí tlačítek se provede akce
                switch (prikaz)
                {
                    case "1":
                        pojistnici.AddLast(VytvorNovehoPojistnika());
                        
                        break;
                    case "2":
                        Console.WriteLine("Všechny záznamy:");
                        foreach (Zaznam pojistnik in pojistnici)
                        {
                            TiskniZaznam(pojistnik);
                        }
                        //Bez toho se vymaže obrazovka a nic se neukáže
                        Console.WriteLine();
                        Console.Write("Stiskni libovolnou klávesu: ");
                        Console.ReadLine();

                        break;
                    case "3":
                        Console.Write("Zadej Jmeno: ");
                        string jmeno = Console.ReadLine();
                        Console.Write("Zadej Prijmeni: ");
                        string prijmeni = Console.ReadLine();

                        foreach (Zaznam pojistnik in pojistnici)
                        {
                            if ((pojistnik.Jmeno == jmeno) && (pojistnik.Prijmeni == prijmeni)) 
                            {
                                TiskniZaznam(pojistnik);

                            }
                            
                        }
                        //Bez toho se vymaže obrazovka a nic se neukáže
                        Console.WriteLine();
                        Console.Write("Stiskni libovolnou klávesu: ");
                        Console.ReadLine();
                        break;
                }
            }
            while (prikaz != "4");
        }

        //Menu
        static void VytiskniMenu()
        {
            Console.Clear();


            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Evidence pojištěných.");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1 - Přidat nového pojištěného.");
            Console.WriteLine("2 - Vypsat všechny pojištěné.");
            Console.WriteLine("3 - Vyhledat pojištěného.");
            Console.WriteLine("4 - Konec");
            
        }

        //Vypsání záznamu
        static void TiskniZaznam(Zaznam zaznam)
        {
            Console.WriteLine("{0}, {1}  tel.: {2}, věk: {3}", zaznam.Prijmeni, zaznam.Jmeno, zaznam.Mobil, zaznam.Vek);
        }

        //vytvoření pojistníka
        static Zaznam VytvorNovehoPojistnika()
        {
            Console.Write("Zadej Jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadej Prijmeni: ");
            string prijmeni = Console.ReadLine();
            Console.Write("Zadej Mobil: ");
            string mobil = Console.ReadLine();
            Console.Write("Zadej Vek: ");
            string vek = Console.ReadLine();

            return new Zaznam(jmeno, prijmeni, mobil, vek);

        }
    }
}