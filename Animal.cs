using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written By Bobbi Lovstad
// 2/27/25
namespace Homework5
{
    public class Animal
    {
        private string name = "n/a";

        // gets and sets 

        public string name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructor

        public Animal(string aname)
        {
            this.name = aname;
        }

        public virtual string MakeSound()
        {
            return "some generic animal noise";
        }

        public override string ToString()
        {
            return "Animal:" + name + "sound:" + MakeSound();
        }

        public class Dog:Animal
        {
            // Constructor 
            public Dog(string aname) : base(aname) { }
            public override string MakeSound()
            {
                return "Bark";
            }
            public override string ToString()
            {
                return "Animal" + name + "sound:" + MakeSound();
            }

            public class Cat : Animal
            {
                // Constructor 
                public Cat(string aname) : base(aname) { }
                public override string MakeSound()
                {
                    return "Neow";
                }
                public override string ToString()
                {
                    return "Animal" + name + "sound:" + MakeSound();
                }


            }
        }
}
