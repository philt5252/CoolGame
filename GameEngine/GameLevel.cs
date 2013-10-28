using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameEngine
{
    public partial class GameLevel : UserControl
    {
        private DateTime lastTime;
        private Bitmap backBuffer;

        public GameLevel()
        {
            InitializeComponent();
            lastTime = DateTime.Now;
            DoubleBuffered = true;

            backBuffer = new Bitmap(ClientSize.Width, ClientSize.Height);

            this.Paint += Form1_Paint;
            this.Resize += Form1_CreateBackBuffer;
        }

        public void Start()
        {
            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Update(DateTime.Now - lastTime);

            if (backBuffer != null)
            {
                using (var g = Graphics.FromImage(backBuffer))
                {
                    g.Clear(Color.White);
                    Draw(g);
                }

                Invalidate();
            }

            lastTime = DateTime.Now;
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (backBuffer != null)
            {
                e.Graphics.DrawImageUnscaled(backBuffer, Point.Empty);
            }
        }

        void Form1_CreateBackBuffer(object sender, EventArgs e)
        {
            if (backBuffer != null)
                backBuffer.Dispose();

            backBuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        protected virtual void Draw(Graphics graphics)
        {
            
        }
        
        protected virtual void Update(TimeSpan elapsedTime)
        {
            
        }
    }
}
