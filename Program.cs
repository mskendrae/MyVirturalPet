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

            //Display Status of pet
            VirtualPet statusPet = new VirtualPet();
           


            Console.WriteLine("Please keep an eye on the health status of " + pandaName + " choose from the menu ways to care for your panda.");

            Console.WriteLine("Hunger " + statusPet );

           //UserInstructions to care for the Panda and accept user input
              Console.WriteLine("Please enter a number");
              Console.WriteLine("1. Give panda Bamboo?");
              Console.WriteLine("2. Give panda water?");
              Console.WriteLine("3. Let pet out to poop?");
              Console.WriteLine("4. Play with your panda outside?");
              int userChoice = int.Parse(Console.ReadLine());










        } //end main
    } //end class
} //end namespace
