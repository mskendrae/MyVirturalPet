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
        private int petBathroom;
        private int petThirst;
        private int petHungry;
        private int petBored;


        //properties

       public int Bathroom
             {
               get {return this.petBathroom;}
               set {this.petBathroom = value;}
             }

        public int Thirst
             {
                get {return this.petThirst;}
                set {this.petThirst = value;}
             }

        public int Hungry
             {
                get {return this.petHungry;}
                set {this.petHungry = value;}
             }

         public int Bored
             {
                get {return this.petBored;}
                set {this.petBored = value;}
             }


        //contructor
        public VirtualPet(int petBathroom, int petThirst, int petHungry, int petBored)
            {
            this.petBathroom = petBathroom;
            this.petThirst = petThirst;
            this.petHungry = petHungry;
            this.petBored = petBored;
            }










    }
}
