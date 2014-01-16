using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class House : Entity
    {
        protected Image img;
        private RichText text;

        public House(float x, float y) : base()
        {
            img = new Image(Resources.HouseSprite);

            SetGraphic(img);

            img.CenterOrigin();

            this.X = x;
            this.Y = y;

            img.Scale = 1;
            img.Visible = true;

            text = new RichText("house", 64);
            text.X = Game.Instance.HalfWidth - img.HalfWidth / 2;
            text.Y = img.Height + 150;
            text.Color = Color.Red;
        }

        public override void Render()
        {
            base.Render();

            Draw.Graphic(text);
        }
        
        public override void Update()
        {
            base.Update();


        }
    }
}
