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
        private int PetBath = 30;
        private int petThirst =30;
        private int petHungry =30;
        private int petBored = 30;
       
      //properties

        public int Bath
        {
            get { return this.PetBath; }
            set { this.PetBath = value; }
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

        public VirtualPet(int petBath, int petThirst, int petHungry, int petBored)
        {
            this.PetBath = petBath;
            this.petThirst = petThirst;
            this.petHungry = petHungry;
            this.petBored = petBored;
        }


        //methods -- VERBS 
        // All of these methods change the counters of the pets health each time a menu
        //choice is made.  All variables are effected.  methods also prints out the new
        //heath of the pet.

        public void feedPet()
           {
            PetBath ++;
            petThirst ++;
            petHungry -= 5;
            petBored +=2;

            Console.WriteLine();
            Console.WriteLine("LingLu\'s  Heath");
            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Dirty = " + Bath);
            Console.WriteLine("Play = " + Bored);
            Console.WriteLine();

            // return petHungry; 
        }
        
        public void waterPet()
          {
            PetBath += 2;
            petThirst-=5;
            petHungry += 1;
            petBored += 3;

            Console.WriteLine();
            Console.WriteLine("LingLu\'s  Heath");
            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Dirty = " + Bath);
            Console.WriteLine("Play = " + Bored);

          }

        public void bathPet()
          {
            PetBath -= 5;
            petThirst += 2;
            petHungry += 2;
            petBored -= 5;

            Console.WriteLine();
            Console.WriteLine("LingLu\'s  Heath");
            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Dirty = " + Bath);
            Console.WriteLine("Play = " + Bored);

            //return petPoop;
          }


        public void playBall()
        {
            PetBath -= 5;
            petThirst += 2;
            petHungry += 2;
            petBored -= 5;

            Console.WriteLine();
            Console.WriteLine("LingLu\'s  Heath");
            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Dirty = " + Bath);
            Console.WriteLine("Play = " + Bored);

          //  return petBored;
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
    
    }// end class


    }//end namespace

