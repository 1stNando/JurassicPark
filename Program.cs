using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");


            //Lets create a Class to represent the Dinosaurs.
            //Properties to include:
            //  -Name, Weight, DietType,WhenAcquired, and EnclosureNumber.
            class Dinosaur
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public string DietType { get; set; }
            public int EnclosureNumber { get; set; }
            public string WhenAcquired { get; set; }
        }
        /*--Add a METHOD called Description to the class that prints out description
             of the dinosaur to include all the properties.
            --Keep track of the dinosaurs in a List<Dinosaur>. 
          */



        //CONSOLE APPLICATION COMMANDS TO INCLUDE:
        //1) View--This will ask the user if they wish to see the dinosaur in Name or EnclosureNumber order.
        //    --If there are no dinosaurs in the park, print out a unique message to the user.

        //2) Add--This will let the user type in the information for a new dinosaur and add it to the list. 
        /* --Prompt for Name, Weight, DietType, EnclosureNumber, but the WhenAcquired must be supplied by the code!!!.
        */

        //3) Remove--This will PROMPT the user for a dinosaur name then find it in the system and delete it.

        //4) Transfer--This will PROMPT the user for a dinosaur Name and a new EnclosureNumber.
        //And update the changes made to the dinosaur.

        //5) Summary--This will display the number of carnivores and the number of herbivores.

        //6) Quit--This will quit program.



















    }//end of main
}//end of program
}//end of namespace
