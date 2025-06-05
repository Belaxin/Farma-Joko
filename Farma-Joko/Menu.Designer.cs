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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            upgradeBuy = new Button();
            purchaseChicken = new Button();
            mute = new Button();
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
            kurnikyBack = new Button();
            SelectionScreen = new Panel();
            selectionBack = new Button();
            selectionKurniky = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            menuPlay.Location = new Point(159, 424);
            menuPlay.Margin = new Padding(4, 5, 4, 5);
            menuPlay.Name = "menuPlay";
            menuPlay.Size = new Size(108, 40);
            menuPlay.TabIndex = 0;
            menuPlay.Text = "Play";
            menuPlay.UseVisualStyleBackColor = true;
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
            Kurniky.BackgroundImage = Properties.Resources.chicken_farm_background_bg;
            Kurniky.Controls.Add(panel1);
            Kurniky.Controls.Add(mute);
            Kurniky.Controls.Add(coop);
            Kurniky.Controls.Add(cheat);
            Kurniky.Controls.Add(Info);
            Kurniky.Controls.Add(removeChicken);
            Kurniky.Controls.Add(sellEggs);
            Kurniky.Controls.Add(statusLabel);
            Kurniky.Controls.Add(kurnikyBack);
            Kurniky.Location = new Point(1, 1);
            Kurniky.Margin = new Padding(4, 5, 4, 5);
            Kurniky.Name = "Kurniky";
            Kurniky.Size = new Size(432, 763);
            Kurniky.TabIndex = 4;
            Kurniky.Paint += Kurniky_Paint_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(upgradeBuy);
            panel1.Controls.Add(purchaseChicken);
            panel1.Location = new Point(0, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 363);
            panel1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 31);
            textBox2.TabIndex = 24;
            textBox2.Text = "SHOP";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 31);
            textBox1.TabIndex = 22;
            textBox1.Text = "Coop - 200$";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.miniKurenec;
            button1.Location = new Point(10, 49);
            button1.Name = "button1";
            button1.Size = new Size(106, 66);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += purchaseCoop_Click;
            // 
            // upgradeBuy
            // 
            upgradeBuy.Anchor = AnchorStyles.Top;
            upgradeBuy.BackColor = Color.Transparent;
            upgradeBuy.BackgroundImageLayout = ImageLayout.Center;
            upgradeBuy.FlatStyle = FlatStyle.Flat;
            upgradeBuy.Font = new Font("Verdana", 7.8F);
            upgradeBuy.Image = Properties.Resources.upgradeIcon;
            upgradeBuy.Location = new Point(8, 254);
            upgradeBuy.Name = "upgradeBuy";
            upgradeBuy.Size = new Size(108, 66);
            upgradeBuy.TabIndex = 9;
            upgradeBuy.Text = "Buy";
            upgradeBuy.UseVisualStyleBackColor = false;
            upgradeBuy.Click += buyUpgrade_Click;
            // 
            // purchaseChicken
            // 
            purchaseChicken.BackColor = Color.Transparent;
            purchaseChicken.BackgroundImage = (Image)resources.GetObject("purchaseChicken.BackgroundImage");
            purchaseChicken.BackgroundImageLayout = ImageLayout.Center;
            purchaseChicken.FlatStyle = FlatStyle.Flat;
            purchaseChicken.Font = new Font("Courier New", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchaseChicken.Location = new Point(8, 152);
            purchaseChicken.Name = "purchaseChicken";
            purchaseChicken.Size = new Size(108, 66);
            purchaseChicken.TabIndex = 2;
            purchaseChicken.UseVisualStyleBackColor = false;
            purchaseChicken.Click += purchaseChicken_Click;
            // 
            // mute
            // 
            mute.BackColor = Color.Transparent;
            mute.FlatStyle = FlatStyle.Popup;
            mute.Image = Properties.Resources.mute;
            mute.Location = new Point(391, 50);
            mute.Name = "mute";
            mute.Size = new Size(29, 33);
            mute.TabIndex = 21;
            mute.UseVisualStyleBackColor = false;
            mute.Click += mute_Click;
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
            epsLabel.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            epsLabel.Location = new Point(340, 8);
            epsLabel.Name = "epsLabel";
            epsLabel.Padding = new Padding(5);
            epsLabel.Size = new Size(61, 26);
            epsLabel.TabIndex = 8;
            epsLabel.Text = "EpS: 0";
            // 
            // moneyCountLabel
            // 
            moneyCountLabel.AutoSize = true;
            moneyCountLabel.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyCountLabel.Location = new Point(133, 8);
            moneyCountLabel.Name = "moneyCountLabel";
            moneyCountLabel.Padding = new Padding(5);
            moneyCountLabel.Size = new Size(92, 27);
            moneyCountLabel.TabIndex = 7;
            moneyCountLabel.Text = "Money: $0";
            // 
            // eggCountLabel
            // 
            eggCountLabel.AutoSize = true;
            eggCountLabel.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            eggCountLabel.Location = new Point(253, 8);
            eggCountLabel.Name = "eggCountLabel";
            eggCountLabel.Padding = new Padding(5);
            eggCountLabel.Size = new Size(67, 26);
            eggCountLabel.TabIndex = 3;
            eggCountLabel.Text = "Eggs: 0";
            // 
            // chickenCountLabel
            // 
            chickenCountLabel.AutoSize = true;
            chickenCountLabel.Font = new Font("Verdana", 7.8F);
            chickenCountLabel.Location = new Point(8, 8);
            chickenCountLabel.Name = "chickenCountLabel";
            chickenCountLabel.Padding = new Padding(5);
            chickenCountLabel.Size = new Size(108, 26);
            chickenCountLabel.TabIndex = 5;
            chickenCountLabel.Text = "Chickens: 0/0";
            // 
            // removeChicken
            // 
            removeChicken.BackColor = Color.Red;
            removeChicken.FlatStyle = FlatStyle.Popup;
            removeChicken.Font = new Font("Verdana", 7.8F);
            removeChicken.Location = new Point(11, 690);
            removeChicken.Name = "removeChicken";
            removeChicken.Size = new Size(129, 53);
            removeChicken.TabIndex = 8;
            removeChicken.Text = "Remove Chicken";
            removeChicken.UseVisualStyleBackColor = false;
            removeChicken.Click += removeChicken_Click;
            // 
            // sellEggs
            // 
            sellEggs.BackColor = Color.Lime;
            sellEggs.BackgroundImageLayout = ImageLayout.Center;
            sellEggs.FlatStyle = FlatStyle.Popup;
            sellEggs.Font = new Font("Verdana", 7.8F);
            sellEggs.Location = new Point(146, 690);
            sellEggs.Name = "sellEggs";
            sellEggs.Size = new Size(121, 53);
            sellEggs.TabIndex = 6;
            sellEggs.Text = "Sell Eggs";
            sellEggs.UseVisualStyleBackColor = false;
            sellEggs.Click += sellEggs_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.LawnGreen;
            statusLabel.Location = new Point(22, 237);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(94, 32);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "status";
            statusLabel.Click += statusLabel_Click;
            // 
            // kurnikyBack
            // 
            kurnikyBack.Anchor = AnchorStyles.Top;
            kurnikyBack.BackColor = SystemColors.ControlDark;
            kurnikyBack.FlatStyle = FlatStyle.System;
            kurnikyBack.Font = new Font("Verdana", 7.8F);
            kurnikyBack.Location = new Point(363, 716);
            kurnikyBack.Margin = new Padding(4, 5, 4, 5);
            kurnikyBack.Name = "kurnikyBack";
            kurnikyBack.Size = new Size(65, 29);
            kurnikyBack.TabIndex = 1;
            kurnikyBack.Text = "back";
            kurnikyBack.UseVisualStyleBackColor = false;
            kurnikyBack.Click += kurnikyBack_Click;
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
            selectionBack.FlatStyle = FlatStyle.Popup;
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
            selectionKurniky.Location = new Point(212, 324);
            selectionKurniky.Margin = new Padding(4, 5, 4, 5);
            selectionKurniky.Name = "selectionKurniky";
            selectionKurniky.Size = new Size(108, 37);
            selectionKurniky.TabIndex = 0;
            selectionKurniky.Text = "Kurniky";
            selectionKurniky.UseVisualStyleBackColor = true;
            selectionKurniky.Click += selectionKurniky_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 31);
            textBox3.TabIndex = 25;
            textBox3.Text = "Chick - 50$";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(8, 322);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 31);
            textBox4.TabIndex = 26;
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
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}
