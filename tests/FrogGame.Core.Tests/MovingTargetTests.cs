using System.Drawing;
using FrogGame.Core;
using Xunit;

namespace FrogGame.Core.Tests
{
    public class MovingTargetTests
    {
        private static readonly Rectangle PlayArea = new Rectangle(0, 0, 200, 100);
        private static readonly Size TargetSize = new Size(20, 20);

        [Fact]
        public void Move_AtZeroDegrees_TravelsRight()
        {
            var target = new MovingTarget(100, speed: 5, start: new Point(50, 50), angleDegrees: 0, PlayArea, TargetSize);

            Assert.Equal(new Point(55, 50), target.Move());
        }

        [Fact]
        public void Move_NeverLeavesThePlayArea()
        {
            var target = new MovingTarget(100, speed: 7, start: new Point(10, 10), angleDegrees: 37, PlayArea, TargetSize);

            for (int i = 0; i < 1000; i++)
            {
                Point p = target.Move();
                Assert.InRange(p.X, PlayArea.Left, PlayArea.Right - TargetSize.Width);
                Assert.InRange(p.Y, PlayArea.Top, PlayArea.Bottom - TargetSize.Height);
            }
        }

        [Fact]
        public void Move_BouncesOffTheRightEdge()
        {
            var target = new MovingTarget(100, speed: 10, start: new Point(175, 50), angleDegrees: 0, PlayArea, TargetSize);

            target.Move(); // hits the wall at x = 180
            Point afterBounce = target.Move();

            Assert.Equal(170, afterBounce.X);
        }

        [Fact]
        public void Hit_ReturnsPointsAndChangesDirection()
        {
            var target = new MovingTarget(200, speed: 10, start: new Point(100, 50), angleDegrees: 0, PlayArea, TargetSize);

            int points = target.Hit(180);

            Assert.Equal(200, points);
            Assert.Equal(new Point(90, 50), target.Move());
        }
    }
}
