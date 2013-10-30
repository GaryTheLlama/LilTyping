﻿using System;
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
            Game game = new Game("Li'l Typing", 1000, 800);

            game.FirstScene = new BasicSpellingScene();
            
            game.Start();
        }
    }
}
