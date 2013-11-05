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
            String title = String.Format("{0} {1}", Resources.GameTitle, Resources.Version);

            Game game = new Game(title, 1280, 720);

            List<Scene> sceneCollection = new List<Scene>() { new BasicSpellingScene(), new MenuScene() };

            game.AddScene(sceneCollection.ToArray());
            
            game.Start();
        }
    }
}
