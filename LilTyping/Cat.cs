using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class Cat : Entity
    {
        protected Image img;

        public Cat(float x, float y) : base()
        {
            img = new Image(Resources.CatSprite);

            SetGraphic(img);

            img.CenterOrigin();

            this.X = x;
            this.Y = y;

            img.Scale = 1;
            img.Visible = true;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
