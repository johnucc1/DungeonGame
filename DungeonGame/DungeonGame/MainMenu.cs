using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GuiCookie;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonGame
{
    class MainMenu : GuiContainer
    {
        public MainMenu(string GuiSheet, string StyleSheet, GameWindow Window, ContentManager Content, GraphicsDevice GraphicsDevice)
            :base(GuiSheet, StyleSheet, Window, Content, GraphicsDevice)
        {

        }

        public override void ButtonPressed(string message)
        {
            if (message == "peep")
                GetElementFromName("peep").Visible ^= true;

            base.ButtonPressed(message);
            Console.WriteLine(message);
        }
    }
}
