using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada oma eesnime
            //Programm kuvab kasutaja eesnime pikkuse
            //Programm kuvab kasutaja eesnime esimese tähe
            //Programm kuvab kasutaja eesnime tagurpidi
            //Main meetodis ei tohi olla rohkem, kui kolm rida koodi

            Console.WriteLine("Sisesta oma eesnimi");
            string userName = Console.ReadLine();
            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sumblit pikk.");
            Console.WriteLine($"Sinu eesnimi esimene taht on {userInput[0]}");

            for(int i = userInput.Length - 1; i>= 0; i++)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
