using System.Windows.Forms;

namespace Farma_Joko
{
    public partial class Menu : Form
    {


        private Farm farm;
        private System.Windows.Forms.Timer uiTimer = new System.Windows.Forms.Timer();
        internal Upgrade selectedUpgrade;

        public Menu()
        {
            uiTimer.Interval = 10;
            uiTimer.Start();
            uiTimer.Tick += UiTimer_Tick;
            InitializeComponent();
            farm = new Farm();
            updateEggCount(farm.eggCount);
            updateUpgrade(farm.upgrades);
        }
        private void UiTimer_Tick(object sender, EventArgs e)
        {
            updateEggSlide(farm.eggSlide.ElapsedMilliseconds, farm.eggTimer.Interval);
            updateEggCount(farm.eggCount);
            updateChickenCount(farm.chickens.Count, farm.coop);
            updateMoneyCount(farm.moneyCount);
            updateLogStatus(farm.status);
            updateEpS(farm.eggTimer.Interval);
        }
        public void updateLogStatus(string status)
        {
            statusLabel.Text = status;
        }




        private void selectionKurniky_Click(object sender, EventArgs e)
        {
            Kurniky.BringToFront();
        }

        private void kurnikyBack_Click(object sender, EventArgs e)
        {
            SelectionScreen.BringToFront();
        }

        private void selectionBack_Click(object sender, EventArgs e)
        {
            MainMenu.BringToFront();
        }

        private void menuPlay_Click(object sender, EventArgs e)
        {
            SelectionScreen.BringToFront();
        }



        private void purchaseChicken_Click(object sender, EventArgs e)
        {
            farm.purchaseChicken();
            System.Diagnostics.Debug.WriteLine("clicked buy chicken");
        }
        private void purchaseCoop_Click(object sender, EventArgs e)
        {
            farm.purchaseCoop();
        }
        private void removeChicken_Click(object sender, EventArgs e)
        {
            farm.killChicken();
        }
        private void sellEggs_Click(object sender, EventArgs e)
        {
            farm.sellEggs();
        }
        public void updateEggCount(int eggs)
        {
            eggCountLabel.Text = "Eggs: " + eggs.ToString();
        }
        public void updateChickenCount(int chickens, int coops)
        {
            chickenCountLabel.Text = $"Chickens: {chickens.ToString()} / {(coops * 10).ToString()} ";
        }
        public void updateMoneyCount(int money)
        {
            moneyCountLabel.Text = "Money: $" + money.ToString();
        }
        public void updateEpS(double eggTimeInterval)
        {
            epsLabel.Text = "EpS: " + Math.Round(1000 / eggTimeInterval, 3);
        }
        private void updateUpgrade(List<Upgrade> list)
        {
            foreach (Upgrade upgrade in list)
            {
                if (!upgrade.isBought)
                {
                    upgradeName.Text = upgrade.name;
                    upgradeDesc.Text = upgrade.description;
                    upgradeBuy.Text = "Buy for $" + upgrade.price.ToString();
                    selectedUpgrade = upgrade;
                    break;
                }
                else
                {

                    upgradeName.Text = "";
                    upgradeDesc.Text = "";
                    upgradeBuy.Text = "";
                    selectedUpgrade = null;
                }
            }

        }
        private void buyUpgrade_Click(object sender, EventArgs e)
        {
            if (selectedUpgrade != null && !selectedUpgrade.isBought)
            {
                farm.buyUpgrade(selectedUpgrade);
            }
            updateUpgrade(farm.upgrades);

        }


        private void updateEggSlide(long timer, double eggTimeInterval)
        {
            double t = timer / eggTimeInterval;
            Point start = new Point(102, 155);
            Point end = new Point(18, 209);
            int x = (int)(start.X + (end.X - start.X) * t);
            int y = (int)(start.Y + (end.Y - start.Y) * t);
            pictureBox3.Location = new Point(x, y);
            pictureBox3.Invalidate();
        }
        private void cheat_Click(object sender, EventArgs e)
        {
            farm.cheat(1000);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Kurniky_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void upgradeName_Click(object sender, EventArgs e)
        {

        }

        private void upgradeDesc_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void chickenCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void moneyCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void coop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void epsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Kurniky_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SelectionScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
