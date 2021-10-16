using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // AddTwoNumbers(20, 6);
            // DivideTwoNumbers(20, 6);

            Console.WriteLine("Sisesta esimene arv:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe (sisesta '+', '-', '*' või '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());
                
        switch (userOperator)
        {
           case '+':
           AddTwoNumbers(userNumberOne, userNumberTwo);
        break;

        case '/':
        DivideTwoNumbers(userNumberOne, userNumberTwo);
        break;

               
                case '-': // iseseisva töö osa)
                    SubtractionTwoNumbers(userNumberOne, userNumberTwo);
                    break;

                case '*': // iseseisva töö osa)
                    MultipleTwoNumbers(userNumberOne, userNumberTwo);
                    break;

        default:
        Console.WriteLine("Kena päeva!");
            break;
        }
    }

        public static void SubtractionTwoNumbers(int x, int y) // iseseisva töö osa)
        {
            int result = x - y;
            Console.WriteLine(result);
        }

        public static void MultipleTwoNumbers(int x, int y) // iseseisva töö osa)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        public static void AddTwoNumbers(int x, int y) // järgnevat kasutati ka etteantud numbrite puhul (variant ridadel 9 ja 10)
        {
        int result = x + y;
        Console.WriteLine(result);
        }

    public static void DivideTwoNumbers(double x, double y )
        {
            double result = x / y;
            Console.WriteLine(result);
        }

    }
}
