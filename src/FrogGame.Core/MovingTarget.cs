using System;
using System.Drawing;

namespace FrogGame.Core
{
    /// <summary>
    /// A clickable character that travels in a straight line and bounces off the edges of the play area.
    /// </summary>
    public sealed class MovingTarget
    {
        private readonly Rectangle playArea;
        private readonly Size size;

        private int x;
        private int y;
        private int stepX;
        private int stepY;
        private double radians;

        /// <param name="points">Score awarded each time the target is hit.</param>
        /// <param name="speed">Pixels moved per call to <see cref="Move"/>.</param>
        /// <param name="start">Top-left starting position.</param>
        /// <param name="angleDegrees">Initial direction of travel.</param>
        /// <param name="playArea">Region the target must stay inside.</param>
        /// <param name="size">Size of the target, used for collision with the right and bottom edges.</param>
        public MovingTarget(int points, int speed, Point start, int angleDegrees, Rectangle playArea, Size size)
        {
            Points = points;
            this.playArea = playArea;
            this.size = size;
            stepX = speed;
            stepY = speed;
            x = start.X;
            y = start.Y;
            SetDirection(angleDegrees);
        }

        public int Points { get; }

        public Point Position => new Point(x, y);

        /// <summary>
        /// Advances one step and returns the new position, reversing direction on any edge it touches.
        /// </summary>
        public Point Move()
        {
            x += (int)(stepX * Math.Cos(radians));
            if (x < playArea.Left || x + size.Width > playArea.Right)
            {
                stepX = -stepX;
                x = Clamp(x, playArea.Left, playArea.Right - size.Width);
            }

            y += (int)(stepY * Math.Sin(radians));
            if (y < playArea.Top || y + size.Height > playArea.Bottom)
            {
                stepY = -stepY;
                y = Clamp(y, playArea.Top, playArea.Bottom - size.Height);
            }

            return Position;
        }

        /// <summary>
        /// Sends the target off in a new direction and returns the points earned for the hit.
        /// </summary>
        public int Hit(int newAngleDegrees)
        {
            SetDirection(newAngleDegrees);
            return Points;
        }

        private void SetDirection(int angleDegrees)
        {
            radians = angleDegrees * Math.PI / 180;
        }

        private static int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
