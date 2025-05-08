using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farma_Joko
{
    internal class Animal
    {
        protected string name { get; set; }
        protected int age { get; private set; }
        protected bool isAlive { get; private set; }

        public Animal(string name) {
            this.name = name;
            this.age = 0;
            this.isAlive = true;
        }

        public void ageUp() {this.age++;}
        public void death() { this.isAlive = false; Console.WriteLine(this.name + " Has died."); }
    }
}
