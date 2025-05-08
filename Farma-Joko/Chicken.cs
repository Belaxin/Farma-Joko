using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farma_Joko
{
    internal class Chicken : Animal
    {
        private Random random = new Random();
        protected chickenBreeds breed {get;}

        public Chicken(string name = "Chicken") : base(name)
        {
            System.Diagnostics.Debug.WriteLine("Made a new chicken");
            //  random breed selector
            int chance = random.Next(1000);
            if (chance > 975)
            {
                this.breed = chickenBreeds.Dodo;
            }
            else if (chance > 920)
            {
                this.breed = chickenBreeds.Ayam;
            }
            else if (chance > 900)
            {
                this.breed = chickenBreeds.Sumatra;
            }
            else if (chance > 750)
            {
                this.breed = chickenBreeds.Faverolle;
            }
            else if (chance > 650)
            {
                this.breed = chickenBreeds.Araucana;
            }
            else if (chance > 575)
            {
                this.breed = chickenBreeds.Orpington;
            }
            else if (chance > 500)
            {
                this.breed = chickenBreeds.Australorp;
            }
            else if (chance > 425)
            {
                this.breed = chickenBreeds.Sussex;
            }
            else if (chance > 350)
            {
                this.breed = chickenBreeds.Delaware;
            }
            else if (chance > 275)
            {
                this.breed = chickenBreeds.Dominique;
            }
            else { this.breed = chickenBreeds.Leghorn; }
        }

        public chickenBreeds GetBreed()
        {
            return breed;
        }
    }
}
