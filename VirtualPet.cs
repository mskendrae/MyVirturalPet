using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVirturalPet
{
    class VirtualPet 
    {
        //fields
        private int petPoop = 50;
        private int petThirst =50;
        private int petHungry =50;
        private int petBored = 50;
      //  private int petStatus;

        //properties

        public int Poop
        {
            get { return this.petPoop; }
            set { this.petPoop = value; }
        }

        public int Thirst
        {
            get { return this.petThirst; }
            set { this.petThirst = value; }
        }

        public int Hunger
        {
            get { return this.petHungry; }
            set { this.petHungry = value; }
        }

        public int Bored
        {
            get { return this.petBored; }
            set { this.petBored = value; }
        }

        //contructor
        public VirtualPet()
        {

        }

        public VirtualPet(int petPoop, int petThirst, int petHungry, int petBored)
        {
            this.petPoop = petPoop;
            this.petThirst = petThirst;
            this.petHungry = petHungry;
            this.petBored = petBored;
        }


        //methods -- VERBS 
        // All of these methods change the counters of the pets health each time a menu
        //choice is made.  All variables are effected.  methods also prints out the new
        //heath of the pet.

        public int feedPet()
           {
            petPoop ++;
            petThirst ++;
            petHungry -= 5;
            petBored +=2;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Needs a Break = " + Poop);
            Console.WriteLine("Play = " + Bored);

            return petHungry; 
            }
        
        public int waterPet()
          {
            petPoop += 2;
            petThirst-=5;
            petHungry += 1;
            petBored += 3;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Needs a Break = " + Poop);
            Console.WriteLine("Play = " + Bored);

            return petThirst;
          }

        public int walkPet()
          {
            petPoop -= 5;
            petThirst += 2;
            petHungry += 2;
            petBored -= 5;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Needs a Break = " + Poop);
            Console.WriteLine("Play = " + Bored);

            return petPoop;
          }


        public int playBall()
        {
            petPoop -= 5;
            petThirst += 2;
            petHungry += 2;
            petBored -= 5;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Needs a Break = " + Poop);
            Console.WriteLine("Play = " + Bored);

            return petBored;
        }

            public void sleep()
             {
            Console.WriteLine(" Your panda is sleeping.  Thank you for helping to care for our panda.");
            Console.WriteLine("Please type 5 again to quit.");
            int userExit = int.Parse(Console.ReadLine());
            if (userExit == 5)
            {
                Environment.Exit(0);
            }
            
           
            }//end sleep

            public void mainMenu()
            {
            Console.WriteLine();
            Console.WriteLine("Please enter an number");
            Console.WriteLine();
            Console.WriteLine("1. Give panda Bamboo?");
            Console.WriteLine("2. Give panda water?");
            Console.WriteLine("3. Let pet out to poop?");
            Console.WriteLine("4. Play with your panda outside?");
            Console.WriteLine("5. Let panda sleep");
            int menuChoice = int.Parse(Console.ReadLine());

             }             
    
        public int wrongChoice()
             {

            Console.WriteLine();
            Console.WriteLine("Sorry, Please enter an number 1 through 5");
            Console.WriteLine();
            Console.WriteLine("1. Give panda Bamboo?");
            Console.WriteLine("2. Give panda water?");
            Console.WriteLine("3. Let pet out to poop?");
            Console.WriteLine("4. Play with your panda outside?");
            Console.WriteLine("5. Let panda sleep");
            int menuChoice = int.Parse(Console.ReadLine());

            return menuChoice;
            
        }

  
    }// end class


    }//end namespace

