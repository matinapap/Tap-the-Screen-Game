using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace froggame
{
    public class Interactive
    {
        System.Windows.Forms.PictureBox box;

        int score;

        int posX;
        int posY;
        int moveStepX;
        int moveStepY;

        int angle;
        double radian;

        //constructor
        public Interactive(System.Windows.Forms.PictureBox pb, int sc, int ms, int x, int y, int a)
        {
            box = pb;
            score = sc;
            moveStepX = ms;
            moveStepY = ms;
            posX = x;
            posY = y;
            angle = a;
            radian = (angle * Math.PI) / 180;

        }

        public Interactive()
        {
            ;
        }

        public Point Movement()
        {

            posX += (int)(moveStepX * Math.Cos(radian));
            if (posX < 0 || posX + 80 > 690)
            {
                moveStepX = -moveStepX;
            }

            posY += (int)(moveStepY * Math.Sin(radian));
            if (posY < 30 || posY + 130 > 460)
            {
                moveStepY = -moveStepY;
            }

            return new Point(posX, posY);

        }

        public int Click(int a)
        {
            angle = a;
            radian = (a * Math.PI) / 180;
            return score;
        }


    }
}
