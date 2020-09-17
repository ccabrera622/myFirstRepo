using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Day4HW
{
    class Program
    {
        class House
        {
            protected float area;
            protected Door d;
            public House(float a)
            {
                this.area = a;
                d = new Door();
            }

            public float Area
            {
                get { return area; }
                set { area = value; }
            }

            public Door GetDoor()
            {
                return d;
            }

            public virtual void ShowData()
            {
                Console.WriteLine("I am a house, my area is " + area + " m2");
            }
        }

        class SmallApartment : House
        {
            public SmallApartment() : base(50)
            {
            }
            public override void ShowData()
            {
                Console.WriteLine("I am an apartment, my area is " + area + " m2");
            }
        }

        class Door
        {
            private string color;
            public Door()
            {
                this.color = "White";
            }

            public string GetColor()
            {
                return color;
            }

            public void SetColor(string col)
            {
                color = col;
            }
            public void ShowData()
            {
                Console.WriteLine("I am a door, my color is " + color);
            }
        }

        class Person
        {
            private string name;
            private House h;
            public Person(string n, House h)
            {
                this.name = n;
                this.h = h;
            }

            public void ShowData()
            {
                Console.WriteLine("I am a person, my name is " + name);
                this.h.ShowData();
                this.h.GetDoor().ShowData();
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("Chris", new SmallApartment());
            p.ShowData();
        }
    }
}
