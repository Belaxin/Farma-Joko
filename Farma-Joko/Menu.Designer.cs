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
            Kurniky = new Panel();
            coop = new DoubleBufferedPanel();
            pictureBox3 = new PictureBox();
            cheat = new Button();
            Info = new Panel();
            epsLabel = new Label();
            moneyCountLabel = new Label();
            eggCountLabel = new Label();
            chickenCountLabel = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            upgradeDesc = new Label();
            upgradeName = new Label();
            upgradeBuy = new Button();
            removeChicken = new Button();
            sellEggs = new Button();
            statusLabel = new Label();
            purchaseChicken = new Button();
            kurnikyBack = new Button();
            SelectionScreen = new Panel();
            selectionBack = new Button();
            selectionKurniky = new Button();
            MainMenu.SuspendLayout();
            Kurniky.SuspendLayout();
            coop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Info.SuspendLayout();
            SelectionScreen.SuspendLayout();
            SuspendLayout();
            // 
            // menuPlay
            // 
            menuPlay.Anchor = AnchorStyles.Top;
            menuPlay.Location = new Point(486, 221);
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
            MainMenu.Anchor = AnchorStyles.None;
            MainMenu.AutoSize = true;
            MainMenu.Controls.Add(menuPlay);
            MainMenu.Location = new Point(0, 0);
            MainMenu.Margin = new Padding(4, 5, 4, 5);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(1109, 498);
            MainMenu.TabIndex = 2;
            MainMenu.Paint += panel1_Paint;
            // 
            // Kurniky
            // 
            Kurniky.Anchor = AnchorStyles.None;
            Kurniky.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Kurniky.BackColor = SystemColors.Control;
            Kurniky.Controls.Add(coop);
            Kurniky.Controls.Add(Info);
            Kurniky.Controls.Add(textBox1);
            Kurniky.Controls.Add(button1);
            Kurniky.Controls.Add(upgradeDesc);
            Kurniky.Controls.Add(upgradeName);
            Kurniky.Controls.Add(upgradeBuy);
            Kurniky.Controls.Add(removeChicken);
            Kurniky.Controls.Add(sellEggs);
            Kurniky.Controls.Add(statusLabel);
            Kurniky.Controls.Add(purchaseChicken);
            Kurniky.Controls.Add(kurnikyBack);
            Kurniky.Location = new Point(1, 0);
            Kurniky.Margin = new Padding(4, 5, 4, 5);
            Kurniky.Name = "Kurniky";
            Kurniky.Size = new Size(1105, 504);
            Kurniky.TabIndex = 4;
            // 
            // coop
            // 
            coop.BackColor = Color.Transparent;
            coop.BackgroundImage = (Image)resources.GetObject("coop.BackgroundImage");
            coop.BackgroundImageLayout = ImageLayout.Center;
            coop.Controls.Add(pictureBox3);
            coop.Controls.Add(cheat);
            coop.Location = new Point(52, 79);
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
            cheat.Location = new Point(212, 221);
            cheat.Margin = new Padding(0);
            cheat.Name = "cheat";
            cheat.Size = new Size(25, 25);
            cheat.TabIndex = 12;
            cheat.TextImageRelation = TextImageRelation.ImageAboveText;
            cheat.UseVisualStyleBackColor = false;
            // 
            // Info
            // 
            Info.BackColor = SystemColors.ActiveCaption;
            Info.Controls.Add(epsLabel);
            Info.Controls.Add(moneyCountLabel);
            Info.Controls.Add(eggCountLabel);
            Info.Controls.Add(chickenCountLabel);
            Info.Location = new Point(100, 3);
            Info.Name = "Info";
            Info.Size = new Size(261, 54);
            Info.TabIndex = 16;
            // 
            // epsLabel
            // 
            epsLabel.AutoSize = true;
            epsLabel.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            epsLabel.Location = new Point(145, 31);
            epsLabel.Name = "epsLabel";
            epsLabel.Padding = new Padding(5);
            epsLabel.Size = new Size(55, 23);
            epsLabel.TabIndex = 8;
            epsLabel.Text = "EpS: 0";
            // 
            // moneyCountLabel
            // 
            moneyCountLabel.AutoSize = true;
            moneyCountLabel.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyCountLabel.Location = new Point(128, 1);
            moneyCountLabel.Name = "moneyCountLabel";
            moneyCountLabel.Padding = new Padding(5);
            moneyCountLabel.Size = new Size(77, 23);
            moneyCountLabel.TabIndex = 7;
            moneyCountLabel.Text = "Money: $0";
            // 
            // eggCountLabel
            // 
            eggCountLabel.AutoSize = true;
            eggCountLabel.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            eggCountLabel.Location = new Point(3, 31);
            eggCountLabel.Name = "eggCountLabel";
            eggCountLabel.Padding = new Padding(5);
            eggCountLabel.Size = new Size(60, 23);
            eggCountLabel.TabIndex = 3;
            eggCountLabel.Text = "Eggs: 0";
            // 
            // chickenCountLabel
            // 
            chickenCountLabel.AutoSize = true;
            chickenCountLabel.Font = new Font("Verdana", 7.8F);
            chickenCountLabel.Location = new Point(0, 0);
            chickenCountLabel.Name = "chickenCountLabel";
            chickenCountLabel.Padding = new Padding(5);
            chickenCountLabel.Size = new Size(97, 23);
            chickenCountLabel.TabIndex = 5;
            chickenCountLabel.Text = "Chickens: 0/0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 362);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 26);
            textBox1.TabIndex = 15;
            textBox1.Text = "Sell eggs $20/pc";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(586, 109);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 14;
            button1.Text = "Buy coop $200";
            button1.UseVisualStyleBackColor = false;
            // 
            // upgradeDesc
            // 
            upgradeDesc.Anchor = AnchorStyles.Top;
            upgradeDesc.Font = new Font("Verdana", 7.8F);
            upgradeDesc.Location = new Point(750, 270);
            upgradeDesc.Name = "upgradeDesc";
            upgradeDesc.Size = new Size(170, 30);
            upgradeDesc.TabIndex = 11;
            upgradeDesc.Text = "Temp   ";
            upgradeDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // upgradeName
            // 
            upgradeName.Anchor = AnchorStyles.Top;
            upgradeName.Font = new Font("Verdana", 7.8F);
            upgradeName.Location = new Point(791, 212);
            upgradeName.Name = "upgradeName";
            upgradeName.Size = new Size(170, 30);
            upgradeName.TabIndex = 10;
            upgradeName.Text = "Temp   ";
            upgradeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // upgradeBuy
            // 
            upgradeBuy.Anchor = AnchorStyles.Top;
            upgradeBuy.BackColor = SystemColors.Control;
            upgradeBuy.Font = new Font("Verdana", 7.8F);
            upgradeBuy.Location = new Point(811, 154);
            upgradeBuy.Name = "upgradeBuy";
            upgradeBuy.Size = new Size(150, 40);
            upgradeBuy.TabIndex = 9;
            upgradeBuy.Text = "Buy";
            upgradeBuy.UseVisualStyleBackColor = false;
            // 
            // removeChicken
            // 
            removeChicken.BackColor = Color.Red;
            removeChicken.FlatStyle = FlatStyle.Popup;
            removeChicken.Font = new Font("Verdana", 7.8F);
            removeChicken.Location = new Point(14, 360);
            removeChicken.Name = "removeChicken";
            removeChicken.Size = new Size(149, 29);
            removeChicken.TabIndex = 8;
            removeChicken.Text = "Remove chicken";
            removeChicken.UseVisualStyleBackColor = false;
            // 
            // sellEggs
            // 
            sellEggs.BackColor = Color.Lime;
            sellEggs.BackgroundImageLayout = ImageLayout.Center;
            sellEggs.FlatStyle = FlatStyle.Popup;
            sellEggs.Font = new Font("Verdana", 7.8F);
            sellEggs.Image = (Image)resources.GetObject("sellEggs.Image");
            sellEggs.Location = new Point(393, 261);
            sellEggs.Name = "sellEggs";
            sellEggs.Size = new Size(55, 48);
            sellEggs.TabIndex = 6;
            sellEggs.UseVisualStyleBackColor = false;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.LawnGreen;
            statusLabel.Location = new Point(154, 459);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(73, 24);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "status";
            // 
            // purchaseChicken
            // 
            purchaseChicken.BackColor = SystemColors.Control;
            purchaseChicken.Font = new Font("Courier New", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchaseChicken.Location = new Point(586, 63);
            purchaseChicken.Name = "purchaseChicken";
            purchaseChicken.Size = new Size(150, 30);
            purchaseChicken.TabIndex = 2;
            purchaseChicken.Text = "Buy chicken $50";
            purchaseChicken.UseVisualStyleBackColor = false;
            // 
            // kurnikyBack
            // 
            kurnikyBack.Anchor = AnchorStyles.Top;
            kurnikyBack.BackColor = SystemColors.ControlDark;
            kurnikyBack.FlatStyle = FlatStyle.System;
            kurnikyBack.Font = new Font("Verdana", 7.8F);
            kurnikyBack.Location = new Point(597, 402);
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
            SelectionScreen.Anchor = AnchorStyles.None;
            SelectionScreen.Controls.Add(selectionBack);
            SelectionScreen.Controls.Add(selectionKurniky);
            SelectionScreen.Location = new Point(1, 2);
            SelectionScreen.Margin = new Padding(4, 5, 4, 5);
            SelectionScreen.Name = "SelectionScreen";
            SelectionScreen.Size = new Size(1105, 501);
            SelectionScreen.TabIndex = 5;
            // 
            // selectionBack
            // 
            selectionBack.Anchor = AnchorStyles.Top;
            selectionBack.Location = new Point(824, 245);
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
            selectionKurniky.Location = new Point(119, 219);
            selectionKurniky.Margin = new Padding(4, 5, 4, 5);
            selectionKurniky.Name = "selectionKurniky";
            selectionKurniky.Size = new Size(108, 37);
            selectionKurniky.TabIndex = 0;
            selectionKurniky.Text = "Kurniky";
            selectionKurniky.UseVisualStyleBackColor = true;
            selectionKurniky.Click += selectionKurniky_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1107, 504);
            Controls.Add(MainMenu);
            Controls.Add(SelectionScreen);
            Controls.Add(Kurniky);
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
            Info.ResumeLayout(false);
            Info.PerformLayout();
            SelectionScreen.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel Kurniky;
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
        private Label upgradeDesc;
        private Label upgradeName;
        private Button cheat;
        private Button button1;
        private TextBox textBox1;
        private Panel Info;

        private DoubleBufferedPanel coop;
        private PictureBox pictureBox3;
        private Label epsLabel;
        private Panel SelectionScreen;
        private Button selectionBack;
        private Button selectionKurniky;
    }
}
