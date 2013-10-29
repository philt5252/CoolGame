using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameEngine
{
    public abstract class GameObject
    {
        public Vector2 Position { get; set; }
        public Image Image { get; set; }
    }
}
