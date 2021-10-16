using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm palub sisestada kasutaja eesnime;
            // programm kuvab kasutaja eesnime pikkust;
            // programm kuvab kasutaja eesnime esimest tähte;
            // programm kuvab kasutaja eesnime tagurpidi;
            // main meetodis tohib kasutada ainult kolm rida koodi;

                      
            Console.WriteLine("Palun sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu eesnimi sisaldab {userInput.Length} sümbolit."); // programm kuvab eesnime pikkust
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}."); // programm kuvab eesnime esimest tähte
            
            for(int i = userInput.Length -1; i >= 0; i--) // programm kuvab kasutaja eesnime tagurpidi
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
