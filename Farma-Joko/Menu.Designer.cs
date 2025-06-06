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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuPlay = new Button();
            MainMenu = new Panel();
            Kurniky = new DoubleBufferedPanel();
            epsLabel = new Label();
            eggCountLabel = new Label();
            moneyCountLabel = new Label();
            chickenCountLabel = new Label();
            purchaseChicken = new Button();
            mute = new Button();
            kurnikyBack = new Button();
            button1 = new Button();
            coop = new DoubleBufferedPanel();
            pictureBox3 = new PictureBox();
            upgradeBuy = new Button();
            cheat = new Button();
            removeChicken = new Button();
            sellEggs = new Button();
            statusLabel = new Label();
            SelectionScreen = new Panel();
            selectionBack = new Button();
            selectionKurniky = new Button();
            MainMenu.SuspendLayout();
            Kurniky.SuspendLayout();
            coop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SelectionScreen.SuspendLayout();
            SuspendLayout();
            // 
            // menuPlay
            // 
            menuPlay.Anchor = AnchorStyles.Top;
            menuPlay.BackColor = Color.Transparent;
            menuPlay.BackgroundImageLayout = ImageLayout.Center;
            menuPlay.FlatAppearance.BorderSize = 0;
            menuPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            menuPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            menuPlay.FlatStyle = FlatStyle.Flat;
            menuPlay.Image = (Image)resources.GetObject("menuPlay.Image");
            menuPlay.Location = new Point(86, 309);
            menuPlay.Margin = new Padding(4, 5, 4, 5);
            menuPlay.Name = "menuPlay";
            menuPlay.Size = new Size(244, 151);
            menuPlay.TabIndex = 0;
            menuPlay.UseVisualStyleBackColor = false;
            menuPlay.Click += menuPlay_Click;
            // 
            // MainMenu
            // 
            MainMenu.Anchor = AnchorStyles.Top;
            MainMenu.AutoSize = true;
            MainMenu.BackColor = SystemColors.Control;
            MainMenu.BackgroundImage = Properties.Resources.main_menu_bg;
            MainMenu.BackgroundImageLayout = ImageLayout.Zoom;
            MainMenu.Controls.Add(menuPlay);
            MainMenu.Location = new Point(1, 1);
            MainMenu.Margin = new Padding(4, 5, 4, 5);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(432, 763);
            MainMenu.TabIndex = 2;
            MainMenu.Paint += panel1_Paint;
            // 
            // Kurniky
            // 
            Kurniky.Anchor = AnchorStyles.Top;
            Kurniky.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Kurniky.BackColor = SystemColors.ActiveBorder;
            Kurniky.BackgroundImage = Properties.Resources.chicken_farm_background_bg1;
            Kurniky.Controls.Add(epsLabel);
            Kurniky.Controls.Add(eggCountLabel);
            Kurniky.Controls.Add(moneyCountLabel);
            Kurniky.Controls.Add(chickenCountLabel);
            Kurniky.Controls.Add(purchaseChicken);
            Kurniky.Controls.Add(mute);
            Kurniky.Controls.Add(kurnikyBack);
            Kurniky.Controls.Add(button1);
            Kurniky.Controls.Add(coop);
            Kurniky.Controls.Add(upgradeBuy);
            Kurniky.Controls.Add(cheat);
            Kurniky.Controls.Add(removeChicken);
            Kurniky.Controls.Add(sellEggs);
            Kurniky.Controls.Add(statusLabel);
            Kurniky.Location = new Point(1, 1);
            Kurniky.Margin = new Padding(4, 5, 4, 5);
            Kurniky.Name = "Kurniky";
            Kurniky.Size = new Size(432, 763);
            Kurniky.TabIndex = 4;
            Kurniky.Paint += Kurniky_Paint_1;
            // 
            // epsLabel
            // 
            epsLabel.AutoSize = true;
            epsLabel.BackColor = Color.Transparent;
            epsLabel.Font = new Font("Arial Black", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            epsLabel.Location = new Point(341, 146);
            epsLabel.Name = "epsLabel";
            epsLabel.Padding = new Padding(5);
            epsLabel.Size = new Size(55, 25);
            epsLabel.TabIndex = 8;
            epsLabel.Text = "EpS: 0";
            // 
            // eggCountLabel
            // 
            eggCountLabel.AutoSize = true;
            eggCountLabel.BackColor = Color.Transparent;
            eggCountLabel.Font = new Font("Arial Black", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            eggCountLabel.Location = new Point(233, 20);
            eggCountLabel.Name = "eggCountLabel";
            eggCountLabel.Padding = new Padding(5);
            eggCountLabel.Size = new Size(32, 25);
            eggCountLabel.TabIndex = 3;
            eggCountLabel.Text = ": 0";
            // 
            // moneyCountLabel
            // 
            moneyCountLabel.AutoSize = true;
            moneyCountLabel.BackColor = Color.Transparent;
            moneyCountLabel.Font = new Font("Arial Black", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyCountLabel.Location = new Point(350, 19);
            moneyCountLabel.Name = "moneyCountLabel";
            moneyCountLabel.Padding = new Padding(5);
            moneyCountLabel.Size = new Size(32, 25);
            moneyCountLabel.TabIndex = 7;
            moneyCountLabel.Text = ": 0";
            // 
            // chickenCountLabel
            // 
            chickenCountLabel.AutoSize = true;
            chickenCountLabel.BackColor = Color.Transparent;
            chickenCountLabel.Font = new Font("Arial Black", 7.8F);
            chickenCountLabel.Location = new Point(133, 20);
            chickenCountLabel.Name = "chickenCountLabel";
            chickenCountLabel.Padding = new Padding(5);
            chickenCountLabel.Size = new Size(42, 25);
            chickenCountLabel.TabIndex = 5;
            chickenCountLabel.Text = ": 0/0";
            // 
            // purchaseChicken
            // 
            purchaseChicken.Anchor = AnchorStyles.None;
            purchaseChicken.BackColor = Color.Transparent;
            purchaseChicken.BackgroundImageLayout = ImageLayout.Center;
            purchaseChicken.FlatAppearance.BorderSize = 0;
            purchaseChicken.FlatAppearance.MouseDownBackColor = Color.Transparent;
            purchaseChicken.FlatAppearance.MouseOverBackColor = Color.Transparent;
            purchaseChicken.FlatStyle = FlatStyle.Flat;
            purchaseChicken.Font = new Font("Arial Black", 8.25F);
            purchaseChicken.Image = Properties.Resources.upgrade_chicken_bez_shadowu;
            purchaseChicken.Location = new Point(3, 348);
            purchaseChicken.Name = "purchaseChicken";
            purchaseChicken.Padding = new Padding(0, 0, 0, 20);
            purchaseChicken.Size = new Size(91, 101);
            purchaseChicken.TabIndex = 2;
            purchaseChicken.Text = "50";
            purchaseChicken.TextAlign = ContentAlignment.BottomCenter;
            purchaseChicken.UseVisualStyleBackColor = false;
            purchaseChicken.Click += purchaseChicken_Click;
            // 
            // mute
            // 
            mute.BackColor = Color.Transparent;
            mute.FlatAppearance.BorderSize = 0;
            mute.FlatAppearance.MouseDownBackColor = Color.Transparent;
            mute.FlatAppearance.MouseOverBackColor = Color.Transparent;
            mute.FlatStyle = FlatStyle.Flat;
            mute.Image = Properties.Resources.mute;
            mute.Location = new Point(26, 146);
            mute.Name = "mute";
            mute.Size = new Size(53, 50);
            mute.TabIndex = 21;
            mute.UseVisualStyleBackColor = false;
            mute.Click += mute_Click;
            // 
            // kurnikyBack
            // 
            kurnikyBack.Anchor = AnchorStyles.Top;
            kurnikyBack.BackColor = Color.Transparent;
            kurnikyBack.FlatAppearance.BorderSize = 0;
            kurnikyBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            kurnikyBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            kurnikyBack.FlatStyle = FlatStyle.Flat;
            kurnikyBack.Font = new Font("Verdana", 7.8F);
            kurnikyBack.Image = (Image)resources.GetObject("kurnikyBack.Image");
            kurnikyBack.Location = new Point(3, 13);
            kurnikyBack.Margin = new Padding(4, 5, 4, 5);
            kurnikyBack.Name = "kurnikyBack";
            kurnikyBack.Size = new Size(76, 41);
            kurnikyBack.TabIndex = 1;
            kurnikyBack.UseVisualStyleBackColor = false;
            kurnikyBack.Click += kurnikyBack_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 8.25F);
            button1.Image = Properties.Resources.upgrade_kurnik_bez_shadowu;
            button1.Location = new Point(3, 441);
            button1.Name = "button1";
            button1.Size = new Size(91, 82);
            button1.TabIndex = 14;
            button1.Text = "200";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += purchaseCoop_Click;
            // 
            // coop
            // 
            coop.BackColor = Color.Transparent;
            coop.BackgroundImage = (Image)resources.GetObject("coop.BackgroundImage");
            coop.BackgroundImageLayout = ImageLayout.Center;
            coop.Controls.Add(pictureBox3);
            coop.Location = new Point(127, 309);
            coop.Name = "coop";
            coop.Size = new Size(305, 261);
            coop.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 209);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // upgradeBuy
            // 
            upgradeBuy.BackColor = Color.Transparent;
            upgradeBuy.BackgroundImageLayout = ImageLayout.Center;
            upgradeBuy.FlatAppearance.BorderSize = 0;
            upgradeBuy.FlatAppearance.MouseDownBackColor = Color.Transparent;
            upgradeBuy.FlatAppearance.MouseOverBackColor = Color.Transparent;
            upgradeBuy.FlatStyle = FlatStyle.Flat;
            upgradeBuy.Font = new Font("Arial Black", 8.25F);
            upgradeBuy.Image = Properties.Resources.upgrade_upgrade_bez_shadowu_1;
            upgradeBuy.Location = new Point(3, 529);
            upgradeBuy.Name = "upgradeBuy";
            upgradeBuy.Size = new Size(91, 79);
            upgradeBuy.TabIndex = 9;
            upgradeBuy.Text = "100";
            upgradeBuy.TextAlign = ContentAlignment.BottomCenter;
            upgradeBuy.UseVisualStyleBackColor = false;
            upgradeBuy.Click += buyUpgrade_Click;
            // 
            // cheat
            // 
            cheat.BackColor = Color.Transparent;
            cheat.FlatAppearance.BorderSize = 0;
            cheat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cheat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cheat.FlatStyle = FlatStyle.Flat;
            cheat.Font = new Font("Verdana", 7.8F);
            cheat.ForeColor = Color.Transparent;
            cheat.Image = (Image)resources.GetObject("cheat.Image");
            cheat.Location = new Point(386, 671);
            cheat.Margin = new Padding(0);
            cheat.Name = "cheat";
            cheat.Size = new Size(25, 25);
            cheat.TabIndex = 12;
            cheat.TextImageRelation = TextImageRelation.ImageAboveText;
            cheat.UseVisualStyleBackColor = false;
            cheat.Click += cheat_Click;
            // 
            // removeChicken
            // 
            removeChicken.BackColor = Color.Transparent;
            removeChicken.FlatAppearance.BorderSize = 0;
            removeChicken.FlatAppearance.MouseDownBackColor = Color.Transparent;
            removeChicken.FlatAppearance.MouseOverBackColor = Color.Transparent;
            removeChicken.FlatStyle = FlatStyle.Flat;
            removeChicken.Font = new Font("Verdana", 7.8F);
            removeChicken.Image = Properties.Resources.button_red_remove;
            removeChicken.Location = new Point(3, 680);
            removeChicken.Name = "removeChicken";
            removeChicken.Size = new Size(180, 72);
            removeChicken.TabIndex = 8;
            removeChicken.UseVisualStyleBackColor = false;
            removeChicken.Click += removeChicken_Click;
            // 
            // sellEggs
            // 
            sellEggs.BackColor = Color.Transparent;
            sellEggs.BackgroundImageLayout = ImageLayout.Center;
            sellEggs.FlatAppearance.BorderSize = 0;
            sellEggs.FlatAppearance.MouseDownBackColor = Color.Transparent;
            sellEggs.FlatAppearance.MouseOverBackColor = Color.Transparent;
            sellEggs.FlatStyle = FlatStyle.Flat;
            sellEggs.Font = new Font("Verdana", 7.8F);
            sellEggs.Image = Properties.Resources.button_green_sell;
            sellEggs.Location = new Point(189, 680);
            sellEggs.Name = "sellEggs";
            sellEggs.Size = new Size(121, 72);
            sellEggs.TabIndex = 6;
            sellEggs.UseVisualStyleBackColor = false;
            sellEggs.Click += sellEggs_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.Navy;
            statusLabel.Location = new Point(3, 225);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(80, 28);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "status";
            statusLabel.Click += statusLabel_Click;
            // 
            // SelectionScreen
            // 
            SelectionScreen.Anchor = AnchorStyles.Top;
            SelectionScreen.BackgroundImage = (Image)resources.GetObject("SelectionScreen.BackgroundImage");
            SelectionScreen.Controls.Add(selectionBack);
            SelectionScreen.Controls.Add(selectionKurniky);
            SelectionScreen.Location = new Point(1, 1);
            SelectionScreen.Margin = new Padding(4, 5, 4, 5);
            SelectionScreen.Name = "SelectionScreen";
            SelectionScreen.Size = new Size(432, 758);
            SelectionScreen.TabIndex = 5;
            SelectionScreen.Paint += SelectionScreen_Paint;
            // 
            // selectionBack
            // 
            selectionBack.BackColor = Color.Transparent;
            selectionBack.BackgroundImageLayout = ImageLayout.Center;
            selectionBack.FlatAppearance.BorderSize = 0;
            selectionBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            selectionBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            selectionBack.FlatStyle = FlatStyle.Flat;
            selectionBack.ForeColor = Color.Transparent;
            selectionBack.Image = (Image)resources.GetObject("selectionBack.Image");
            selectionBack.Location = new Point(0, 5);
            selectionBack.Margin = new Padding(4, 5, 4, 5);
            selectionBack.Name = "selectionBack";
            selectionBack.Size = new Size(126, 60);
            selectionBack.TabIndex = 1;
            selectionBack.UseVisualStyleBackColor = false;
            selectionBack.Click += selectionBack_Click;
            // 
            // selectionKurniky
            // 
            selectionKurniky.Anchor = AnchorStyles.Top;
            selectionKurniky.BackColor = Color.Transparent;
            selectionKurniky.FlatAppearance.BorderSize = 0;
            selectionKurniky.FlatAppearance.MouseDownBackColor = Color.Transparent;
            selectionKurniky.FlatAppearance.MouseOverBackColor = Color.Transparent;
            selectionKurniky.FlatStyle = FlatStyle.Flat;
            selectionKurniky.Image = (Image)resources.GetObject("selectionKurniky.Image");
            selectionKurniky.Location = new Point(212, 300);
            selectionKurniky.Margin = new Padding(4, 5, 4, 5);
            selectionKurniky.Name = "selectionKurniky";
            selectionKurniky.Size = new Size(120, 103);
            selectionKurniky.TabIndex = 0;
            selectionKurniky.UseVisualStyleBackColor = false;
            selectionKurniky.Click += selectionKurniky_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(433, 756);
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
            Load += Menu_Load;
            MainMenu.ResumeLayout(false);
            Kurniky.ResumeLayout(false);
            Kurniky.PerformLayout();
            coop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            SelectionScreen.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private DoubleBufferedPanel Kurniky;
        private Button kurnikyBack;
        private Button purchaseChicken;
        private Button menuPlay;
        private Label statusLabel;
        private Panel MainMenu;
        private Label eggCountLabel;
        private Label chickenCountLabel;
        private Button sellEggs;
        private Label moneyCountLabel;
        private Button removeChicken;
        private Button upgradeBuy;
        private Button cheat;
        private Button button1;

        private DoubleBufferedPanel coop;
        private PictureBox pictureBox3;
        private Label epsLabel;
        private Panel SelectionScreen;
        private Button selectionBack;
        private Button selectionKurniky;
        private Button mute;
    }
}
