using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written By Bobbi Lovstad
// 2/27/25
namespace Homework5
{
    public abstract class Shape
    {
        private string color = "n/a'";

        // gets and sets

        public int Color
        {
            get { return this.color; }
            set { this.color = value; }

        }

        // COnstructor 

        public Shape(string acolor)
        {
            this.color = acolor;
        }

        // 1st method 

        public abstract double GetArea();
        public override string ToString()
        {
            return color + "shape";
        }

        public class Rectangle : Shape
        {
            private int width = -1;
            private int height = -1;

            // gets and sets 
            public int Width
            {
                get { return this.width; }
                set { this.width = value; }


            }
            public int Height
            {
                get { return this.height; }
                set { this.height = value; }

            }

            // Constructor 
            public Rectangle(string acolor, int aheight, int awidth) : base(acolor)
            {
                this.width = awidth;
                this.height = aheight;
            }

            //Method 

            public override double GetArea()
            {
                return width * height;
            }
            public override string ToString()
            {
                return color + "Rectangle with width" + width + " and height" + height + "Area" + GetArea();
            }


            public class Circle : Shape
            {
                private int radius = -1;


                // gets and sets 
                public int Radius
                {
                    get { return this.radius; }
                    set { this.radius = value; }


                }


                // Constructor 
                public Circle(string acolor, int aradius) : base(acolor)
                {
                    this.radius = aradius;

                }

                //Method 

                public override double GetArea()
                {
                    return Math.PI * radius * radius;
                }
                public override string ToString()
                {
                    return color + "Circle with Radius" + radius + "Area:" + GetArea();
                }


            }

        }
    }

