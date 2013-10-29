using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
        }

        protected override void Update(TimeSpan elapsedTime)
        {
            base.Update(elapsedTime);

            if (inputManager.IsActionPressed("Right"))
            {
                koala.Position.X += 2;
            }
        }

        protected override void Draw(Graphics graphics)
        {
            base.Draw(graphics);

            graphics.DrawImage(koala.Image, koala.Position);
        }

        protected override void InitInputManagerActionKeys()
        {
            base.InitInputManagerActionKeys();

            inputManager.AddActionKey("Right", Key.D);
        }
    }
}
