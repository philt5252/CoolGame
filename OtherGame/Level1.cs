using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using GameEngine;

namespace OtherGame
{
    public partial class Level1 : GameLevel
    {
        Ball ball = new Ball();
        public Level1()
        {
            InitializeComponent();
            ball.Velocity.X = 4;
            ball.CurrentAnimation = "Idle";
        }

        protected override void Update(TimeSpan elapsedTime)
        {
            base.Update(elapsedTime);

            bool moved = false;

            if (inputManager.IsActionPressed("Right"))
            {
                ball.Velocity.X += 0.02f;
                moved = true;
            }

            if (inputManager.IsActionPressed("Left"))
            {
                ball.Velocity.X += -0.02f;
                moved = true;
            }

            if (inputManager.IsActionPressed("Up"))
            {
                ball.Velocity.Y += -0.02f;
                moved = true;
            }

            if (inputManager.IsActionPressed("Down"))
            {
                ball.Velocity.Y += 0.02f;
                moved = true;
            }

            if (inputManager.IsActionJustPressed("Pulse"))
            {
                if (ball.CurrentAnimation == "Pulse")
                    ball.CurrentAnimation = "Idle";
                else
                    ball.CurrentAnimation = "Pulse";
            }

            if (!moved)
            {
                ball.Velocity.X *= 0.95f;
                ball.Velocity.Y *= 0.95f;

                if (Math.Abs(ball.Velocity.X) < 0.01f)
                    ball.Velocity.X = 0;

                if ((Math.Abs(ball.Velocity.Y)) < 0.01f)
                    ball.Velocity.Y = 0;
            }
            

            ball.Update(elapsedTime);
        }

        protected override void Draw(Graphics graphics)
        {
            base.Draw(graphics);

            ball.Draw(graphics);
            graphics.DrawString("Velocity: " + ball.Velocity.ToString(), 
                new Font(new FontFamily(GenericFontFamilies.Monospace), 8.5f),
                new SolidBrush(Color.Black), 10,10 );
        }

        protected override void InitInputManagerActionKeys()
        {
            base.InitInputManagerActionKeys();

            inputManager.AddActionKey("Right", Keys.Right);
            inputManager.AddActionKey("Left", Keys.Left);
            inputManager.AddActionKey("Up", Keys.Up);
            inputManager.AddActionKey("Down", Keys.Down);
            inputManager.AddActionKey("Pulse", Keys.Space);
        }
    }
}
