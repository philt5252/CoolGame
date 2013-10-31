using System.Drawing;

namespace GameEngine
{
    public class ImageListAnimation : Animation
    {
        private readonly Image[] images;
        private int index = 0;

        public ImageListAnimation(params Image[] images)
        {
            this.images = images;
            CurrentAnimatedImage = images[0];
        }

        protected override Image GetNextImage()
        {
            index++;

            if (index >= images.Length)
                index = 0;

            return images[index];
        }

        public override void Reset()
        {
            base.Reset();

            index = 0;
        }
    }
}