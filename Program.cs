using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace ConsoleApp26
{
   
    class rocket
    {
        public string rocketname;
        public rocket(string name)
        {
            rocketname = name;
        }
        public static implicit operator string (rocket p)
        {
            return p.rocketname;
        }
        public static implicit operator rocket(string p)
        {
            return new rocket(p);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
    
            rocket rocket1 = new rocket("");
            rocket rocket2 = new rocket("");
            bool shouldRun = false;
            while (!shouldRun)
            {
               Clear();
               WriteLine("1: add rocket ");
               WriteLine("2: list of rocket ");
               WriteLine("3: list of rocket ");
               WriteLine("4: Exit ");
                ConsoleKeyInfo input2 =ReadKey();
                switch (input2.Key)

                {
                    case ConsoleKey.D1:
                       Clear();
                        string ro1 = "1 Starship, SpaceX ";
                        string ro2 = "2 Falcon Heavy, SpaceX ";
                       WriteLine(ro1);
                       WriteLine(ro2);
                        ConsoleKeyInfo input =ReadKey();
                        switch (input.Key)
                        {
                            case ConsoleKey.D1:

                                if (rocket1 == "")
                                {
                                    rocket1 = "Starship, SpaceX";
                                   Clear();
                                   WriteLine("rocket add");
                                   
                                    Thread.Sleep(1000);

                                }
                                else if (rocket1 == "Starship, SpaceX")
                                {
                                   Clear();
                                    WriteLine("Rocket already added");
                                    Thread.Sleep(1000);
                                }

                                break;
                            case ConsoleKey.D2:

                                if (rocket2 == "")
                                {
                                    rocket2 = "Heavy Falcon, SpaceX";
                                   Clear();
                                    WriteLine("rocket add");
                                    Thread.Sleep(1000);
                                }
                                else if (rocket2 == "Heavy Falcon, SpaceX")
                                {
                                   Clear();
                                  WriteLine("Rocket already added");
                                    Thread.Sleep(1000);
                                }

                                break;
                        }
                        break;

                    case ConsoleKey.D2:
                       Clear();
                       WriteLine("Simulated rockets");
                       WriteLine("-----------------------------------------------------------------");
                        if(rocket1 == "Starship, SpaceX")
                        {
                           WriteLine(rocket1);
                        }
                        if (rocket2 == "Heavy Falcon, SpaceX")
                        {
                           WriteLine(rocket2);
                        }
                       ReadKey();
                        break;
                    case ConsoleKey.D3:
                        Clear();
                        Write("Engine burn period (sec): ");
                        int sec = Convert.ToInt32(ReadLine());
                        string nameRocket = "Rocket";
                        string Velocity = "   Velocity(km / s)";
                        string Fuel = " Fuel left(tons)";

                        WriteLine(nameRocket.PadLeft(0) + Velocity.PadLeft(25) + Fuel.PadLeft(35));
                        WriteLine("------------------------------------------------------------------");


                        if (rocket1 == "Starship, SpaceX")
                        {
                            WriteLine(rocket1 + (sec / 0.4).ToString().PadLeft(25) + (sec * 35.8).ToString().PadLeft(25));
                        }
                        if (rocket2 == "Heavy Falcon, SpaceX")
                        {
                            WriteLine(rocket2 + (sec / 0.4).ToString().PadLeft(21) + (sec * 35.8).ToString().PadLeft(25));
                        }
                        WriteLine("<Press key to continue>");

                        ReadKey();
                        break;
                       
                    case ConsoleKey.D4:
                       Clear();
                        shouldRun = true;
                        break;
                }
        
            }
        
           
        }
    }
}
