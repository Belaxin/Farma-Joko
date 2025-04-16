namespace Farma_Joko
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainMenu = new Panel();
            menuPlay = new Button();
            SelectionScreen = new Panel();
            selectionBack = new Button();
            selectionKurniky = new Button();
            Kurniky = new Panel();
            kurnikyBack = new Button();
            pictureBox1 = new PictureBox();
            MainMenu.SuspendLayout();
            SelectionScreen.SuspendLayout();
            Kurniky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.BackgroundImage = Properties.Resources.chicken;
            MainMenu.Controls.Add(menuPlay);
            MainMenu.Dock = DockStyle.Fill;
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(799, 380);
            MainMenu.TabIndex = 2;
            MainMenu.Paint += panel1_Paint;
            // 
            // menuPlay
            // 
            menuPlay.Anchor = AnchorStyles.Top;
            menuPlay.Location = new Point(360, 181);
            menuPlay.Name = "menuPlay";
            menuPlay.Size = new Size(75, 25);
            menuPlay.TabIndex = 0;
            menuPlay.Text = "Play";
            menuPlay.UseVisualStyleBackColor = true;
            menuPlay.Click += menuPlay_Click;
            // 
            // SelectionScreen
            // 
            SelectionScreen.Controls.Add(selectionBack);
            SelectionScreen.Controls.Add(selectionKurniky);
            SelectionScreen.Dock = DockStyle.Fill;
            SelectionScreen.Location = new Point(0, 0);
            SelectionScreen.Name = "SelectionScreen";
            SelectionScreen.Size = new Size(799, 380);
            SelectionScreen.TabIndex = 3;
            // 
            // selectionBack
            // 
            selectionBack.Anchor = AnchorStyles.Top;
            selectionBack.Location = new Point(640, 181);
            selectionBack.Name = "selectionBack";
            selectionBack.Size = new Size(75, 23);
            selectionBack.TabIndex = 1;
            selectionBack.Text = "back";
            selectionBack.UseVisualStyleBackColor = true;
            selectionBack.Click += selectionBack_Click;
            // 
            // selectionKurniky
            // 
            selectionKurniky.Anchor = AnchorStyles.Top;
            selectionKurniky.Location = new Point(360, 181);
            selectionKurniky.Name = "selectionKurniky";
            selectionKurniky.Size = new Size(75, 23);
            selectionKurniky.TabIndex = 0;
            selectionKurniky.Text = "Kurniky";
            selectionKurniky.UseVisualStyleBackColor = true;
            selectionKurniky.Click += selectionKurniky_Click;
            // 
            // Kurniky
            // 
            Kurniky.Controls.Add(kurnikyBack);
            Kurniky.Controls.Add(pictureBox1);
            Kurniky.Dock = DockStyle.Fill;
            Kurniky.Location = new Point(0, 0);
            Kurniky.Name = "Kurniky";
            Kurniky.Size = new Size(799, 380);
            Kurniky.TabIndex = 2;
            // 
            // kurnikyBack
            // 
            kurnikyBack.Anchor = AnchorStyles.Top;
            kurnikyBack.Location = new Point(640, 152);
            kurnikyBack.Name = "kurnikyBack";
            kurnikyBack.Size = new Size(75, 23);
            kurnikyBack.TabIndex = 1;
            kurnikyBack.Text = "back";
            kurnikyBack.UseVisualStyleBackColor = true;
            kurnikyBack.Click += kurnikyBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.chicken;
            pictureBox1.Location = new Point(307, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 265);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 380);
            Controls.Add(MainMenu);
            Controls.Add(SelectionScreen);
            Controls.Add(Kurniky);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Form1";
            MainMenu.ResumeLayout(false);
            SelectionScreen.ResumeLayout(false);
            Kurniky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel MainMenu;
        private Button menuPlay;
        private Panel SelectionScreen;
        private Button selectionKurniky;
        private Panel Kurniky;
        private Button kurnikyBack;
        private PictureBox pictureBox1;
        private Button selectionBack;
    }
}
