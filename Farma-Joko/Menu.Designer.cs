﻿namespace Farma_Joko
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
            SelectionScreen = new Panel();
            selectionBack = new Button();
            selectionKurniky = new Button();
            Kurniky = new Panel();
            button1 = new Button();
            cheat = new Button();
            upgradeDesc = new Label();
            upgradeName = new Label();
            upgradeBuy = new Button();
            removeChicken = new Button();
            moneyCountLabel = new Label();
            sellEggs = new Button();
            chickenCountLabel = new Label();
            statusLabel = new Label();
            eggCountLabel = new Label();
            purchaseChicken = new Button();
            kurnikyBack = new Button();
            pictureBox1 = new PictureBox();
            menuPlay = new Button();
            MainMenu = new Panel();
            SelectionScreen.SuspendLayout();
            Kurniky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // SelectionScreen
            // 
            SelectionScreen.Anchor = AnchorStyles.None;
            SelectionScreen.Controls.Add(selectionBack);
            SelectionScreen.Controls.Add(selectionKurniky);
            SelectionScreen.Location = new Point(0, -6);
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
            Kurniky.Anchor = AnchorStyles.None;
            Kurniky.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Kurniky.BackgroundImage = Properties.Resources._180px_Grass;
            Kurniky.Controls.Add(button1);
            Kurniky.Controls.Add(cheat);
            Kurniky.Controls.Add(upgradeDesc);
            Kurniky.Controls.Add(upgradeName);
            Kurniky.Controls.Add(upgradeBuy);
            Kurniky.Controls.Add(removeChicken);
            Kurniky.Controls.Add(moneyCountLabel);
            Kurniky.Controls.Add(sellEggs);
            Kurniky.Controls.Add(chickenCountLabel);
            Kurniky.Controls.Add(statusLabel);
            Kurniky.Controls.Add(eggCountLabel);
            Kurniky.Controls.Add(purchaseChicken);
            Kurniky.Controls.Add(kurnikyBack);
            Kurniky.Controls.Add(pictureBox1);
            Kurniky.Location = new Point(0, -8);
            Kurniky.Margin = new Padding(4, 5, 4, 5);
            Kurniky.Name = "Kurniky";
            Kurniky.Size = new Size(432, 768);
            Kurniky.TabIndex = 2;
            Kurniky.Paint += Kurniky_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(257, 363);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 14;
            button1.Text = "Buy coop $200";
            button1.UseVisualStyleBackColor = true;
            button1.Click += purchaseCoop_Click;
            // 
            // cheat
            // 
            cheat.Location = new Point(294, 167);
            cheat.Name = "cheat";
            cheat.Size = new Size(108, 29);
            cheat.TabIndex = 12;
            cheat.Text = "Money";
            cheat.UseVisualStyleBackColor = true;
            cheat.Click += cheat_Click;
            // 
            // upgradeDesc
            // 
            upgradeDesc.Anchor = AnchorStyles.Top;
            upgradeDesc.Location = new Point(228, 597);
            upgradeDesc.Name = "upgradeDesc";
            upgradeDesc.Size = new Size(174, 19);
            upgradeDesc.TabIndex = 11;
            upgradeDesc.Text = "Temp   ";
            upgradeDesc.TextAlign = ContentAlignment.MiddleCenter;
            upgradeDesc.Click += upgradeDesc_Click;
            // 
            // upgradeName
            // 
            upgradeName.Anchor = AnchorStyles.Top;
            upgradeName.Location = new Point(228, 555);
            upgradeName.Name = "upgradeName";
            upgradeName.Size = new Size(174, 19);
            upgradeName.TabIndex = 10;
            upgradeName.Text = "Temp   ";
            upgradeName.TextAlign = ContentAlignment.MiddleCenter;
            upgradeName.Click += upgradeName_Click;
            // 
            // upgradeBuy
            // 
            upgradeBuy.Anchor = AnchorStyles.Top;
            upgradeBuy.Location = new Point(228, 645);
            upgradeBuy.Name = "upgradeBuy";
            upgradeBuy.Size = new Size(174, 29);
            upgradeBuy.TabIndex = 9;
            upgradeBuy.Text = "Buy";
            upgradeBuy.UseVisualStyleBackColor = true;
            upgradeBuy.Click += buyUpgrade_Click;
            // 
            // removeChicken
            // 
            removeChicken.Location = new Point(60, 398);
            removeChicken.Name = "removeChicken";
            removeChicken.Size = new Size(149, 29);
            removeChicken.TabIndex = 8;
            removeChicken.Text = "Remove chicken";
            removeChicken.UseVisualStyleBackColor = true;
            removeChicken.Click += removeChicken_Click;
            // 
            // moneyCountLabel
            // 
            moneyCountLabel.AutoSize = true;
            moneyCountLabel.Location = new Point(228, 0);
            moneyCountLabel.Name = "moneyCountLabel";
            moneyCountLabel.Size = new Size(68, 19);
            moneyCountLabel.TabIndex = 7;
            moneyCountLabel.Text = "Money: $0";
            // 
            // sellEggs
            // 
            sellEggs.Location = new Point(60, 478);
            sellEggs.Name = "sellEggs";
            sellEggs.Size = new Size(149, 29);
            sellEggs.TabIndex = 6;
            sellEggs.Text = "Sell eggs $20/pc";
            sellEggs.UseVisualStyleBackColor = true;
            sellEggs.Click += sellEggs_Click;
            // 
            // chickenCountLabel
            // 
            chickenCountLabel.AutoSize = true;
            chickenCountLabel.Location = new Point(79, 0);
            chickenCountLabel.Name = "chickenCountLabel";
            chickenCountLabel.Size = new Size(88, 19);
            chickenCountLabel.TabIndex = 5;
            chickenCountLabel.Text = "Chickens: 0/0";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.Firebrick;
            statusLabel.Location = new Point(12, 680);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(73, 24);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "status";
            statusLabel.Click += label1_Click;
            // 
            // eggCountLabel
            // 
            eggCountLabel.AutoSize = true;
            eggCountLabel.Location = new Point(0, 0);
            eggCountLabel.Name = "eggCountLabel";
            eggCountLabel.Size = new Size(52, 19);
            eggCountLabel.TabIndex = 3;
            eggCountLabel.Text = "Eggs: 0";
            eggCountLabel.Click += label1_Click_1;
            // 
            // purchaseChicken
            // 
            purchaseChicken.Location = new Point(60, 363);
            purchaseChicken.Name = "purchaseChicken";
            purchaseChicken.Size = new Size(149, 29);
            purchaseChicken.TabIndex = 2;
            purchaseChicken.Text = "Buy chicken $50";
            purchaseChicken.UseVisualStyleBackColor = true;
            purchaseChicken.Click += purchaseChicken_Click;
            // 
            // kurnikyBack
            // 
            kurnikyBack.Anchor = AnchorStyles.Top;
            kurnikyBack.Location = new Point(294, 94);
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
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.chicken;
            pictureBox1.Location = new Point(30, 61);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 277);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // MainMenu
            // 
            MainMenu.Anchor = AnchorStyles.None;
            MainMenu.AutoSize = true;
            MainMenu.BackgroundImage = Properties.Resources._180px_Grass;
            MainMenu.Controls.Add(menuPlay);
            MainMenu.Location = new Point(0, -6);
            MainMenu.Margin = new Padding(4, 5, 4, 5);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(432, 768);
            MainMenu.TabIndex = 2;
            MainMenu.Paint += panel1_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(428, 752);
            Controls.Add(Kurniky);
            Controls.Add(MainMenu);
            Controls.Add(SelectionScreen);
            Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            Text = "Farma Joko";
            WindowState = FormWindowState.Minimized;
            SelectionScreen.ResumeLayout(false);
            Kurniky.ResumeLayout(false);
            Kurniky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel SelectionScreen;
        private Button selectionKurniky;
        private Panel Kurniky;
        private Button kurnikyBack;
        private PictureBox pictureBox1;
        private Button selectionBack;
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
    }
}
