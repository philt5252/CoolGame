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
        Koala koala = new Koala();
        public Level1()
        {
            InitializeComponent();
            koala.Velocity.X = 4;
        }

        protected override void Update(TimeSpan elapsedTime)
        {
            base.Update(elapsedTime);

            if (inputManager.IsActionPressed("Right"))
            {
                koala.Velocity.X += 0.02f;
            }

            if (inputManager.IsActionPressed("Left"))
            {
                koala.Velocity.X += -0.02f;
            }

            if (inputManager.IsActionPressed("Up"))
            {
                koala.Velocity.Y += -0.02f;
            }

            if (inputManager.IsActionPressed("Down"))
            {
                koala.Velocity.Y += 0.02f;
            }

            koala.Velocity.X *= 0.99f;
            koala.Velocity.Y *= 0.99f;

            koala.Velocity.X = (float)Math.Round(koala.Velocity.X, 3);
            koala.Velocity.Y =(float) Math.Round(koala.Velocity.Y, 3);

            koala.UpdatePositionFromVelocity(elapsedTime);
        }

        protected override void Draw(Graphics graphics)
        {
            base.Draw(graphics);

            graphics.DrawImage(koala.Image, koala.Position);
            graphics.DrawString("Velocity: " + koala.Velocity.ToString(), 
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
        }
    }
}
