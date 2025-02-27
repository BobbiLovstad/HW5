using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Written By Bobbi Lovstad
// 2/27/25

namespace Homework5
{
    public class Employee
    {
        private int salary = -1;
        private string name = "n/a";

        // Gets and sets 

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Constructor 
        
        public Employee(int asalary, string aname)
        {
            this.salary = asalary;
            this.name = aname;
        }

        // Method 

        public override string ToString()
        {
            return "Employee:" + name + ", salary $" + salary;
        }

        public class Manager : Employee
        {
            private int empManaged = -1;

            // Gets and sets 

            public int EmpManaged
            {
                get { return this.empManaged; }
                set { this.empManaged = value; }
            }

            // Constructor 

            public Manager(string aname, int asalary, int aempManaged) : base(aname, asalary)
            {
                this.empManaged = aempManaged;
            }

            public override string ToString()
            {
                return "Employee:" + name + ", salary $" + salary; +"employees Managed:" + empManaged;

            }

            public class Enginner : Employee
            {
                private string specialization = "n/a";

                // Gets and sets 

                public string Specialization
                {
                    get { return this.specialization; }
                    set { this.specialization = value; }
                }

                // Constructor 

                public Specialization(string aname, int asalary, int aspecialization) : base(aname, asalary)
                {
                    this.specialization = aspecialization
                }

                public override string ToString()
                {
                    return "Employee:" + name + ", salary $" + salary; +"specialization:" + specialization;

                }



            }
        }

