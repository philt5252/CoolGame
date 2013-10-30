using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameEngine;

namespace RobinHoodGame
{
    public partial class Level1 : GameLevel
    {
        public Level1()
        {
            InitializeComponent();
        }
        protected override void Draw(Graphics graphics)
        {
            base.Draw(graphics);
        }
        protected override void Update(TimeSpan elapsedTime)
        {
            base.Update(elapsedTime);
        }
    }
}
