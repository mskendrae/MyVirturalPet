using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVirturalPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Greeting 
            Console.WriteLine("Welcome to Virtural Panda Pet!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   ,,,         ,,,");
            Console.WriteLine(" ; \"   ^;     ;'   \" ; ");
            Console.WriteLine("      ; s$$$$$$$s;   ");
            Console.WriteLine("   ,  s$$$$$$$$$$s  ,'");
            Console.WriteLine("   ; s$$$$$$$$$$$$$$$   ");
            Console.WriteLine("    $$$$$$$$$$$$$$$$$   ");
            Console.WriteLine("   $$$$P\"\"Y$$$Y\"\"W$$$$$   ");
            Console.WriteLine("   $$$$  p\"$$$\"q  $$$$$  ");
            Console.WriteLine("    $$$$  .$$$$$.  $$$$    ");
            Console.WriteLine("     $$$$$$$$$$$$$$$$$     ");
            Console.WriteLine("     \"Y$$$\" * \"$$$Y\"   ");
            Console.WriteLine("         \"$$$$$\"   ");
            Console.WriteLine();

            string pandaName = "LingLu";

            Console.WriteLine("The panda your are interacting with today is LingLu:");
            Console.WriteLine("Please keep an eye on her health status and choose from the menu ways to interact with her.");
            Console.WriteLine("Pandas are solitary creatures so we will only have 10 opportunites to work with her.");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            

            //Connect the VirtualPet class to the main. by using "panda" as the reference
            VirtualPet panda = new VirtualPet();

            //this is the initial menu area showing the initial health and the menu choices.
            Console.WriteLine("Here is " + pandaName + "\'s current heath. ");
            Console.WriteLine("Hunger = " + panda.Hunger);
            Console.WriteLine("Thirst = " + panda.Thirst);
            Console.WriteLine("Dirty = " + panda.Bath);
            Console.WriteLine("Play with " + pandaName + " = " + panda.Bored);

            //Spacing
            Console.WriteLine();

            int counter = 0;
            while (counter <= 10)
            {
                //UserInstructions to care for the Panda and accept user input
 
                Console.WriteLine("Please enter an number");
                Console.WriteLine();
                Console.WriteLine("1. Give panda Bamboo?");
                Console.WriteLine("2. Give panda water?");
                Console.WriteLine("3. Give panda a bath?");
                Console.WriteLine("4. Play with " + pandaName + " outside?");
                Console.WriteLine("5. Let panda sleep and end session");

                int menuChoice = int.Parse(Console.ReadLine());
             
                if (menuChoice <= 0 || menuChoice >= 6)
                {
                    Console.WriteLine("That is an invalid choice. Press enter to continue.");
                    Console.ReadLine();
                }

                else if (menuChoice == 1)
                {
                    panda.feedPet();
                }

                else if (menuChoice == 2)
                {
                    panda.waterPet();
                }

                else if (menuChoice == 3)
                {
                    panda.bathPet();
                }

                else if (menuChoice == 4)
                {
                    panda.playBall();
                }

                else if (menuChoice == 5)
                {
                    panda.sleep();
                }//end esle if

                counter++;
           } //end while

             Console.WriteLine("Thank you for taking care of the Panda today. ");
             Console.ReadLine();

        } //end main
    } //end class
} //end namespace
