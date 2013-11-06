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
        public Player() : base()
        {
        }

        public override void Update()
        {
            base.Update();

            if (Input.KeyPressed(Key.Any))
            {
                if (Game.Scene.EntityCount < Resources.MaxNumShapes)
                {
                    Shape s = new Shape(Util.RandomRange(0, Game.Scene.Width - 100), Util.RandomRange(0, Game.Scene.Height - 100));
                    Game.Scene.Add<Shape>(s);
                }
                else if (Game.Scene.EntityCount == 100)
                {
                    Shape s = new Shape(Util.RandomRange(0, Game.Scene.Width - 100), Util.RandomRange(0, Game.Scene.Height - 100));
                    Game.Scene.Add<Shape>(s);
                }

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
        }
    }
}
