using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameEngine
{
    public class AnimatableGameObject : MoveableGameObject
    {
        protected Dictionary<string, Animation> Animations = new Dictionary<string, Animation>();
        private string currentAnimation;

        public string CurrentAnimation
        {
            get { return currentAnimation; }
            set
            {
                ResetAnimation();
                currentAnimation = value;
                UpdateAnimation(TimeSpan.Zero);
            }
        }

        private void ResetAnimation()
        {
            if (CurrentAnimation == null)
                return;

            Animations[CurrentAnimation].Reset();
        }

        public virtual void Update(TimeSpan elapsedTime)
        {
            UpdatePositionFromVelocity(elapsedTime);
            UpdateAnimation(elapsedTime);
        }

        protected virtual void UpdateAnimation(TimeSpan elapsedTime)
        {
            Animations[CurrentAnimation].Update(elapsedTime);
            Image = Animations[CurrentAnimation].GetCurrentImage();
        }

        public virtual void Draw(Graphics graphics)
        {
            graphics.DrawImage(Image, Position);
        }
    }
}