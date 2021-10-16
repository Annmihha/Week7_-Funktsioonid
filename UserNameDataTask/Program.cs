using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutaja eesnime;
            // programm küsib kautajal sisestada number vahemikus 1-3;
            // kui kasutaja sisestab '1', siis programm kuvab kasutaja eesnime tagurpidi;
            // kui kasutaja sisestab '2', siis programm kuvab kasutaja eesnime esimest tähte;
            // kui kasutaja sisestab '3', siis programm kuvab kasutaja eesnime pikkust;

            Console.WriteLine("Palun sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta üks number vahemikus 1 - 3");
            int userNumber = Convert.ToInt32(Console.ReadLine());


            switch (userNumber)

            {
              case 1:
                    for (int i = userName.Length - 1; i >= 0; i--) // programm kuvab kasutaja eesnime tagurpidi
                    {
                        Console.Write(userName[i]);
                    }
                    break;

                case 2:
                    Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}."); // programm kuvab eesnime esimest tähte
                    break;

                case 3:
                    Console.WriteLine($"Sinu eesnimi sisaldab {userName.Length} sümbolit."); // programm kuvab eesnime pikkust
                    break;

                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }
    }
}
