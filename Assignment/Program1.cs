/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        private string name;
        private int age;

        public void SetAnimal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a Sound");
        }
    }

    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dogs Barks");
        }
    }
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat Meows");
        }
    }

        internal class Bird : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bird Chirps");
            }
        }
            internal class Program1
            {
                static void Main(string[] args) {
                    Animal A = new Animal();
                    A.MakeSound();

                    Animal D = new Dog();
                    D.MakeSound();

                    Animal C = new Cat();
                    C.MakeSound();

                    Animal B = new Bird();
                    B.MakeSound();
                }
            }
        }
*/