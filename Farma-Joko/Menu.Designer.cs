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
            panel1 = new Panel();
            purchaseChicken = new Button();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            upgradeBuy = new Button();
            mute = new Button();
            kurnikyBack = new Button();
            coop = new DoubleBufferedPanel();
            pictureBox3 = new PictureBox();
            cheat = new Button();
            Info = new Panel();
            epsLabel = new Label();
            moneyCountLabel = new Label();
            eggCountLabel = new Label();
            chickenCountLabel = new Label();
            removeChicken = new Button();
            sellEggs = new Button();
            statusLabel = new Label();
            SelectionScreen = new Panel();
            selectionBack = new Button();
            selectionKurniky = new Button();
            MainMenu.SuspendLayout();
            Kurniky.SuspendLayout();
            panel1.SuspendLayout();
            coop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Info.SuspendLayout();
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
            Kurniky.BackgroundImage = (Image)resources.GetObject("Kurniky.BackgroundImage");
            Kurniky.Controls.Add(panel1);
            Kurniky.Controls.Add(mute);
            Kurniky.Controls.Add(kurnikyBack);
            Kurniky.Controls.Add(coop);
            Kurniky.Controls.Add(cheat);
            Kurniky.Controls.Add(Info);
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
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(purchaseChicken);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(upgradeBuy);
            panel1.Location = new Point(252, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 268);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint_1;
            // 
            // purchaseChicken
            // 
            purchaseChicken.BackColor = Color.Transparent;
            purchaseChicken.BackgroundImage = (Image)resources.GetObject("purchaseChicken.BackgroundImage");
            purchaseChicken.BackgroundImageLayout = ImageLayout.Center;
            purchaseChicken.FlatAppearance.BorderSize = 0;
            purchaseChicken.FlatAppearance.MouseDownBackColor = Color.Transparent;
            purchaseChicken.FlatAppearance.MouseOverBackColor = Color.Transparent;
            purchaseChicken.FlatStyle = FlatStyle.Flat;
            purchaseChicken.Font = new Font("Courier New", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchaseChicken.Location = new Point(63, 37);
            purchaseChicken.Name = "purchaseChicken";
            purchaseChicken.Size = new Size(62, 55);
            purchaseChicken.TabIndex = 2;
            purchaseChicken.UseVisualStyleBackColor = false;
            purchaseChicken.Click += purchaseChicken_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 9F);
            label2.Location = new Point(70, 162);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 28;
            label2.Text = "200$";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 9F);
            label1.Location = new Point(73, 86);
            label1.Name = "label1";
            label1.Size = new Size(40, 22);
            label1.TabIndex = 27;
            label1.Text = "50$";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(57, 113);
            button1.Name = "button1";
            button1.Size = new Size(62, 55);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += purchaseCoop_Click;
            // 
            // upgradeBuy
            // 
            upgradeBuy.BackColor = Color.Transparent;
            upgradeBuy.BackgroundImageLayout = ImageLayout.Center;
            upgradeBuy.FlatAppearance.BorderSize = 0;
            upgradeBuy.FlatAppearance.MouseDownBackColor = Color.Transparent;
            upgradeBuy.FlatAppearance.MouseOverBackColor = Color.Transparent;
            upgradeBuy.FlatStyle = FlatStyle.Flat;
            upgradeBuy.Font = new Font("Verdana", 7.8F);
            upgradeBuy.Image = (Image)resources.GetObject("upgradeBuy.Image");
            upgradeBuy.Location = new Point(63, 183);
            upgradeBuy.Name = "upgradeBuy";
            upgradeBuy.Size = new Size(62, 55);
            upgradeBuy.TabIndex = 9;
            upgradeBuy.Text = "Buy";
            upgradeBuy.UseVisualStyleBackColor = false;
            upgradeBuy.Click += buyUpgrade_Click;
            // 
            // mute
            // 
            mute.BackColor = Color.Transparent;
            mute.FlatStyle = FlatStyle.Popup;
            mute.Image = Properties.Resources.mute;
            mute.Location = new Point(86, 45);
            mute.Name = "mute";
            mute.Size = new Size(29, 33);
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
            kurnikyBack.Location = new Point(3, 45);
            kurnikyBack.Margin = new Padding(4, 5, 4, 5);
            kurnikyBack.Name = "kurnikyBack";
            kurnikyBack.Size = new Size(76, 41);
            kurnikyBack.TabIndex = 1;
            kurnikyBack.UseVisualStyleBackColor = false;
            kurnikyBack.Click += kurnikyBack_Click;
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
            // Info
            // 
            Info.BackColor = SystemColors.ActiveCaption;
            Info.Controls.Add(epsLabel);
            Info.Controls.Add(moneyCountLabel);
            Info.Controls.Add(eggCountLabel);
            Info.Controls.Add(chickenCountLabel);
            Info.Location = new Point(0, 0);
            Info.Name = "Info";
            Info.Size = new Size(432, 44);
            Info.TabIndex = 16;
            // 
            // epsLabel
            // 
            epsLabel.AutoSize = true;
            epsLabel.Font = new Font("Arial Black", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            epsLabel.Location = new Point(358, 8);
            epsLabel.Name = "epsLabel";
            epsLabel.Padding = new Padding(5);
            epsLabel.Size = new Size(62, 28);
            epsLabel.TabIndex = 8;
            epsLabel.Text = "EpS: 0";
            // 
            // moneyCountLabel
            // 
            moneyCountLabel.AutoSize = true;
            moneyCountLabel.Font = new Font("Arial Black", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyCountLabel.Location = new Point(155, 8);
            moneyCountLabel.Name = "moneyCountLabel";
            moneyCountLabel.Padding = new Padding(5);
            moneyCountLabel.Size = new Size(96, 29);
            moneyCountLabel.TabIndex = 7;
            moneyCountLabel.Text = "Money: $0";
            // 
            // eggCountLabel
            // 
            eggCountLabel.AutoSize = true;
            eggCountLabel.Font = new Font("Arial Black", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            eggCountLabel.Location = new Point(280, 8);
            eggCountLabel.Name = "eggCountLabel";
            eggCountLabel.Padding = new Padding(5);
            eggCountLabel.Size = new Size(70, 28);
            eggCountLabel.TabIndex = 3;
            eggCountLabel.Text = "Eggs: 0";
            // 
            // chickenCountLabel
            // 
            chickenCountLabel.AutoSize = true;
            chickenCountLabel.Font = new Font("Arial Black", 7.8F);
            chickenCountLabel.Location = new Point(0, 8);
            chickenCountLabel.Name = "chickenCountLabel";
            chickenCountLabel.Padding = new Padding(5);
            chickenCountLabel.Size = new Size(115, 28);
            chickenCountLabel.TabIndex = 5;
            chickenCountLabel.Text = "Chickens: 0/0";
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
            sellEggs.FlatStyle = FlatStyle.Popup;
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
            statusLabel.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            SelectionScreen.BackgroundImage = Properties.Resources.map_menu_bg_v4;
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
            selectionBack.Image = Properties.Resources.back_button_tabula;
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
            AutoScaleDimensions = new SizeF(10F, 24F);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            coop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Info.ResumeLayout(false);
            Info.PerformLayout();
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
        private Panel Info;

        private DoubleBufferedPanel coop;
        private PictureBox pictureBox3;
        private Label epsLabel;
        private Panel SelectionScreen;
        private Button selectionBack;
        private Button selectionKurniky;
        private Button mute;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}
