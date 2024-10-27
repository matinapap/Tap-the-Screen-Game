using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace froggame
{
    public partial class Form3 : Form
    {

        Random rnd = new Random();
        Class1 piggyBank = new Class1();

        int counter;
        int time = 120;
        int removeTime = 0;

        int speed, speed2;

        string wand;
        int level;

        Interactive Frog;
        Interactive Duck;

        public Form3()
        {
            InitializeComponent();

            int min, sec_deci, sec_centi;
            min = time / 60;
            sec_deci = (time % 60) / 10;
            sec_centi = (time % 60) % 10;

            label2.Text = min.ToString() + ":" + sec_deci.ToString() + sec_centi.ToString();

            timer3.Enabled = true;

        }

        public Form3(int l) : this()
        {
            level = l;

            counter = 0;

            label3.Text += level;

            switch (level)
            {
                case 1:
                    wand = "wand1.png";
                    this.BackgroundImage = froggame.Properties.Resources.water;
                    speed = 5;
                    speed = 5;
                    break;

                case 2:
                    wand = "wand2.png";
                    this.BackgroundImage = froggame.Properties.Resources.lake;
                    speed = 8;
                    speed = 8;
                    break;

                case 3:
                    wand = "wand3.png";
                    speed = 11 - 5;
                    speed = 11 - 5;
                    speed2 = 15 - 5;
                    speed2 = 15 - 5;
                    pictureBox2.Visible = true;
                    break;
            }

            Frog = new Interactive(pictureBox1, 100, speed, rnd.Next(80, 300), rnd.Next(100, 300), rnd.Next(360));
            Duck = new Interactive(pictureBox2, 200, speed2, rnd.Next(300, 600) / 2 + 30, rnd.Next(400, 450) / 2 + 100, rnd.Next(360));
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            label1.Text = "Score: " + counter.ToString();

            Bitmap btm = new Bitmap(new Bitmap(wand), 80, 130); 
            this.Cursor = new Cursor(btm.GetHicon());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = Frog.Movement();
            pictureBox2.Location = Duck.Movement();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (level > 1) counter += Frog.Click(rnd.Next(360));
            else counter += 100;
            label1.Text = "Score: " + counter.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            counter += Duck.Click(rnd.Next(360));
            label1.Text = "Score: " + counter.ToString();
        }

        public void Coin_Click(object sender, EventArgs e)
        {
            counter += 50;
            label1.Text = "Score: " + counter.ToString();
            piggyBank.RemoveCoin(this, sender);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            Class1.Clock(ref time, ref label2, ref timer3, ref counter, this, level);

            removeTime -= 1;
            if (time % 30 == 0 && time != 0)
            {
                piggyBank.CreateCoin(this);
                removeTime = 10;
            }
            if (removeTime == 0)
            {
                piggyBank.RemoveAllCoins(this);
            }
        }
    }
}
