using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class MenuScene : Scene
    {
        public MenuScene() : base()
        {
            Entity e = new Entity();

            Image i = new Image(Resources.PaperLlamaLogo);
            
            i.CenterOrigin();
            i.X = Game.Instance.HalfWidth;
            i.Y = Game.Instance.HalfHeight;

            e.SetGraphic(i);
            
            Add(e);
        }

        public override void Update()
        {
            base.Update();

            if (Timer > 180)
            {
                Game.Instance.Scenes.Pop();
            }
        }
    }
}
