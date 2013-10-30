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

        //private static Session PlayerOne;

        private KeyboardController keyboard;

        Image img = Image.CreateRectangle(100, 100);

        String s = String.Empty;

        public Player() : base()
        {
            SetGraphic(img);
            img.CenterOrigin();

            keyboard = new KeyboardController();
            keyboard.A.AddKey(Key.A);
            keyboard.B.AddKey(Key.B);
            keyboard.C.AddKey(Key.Any);

            img.Visible = false;

            //PlayerOne = Game.AddSession("P1");
            //PlayerOne.Controller = kb;
        }

        public override void Update()
        {
            base.Update();

            if (Input.KeyPressed(Key.Any))
            {
                img.Scale = 1;

                img.Visible = true;
                X = Util.RandomRange(0, Game.Scene.Width - 100);
                Y = Util.RandomRange(0, Game.Scene.Height - 100);
                img.Color = Util.RandomColor();

                var rect = Util.RandomRange(2, 5);

                Tween(img, new { ScaleX = rect, ScaleY = rect }, 30).Ease(Ease.ElasticOut);

                if (Input.LastKey.ToString().Equals("Return"))
                {
                    Input.ClearKeystring();
                }
                
                // Keep track of input string.
                if (Input.KeyString.ToLower().Equals("quit"))
                {
                    Game.Close();
                }
            }

            if (Timer % 6 == 0)
            {
                //img.Color = Util.RandomColor();
            }
        }
    }
}
