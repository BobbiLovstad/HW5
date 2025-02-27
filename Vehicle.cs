using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written By Bobbi Lovstad
// 2/27/25

namespace Homework5
{
    public class Vehicle
    {
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        // Gets and Sets 
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        // Constructor 

        public Vehicle(string amake, string amodel, int ayear)
        {
            this.make = amake;
            this.model = amodel;
            this.year = ayear;
        }

        // Method 

        public override string ToString()
        {
            return year + "" + make + "" + model;
        }

        // inheritance 

        class Car: Vehicle
        {
            private int numDoors = -1;


            // Gets and sets
            public int NumDoors
            {
                get { return this.numDoors; }
                set { this.numDoors = value; }
            }

            // Constructor 

            public Car(string amake, string amodel, int ayear, int anumDoors): base (amake,amodel,ayear)
            {
                this.numDoors = anumDoors;
            }

            //Method

            public override string ToString()
            {
                return year + "" + make + "" + model + "" + numDoors "number of doors";
            }

            public class MotorCycle:Vehicle
            {
                private bool hasSideCar = false;

                // Gets and Sets 

                public bool HasSideCar
                {
                    get { return this.HasSideCar; }
                    set { this.hasSideCar = value; }
                }

                // Constructor 

                public MotorCycle(string amake, string amodel, int ayear, bool ahasSideCar): base(amake,amodel,ayear)
                {
                    this.hasSideCar = ahasSideCar;
                }

                public override string ToString()
                {
                    return year + "" + make + "" + model + "" + ("Has SIdecar:" + (hasSideCar ? "true" : "false" +) + ")";
                }
            }
        }

        


    }
}
