using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farma_Joko
{
    internal class Farm
    {
        //chickens
        public List<Chicken> chickens = new List<Chicken>();
        public System.Timers.Timer eggTimer = new System.Timers.Timer();
        public int eggCount { get; private set; } = 0;
        public int moneyCount { get; private set; } = 200;
        public string status { get; private set; } = "";
        public float multiplier { get; set; } = 1f;
        public List<Upgrade> upgrades = new List<Upgrade>();
        public int coop { get; private set; } = 1;

        public Farm()
        {
            updateEggTimerInterval();
            eggTimer.Elapsed += EggTimer_Elapsed;

            upgrades.Add(new Upgrade("Heated nests", "Heating for your chickens' butts'", 100, 0.2f));
            upgrades.Add(new Upgrade("High protein feed", "Anabolic eggs", 300, 0.3f));
            upgrades.Add(new Upgrade("Growth hormone", "Don't tell the government", 1000, 1f));

            upgrades.Sort((a, b) => a.price.CompareTo(b.price));
        }

        public void cheat(int m)
        {
            moneyCount += m;
        }

        private void EggTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            eggCount++;
            System.Diagnostics.Debug.WriteLine("A chicken has laid an egg");
            System.Diagnostics.Debug.WriteLine(eggTimer.Interval);
            eggSlide.Restart();

        }


        public void sellEggs()
        {
            status = "sold Eggs for: " + eggCount * 20;
            moneyCount += eggCount * 20;
            eggCount = 0;
        }
        public void purchaseCoop()
        {
            if (moneyCount >= 200)
            {
                coop++;
                moneyCount -= 200;
                status = "Bought a coop";
            }
            else { status = "insufficent balance"; }
        }
        public void purchaseChicken()
        {
            if (chickens.Count/coop < 10)
            {
                if (moneyCount >= 50)
                {
                    chickens.Add(new Chicken());
                    moneyCount -= 50;
                    status = "Bought a " + chickens.Last<Chicken>().GetBreed();
                    updateEggTimerInterval();
                }
                else
                {
                    status = "Insufficent balance";
                }
            }
            else {
                status = "Insufficent space";
            }
        }
        public void killChicken()
        {
            if (chickens.Count > 1)
            {
                chickens.Remove(chickens.Last<Chicken>());
                chickens.Last<Chicken>().death();
                updateEggTimerInterval();
                status = "Killed a " + chickens.Last<Chicken>().GetBreed();
            }
        }

        public Stopwatch eggSlide = new Stopwatch();
        protected void updateEggTimerInterval()
        {
            if (chickens.Count > 0)
            {
                eggSlide.Stop();
                eggTimer.Stop();
                eggTimer.Interval = 30000 / (chickens.Count*multiplier) ;
                eggSlide.Restart();
                eggTimer.Start();
            }
            else
            {
                eggTimer.Stop();
            }

        }


        public void buyUpgrade(Upgrade upgrade)
        {
            if (!upgrade.isBought)
            {
                if (moneyCount >= upgrade.price)
                {
                    upgrade.isBought = true;
                    multiplier += upgrade.multiplier;
                    moneyCount -= upgrade.price;
                    updateEggTimerInterval();
                }
                else { status = "Insufficent balance"; }
            }
            else { status = "Upgrade already owned"; }
        }


    }
}



