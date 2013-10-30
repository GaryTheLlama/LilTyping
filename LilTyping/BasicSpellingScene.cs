using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public class BasicSpellingScene : Scene
    {
        public BasicSpellingScene() : base()
        {
            Add(new Player());
        }
    }
}
