using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game("Li'l Typing", 1280, 720);

            List<Scene> sceneCollection = new List<Scene>() { new BasicSpellingScene(), new MenuScene() };

            game.Scenes = new Stack<Scene>(sceneCollection);
            game.FirstScene = game.Scenes.Pop();
            
            game.Start();
        }
    }
}
