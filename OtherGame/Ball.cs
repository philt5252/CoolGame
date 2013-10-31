using GameEngine;
using OtherGame.Properties;

namespace OtherGame
{
    public class Ball : AnimatableGameObject
    {
        public Ball()
        {
            Animations.Add("Idle", new ImageListAnimation(Resources.ball1, Resources.ball2,
                Resources.ball3, Resources.ball4, Resources.ball5, Resources.ball6));

            Animations.Add("Pulse",
                new ImageListAnimation(Resources.ball_mad1, Resources.ball_mad2, Resources.ball_mad3,
                    Resources.ball_mad4, Resources.ball_mad5, Resources.ball_mad6));
        }
    }
}