using System;

namespace GameEngine
{
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