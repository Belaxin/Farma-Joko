using System.Windows.Forms;

namespace Farma_Joko
{
    public partial class Menu : Form
    {


        private Farm farm;
        private System.Windows.Forms.Timer uiTimer = new System.Windows.Forms.Timer();

        public Menu()
        {
            uiTimer.Interval = 100;
            uiTimer.Start();
            uiTimer.Tick += UiTimer_Tick;
            InitializeComponent();
            farm = new Farm();
            updateEggCount(farm.eggCount);
        }
        private void UiTimer_Tick(object sender, EventArgs e)
        {
            updateEggCount(farm.eggCount);
            updateChickenCount(farm.chickens.Count);
            updateMoneyCount(farm.moneyCount);
            UpdateLogStatus(farm.status);
        }

        public void UpdateLogStatus(string status)
        {
            statusLabel.Text = status;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void purchaseChicken_Click(object sender, EventArgs e)
        {
            farm.purchaseChicken();
            System.Diagnostics.Debug.WriteLine("clicked buy chicken");
        }
        private void removeChicken_Click(object sender, EventArgs e)
        {
            farm.killChicken();
        }
        private void sellEggs_Click(object sender, EventArgs e)
        {
            farm.sellEggs();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void updateEggCount(int eggs)
        {
            eggCountLabel.Text = "Eggs: " + eggs.ToString();
        }
        public void updateChickenCount(int chickens)
        {
            chickenCountLabel.Text = "Chickens: " + chickens.ToString();
        }
        public void updateMoneyCount(int money)
        {
            moneyCountLabel.Text = "Money: $" + money.ToString();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
