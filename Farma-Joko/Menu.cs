namespace Farma_Joko
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
    }
}
