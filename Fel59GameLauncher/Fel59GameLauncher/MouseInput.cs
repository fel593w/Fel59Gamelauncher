using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fel59GameLauncher
{
    public static class MouseInput
    {
        public static MouseState mouse = new MouseState();
        public static MouseState mousePrev = new MouseState();


        public static void Update()
        {
            // stores previus state
            mousePrev = mouse;
            // gets status of the mouse
            mouse = Mouse.GetState();

            if (mouse.LeftButton == ButtonState.Released && mousePrev.LeftButton == ButtonState.Pressed)
            {
                Console.WriteLine("Left mouse button was released!");
            }
        }
    }
}
