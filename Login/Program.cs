using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus
            //programm küsib kasutajal sisestada parool
            //programm kontrollib, kas mõlemad, nii kasutajatunnus kui ka parool on õiged
            //kui mõlemad, kasutajatunnus ja parool on õiged, programm kuvab konsoolis "Tere tulemast!"
            //kui kasutajatunnus või parool on vale, siis programm kuvab "sisselogimine ebaõnnestus. Proovi uuesti"
            //kt: admin, pr: admin1234

            Console.WriteLine("Username:");
            string UserName = Console.ReadLine();

            Console.WriteLine("Password:");
            string PassWord = Console.ReadLine();

            if (UserName != "admin" || PassWord != "admin1234")
            {
                Console.WriteLine("Sisselogimine ebaõnnestus. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere Tulemast!");
            }
        }
    }
}
