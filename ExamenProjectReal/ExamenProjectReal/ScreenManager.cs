using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace ExamenProjectReal
{
    static class ScreenManager
    {

        private static ContentManager contentmanager;

        private static Vector2 screenDimensions;

        private static GameScreen currentscreen;

        public static ContentManager Contentmanager { get => contentmanager; }
        public static Vector2 ScreenDimensions { get => screenDimensions; }

        public static void Initializa()
        {

        }

        public static void LoadContent(ContentManager contentManager)
        {

        }

        public static void UnloadContent()
        {

        }

        public static void Draw(SpriteBatch spriteBatch)
        {

        }


    }
}
