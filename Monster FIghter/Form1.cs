using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_FIghter
{
    public partial class Form1 : Form
    {
        List<Player> players = new List<Player>();
        List<Monster> monsters = new List<Monster>();
        List<Weapon> weapons = new List<Weapon>();
        List<Armour> armour = new List<Armour>();

        int playerDisplayed = 0;
        int currentMonster;
        int reset;
        private void GenerateRandomMonsterNumber()
        {
            Random rnd = new Random();
            currentMonster = rnd.Next(0, monsters.Count());
        }

        private void DisplayCurrentMonster()
        {
            Image monsterImage = Image.FromFile("MonsterImages\\" + monsters[currentMonster].Name + ".jpg");
            pictureBoxMonster.Image = monsterImage;

            textBoxMonsterNameAndType.Text = monsters[currentMonster].Name + " the " + monsters[currentMonster].Type;
            textBoxMonsterHealth.Text = Convert.ToString(monsters[currentMonster].Health);
            textBoxMonsterAttack.Text = Convert.ToString(monsters[currentMonster].Attack);
            textBoxMonsterDefence.Text = Convert.ToString(monsters[currentMonster].Defence);
        }
        private void DisplayData()
        {
            textBoxPlayerName.Text = players[playerDisplayed].Name;
            textBoxPlayerScore.Text = players[playerDisplayed].Score.ToString();
            textBoxPlayerHealth.Text = players[playerDisplayed].Health.ToString();
            textBoxPlayerLive.Text = players[playerDisplayed].Lives.ToString();

            if (players[playerDisplayed].Weapon == null)
            {
                textBoxWeaponName.Text = "None";
                textBoxWeaponType.Text = "N/A";
                textBoxWeaponAttackPower.Text = "N/A";
            }
            else
            {
                textBoxWeaponName.Text = players[playerDisplayed].Weapon.Name;
                textBoxWeaponType.Text = players[playerDisplayed].Weapon.Type;
                textBoxWeaponAttackPower.Text = players[playerDisplayed].Weapon.AttackPower.ToString();
            }

            if (players[playerDisplayed].Armour == null)
            {
                textBoxArmourName.Text = "None";
                textBoxArmourType.Text = "N/A";
                textBoxArmourDefensePower.Text = "N/A";
            }
            else
            {
                textBoxArmourName.Text = players[playerDisplayed].Armour.Name;
                textBoxArmourType.Text = players[playerDisplayed].Armour.Type;
                textBoxArmourDefensePower.Text = players[playerDisplayed].Armour.DefencePower.ToString();
            }



        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlayerTwoName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            players.Add(new Player("Parzival", 0, 100, 3));
            players.Add(new Player("Art3mis", 0, 100, 5));
            players.Add(new Player("Aech", 0, 100, 4));
            players.Add(new Player("Adrian", 0, 100, 5));
            players.Add(new Player("Razvan", 0, 10, 3));

            monsters.Add(new Monster("Beast", "Bear", 8000, 5000, 10000));
            monsters.Add(new Monster("Draconid", "Basilisk", 5000, 3000, 12000));
            monsters.Add(new Monster("Elemental", "Gargoyle", 1000, 2000, 90000));
            monsters.Add(new Monster("Hybrid", "Griffin", 4000, 5500, 7000));
            monsters.Add(new Monster("Insectoid", "Arachas", 8000, 6000, 8000));
            monsters.Add(new Monster("Necrophage", "Alghoul", 8500, 2500, 10000));
            monsters.Add(new Monster("Ogroid", "Nekker", 4600, 1500, 5000));
            monsters.Add(new Monster("Relict", "Chort", 10000, 5000, 15000));
            monsters.Add(new Monster("Specter", "Hym", 40000, 5000, 40000));
            monsters.Add(new Monster("Vampire", "Alp", 20000, 1200, 2000));
            monsters.Add(new Monster("Specter", "Banshee", 7000, 1100, 22000));


            weapons.Add(new Weapon("Wand", "Twig", 3));
            weapons.Add(new Weapon("Wand", "Cosmic Wand", 12));
            weapons.Add(new Weapon("Wand", "Gandalf's Staff", 18));
            weapons.Add(new Weapon("Dagger", "Butter Knife", 5));
            weapons.Add(new Weapon("Dagger", "Hidden Blades", 11));
            weapons.Add(new Weapon("Dagger", "Cthulhu Sacrificial Dagger", 16));
            weapons.Add(new Weapon("Axe", "Wooden Axe", 6));
            weapons.Add(new Weapon("Axe", "Stormbreaker", 10));
            weapons.Add(new Weapon("Axe", "BOI", 20));
            weapons.Add(new Weapon("Sword", "Golden Sword", 4));
            weapons.Add(new Weapon("Sword", "Excalibur", 9));
            weapons.Add(new Weapon("Sword", "Deus Vult", 30));

            armour.Add(new Armour("Helmet", "Pot", 5));
            armour.Add(new Armour("Helmet", "Chozo Helmet", 15));
            armour.Add(new Armour("Shield", "Plate", 3));
            armour.Add(new Armour("Shield", "Pantheon's Shield", 25));
            armour.Add(new Armour("Shield", "Vibranium Shield", 35));



            DisplayData();
            GenerateRandomMonsterNumber();
            DisplayCurrentMonster();

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            playerDisplayed++;

            if (playerDisplayed == players.Count())
            {
                playerDisplayed = 0;
            }

            DisplayData();

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            playerDisplayed--;
            if (playerDisplayed == -1)
            {
                playerDisplayed = players.Count() - 1;
            }

            DisplayData();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonIncreaseScore_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeScore = 100;

            DisplayData();

        }

        private void buttonDecreaseScore_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeScore = -100;

            DisplayData();

        }

        private void buttonIncreaseHealth_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeHealth = 25;

            DisplayData();
        }

        private void buttonDecreaseHealth_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeHealth = -25;

            DisplayData();
        }

        private void buttonDecreaseLives_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeLives = -1;

            DisplayData();

        }

        private void buttonIncreaseLives_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeLives = 1;

            DisplayData();

        }

        private void buttonGenerateRandomWeapon_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomWeaponNumber = rnd.Next(0, weapons.Count());

            DialogResult result = MessageBox.Show(weapons[randomWeaponNumber].Type + " found!" +
                Environment.NewLine + "\nIt's called " + weapons[randomWeaponNumber].Name +
                Environment.NewLine + "\nAttack Power " + weapons[randomWeaponNumber].AttackPower.ToString() + "!" +
                Environment.NewLine + "\nWould you like to Equip it?", "Weapon Found", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                players[playerDisplayed].Weapon = weapons[randomWeaponNumber];
            }

            DisplayData();
        }


        private void buttonDropWeapon_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].Weapon = null;
            DisplayData();
        }


        private void buttonGenerateRandomArmour_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomArmourNumber = rnd.Next(0, armour.Count());

            DialogResult result = MessageBox.Show(armour[randomArmourNumber].Type + " found!" +
                Environment.NewLine + "\nIt's called " + armour[randomArmourNumber].Name +
                Environment.NewLine + "\nDefense Power " + armour[randomArmourNumber].DefencePower.ToString() + "!" +
                Environment.NewLine + "\nWould you like to Equip it?", "Armour Found", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                players[playerDisplayed].Armour = armour[randomArmourNumber];
            }

            DisplayData();

        }

        private void buttonDropArmour_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].Armour = null;
            DisplayData();
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            Pet myPet = new Pet("Bob", "Generic");

            MessageBox.Show(myPet.MakeNoise() +
                " I am a " + myPet.Breed +
                " Pet and my name is " + myPet.Name);
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            Dog myPet = new Dog("Doge", "Shiba Inu");

            MessageBox.Show(myPet.MakeNoise() +
                " I am a " + myPet.Breed +
                " Dog and my name is " + myPet.Name);

        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Cat myPet = new Cat("Yuumi", "Rat");

            MessageBox.Show(myPet.MakeNoise() +
                " I am a " + myPet.Breed +
                " Cat and my name is " + myPet.Name);
        }

        private void buttonDuck_Click(object sender, EventArgs e)
        {
            Duck myPet = new Duck("Howard", "Mallard");

            MessageBox.Show(myPet.MakeNoise() +
                " I am a " + myPet.Breed +
                " Duck and my name is " + myPet.Name);

        }

        private void buttonMonkey_Click(object sender, EventArgs e)
        {
            Monkey myPet = new Monkey("Yassuo", "Silver");

            MessageBox.Show(myPet.MakeNoise() +
                "! I am a " + myPet.Breed +
                " Monkey and my name is " + myPet.Name + " and I will ruin your game");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            int hitPower = 100;

            if (players[playerDisplayed].Weapon != null)
            {
                hitPower = 100 * players[playerDisplayed].Weapon.AttackPower;

            }

            Random rnd = new Random();
            int grabChance = rnd.Next(0, 4);

            if (grabChance == 3)
            {

                int healthLost = monsters[currentMonster].Attack / 40;

                if (players[playerDisplayed].Armour != null)
                {
                    healthLost = healthLost / players[playerDisplayed].Armour.DefencePower;
                }

                if (players[playerDisplayed].Health - healthLost <= 0)
                {
                    players[playerDisplayed].Health = 0;
                }
                else
                {
                    players[playerDisplayed].Health = players[playerDisplayed].Health - healthLost;
                }
            }


            reset = monsters[currentMonster].Health;
            monsters[currentMonster].Health = monsters[currentMonster].Health - hitPower;

            players[playerDisplayed].ChangeScore = hitPower;
            if (players[playerDisplayed].Health != 0)
            {
            }

            else
            {
                MessageBox.Show("GAME OVER" + Environment.NewLine + Environment.NewLine +
                    "GIT GUD");
                this.Close();
            }

            if (monsters[currentMonster].Health <= 0)
            {
                MessageBox.Show("Congratulations! You have killed " + monsters[currentMonster].Name);
                MessageBox.Show("Get Ready for the next Monster!");

                monsters[currentMonster].Health = reset;
                GenerateRandomMonsterNumber();

            }
            DisplayCurrentMonster();

            DisplayData();


        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int grabChance = rnd.Next(0, 3);

            if (grabChance == 2)
            {
                int healthLost = monsters[currentMonster].Attack / 30;

                if (players[playerDisplayed].Armour != null)
                {
                    healthLost = healthLost / players[playerDisplayed].Armour.DefencePower;
                }

                if (players[playerDisplayed].Health - healthLost <= 0)
                {
                    players[playerDisplayed].Health = 0;
                }
                else
                {
                    players[playerDisplayed].Health = players[playerDisplayed].Health - healthLost;
                }
                

                DisplayData();

                MessageBox.Show("As you were running away, the " + monsters[currentMonster].Name +
                    " grabbed you! And you have lost " + healthLost + " health ");

            }

            if (players[playerDisplayed].Health != 0)
            {
                GenerateRandomMonsterNumber();
                DisplayCurrentMonster();
            }

            else
            {
                MessageBox.Show("GAME OVER" + Environment.NewLine + Environment.NewLine +
                    "GIT GUD");
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Form2 helpForm = new Form2();
            helpForm.Show();
        }
    }
}
