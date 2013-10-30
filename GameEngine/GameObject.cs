using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GameEngine
{
    public abstract class GameObject
    {
        private Vector2 size;
        private Image image;

        public Vector2 Position { get; set; }
        public Vector2 Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;

                if(Image != null)
                {
                    Image = new Bitmap(Image, new Size((int)size.X, (int)size.Y));
                }
            }
        }
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = new Bitmap(value, new Size((int)Size.X, (int)Size.Y));
            }
        }

        protected GameObject()
        {
            Position = new Vector2();
            Size = new Vector2(50, 50);
        }
    }

    public class MoveableGameObject : GameObject
    {
        public Vector2 Velocity { get; set; }

        public MoveableGameObject()
        {
            Velocity = Vector2.Zero;
        }

        public virtual void UpdatePositionFromVelocity(TimeSpan elapsedTime)
        {
            Position += Velocity;
        }
    }
}
