﻿namespace GasCalculator
{
    partial class storeInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.costButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.gasType = new System.Windows.Forms.Label();
            this.regularBox = new System.Windows.Forms.TextBox();
            this.premiumBox = new System.Windows.Forms.TextBox();
            this.midBox = new System.Windows.Forms.TextBox();
            this.carType = new System.Windows.Forms.Label();
            this.pathType = new System.Windows.Forms.Label();
            this.fuelNeeded = new System.Windows.Forms.TextBox();
            this.amountTitle = new System.Windows.Forms.Label();
            this.fuelAmount = new System.Windows.Forms.TextBox();
            this.moneyRequest = new System.Windows.Forms.TextBox();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.regCheck = new System.Windows.Forms.CheckBox();
            this.midCheck = new System.Windows.Forms.CheckBox();
            this.premCheck = new System.Windows.Forms.CheckBox();
            this.miniCheck = new System.Windows.Forms.CheckBox();
            this.truckCheck = new System.Windows.Forms.CheckBox();
            this.carCheck = new System.Windows.Forms.CheckBox();
            this.option1 = new System.Windows.Forms.CheckBox();
            this.option2 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisIsVersion10BySamWyattAsTheSecondSummativeInICS3UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printButton = new System.Windows.Forms.Button();
            this.tenderBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.reqirements3 = new System.Windows.Forms.Label();
            this.fullButton = new System.Windows.Forms.Button();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // costButton
            // 
            this.costButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.costButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costButton.Location = new System.Drawing.Point(355, 165);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(126, 38);
            this.costButton.TabIndex = 4;
            this.costButton.Text = "Calculate Cost";
            this.costButton.UseVisualStyleBackColor = false;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Courier New", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(195, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 37);
            this.title.TabIndex = 8;
            this.title.Text = "The Gas Corner";
            // 
            // gasType
            // 
            this.gasType.AutoSize = true;
            this.gasType.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasType.ForeColor = System.Drawing.Color.White;
            this.gasType.Location = new System.Drawing.Point(12, 67);
            this.gasType.Name = "gasType";
            this.gasType.Size = new System.Drawing.Size(288, 18);
            this.gasType.TabIndex = 9;
            this.gasType.Text = "Step 1: Select your gas type";
            // 
            // regularBox
            // 
            this.regularBox.Location = new System.Drawing.Point(139, 102);
            this.regularBox.Name = "regularBox";
            this.regularBox.Size = new System.Drawing.Size(100, 20);
            this.regularBox.TabIndex = 13;
            this.regularBox.Text = "$ 0.869 per liter";
            // 
            // premiumBox
            // 
            this.premiumBox.Location = new System.Drawing.Point(139, 152);
            this.premiumBox.Name = "premiumBox";
            this.premiumBox.Size = new System.Drawing.Size(100, 20);
            this.premiumBox.TabIndex = 14;
            this.premiumBox.Text = "$ 1.019 per liter";
            // 
            // midBox
            // 
            this.midBox.Location = new System.Drawing.Point(139, 127);
            this.midBox.Name = "midBox";
            this.midBox.Size = new System.Drawing.Size(100, 20);
            this.midBox.TabIndex = 15;
            this.midBox.Text = "$ 0.946 per liter";
            // 
            // carType
            // 
            this.carType.AutoSize = true;
            this.carType.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carType.ForeColor = System.Drawing.Color.White;
            this.carType.Location = new System.Drawing.Point(9, 234);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(296, 17);
            this.carType.TabIndex = 17;
            this.carType.Text = "Step 2: Select your vehicle type";
            // 
            // pathType
            // 
            this.pathType.AutoSize = true;
            this.pathType.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathType.ForeColor = System.Drawing.Color.White;
            this.pathType.Location = new System.Drawing.Point(352, 67);
            this.pathType.Name = "pathType";
            this.pathType.Size = new System.Drawing.Size(248, 18);
            this.pathType.TabIndex = 21;
            this.pathType.Text = "Step 4: Select your path";
            // 
            // fuelNeeded
            // 
            this.fuelNeeded.BackColor = System.Drawing.Color.White;
            this.fuelNeeded.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fuelNeeded.Location = new System.Drawing.Point(356, 139);
            this.fuelNeeded.Name = "fuelNeeded";
            this.fuelNeeded.Size = new System.Drawing.Size(125, 20);
            this.fuelNeeded.TabIndex = 22;
            this.fuelNeeded.Text = "Ex. 100% full = 1";
            // 
            // amountTitle
            // 
            this.amountTitle.AutoSize = true;
            this.amountTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTitle.ForeColor = System.Drawing.Color.White;
            this.amountTitle.Location = new System.Drawing.Point(12, 343);
            this.amountTitle.Name = "amountTitle";
            this.amountTitle.Size = new System.Drawing.Size(308, 18);
            this.amountTitle.TabIndex = 23;
            this.amountTitle.Text = "Step 3: How full is your tank?";
            // 
            // fuelAmount
            // 
            this.fuelAmount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fuelAmount.Location = new System.Drawing.Point(16, 377);
            this.fuelAmount.Name = "fuelAmount";
            this.fuelAmount.Size = new System.Drawing.Size(100, 20);
            this.fuelAmount.TabIndex = 24;
            this.fuelAmount.Text = "Ex. 50% full = 0.5";
            // 
            // moneyRequest
            // 
            this.moneyRequest.BackColor = System.Drawing.Color.White;
            this.moneyRequest.Location = new System.Drawing.Point(355, 286);
            this.moneyRequest.Name = "moneyRequest";
            this.moneyRequest.Size = new System.Drawing.Size(125, 20);
            this.moneyRequest.TabIndex = 25;
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.BackColor = System.Drawing.Color.White;
            this.outputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel1.ForeColor = System.Drawing.Color.Navy;
            this.outputLabel1.Location = new System.Drawing.Point(440, 223);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(0, 13);
            this.outputLabel1.TabIndex = 26;
            // 
            // regCheck
            // 
            this.regCheck.AutoSize = true;
            this.regCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regCheck.FlatAppearance.BorderSize = 3;
            this.regCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.regCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCheck.ForeColor = System.Drawing.Color.White;
            this.regCheck.Location = new System.Drawing.Point(16, 101);
            this.regCheck.Name = "regCheck";
            this.regCheck.Size = new System.Drawing.Size(74, 19);
            this.regCheck.TabIndex = 27;
            this.regCheck.Text = "Regular";
            this.regCheck.UseVisualStyleBackColor = true;
            this.regCheck.CheckStateChanged += new System.EventHandler(this.regCheck_CheckStateChanged);
            this.regCheck.MouseLeave += new System.EventHandler(this.regCheck_MouseLeave);
            this.regCheck.MouseHover += new System.EventHandler(this.regCheck_MouseHover);
            // 
            // midCheck
            // 
            this.midCheck.AutoSize = true;
            this.midCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.midCheck.FlatAppearance.BorderSize = 3;
            this.midCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.midCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.midCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midCheck.ForeColor = System.Drawing.Color.White;
            this.midCheck.Location = new System.Drawing.Point(15, 126);
            this.midCheck.Name = "midCheck";
            this.midCheck.Size = new System.Drawing.Size(99, 19);
            this.midCheck.TabIndex = 28;
            this.midCheck.Text = "Mid - Grade";
            this.midCheck.UseVisualStyleBackColor = true;
            this.midCheck.CheckStateChanged += new System.EventHandler(this.midCheck_CheckStateChanged);
            this.midCheck.MouseLeave += new System.EventHandler(this.midCheck_MouseLeave);
            this.midCheck.MouseHover += new System.EventHandler(this.midCheck_MouseHover);
            // 
            // premCheck
            // 
            this.premCheck.AutoSize = true;
            this.premCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.premCheck.FlatAppearance.BorderSize = 3;
            this.premCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.premCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.premCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premCheck.ForeColor = System.Drawing.Color.White;
            this.premCheck.Location = new System.Drawing.Point(15, 151);
            this.premCheck.Name = "premCheck";
            this.premCheck.Size = new System.Drawing.Size(81, 19);
            this.premCheck.TabIndex = 29;
            this.premCheck.Text = "Premium";
            this.premCheck.UseVisualStyleBackColor = true;
            this.premCheck.CheckStateChanged += new System.EventHandler(this.premCheck_CheckStateChanged);
            this.premCheck.MouseLeave += new System.EventHandler(this.premCheck_MouseLeave);
            this.premCheck.MouseHover += new System.EventHandler(this.premCheck_MouseHover);
            // 
            // miniCheck
            // 
            this.miniCheck.AutoSize = true;
            this.miniCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.miniCheck.FlatAppearance.BorderSize = 3;
            this.miniCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.miniCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniCheck.ForeColor = System.Drawing.Color.White;
            this.miniCheck.Location = new System.Drawing.Point(82, 266);
            this.miniCheck.Name = "miniCheck";
            this.miniCheck.Size = new System.Drawing.Size(79, 19);
            this.miniCheck.TabIndex = 30;
            this.miniCheck.Text = "Mini Van";
            this.miniCheck.UseVisualStyleBackColor = true;
            this.miniCheck.CheckStateChanged += new System.EventHandler(this.miniCheck_CheckStateChanged);
            // 
            // truckCheck
            // 
            this.truckCheck.AutoSize = true;
            this.truckCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.truckCheck.FlatAppearance.BorderSize = 3;
            this.truckCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.truckCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.truckCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truckCheck.ForeColor = System.Drawing.Color.White;
            this.truckCheck.Location = new System.Drawing.Point(181, 266);
            this.truckCheck.Name = "truckCheck";
            this.truckCheck.Size = new System.Drawing.Size(58, 19);
            this.truckCheck.TabIndex = 31;
            this.truckCheck.Text = "Truck";
            this.truckCheck.UseVisualStyleBackColor = true;
            this.truckCheck.CheckStateChanged += new System.EventHandler(this.truckCheck_CheckStateChanged);
            // 
            // carCheck
            // 
            this.carCheck.AutoSize = true;
            this.carCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.carCheck.FlatAppearance.BorderSize = 3;
            this.carCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.carCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carCheck.ForeColor = System.Drawing.Color.White;
            this.carCheck.Location = new System.Drawing.Point(12, 266);
            this.carCheck.Name = "carCheck";
            this.carCheck.Size = new System.Drawing.Size(45, 19);
            this.carCheck.TabIndex = 32;
            this.carCheck.Text = "Car";
            this.carCheck.UseVisualStyleBackColor = true;
            this.carCheck.CheckStateChanged += new System.EventHandler(this.carCheck_CheckStateChanged);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.option1.FlatAppearance.BorderSize = 3;
            this.option1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.ForeColor = System.Drawing.Color.White;
            this.option1.Location = new System.Drawing.Point(355, 101);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(323, 19);
            this.option1.TabIndex = 33;
            this.option1.Text = "Option 1: How full do you want your tank to be?";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.CheckStateChanged += new System.EventHandler(this.option1_CheckStateChanged);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.option2.FlatAppearance.BorderSize = 3;
            this.option2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.ForeColor = System.Drawing.Color.White;
            this.option2.Location = new System.Drawing.Point(355, 256);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(345, 19);
            this.option2.TabIndex = 34;
            this.option2.Text = "Option 2: How much money do you want to spend?";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.CheckStateChanged += new System.EventHandler(this.option2_CheckStateChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisIsVersion10BySamWyattAsTheSecondSummativeInICS3UToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.aboutToolStripMenuItem.Text = "About ";
            // 
            // thisIsVersion10BySamWyattAsTheSecondSummativeInICS3UToolStripMenuItem
            // 
            this.thisIsVersion10BySamWyattAsTheSecondSummativeInICS3UToolStripMenuItem.Name = "thisIsVersion10BySamWyattAsTheSecondSummativeInICS3UToolStripMenuItem";
            this.thisIsVersion10BySamWyattAsTheSecondSummativeInICS3UToolStripMenuItem.Size = new System.Drawing.Size(432, 22);
            this.thisIsVersion10BySamWyattAsTheSecondSummativeInICS3UToolStripMenuItem.Text = "This is version 1.1 by Sam Wyatt as the second summative in ICS3U. ";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(282, 410);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 23);
            this.printButton.TabIndex = 36;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // tenderBox
            // 
            this.tenderBox.BackColor = System.Drawing.Color.White;
            this.tenderBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tenderBox.Location = new System.Drawing.Point(490, 139);
            this.tenderBox.Name = "tenderBox";
            this.tenderBox.Size = new System.Drawing.Size(138, 20);
            this.tenderBox.TabIndex = 38;
            this.tenderBox.Text = "Tendered Amount";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(490, 165);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(138, 38);
            this.changeButton.TabIndex = 39;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // reqirements3
            // 
            this.reqirements3.AutoSize = true;
            this.reqirements3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqirements3.ForeColor = System.Drawing.Color.White;
            this.reqirements3.Location = new System.Drawing.Point(487, 291);
            this.reqirements3.Name = "reqirements3";
            this.reqirements3.Size = new System.Drawing.Size(198, 15);
            this.reqirements3.TabIndex = 44;
            this.reqirements3.Text = "Do not use symbols or spaces";
            // 
            // fullButton
            // 
            this.fullButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fullButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullButton.Location = new System.Drawing.Point(356, 317);
            this.fullButton.Name = "fullButton";
            this.fullButton.Size = new System.Drawing.Size(126, 44);
            this.fullButton.TabIndex = 45;
            this.fullButton.Text = "Calculate Fullness";
            this.fullButton.UseVisualStyleBackColor = false;
            this.fullButton.Click += new System.EventHandler(this.fullButton_Click);
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.BackColor = System.Drawing.Color.White;
            this.outputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel2.ForeColor = System.Drawing.Color.Navy;
            this.outputLabel2.Location = new System.Drawing.Point(492, 317);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(0, 13);
            this.outputLabel2.TabIndex = 46;
            // 
            // storeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(705, 445);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.fullButton);
            this.Controls.Add(this.reqirements3);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.carCheck);
            this.Controls.Add(this.truckCheck);
            this.Controls.Add(this.miniCheck);
            this.Controls.Add(this.premCheck);
            this.Controls.Add(this.midCheck);
            this.Controls.Add(this.regCheck);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.moneyRequest);
            this.Controls.Add(this.fuelAmount);
            this.Controls.Add(this.amountTitle);
            this.Controls.Add(this.fuelNeeded);
            this.Controls.Add(this.pathType);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.midBox);
            this.Controls.Add(this.premiumBox);
            this.Controls.Add(this.regularBox);
            this.Controls.Add(this.gasType);
            this.Controls.Add(this.title);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "storeInterface";
            this.Text = "The Corner Gas";
            this.Load += new System.EventHandler(this.storeInterface_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.storeInterface_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label gasType;
        private System.Windows.Forms.TextBox regularBox;
        private System.Windows.Forms.TextBox premiumBox;
        private System.Windows.Forms.TextBox midBox;
        private System.Windows.Forms.Label carType;
        private System.Windows.Forms.Label pathType;
        private System.Windows.Forms.TextBox fuelNeeded;
        private System.Windows.Forms.Label amountTitle;
        private System.Windows.Forms.TextBox fuelAmount;
        private System.Windows.Forms.TextBox moneyRequest;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.CheckBox regCheck;
        private System.Windows.Forms.CheckBox midCheck;
        private System.Windows.Forms.CheckBox premCheck;
        private System.Windows.Forms.CheckBox miniCheck;
        private System.Windows.Forms.CheckBox truckCheck;
        private System.Windows.Forms.CheckBox carCheck;
        private System.Windows.Forms.CheckBox option1;
        private System.Windows.Forms.CheckBox option2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisIsVersion10BySamWyattAsTheSecondSummativeInICS3UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox tenderBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label reqirements3;
        private System.Windows.Forms.Button fullButton;
        private System.Windows.Forms.Label outputLabel2;
    }
}

