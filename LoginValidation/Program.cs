using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string UserName = Console.ReadLine();
                
                Console.WriteLine("Sisesta salasõna");
                string UserPassword = Console.ReadLine();
                
                if (UserName == "admin" && UserPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. {3 - i} katset on jäänud");
                }


            }
            

        }
    }
}
