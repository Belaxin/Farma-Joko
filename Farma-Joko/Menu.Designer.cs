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
            MainMenu.AutoSize = true;
            MainMenu.BackgroundImage = Properties.Resources._180px_Grass;
            MainMenu.Controls.Add(menuPlay);
            MainMenu.Location = new Point(0, 0);
            MainMenu.Margin = new Padding(4, 5, 4, 5);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(432, 768);
            MainMenu.TabIndex = 2;
            MainMenu.Paint += panel1_Paint;
            // 
            // menuPlay
            // 
            menuPlay.Anchor = AnchorStyles.Top;
            menuPlay.Location = new Point(159, 287);
            menuPlay.Margin = new Padding(4, 5, 4, 5);
            menuPlay.Name = "menuPlay";
            menuPlay.Size = new Size(108, 40);
            menuPlay.TabIndex = 0;
            menuPlay.Text = "Play";
            menuPlay.UseVisualStyleBackColor = true;
            menuPlay.Click += menuPlay_Click;
            // 
            // SelectionScreen
            // 
            SelectionScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SelectionScreen.Controls.Add(selectionBack);
            SelectionScreen.Controls.Add(selectionKurniky);
            SelectionScreen.Location = new Point(0, 0);
            SelectionScreen.Margin = new Padding(4, 5, 4, 5);
            SelectionScreen.Name = "SelectionScreen";
            SelectionScreen.Size = new Size(432, 768);
            SelectionScreen.TabIndex = 3;
            // 
            // selectionBack
            // 
            selectionBack.Anchor = AnchorStyles.Top;
            selectionBack.Location = new Point(275, 287);
            selectionBack.Margin = new Padding(4, 5, 4, 5);
            selectionBack.Name = "selectionBack";
            selectionBack.Size = new Size(108, 37);
            selectionBack.TabIndex = 1;
            selectionBack.Text = "back";
            selectionBack.UseVisualStyleBackColor = true;
            selectionBack.Click += selectionBack_Click;
            // 
            // selectionKurniky
            // 
            selectionKurniky.Anchor = AnchorStyles.Top;
            selectionKurniky.Location = new Point(34, 287);
            selectionKurniky.Margin = new Padding(4, 5, 4, 5);
            selectionKurniky.Name = "selectionKurniky";
            selectionKurniky.Size = new Size(108, 37);
            selectionKurniky.TabIndex = 0;
            selectionKurniky.Text = "Kurniky";
            selectionKurniky.UseVisualStyleBackColor = true;
            selectionKurniky.Click += selectionKurniky_Click;
            // 
            // Kurniky
            // 
            Kurniky.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Kurniky.Controls.Add(kurnikyBack);
            Kurniky.Controls.Add(pictureBox1);
            Kurniky.Location = new Point(0, 0);
            Kurniky.Margin = new Padding(4, 5, 4, 5);
            Kurniky.Name = "Kurniky";
            Kurniky.Size = new Size(432, 768);
            Kurniky.TabIndex = 2;
            Kurniky.Paint += Kurniky_Paint;
            // 
            // kurnikyBack
            // 
            kurnikyBack.Anchor = AnchorStyles.Top;
            kurnikyBack.Location = new Point(263, 261);
            kurnikyBack.Margin = new Padding(4, 5, 4, 5);
            kurnikyBack.Name = "kurnikyBack";
            kurnikyBack.Size = new Size(108, 37);
            kurnikyBack.TabIndex = 1;
            kurnikyBack.Text = "back";
            kurnikyBack.UseVisualStyleBackColor = true;
            kurnikyBack.Click += kurnikyBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.chicken;
            pictureBox1.Location = new Point(34, 78);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 277);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(414, 721);
            Controls.Add(Kurniky);
            Controls.Add(SelectionScreen);
            Controls.Add(MainMenu);
            Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            Text = "Farma Joko";
            WindowState = FormWindowState.Minimized;
            MainMenu.ResumeLayout(false);
            SelectionScreen.ResumeLayout(false);
            Kurniky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
