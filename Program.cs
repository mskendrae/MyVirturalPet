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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please name your panda:");
            string pandaName = Console.ReadLine();

            //Connect the VirtualPet class to the main. by using "panda" as the reference
            VirtualPet panda = new VirtualPet();


            //this is the initial menu area showing the initial pet health and the menu choices.
            Console.WriteLine("Please keep an eye on the health status of " + pandaName + " choose from the menu ways to care for your panda.");

            //Initial pet health
            Console.WriteLine("Hunger = " + panda.Hunger);
            Console.WriteLine("Thirst = " + panda.Thirst);
            Console.WriteLine("Needs a Break = " + panda.Poop);
            Console.WriteLine("Play with  " + pandaName + " = " + panda.Bored);

            //Spacing
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //UserInstructions to care for the Panda and accept user input
            Console.WriteLine("Please enter a number");
            Console.WriteLine("1. Give panda Bamboo?");
            Console.WriteLine("2. Give panda water?");
            Console.WriteLine("3. Let pet out to poop?");
            Console.WriteLine("4. Play with your panda outside?");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice >= 1 && menuChoice <= 4)
                {

                    switch (menuChoice)
                   {
                    case 1:
                        panda.feedPet();
                        panda.mainMenu();
                        break;

                    case 2:
                        panda.waterPet();
                        panda.mainMenu();
                        break;

                    case 3:
                        panda.walkPet();
                        panda.mainMenu();
                        break;

                    case 4:
                        panda.playBall();
                        panda.mainMenu();
                        break;
                    }//end switch

                  }  //end top if

                    else
                    {
                    panda.wrongChoice();
                    } // end else

                   


            Console.ReadLine();








        } //end main
    } //end class
} //end namespace
