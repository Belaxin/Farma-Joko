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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuPlay = new Button();
            SelectionScreen = new Panel();
            selectionBack = new Button();
            selectionKurniky = new Button();
            Kurniky = new Panel();
            kurnikyBack = new Button();
            pictureBox1 = new PictureBox();
            MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SelectionScreen.SuspendLayout();
            Kurniky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.BackgroundImage = Properties.Resources._180px_Grass;
            MainMenu.Controls.Add(pictureBox3);
            MainMenu.Controls.Add(pictureBox2);
            MainMenu.Controls.Add(menuPlay);
            MainMenu.Dock = DockStyle.Fill;
            MainMenu.Location = new Point(0, 0);
            MainMenu.Margin = new Padding(3, 4, 3, 4);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(913, 507);
            MainMenu.TabIndex = 2;
            MainMenu.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.chicken;
            pictureBox3.Location = new Point(14, 60);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(208, 364);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.chicken;
            pictureBox2.Location = new Point(678, 60);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 364);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // menuPlay
            // 
            menuPlay.Anchor = AnchorStyles.Top;
            menuPlay.Location = new Point(411, 239);
            menuPlay.Margin = new Padding(3, 4, 3, 4);
            menuPlay.Name = "menuPlay";
            menuPlay.Size = new Size(86, 33);
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
            SelectionScreen.Margin = new Padding(3, 4, 3, 4);
            SelectionScreen.Name = "SelectionScreen";
            SelectionScreen.Size = new Size(913, 507);
            SelectionScreen.TabIndex = 3;
            // 
            // selectionBack
            // 
            selectionBack.Anchor = AnchorStyles.Top;
            selectionBack.Location = new Point(731, 241);
            selectionBack.Margin = new Padding(3, 4, 3, 4);
            selectionBack.Name = "selectionBack";
            selectionBack.Size = new Size(86, 31);
            selectionBack.TabIndex = 1;
            selectionBack.Text = "back";
            selectionBack.UseVisualStyleBackColor = true;
            selectionBack.Click += selectionBack_Click;
            // 
            // selectionKurniky
            // 
            selectionKurniky.Anchor = AnchorStyles.Top;
            selectionKurniky.Location = new Point(411, 241);
            selectionKurniky.Margin = new Padding(3, 4, 3, 4);
            selectionKurniky.Name = "selectionKurniky";
            selectionKurniky.Size = new Size(86, 31);
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
            Kurniky.Margin = new Padding(3, 4, 3, 4);
            Kurniky.Name = "Kurniky";
            Kurniky.Size = new Size(913, 507);
            Kurniky.TabIndex = 2;
            // 
            // kurnikyBack
            // 
            kurnikyBack.Anchor = AnchorStyles.Top;
            kurnikyBack.Location = new Point(731, 203);
            kurnikyBack.Margin = new Padding(3, 4, 3, 4);
            kurnikyBack.Name = "kurnikyBack";
            kurnikyBack.Size = new Size(86, 31);
            kurnikyBack.TabIndex = 1;
            kurnikyBack.Text = "back";
            kurnikyBack.UseVisualStyleBackColor = true;
            kurnikyBack.Click += kurnikyBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.chicken;
            pictureBox1.Location = new Point(351, 71);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 353);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 507);
            Controls.Add(MainMenu);
            Controls.Add(SelectionScreen);
            Controls.Add(Kurniky);
            Name = "Menu";
            Text = "Form1";
            MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
