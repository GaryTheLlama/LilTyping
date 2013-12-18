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
        private Image img;
        private Entity e;

        public MenuScene() : base()
        {
            e = new Entity();

            img = new Image(Resources.PaperLlamaLogo);
            
            img.CenterOrigin();
            img.X = Game.Instance.HalfWidth;
            img.Y = Game.Instance.HalfHeight;

            e.SetGraphic(img);
            
            Add(e);
        }

        public override void Update()
        {
            base.Update();
            
            if (Input.KeyPressed(Key.Any) || Timer > 180)
            {
                Tween(img, new { Alpha = 0 }, 30).Ease(Ease.SineOut);
                
                // Now clear the input string.
                Game.Instance.Input.ClearKeystring();
            }

            // Pop the splash screen once the alpha reaches zero.
            if (img.Alpha == 0)
            {
                Game.Instance.Scenes.Pop();
            }
        }
    }
}
