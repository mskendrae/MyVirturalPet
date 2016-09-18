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
        private int petPoop = 7;
        private int petThirst = 6;
        private int petHungry =8 ;
        private int petBored = 3;
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

        public int feedPet()
           {
            petPoop ++;
            petThirst ++;
            petHungry -= 3;
            petBored +=2;

            Console.WriteLine("Hunger = " + Hunger);
            Console.WriteLine("Thirst = " + Thirst);
            Console.WriteLine("Needs a Break = " + Poop);
            Console.WriteLine("Play  =" + Bored);

            return petHungry; 
            }
        
        public int waterPet()
          {
            petPoop += 2;
            petThirst-=3;
            petHungry += 1;
            petBored += 3;

            return petThirst;
          }

        public int walkPet()
          {
            petPoop -= 4;
            petThirst += 2;
            petHungry += 2;
            petBored -= 3;

            return petPoop;
          }


        public int playBall()
        {
            petPoop -= 2;
            petThirst += 2;
            petHungry += 2;
            petBored -= 4;

            return petBored;
        }

       




    }// end class


    }//end namespace

