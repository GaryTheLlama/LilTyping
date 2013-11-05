using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class Player : Entity
    {
        //Texture texture = new Texture("test.png");
        
        protected Image img = Image.CreateRectangle(100, 100);
        
        private float angle = 0.0f;

        public Player() : base()
        {
            SetGraphic(img);

            img.CenterOrigin();
            img.Visible = false;
        }

        public override void Update()
        {
            base.Update();

            img.Angle += angle * Game.DeltaTime;

            if (Input.KeyPressed(Key.Any))
            {
                img.Scale = 1;
                img.Visible = true;
                img.Color = Util.RandomColor();

                angle = Rand.Float(-4.0f, 4.0f);

                X = Util.RandomRange(0, Game.Scene.Width - 100);
                Y = Util.RandomRange(0, Game.Scene.Height - 100);

                var rect = Util.RandomRange(2, 5);

                Tween(img, new { ScaleX = rect, ScaleY = rect }, 30).Ease(Ease.ElasticOut);

                // Clear KeyString when Enter is pressed.
                if (Input.LastKey.ToString().Equals("Return"))
                {
                    Input.ClearKeystring();
                }
                
                if (Input.KeyString.ToLower().Equals("quit"))
                {
                    if (Game.Instance.Scenes.Count > 1)
                    {
                        Game.Instance.Scenes.Pop();
                    }
                    else
                    {
                        Game.Close();
                    }
                }
            }

            if (Timer % 6 == 0)
            {
                //img.Color = Util.RandomColor();
            }
        }
    }
}
