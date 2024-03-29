﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using gameprototype.menu;

namespace gameprototype
{

    //enum
    enum GameState { Menu, ingame, Pause }


    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {


        //overgame
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //menu
        SpriteFont text;
        Menu mu;
        SoundEffect menuBackgroundMusic;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            //setting fullscreen
            graphics.IsFullScreen = true;
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            StaticVaribels.gs = GameState.Menu;

            

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            text = Content.Load<SpriteFont>("font");

            mu = new Menu(text, menuBackgroundMusic);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            switch (StaticVaribels.gs)
            {
                default:
                    mu.Update();
                    break;
            };

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            switch(StaticVaribels.gs)
            {
                default:
                    spriteBatch.Begin();

                    mu.Draw(spriteBatch);

                    spriteBatch.End();
                    break;
            };
            


            base.Draw(gameTime);
        }
    }
}
