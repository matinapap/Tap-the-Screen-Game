using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace froggame
{
    internal class Class1
    {
        Random rnd = new Random();

        List<PictureBox> coins = new List<PictureBox>();

        public Class1()
        {
            ;
        }

        public static void Clock(ref int time, ref System.Windows.Forms.Label label2, ref Timer t,ref int counter, Form fi, int level )
        {
            int min, sec_deci, sec_centi;

            if (time == 0)
            {
                t.Enabled = false;
                Form6 form6 = new Form6(counter, level);
                form6.Show();
                fi.Close();
            }

            time--;

            min = time / 60;
            sec_deci = (time % 60) / 10;
            sec_centi = (time % 60) % 10;

            label2.Text = min.ToString() + ":" + sec_deci.ToString() + sec_centi.ToString();
        }

        public void CreateCoin(Form3 fi)
        {
            for (int i = 0; i < 10; i++)
            {
                PictureBox coin = new PictureBox();
                coin.BackColor = Color.Transparent;
                coin.ImageLocation = "coin.png";
                coin.Size = new Size(50, 50);
                coin.Location = new Point(rnd.Next(30, 600), rnd.Next(30, 380));
                coin.SizeMode = PictureBoxSizeMode.StretchImage;
                coin.Click += fi.Coin_Click;
                fi.Controls.Add(coin);
                this.coins.Add(coin);
            }
        }

        public void RemoveCoin(Form3 fi, object sender)
        {
            PictureBox temCoin = sender as PictureBox;
            coins.Remove(temCoin);
            fi.Controls.Remove(temCoin);
        }

        public void RemoveAllCoins(Form3 fi)
        {
            foreach (PictureBox coin in coins.ToList())
            {
                coins.Remove(coin);
                fi.Controls.Remove(coin);
            }
        }


    }
}
