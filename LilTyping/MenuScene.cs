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
            Image i = new Image("test.png");

            e.SetGraphic(i);
            
            Add(e);
        }
    }
}
