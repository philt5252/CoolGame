using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameEngine
{
    public partial class Level1 : GameLevel
    {
        private Ball ball = new Ball();

        public Level1()
        {
            InitializeComponent();

            //ball.Position = new Vector2(0, 0);
        }

        protected override void Update(TimeSpan elapsedTime)
        {
            base.Update(elapsedTime);

            ball.Position.X += 5f;
        }

        protected override void Draw(Graphics graphics)
        {
            graphics.DrawImage(ball.Image, ball.Position.X, ball.Position.Y);

            base.Draw(graphics);
        }
    }
}
