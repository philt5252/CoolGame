
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

        public static Vector2 Zero
        {
            get { return new Vector2(0,0); }
        }

        public static implicit operator PointF(Vector2 vector)
        {
            return new PointF(vector.X, vector.Y);
        }

        public static Vector2 operator +(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }

        public override string ToString()
        {
            return string.Format("X:{0}.Y:{1}", X, Y);
        }
    }
}