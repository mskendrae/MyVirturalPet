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
        private int petPoop;
        private int petThirst;
        private int petHungry ;
        private int petBored;
      //  private int petStatus;

        //properties

        public int Poop
        {
            get { return this.petPoop; }
            set { this.petPoop = 10; }
        }

        public int Thirst
        {
            get { return this.petThirst; }
            set { this.petThirst = 7; }
        }

        public int Hunger
        {
            get { return this.petHungry; }
            set { this.petHungry = 8; }
        }

        public int Bored
        {
            get { return this.petBored; }
            set { this.petBored = 5; }
        }

      //  public int Status
      // {
      //      get { return this.petStatus; }
      //      set { this.petStatus = value; }
    //    }

       
        //methods

        public int feedPet()
           {
            petPoop ++;
            petThirst ++;
            petHungry -= 3;
            petBored +=2;

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




    }// end class


    }//end namespace

