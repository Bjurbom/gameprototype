﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using gameprototype.menu;

namespace gameprototype.menu
{
    class Menu
    {
        SpriteFont textFont;
        SoundEffect backgroundMusic;

        public Menu(SpriteFont textFont, SoundEffect backgroundMusic)
        {
            this.textFont = textFont;
            this.backgroundMusic = backgroundMusic;
        }

        public void Update()
        {
            //backgroundMusic.Play();
        }


        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.DrawString(textFont,"Test", new Vector2(20,20),Color.White);
        }
    }
}
