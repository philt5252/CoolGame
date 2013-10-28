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
    }
}