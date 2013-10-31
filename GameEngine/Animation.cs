using System;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace GameEngine
{
    public abstract class Animation
    {
        protected Image CurrentAnimatedImage;

        private TimeSpan FrameTimeSpan
        {
            get
            {
                return TimeSpan.FromMilliseconds(1000/FramesPerSecond);
            }
        }

        public int FramesPerSecond { get; set; }

        protected TimeSpan CurrentTimeSpan { get; set; }

        protected Animation()
        {
            CurrentTimeSpan = TimeSpan.Zero;
            FramesPerSecond = 10;
        }

        public void Update(TimeSpan elapsedTime)
        {
            CurrentTimeSpan += elapsedTime;

            if (CurrentTimeSpan > FrameTimeSpan)
            {
                CurrentTimeSpan = TimeSpan.Zero;
                CurrentAnimatedImage = GetNextImage();
            }
        }

        public Image GetCurrentImage()
        {
            return CurrentAnimatedImage;
        }

        protected abstract Image GetNextImage();

        public virtual void Reset()
        {
            CurrentTimeSpan = TimeSpan.Zero;
        }
    }
}