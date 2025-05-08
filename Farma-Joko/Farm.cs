using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farma_Joko
{
    internal class Farm
    {
        public List<Chicken> chickens = new List<Chicken>();
        private System.Timers.Timer eggTimer = new System.Timers.Timer();
        public int eggCount { get; private set; } = 0;
        public int moneyCount { get; private set; } = 0;
        public string status { get; private set; } = "";

        public Farm()
        {
            updateEggTimerInterval();
            eggTimer.Elapsed += EggTimer_Elapsed;
        }


        private void EggTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            eggCount++;
            System.Diagnostics.Debug.WriteLine("A chicken has laid an egg");
            
        }


        public void sellEggs()
        {
            status = "sold Eggs for: " + eggCount * 20;
            moneyCount += eggCount * 20;
            eggCount = 0;
        }
        public void purchaseChicken()
        {
            chickens.Add(new  Chicken());
            status = "Bought a " + chickens.Last<Chicken>().GetBreed();
            updateEggTimerInterval();
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



        protected void updateEggTimerInterval()
        {
            if (chickens.Count > 0)
            {
                eggTimer.Stop();
                eggTimer.Interval = 30000 / chickens.Count;
                eggTimer.Start();
            }
            else
            {
                eggTimer.Stop();
            }
        }
    }
}



