using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class Player : Entity
    {
        private ArrayList dictionary;
        private RichText text;
        private string currentWord;

        public Player() : base()
        {
            dictionary = new ArrayList();

            dictionary.Add("cat");
            dictionary.Add("dog");
            dictionary.Add("ball");
            dictionary.Add("boo");
            dictionary.Add("house");

            text = new RichText("", 64);
            text.X = 50;
            text.Y = 50;
            text.Color = Color.White;
        }

        public override void Render()
        {
            base.Render();

            Draw.Graphic(text);
        }

        public override void Update()
        {
            base.Update();

            // Must be called manually since the RichText object isn't associated with an Entity.
            text.Update();

            // Test out text effects.
            //text.String = "{waveAmpY:5}{waveRate:5}" + Input.KeyString;

            text.String = Input.KeyString;

            if (Input.KeyPressed(Key.Any))
            {
                /*if (Game.Scene.EntityCount < Resources.MaxNumShapes)
                {
                    Shape s = new Shape(Util.RandomRange(0, Game.Scene.Width - 100), Util.RandomRange(0, Game.Scene.Height - 100));
                    Game.Scene.Add<Shape>(s);
                }
                else if (Game.Scene.EntityCount == 100)
                {
                    Shape s = new Shape(Util.RandomRange(0, Game.Scene.Width - 100), Util.RandomRange(0, Game.Scene.Height - 100));
                    Game.Scene.Add<Shape>(s);
                }*/

                // StringBuilder may be faster, but no point in using it until I've profiled.
                //currentWord += Input.LastKey;
                currentWord += Input.LastKey.ToString().ToLower();

                Console.Write(currentWord.ToLower());

                // Clear KeyString when enter or spacebar is pressed.
                if (Input.LastKey.ToString().Equals("Return") || Input.LastKey.ToString().Equals("Space"))
                {
                    Input.ClearKeystring();

                    currentWord = "";
                }

                // Check current key string against dictionary of words.
                if (dictionary.Contains(currentWord.ToLower()))
                {
                    var entity = EntityFactory.GetEntity(currentWord);
                    Game.Instance.Scene.Add(entity);

                    /*switch (currentWord.ToLower())
                    {
                        case "cat":
                            // TODO: Highlight the text.
                            text.String = "";
                            Game.Instance.Scene.Add(new Cat(Game.HalfWidth, Game.HalfHeight));
                            break;
                        case "home":
                            Console.WriteLine("house");
                            Entity house = Game.Instance.Scene.GetClass<House>().First();
                            break;
                        case "boo":
                            Console.WriteLine("boo");
                            //text.String = "{waveAmpY:5}{waveRate:5}" + currentWord;
                            break;
                        default:
                            break;
                    }*/
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
