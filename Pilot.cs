using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jose_FlyingApp
{
    public class Pilot
    {
        // A. Set Data members / Instance Fields / Properties
        private int pilotNumber;
        private string pilotFirstName;
        private string pilotMiddleName;
        private string pilotLastName;
        private double flyingHoursDay1;
        private double flyingHoursDay2;
        private double flyingHoursDay3;
        private double flyingHoursDay4;
        private double flyingHoursDay5;

       
        // B. Set Constructor Methods

        // B1. Default Constructor
        public Pilot() 
        {

        }


        // B2. Argument Constructor              
        public Pilot(int pilotId, string firstName, string middleName, string lastName, double pilotHoursDay1,
            double pilotHoursDay2, double pilotHoursDay3, double pilotHoursDay4, double pilotHoursDay5)
        {
            pilotNumber = pilotId;
            pilotFirstName = firstName;
            pilotMiddleName = middleName;
            pilotLastName = lastName;
            flyingHoursDay1 = pilotHoursDay1;
            flyingHoursDay2 = pilotHoursDay2;
            flyingHoursDay3 = pilotHoursDay3;
            flyingHoursDay4 = pilotHoursDay4;
            flyingHoursDay5 = pilotHoursDay5;            
        }


        // B3. Compute Weekly Flying Hours (Parameterized constructor)            
        public double WeeklyFlyingHours()
        {
            return flyingHoursDay1 + flyingHoursDay2 + flyingHoursDay3 + flyingHoursDay4 + flyingHoursDay5;
        }


        // B4. Compute Average Flying Hours (Parameterized constructor)
        public double AverageFlyingHours()
        {
            return (flyingHoursDay1 + flyingHoursDay2 + flyingHoursDay3 + flyingHoursDay4 + flyingHoursDay5)/5;
        }
               

        // C. Set Mutators
        public void SetPilotNumber(int pilotId)
        {
            pilotNumber = pilotId;
        }

        public void SetPilotFirstName(string firstName)
        {
            pilotFirstName = firstName;
        }

        public void SetPilotMiddleName(string middleName)
        {
            pilotMiddleName = middleName;
        }

        public void SetPilotLastName(string lastName)
        {
            pilotLastName = lastName;
        }

        public void SetFlyingHoursDay1(double pilotHoursDay1)
        {
            flyingHoursDay1 = pilotHoursDay1;
        }
       
        public void SetFlyingHoursDay2(double pilotHourDay2)
        {
            flyingHoursDay2 = pilotHourDay2;
        }

        public void SetFlyingHoursDay3(double pilotHourDay3)
        {
            flyingHoursDay3 = pilotHourDay3;
        }

        public void SetFlyingHoursDay4(double pilotHourDay4)
        {
            flyingHoursDay4 = pilotHourDay4;
        }
        public void SetFlyingHoursDay5(double pilotHourDay5)
        {
            flyingHoursDay5 = pilotHourDay5;
        }
      

        // Set Accesors
        public int GetPilotNumber()
        {
            return pilotNumber;
        }

        public string GetPilotFirstName()
        {
            return pilotFirstName;
        }
        public string GetPilotMiddleName()
        {
            return pilotMiddleName;
        }

        public string GetPilotLasttName()
        {
            return pilotLastName;
        }

        public double GetFlyingHoursDay1()
        {
            return flyingHoursDay1;
        }
      
        public double GetFlyingHoursDay2()
        {
            return flyingHoursDay2;
        }

        public double GetFlyingHoursDay3()
        {
            return flyingHoursDay3;
        }

        public double GetFlyingHoursDay4()
        {
            return flyingHoursDay4;
        }

        public double GetFlyingHoursDay5()
        {
            return flyingHoursDay5;
        }

     
        // ToString() Method: display complete information about a pilot.
        public override string ToString()
        {
            return "Pilot Number: "+pilotNumber+ 
                "\nPilot Name: " + pilotFirstName + " " + pilotMiddleName + " " + pilotLastName+
                "\n TotalHours"+ WeeklyFlyingHours()+
                "\n AverageHours" + AverageFlyingHours();
        }
    }
}
