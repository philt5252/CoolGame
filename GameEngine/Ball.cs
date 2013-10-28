using System.Drawing;
using System.Windows.Forms;
using GameEngine.Properties;

namespace GameEngine
{
    public class Ball
    {
        public Image Image { get; set; }

        public Vector2 Position { get; set; }

        public Ball()
        {
            Image = Resources.goomba2d;
        }
    }
}