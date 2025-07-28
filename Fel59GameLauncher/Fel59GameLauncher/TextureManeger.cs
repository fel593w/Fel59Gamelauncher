using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Content;

namespace Fel59GameLauncher
{
    public static class TextureManeger
    {
        private static Dictionary<string, Texture2D> Textures = new Dictionary<string, Texture2D>();
        public static ContentManager Content;

        public static Texture2D getTexture(string name)
        {
            if (!Textures.ContainsKey(name)) 
                loadTexture(name, "Content\\" + name + ".png");
            if (!Textures.ContainsKey(name))
                return Textures["FNATexture"];
            return Textures[name];
        }

        public static void loadTexture(string name, string file)
        {
            if(File.Exists(file))
                Textures.Add(name, Content.Load<Texture2D>(file));
        }

        public static void Dispose()
        {
            foreach (Texture2D texture in Textures.Values)
            {
                texture.Dispose();
            }
        }
    }
}
