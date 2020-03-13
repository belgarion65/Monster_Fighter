namespace Monster_FIghter
{
    partial class Form1
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
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.textBoxPlayerHealth = new System.Windows.Forms.TextBox();
            this.textBoxPlayerScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxPlayerLive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDecreaseScore = new System.Windows.Forms.Button();
            this.buttonIncreaseScore = new System.Windows.Forms.Button();
            this.buttonDecreaseHealth = new System.Windows.Forms.Button();
            this.buttonIncreaseHealth = new System.Windows.Forms.Button();
            this.buttonDecreaseLives = new System.Windows.Forms.Button();
            this.buttonIncreaseLives = new System.Windows.Forms.Button();
            this.groupBoxCurrentWeapon = new System.Windows.Forms.GroupBox();
            this.buttonDropWeapon = new System.Windows.Forms.Button();
            this.buttonGenerateRandomWeapon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWeaponAttackPower = new System.Windows.Forms.TextBox();
            this.textBoxWeaponType = new System.Windows.Forms.TextBox();
            this.textBoxWeaponName = new System.Windows.Forms.TextBox();
            this.groupBoxCurrentArmour = new System.Windows.Forms.GroupBox();
            this.buttonDropArmour = new System.Windows.Forms.Button();
            this.textBoxArmourDefensePower = new System.Windows.Forms.TextBox();
            this.buttonGenerateRandomArmour = new System.Windows.Forms.Button();
            this.textBoxArmourType = new System.Windows.Forms.TextBox();
            this.textBoxArmourName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonPet = new System.Windows.Forms.Button();
            this.buttonDog = new System.Windows.Forms.Button();
            this.buttonCat = new System.Windows.Forms.Button();
            this.buttonDuck = new System.Windows.Forms.Button();
            this.buttonMonkey = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMonsterHealth = new System.Windows.Forms.TextBox();
            this.textBoxMonsterDefence = new System.Windows.Forms.TextBox();
            this.textBoxMonsterAttack = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxMonster = new System.Windows.Forms.PictureBox();
            this.textBoxMonsterNameAndType = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxCurrentWeapon.SuspendLayout();
            this.groupBoxCurrentArmour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.AccessibleName = "";
            this.textBoxPlayerName.Location = new System.Drawing.Point(56, 12);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerName.TabIndex = 3;
            this.textBoxPlayerName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxPlayerHealth
            // 
            this.textBoxPlayerHealth.AccessibleName = "";
            this.textBoxPlayerHealth.Location = new System.Drawing.Point(56, 38);
            this.textBoxPlayerHealth.Name = "textBoxPlayerHealth";
            this.textBoxPlayerHealth.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerHealth.TabIndex = 4;
            // 
            // textBoxPlayerScore
            // 
            this.textBoxPlayerScore.AccessibleName = "";
            this.textBoxPlayerScore.Location = new System.Drawing.Point(56, 64);
            this.textBoxPlayerScore.Name = "textBoxPlayerScore";
            this.textBoxPlayerScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerScore.TabIndex = 5;
            this.textBoxPlayerScore.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Health";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Score";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(17, 126);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(88, 38);
            this.buttonPrevious.TabIndex = 11;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(145, 126);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(88, 38);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxPlayerLive
            // 
            this.textBoxPlayerLive.Location = new System.Drawing.Point(56, 90);
            this.textBoxPlayerLive.Name = "textBoxPlayerLive";
            this.textBoxPlayerLive.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerLive.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lives";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonDecreaseScore
            // 
            this.buttonDecreaseScore.Location = new System.Drawing.Point(295, 65);
            this.buttonDecreaseScore.Name = "buttonDecreaseScore";
            this.buttonDecreaseScore.Size = new System.Drawing.Size(106, 23);
            this.buttonDecreaseScore.TabIndex = 15;
            this.buttonDecreaseScore.Text = "Decrease Score";
            this.buttonDecreaseScore.UseVisualStyleBackColor = true;
            this.buttonDecreaseScore.Click += new System.EventHandler(this.buttonDecreaseScore_Click);
            // 
            // buttonIncreaseScore
            // 
            this.buttonIncreaseScore.Location = new System.Drawing.Point(187, 64);
            this.buttonIncreaseScore.Name = "buttonIncreaseScore";
            this.buttonIncreaseScore.Size = new System.Drawing.Size(102, 23);
            this.buttonIncreaseScore.TabIndex = 16;
            this.buttonIncreaseScore.Text = "Increase Score";
            this.buttonIncreaseScore.UseVisualStyleBackColor = true;
            this.buttonIncreaseScore.Click += new System.EventHandler(this.buttonIncreaseScore_Click);
            // 
            // buttonDecreaseHealth
            // 
            this.buttonDecreaseHealth.Location = new System.Drawing.Point(295, 38);
            this.buttonDecreaseHealth.Name = "buttonDecreaseHealth";
            this.buttonDecreaseHealth.Size = new System.Drawing.Size(106, 23);
            this.buttonDecreaseHealth.TabIndex = 17;
            this.buttonDecreaseHealth.Text = "Decrease Health";
            this.buttonDecreaseHealth.UseVisualStyleBackColor = true;
            this.buttonDecreaseHealth.Click += new System.EventHandler(this.buttonDecreaseHealth_Click);
            // 
            // buttonIncreaseHealth
            // 
            this.buttonIncreaseHealth.Location = new System.Drawing.Point(187, 38);
            this.buttonIncreaseHealth.Name = "buttonIncreaseHealth";
            this.buttonIncreaseHealth.Size = new System.Drawing.Size(102, 23);
            this.buttonIncreaseHealth.TabIndex = 18;
            this.buttonIncreaseHealth.Text = "Increase Health";
            this.buttonIncreaseHealth.UseVisualStyleBackColor = true;
            this.buttonIncreaseHealth.Click += new System.EventHandler(this.buttonIncreaseHealth_Click);
            // 
            // buttonDecreaseLives
            // 
            this.buttonDecreaseLives.Location = new System.Drawing.Point(295, 90);
            this.buttonDecreaseLives.Name = "buttonDecreaseLives";
            this.buttonDecreaseLives.Size = new System.Drawing.Size(106, 23);
            this.buttonDecreaseLives.TabIndex = 19;
            this.buttonDecreaseLives.Text = "Decrease Lives";
            this.buttonDecreaseLives.UseVisualStyleBackColor = true;
            this.buttonDecreaseLives.Click += new System.EventHandler(this.buttonDecreaseLives_Click);
            // 
            // buttonIncreaseLives
            // 
            this.buttonIncreaseLives.Location = new System.Drawing.Point(187, 90);
            this.buttonIncreaseLives.Name = "buttonIncreaseLives";
            this.buttonIncreaseLives.Size = new System.Drawing.Size(102, 23);
            this.buttonIncreaseLives.TabIndex = 20;
            this.buttonIncreaseLives.Text = "Increase Lives";
            this.buttonIncreaseLives.UseVisualStyleBackColor = true;
            this.buttonIncreaseLives.Click += new System.EventHandler(this.buttonIncreaseLives_Click);
            // 
            // groupBoxCurrentWeapon
            // 
            this.groupBoxCurrentWeapon.Controls.Add(this.buttonDropWeapon);
            this.groupBoxCurrentWeapon.Controls.Add(this.buttonGenerateRandomWeapon);
            this.groupBoxCurrentWeapon.Controls.Add(this.label7);
            this.groupBoxCurrentWeapon.Controls.Add(this.label6);
            this.groupBoxCurrentWeapon.Controls.Add(this.label2);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponAttackPower);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponType);
            this.groupBoxCurrentWeapon.Controls.Add(this.textBoxWeaponName);
            this.groupBoxCurrentWeapon.Location = new System.Drawing.Point(17, 214);
            this.groupBoxCurrentWeapon.Name = "groupBoxCurrentWeapon";
            this.groupBoxCurrentWeapon.Size = new System.Drawing.Size(282, 197);
            this.groupBoxCurrentWeapon.TabIndex = 21;
            this.groupBoxCurrentWeapon.TabStop = false;
            this.groupBoxCurrentWeapon.Text = "Current Weapon";
            // 
            // buttonDropWeapon
            // 
            this.buttonDropWeapon.Location = new System.Drawing.Point(128, 139);
            this.buttonDropWeapon.Name = "buttonDropWeapon";
            this.buttonDropWeapon.Size = new System.Drawing.Size(111, 38);
            this.buttonDropWeapon.TabIndex = 7;
            this.buttonDropWeapon.Text = "Drop Weapon";
            this.buttonDropWeapon.UseVisualStyleBackColor = true;
            this.buttonDropWeapon.Click += new System.EventHandler(this.buttonDropWeapon_Click);
            // 
            // buttonGenerateRandomWeapon
            // 
            this.buttonGenerateRandomWeapon.Location = new System.Drawing.Point(10, 139);
            this.buttonGenerateRandomWeapon.Name = "buttonGenerateRandomWeapon";
            this.buttonGenerateRandomWeapon.Size = new System.Drawing.Size(111, 38);
            this.buttonGenerateRandomWeapon.TabIndex = 6;
            this.buttonGenerateRandomWeapon.Text = "Generate Random Weapon";
            this.buttonGenerateRandomWeapon.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomWeapon.Click += new System.EventHandler(this.buttonGenerateRandomWeapon_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Attack Power";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // textBoxWeaponAttackPower
            // 
            this.textBoxWeaponAttackPower.Location = new System.Drawing.Point(101, 94);
            this.textBoxWeaponAttackPower.Name = "textBoxWeaponAttackPower";
            this.textBoxWeaponAttackPower.Size = new System.Drawing.Size(138, 20);
            this.textBoxWeaponAttackPower.TabIndex = 2;
            // 
            // textBoxWeaponType
            // 
            this.textBoxWeaponType.Location = new System.Drawing.Point(101, 65);
            this.textBoxWeaponType.Name = "textBoxWeaponType";
            this.textBoxWeaponType.Size = new System.Drawing.Size(138, 20);
            this.textBoxWeaponType.TabIndex = 1;
            // 
            // textBoxWeaponName
            // 
            this.textBoxWeaponName.Location = new System.Drawing.Point(101, 39);
            this.textBoxWeaponName.Name = "textBoxWeaponName";
            this.textBoxWeaponName.Size = new System.Drawing.Size(138, 20);
            this.textBoxWeaponName.TabIndex = 0;
            // 
            // groupBoxCurrentArmour
            // 
            this.groupBoxCurrentArmour.Controls.Add(this.buttonDropArmour);
            this.groupBoxCurrentArmour.Controls.Add(this.textBoxArmourDefensePower);
            this.groupBoxCurrentArmour.Controls.Add(this.buttonGenerateRandomArmour);
            this.groupBoxCurrentArmour.Controls.Add(this.textBoxArmourType);
            this.groupBoxCurrentArmour.Controls.Add(this.textBoxArmourName);
            this.groupBoxCurrentArmour.Controls.Add(this.label);
            this.groupBoxCurrentArmour.Controls.Add(this.label23);
            this.groupBoxCurrentArmour.Controls.Add(this.label12);
            this.groupBoxCurrentArmour.Location = new System.Drawing.Point(17, 430);
            this.groupBoxCurrentArmour.Name = "groupBoxCurrentArmour";
            this.groupBoxCurrentArmour.Size = new System.Drawing.Size(278, 178);
            this.groupBoxCurrentArmour.TabIndex = 22;
            this.groupBoxCurrentArmour.TabStop = false;
            this.groupBoxCurrentArmour.Text = "Current Armour";
            // 
            // buttonDropArmour
            // 
            this.buttonDropArmour.Location = new System.Drawing.Point(124, 136);
            this.buttonDropArmour.Name = "buttonDropArmour";
            this.buttonDropArmour.Size = new System.Drawing.Size(111, 36);
            this.buttonDropArmour.TabIndex = 24;
            this.buttonDropArmour.Text = "Drop Armour";
            this.buttonDropArmour.UseVisualStyleBackColor = true;
            this.buttonDropArmour.Click += new System.EventHandler(this.buttonDropArmour_Click);
            // 
            // textBoxArmourDefensePower
            // 
            this.textBoxArmourDefensePower.Location = new System.Drawing.Point(97, 100);
            this.textBoxArmourDefensePower.Name = "textBoxArmourDefensePower";
            this.textBoxArmourDefensePower.Size = new System.Drawing.Size(138, 20);
            this.textBoxArmourDefensePower.TabIndex = 24;
            // 
            // buttonGenerateRandomArmour
            // 
            this.buttonGenerateRandomArmour.Location = new System.Drawing.Point(6, 136);
            this.buttonGenerateRandomArmour.Name = "buttonGenerateRandomArmour";
            this.buttonGenerateRandomArmour.Size = new System.Drawing.Size(111, 36);
            this.buttonGenerateRandomArmour.TabIndex = 23;
            this.buttonGenerateRandomArmour.Text = "Generate Random Armour";
            this.buttonGenerateRandomArmour.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomArmour.Click += new System.EventHandler(this.buttonGenerateRandomArmour_Click_1);
            // 
            // textBoxArmourType
            // 
            this.textBoxArmourType.Location = new System.Drawing.Point(97, 71);
            this.textBoxArmourType.Name = "textBoxArmourType";
            this.textBoxArmourType.Size = new System.Drawing.Size(138, 20);
            this.textBoxArmourType.TabIndex = 25;
            // 
            // textBoxArmourName
            // 
            this.textBoxArmourName.Location = new System.Drawing.Point(97, 40);
            this.textBoxArmourName.Name = "textBoxArmourName";
            this.textBoxArmourName.Size = new System.Drawing.Size(138, 20);
            this.textBoxArmourName.TabIndex = 25;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(2, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 23;
            this.label.Text = "Name:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(2, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Defence Power:";
            // 
            // buttonPet
            // 
            this.buttonPet.Location = new System.Drawing.Point(17, 629);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(104, 69);
            this.buttonPet.TabIndex = 23;
            this.buttonPet.Text = "Pet";
            this.buttonPet.UseVisualStyleBackColor = true;
            this.buttonPet.Click += new System.EventHandler(this.buttonPet_Click);
            // 
            // buttonDog
            // 
            this.buttonDog.Location = new System.Drawing.Point(129, 629);
            this.buttonDog.Name = "buttonDog";
            this.buttonDog.Size = new System.Drawing.Size(104, 69);
            this.buttonDog.TabIndex = 24;
            this.buttonDog.Text = "Dog";
            this.buttonDog.UseVisualStyleBackColor = true;
            this.buttonDog.Click += new System.EventHandler(this.buttonDog_Click);
            // 
            // buttonCat
            // 
            this.buttonCat.Location = new System.Drawing.Point(239, 629);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(104, 69);
            this.buttonCat.TabIndex = 25;
            this.buttonCat.Text = "Cat";
            this.buttonCat.UseVisualStyleBackColor = true;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // buttonDuck
            // 
            this.buttonDuck.Location = new System.Drawing.Point(349, 629);
            this.buttonDuck.Name = "buttonDuck";
            this.buttonDuck.Size = new System.Drawing.Size(104, 69);
            this.buttonDuck.TabIndex = 26;
            this.buttonDuck.Text = "Duck";
            this.buttonDuck.UseVisualStyleBackColor = true;
            this.buttonDuck.Click += new System.EventHandler(this.buttonDuck_Click);
            // 
            // buttonMonkey
            // 
            this.buttonMonkey.Location = new System.Drawing.Point(459, 629);
            this.buttonMonkey.Name = "buttonMonkey";
            this.buttonMonkey.Size = new System.Drawing.Size(104, 69);
            this.buttonMonkey.TabIndex = 27;
            this.buttonMonkey.Text = "Monkey";
            this.buttonMonkey.UseVisualStyleBackColor = true;
            this.buttonMonkey.Click += new System.EventHandler(this.buttonMonkey_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(640, 629);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(179, 69);
            this.buttonAttack.TabIndex = 28;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(859, 629);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(179, 69);
            this.buttonRun.TabIndex = 29;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.Location = new System.Drawing.Point(634, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 31);
            this.label10.TabIndex = 35;
            this.label10.Text = "Health:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBoxMonsterHealth
            // 
            this.textBoxMonsterHealth.Location = new System.Drawing.Point(859, 498);
            this.textBoxMonsterHealth.Multiline = true;
            this.textBoxMonsterHealth.Name = "textBoxMonsterHealth";
            this.textBoxMonsterHealth.Size = new System.Drawing.Size(179, 28);
            this.textBoxMonsterHealth.TabIndex = 36;
            // 
            // textBoxMonsterDefence
            // 
            this.textBoxMonsterDefence.Location = new System.Drawing.Point(859, 584);
            this.textBoxMonsterDefence.Multiline = true;
            this.textBoxMonsterDefence.Name = "textBoxMonsterDefence";
            this.textBoxMonsterDefence.Size = new System.Drawing.Size(179, 28);
            this.textBoxMonsterDefence.TabIndex = 37;
            // 
            // textBoxMonsterAttack
            // 
            this.textBoxMonsterAttack.Location = new System.Drawing.Point(859, 545);
            this.textBoxMonsterAttack.Multiline = true;
            this.textBoxMonsterAttack.Name = "textBoxMonsterAttack";
            this.textBoxMonsterAttack.Size = new System.Drawing.Size(179, 28);
            this.textBoxMonsterAttack.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label11.Location = new System.Drawing.Point(636, 542);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 31);
            this.label11.TabIndex = 39;
            this.label11.Text = "Attack:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(636, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 31);
            this.label8.TabIndex = 40;
            this.label8.Text = "Defence:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBoxMonster
            // 
            this.pictureBoxMonster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMonster.Location = new System.Drawing.Point(640, 19);
            this.pictureBoxMonster.Name = "pictureBoxMonster";
            this.pictureBoxMonster.Size = new System.Drawing.Size(398, 398);
            this.pictureBoxMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonster.TabIndex = 41;
            this.pictureBoxMonster.TabStop = false;
            // 
            // textBoxMonsterNameAndType
            // 
            this.textBoxMonsterNameAndType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxMonsterNameAndType.Location = new System.Drawing.Point(640, 430);
            this.textBoxMonsterNameAndType.Multiline = true;
            this.textBoxMonsterNameAndType.Name = "textBoxMonsterNameAndType";
            this.textBoxMonsterNameAndType.Size = new System.Drawing.Size(398, 41);
            this.textBoxMonsterNameAndType.TabIndex = 42;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(1086, 19);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(119, 65);
            this.buttonHelp.TabIndex = 43;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1217, 797);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxMonsterNameAndType);
            this.Controls.Add(this.pictureBoxMonster);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxMonsterAttack);
            this.Controls.Add(this.textBoxMonsterDefence);
            this.Controls.Add(this.textBoxMonsterHealth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.buttonMonkey);
            this.Controls.Add(this.buttonDuck);
            this.Controls.Add(this.buttonCat);
            this.Controls.Add(this.buttonDog);
            this.Controls.Add(this.buttonPet);
            this.Controls.Add(this.groupBoxCurrentArmour);
            this.Controls.Add(this.groupBoxCurrentWeapon);
            this.Controls.Add(this.buttonIncreaseLives);
            this.Controls.Add(this.buttonDecreaseLives);
            this.Controls.Add(this.buttonIncreaseHealth);
            this.Controls.Add(this.buttonDecreaseHealth);
            this.Controls.Add(this.buttonIncreaseScore);
            this.Controls.Add(this.buttonDecreaseScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlayerLive);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPlayerScore);
            this.Controls.Add(this.textBoxPlayerHealth);
            this.Controls.Add(this.textBoxPlayerName);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBoxCurrentWeapon.ResumeLayout(false);
            this.groupBoxCurrentWeapon.PerformLayout();
            this.groupBoxCurrentArmour.ResumeLayout(false);
            this.groupBoxCurrentArmour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.TextBox textBoxPlayerHealth;
        private System.Windows.Forms.TextBox textBoxPlayerScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxPlayerLive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDecreaseScore;
        private System.Windows.Forms.Button buttonIncreaseScore;
        private System.Windows.Forms.Button buttonDecreaseHealth;
        private System.Windows.Forms.Button buttonIncreaseHealth;
        private System.Windows.Forms.Button buttonDecreaseLives;
        private System.Windows.Forms.Button buttonIncreaseLives;
        private System.Windows.Forms.GroupBox groupBoxCurrentWeapon;
        private System.Windows.Forms.Button buttonDropWeapon;
        private System.Windows.Forms.Button buttonGenerateRandomWeapon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWeaponAttackPower;
        private System.Windows.Forms.TextBox textBoxWeaponType;
        private System.Windows.Forms.TextBox textBoxWeaponName;
        private System.Windows.Forms.GroupBox groupBoxCurrentArmour;
        private System.Windows.Forms.TextBox textBoxArmourDefensePower;
        private System.Windows.Forms.TextBox textBoxArmourType;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDropArmour;
        private System.Windows.Forms.Button buttonGenerateRandomArmour;
        private System.Windows.Forms.TextBox textBoxArmourName;
        private System.Windows.Forms.Button buttonPet;
        private System.Windows.Forms.Button buttonDog;
        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.Button buttonDuck;
        private System.Windows.Forms.Button buttonMonkey;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMonsterHealth;
        private System.Windows.Forms.TextBox textBoxMonsterDefence;
        private System.Windows.Forms.TextBox textBoxMonsterAttack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxMonster;
        private System.Windows.Forms.TextBox textBoxMonsterNameAndType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonHelp;
    }
}

