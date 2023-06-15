using System;
using System.Net.Http.Headers;
using static System.Console;

namespace Jose_FlyingApp
{
    class Jose_FlyingApp
    {
        static void Main()
        {
            Pilot firstPilotObject = new Pilot(); // Set new object "Pilot"

            DisplayInstructions();

            int pilotNumber=1234;
            firstPilotObject.SetPilotNumber(pilotNumber);
            
            //Input Data from User
            WriteLine("\nEnter pilot first Name: ");
            string firstName = ReadLine();
            firstPilotObject.SetPilotFirstName(firstName);

            WriteLine("Enter pilot Middle Name: ");
            string middleName = ReadLine();
            firstPilotObject.SetPilotMiddleName(middleName);

            WriteLine("Enter pilot Last Name: ");
            string lastName = ReadLine();
            firstPilotObject.SetPilotLastName(lastName);

           
            double pilotHoursDay1;
            double pilotHoursDay2;
            double pilotHoursDay3;
            double pilotHoursDay4;
            double pilotHoursDay5;


            WriteLine("\nEnter flying hours on day 1: ");
            //pilotHoursDay1 = double.Parse(ReadLine()); //Convert data type to double
            //Error Handling: Validate input is a double
            string pilotHoursDay1Str;
            pilotHoursDay1Str = ReadLine();
            while(double.TryParse(pilotHoursDay1Str,out pilotHoursDay1)==false)
            {
                WriteLine("Please type a valid number of hours on day 1.");
                pilotHoursDay1Str = ReadLine();
            }
 

            WriteLine("Enter flying hours on day 2: ");
            //pilotHoursDay2 = double.Parse(ReadLine());
            string pilotHoursDay2Str=ReadLine();
            while(double.TryParse(pilotHoursDay2Str,out pilotHoursDay2) == false)
            {
                WriteLine("Please type a valid number of hours on day 2.");
                pilotHoursDay2Str = ReadLine();
            }



            WriteLine("Enter flying hours on day 3: ");
            pilotHoursDay3 = double.Parse(ReadLine());




            WriteLine("Enter flying hours on day 4: ");
            pilotHoursDay4 = double.Parse(ReadLine());

            WriteLine("Enter flying hours on day 5: ");
            pilotHoursDay5 = double.Parse(ReadLine());

            WriteLine("\n Press any key to see the results: ");
            ReadKey();
            Clear();

            firstPilotObject.SetFlyingHoursDay1(pilotHoursDay1);
            firstPilotObject.SetFlyingHoursDay2(pilotHoursDay2);            
            firstPilotObject.SetFlyingHoursDay3(pilotHoursDay3);
            firstPilotObject.SetFlyingHoursDay4(pilotHoursDay4);
            firstPilotObject.SetFlyingHoursDay5(pilotHoursDay5);
           
            firstPilotObject.WeeklyFlyingHours();
            firstPilotObject.AverageFlyingHours();                         
                        
            //Display Output Results from Jose_FlyingApp
            WriteLine("\nPilot Number: " + pilotNumber);
            WriteLine("Pilot Name: " + firstName + " " + middleName + " " + lastName);
            WriteLine("Total Weekly Flying Hours: " +firstPilotObject.WeeklyFlyingHours().ToString());
            WriteLine("Average Weekly Flying Hours: " + firstPilotObject.AverageFlyingHours().ToString());
            WriteLine("\n\nPress any key exit.\n\n");

        }

        //Display initial Instruction of the App
        static void DisplayInstructions()
        {
            WriteLine("\nThis application computes pilot flying hours.\n\nPress any key to continue.");
            WriteLine();
            ReadKey();
            Clear();
        }               
    }
}

