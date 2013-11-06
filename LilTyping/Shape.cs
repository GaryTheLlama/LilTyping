using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class Shape : Entity
    {
        protected Image img = Image.CreateRectangle(100, 100);

        private float angle = 0.0f;

        public Shape(float x, float y) : base()
        {
            SetGraphic(img);

            img.CenterOrigin();
            
            this.X = x;
            this.Y = y;

            img.Scale = 1;
            img.Visible = true;
            img.Color = Util.RandomColor();

            angle = Rand.Float(-4.0f, 4.0f);
        }

        public override void Update()
        {
            base.Update();

            img.Angle += angle * Game.DeltaTime;
            
            //img.Y += Convert.ToSingle(Math.Sin(angle + img.X)) * Game.DeltaTime;

            //var rect = Util.RandomRange(2, 5);
            //Tween(img, new { ScaleX = rect, ScaleY = rect }, 30).Ease(Ease.ElasticOut);

            // Fade object out after five seconds.
            if (Timer == 300)
            {
                Tween(img, new { Alpha = 0 }, 60).Ease(Ease.SineOut);
            }

            // Remove object once alpha reaches zero.
            if (img.Alpha == 0)
            {
                RemoveSelf();
            }
        }
    }
}
