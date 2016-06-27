﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
        //Properties
        //  Name
        //  Hunger (and how feeding works)
        //  Thirst (and how watering works)
        //  Health ("              ")
        //  Bathroom ("               " )
        //  Train ("              ")

        public string Name { get; set; }

        private int hunger;
        private int maxHungerThirst = 0;
        private int minHungerThirst = 10;
        private int minStat = 0;
        private int maxStat = 0;

        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
                if (hunger < maxHungerThirst) 
                {
                    Console.WriteLine("\n {0} is full! Maybe try some training to burn off those calories!", Name);
                    hunger = maxHungerThirst;
                }
                if (hunger > minHungerThirst) 
                {

                    hunger = minHungerThirst;
                }


            }


        }



        private int thirst;
        public int Thirst
        {
            get
            {
                return thirst;
            }
            set
            {
                thirst = value;
                if (thirst < maxHungerThirst)
                {
                    Console.WriteLine("\n {0} is not thirsty! Maybe try some training!", Name);
                    thirst = maxHungerThirst;
                }
                if (thirst > minHungerThirst)
                {

                    thirst = minHungerThirst;
                }


            }


        }


        private int health;
        public int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
                if (Hunger <= 2 || Thirst <= 2 || Health <= 2)
                {
                    Console.WriteLine("\n {0} is very weak! You need to check their vitals and train if you ever want to see battle!", Name);
                }
                if (health > maxStat)
                {
                    health = maxStat; // may modify later to allow super healthy pet
                    Console.WriteLine("\n {0} is in great shape! The two of you will make great warriors!", Name);
                    health = maxStat;
                }
                if (health < minHungerThirst)
                {

                    health = minHungerThirst;
                }

            }
        }
        // possibly modified later to make more robust. Initally wanted it to be a bool
        private int bathroom;
        public int Bathroom
        {
            get
            {
                return bathroom;
            }
            set
            {
                bathroom = value;
                if (bathroom < maxStat)
                {
                    Console.WriteLine("\n {0} does not need to go to the bathroom! It could be hungry or thirsty... Or maybe try some training!", Name);
                    bathroom = maxStat;
                }
                if (bathroom > minStat)
                {

                    bathroom = minStat;
                }

            }

        }



        public int Train { get; set; }

        
        //Pet Methods
        //Constructors 
        public Pet()
        {
            //TODO
            Hunger = 5;
            Thirst = 5;
            Health = 7;
            Bathroom = 5;
            Train = 2;

        }

        //name method
        public string PantherName()
        {
            return Name = Console.ReadLine();
        }
        //---------------------


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("\n--------------------------------------------------");
            sb.AppendFormat("XXXXXX~~~| Panther Totem: {0} Stats |~~~XXXXXX\n", Name);
            sb.AppendLine("--------------------------------------------------\n");
            sb.AppendFormat("Hunger: {0}                                     |\n", Hunger);
            sb.AppendFormat("Thirst: {0}                                     |\n", Thirst);
            sb.AppendFormat("Health: {0}                                     |\n", Health);
            sb.AppendFormat("Bathroom: {0}                                   |\n", Bathroom);
            sb.AppendFormat("Train: {0}                                      |\n", Train);
            sb.AppendLine("\n--------------------------------------------------");
            sb.AppendLine("XXXXXXXX~~~|XXXXXXXXXXXXXXXXXXXXXXXXXX|~~~XXXXXXXX");
            sb.AppendLine("--------------------------------------------------");

            return sb.ToString();
        }

        //-----------------------------------

        public int PantherHunger()
        {
            //Todo
          
                Hunger++;
                Thirst -= 1;
                Bathroom += 1;

            Console.WriteLine(" You've fed {0}! Their Hunger is now {1}", Name, Hunger);
            Console.ReadKey();
            return Hunger;
            
            //Tick()
        }
        // ------------------------
        public int PantherThirst()
        {
            //Todo                      
          
                Thirst++;
                Hunger += 1;
                Bathroom += 2;

            Console.WriteLine(" You've watered {0}! Their Thirst is now {1}", Name, Thirst);
            Console.ReadKey();
            return Thirst;
            //Tick()
        }
        //----------------------------------
        // TODO change health parameters
        //// public int PantherHealth()
        //{
        //    //Todo
        //    Thirst++;
        //    Hunger += 1;
        //    Bathroom += 2;

        //    Console.WriteLine(" You've watered {0}! Their Thirst is now {1}", Name, Thirst);
        //    Console.ReadKey();

        //    return Health;
            //Tick()
        //}
        //----------------------------------


        public int PantherBathroom()
        {
            //Todo
            bathroom = 0;
            hunger = Hunger;

            Console.WriteLine(" You've taken {0} to the bathroom! Their bathroom is now {1}", Name, Bathroom);
            Console.ReadKey();


            return Bathroom;
        }
        //----------------------------------
        public int PantherTrain()
        {
            //Todo
            return Train;
        }
        //----------------------------------
        //Tick method
        //public void Tick();
        //{
        ////todo
        //continue 
        //}
        
    }
}
