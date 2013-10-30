
using System.Drawing;
namespace GameEngine
{
    public class Vector2
    {
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Vector2()
        {
            X = Y = 0;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public static implicit operator PointF(Vector2 vector)
        {
            return new PointF(vector.X, vector.Y);
        }
    }
}