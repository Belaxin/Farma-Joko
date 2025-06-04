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
            SelectionScreen = new Panel();
            selectionBack = new Button();
            selectionKurniky = new Button();
            Kurniky = new Panel();
            textBox1 = new TextBox();
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
            SelectionScreen.Location = new Point(339, -130);
            SelectionScreen.Margin = new Padding(4, 5, 4, 5);
            SelectionScreen.Name = "SelectionScreen";
            SelectionScreen.Size = new Size(432, 549);
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
            Kurniky.Controls.Add(textBox1);
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
            Kurniky.Location = new Point(1, 130);
            Kurniky.Margin = new Padding(4, 5, 4, 5);
            Kurniky.Name = "Kurniky";
            Kurniky.Size = new Size(1105, 504);
            Kurniky.TabIndex = 2;
            Kurniky.Paint += Kurniky_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 332);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 31);
            textBox1.TabIndex = 15;
            textBox1.Text = "Sell eggs $20/pc";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Verdana", 7.8F);
            button1.Location = new Point(586, 109);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 14;
            button1.Text = "Buy coop $200";
            button1.UseVisualStyleBackColor = false;
            button1.Click += purchaseCoop_Click;
            // 
            // cheat
            // 
            cheat.BackColor = SystemColors.ControlDark;
            cheat.FlatStyle = FlatStyle.System;
            cheat.Font = new Font("Verdana", 7.8F);
            cheat.Location = new Point(13, 464);
            cheat.Name = "cheat";
            cheat.Size = new Size(108, 29);
            cheat.TabIndex = 12;
            cheat.Text = "Money";
            cheat.UseVisualStyleBackColor = false;
            cheat.Click += cheat_Click;
            // 
            // upgradeDesc
            // 
            upgradeDesc.Anchor = AnchorStyles.Top;
            upgradeDesc.Font = new Font("Verdana", 7.8F);
            upgradeDesc.Location = new Point(566, 234);
            upgradeDesc.Name = "upgradeDesc";
            upgradeDesc.Size = new Size(170, 30);
            upgradeDesc.TabIndex = 11;
            upgradeDesc.Text = "Temp   ";
            upgradeDesc.TextAlign = ContentAlignment.MiddleCenter;
            upgradeDesc.Click += upgradeDesc_Click;
            // 
            // upgradeName
            // 
            upgradeName.Anchor = AnchorStyles.Top;
            upgradeName.Font = new Font("Verdana", 7.8F);
            upgradeName.Location = new Point(566, 199);
            upgradeName.Name = "upgradeName";
            upgradeName.Size = new Size(170, 30);
            upgradeName.TabIndex = 10;
            upgradeName.Text = "Temp   ";
            upgradeName.TextAlign = ContentAlignment.MiddleCenter;
            upgradeName.Click += upgradeName_Click;
            // 
            // upgradeBuy
            // 
            upgradeBuy.Anchor = AnchorStyles.Top;
            upgradeBuy.BackColor = SystemColors.Control;
            upgradeBuy.Font = new Font("Verdana", 7.8F);
            upgradeBuy.Location = new Point(586, 154);
            upgradeBuy.Name = "upgradeBuy";
            upgradeBuy.Size = new Size(150, 40);
            upgradeBuy.TabIndex = 9;
            upgradeBuy.Text = "Buy";
            upgradeBuy.UseVisualStyleBackColor = false;
            upgradeBuy.Click += buyUpgrade_Click;
            // 
            // removeChicken
            // 
            removeChicken.BackColor = Color.Red;
            removeChicken.FlatStyle = FlatStyle.Popup;
            removeChicken.Font = new Font("Verdana", 7.8F);
            removeChicken.Location = new Point(34, 334);
            removeChicken.Name = "removeChicken";
            removeChicken.Size = new Size(149, 29);
            removeChicken.TabIndex = 8;
            removeChicken.Text = "Remove chicken";
            removeChicken.UseVisualStyleBackColor = false;
            removeChicken.Click += removeChicken_Click;
            // 
            // moneyCountLabel
            // 
            moneyCountLabel.AutoSize = true;
            moneyCountLabel.Font = new Font("Verdana", 7.8F);
            moneyCountLabel.Location = new Point(307, 0);
            moneyCountLabel.Name = "moneyCountLabel";
            moneyCountLabel.Padding = new Padding(5);
            moneyCountLabel.Size = new Size(87, 26);
            moneyCountLabel.TabIndex = 7;
            moneyCountLabel.Text = "Money: $0";
            // 
            // sellEggs
            // 
            sellEggs.BackColor = Color.Lime;
            sellEggs.BackgroundImage = Properties.Resources.vajec1;
            sellEggs.BackgroundImageLayout = ImageLayout.Center;
            sellEggs.FlatStyle = FlatStyle.Popup;
            sellEggs.Font = new Font("Verdana", 7.8F);
            sellEggs.Location = new Point(393, 261);
            sellEggs.Name = "sellEggs";
            sellEggs.Size = new Size(55, 48);
            sellEggs.TabIndex = 6;
            sellEggs.UseVisualStyleBackColor = false;
            sellEggs.Click += sellEggs_Click;
            // 
            // chickenCountLabel
            // 
            chickenCountLabel.AutoSize = true;
            chickenCountLabel.Font = new Font("Verdana", 7.8F);
            chickenCountLabel.Location = new Point(146, 0);
            chickenCountLabel.Name = "chickenCountLabel";
            chickenCountLabel.Padding = new Padding(5);
            chickenCountLabel.Size = new Size(108, 26);
            chickenCountLabel.TabIndex = 5;
            chickenCountLabel.Text = "Chickens: 0/0";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.LawnGreen;
            statusLabel.Location = new Point(27, 400);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(94, 32);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "status";
            statusLabel.Click += label1_Click;
            // 
            // eggCountLabel
            // 
            eggCountLabel.AutoSize = true;
            eggCountLabel.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            eggCountLabel.Location = new Point(34, 0);
            eggCountLabel.Name = "eggCountLabel";
            eggCountLabel.Padding = new Padding(5);
            eggCountLabel.Size = new Size(67, 26);
            eggCountLabel.TabIndex = 3;
            eggCountLabel.Text = "Eggs: 0";
            eggCountLabel.Click += label1_Click_1;
            // 
            // purchaseChicken
            // 
            purchaseChicken.BackColor = SystemColors.Control;
            purchaseChicken.Font = new Font("Verdana", 7.8F);
            purchaseChicken.Location = new Point(586, 63);
            purchaseChicken.Name = "purchaseChicken";
            purchaseChicken.Size = new Size(150, 30);
            purchaseChicken.TabIndex = 2;
            purchaseChicken.Text = "Buy chicken $50";
            purchaseChicken.UseVisualStyleBackColor = false;
            purchaseChicken.Click += purchaseChicken_Click;
            // 
            // kurnikyBack
            // 
            kurnikyBack.Anchor = AnchorStyles.Top;
            kurnikyBack.BackColor = SystemColors.ControlDark;
            kurnikyBack.FlatStyle = FlatStyle.System;
            kurnikyBack.Font = new Font("Verdana", 7.8F);
            kurnikyBack.Location = new Point(682, 470);
            kurnikyBack.Margin = new Padding(4, 5, 4, 5);
            kurnikyBack.Name = "kurnikyBack";
            kurnikyBack.Size = new Size(65, 29);
            kurnikyBack.TabIndex = 1;
            kurnikyBack.Text = "back";
            kurnikyBack.UseVisualStyleBackColor = false;
            kurnikyBack.Click += kurnikyBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.kurenec;
            pictureBox1.Location = new Point(48, 31);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 288);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuPlay
            // 
            menuPlay.Anchor = AnchorStyles.Top;
            menuPlay.Location = new Point(497, 287);
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
            MainMenu.Controls.Add(Kurniky);
            MainMenu.Controls.Add(menuPlay);
            MainMenu.Location = new Point(-1, -130);
            MainMenu.Margin = new Padding(4, 5, 4, 5);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(1109, 677);
            MainMenu.TabIndex = 2;
            MainMenu.Paint += panel1_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1107, 504);
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
            Load += Menu_Load;
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
        private TextBox textBox1;
    }
}
