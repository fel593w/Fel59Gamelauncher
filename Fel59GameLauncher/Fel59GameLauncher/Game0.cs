/*

using Downloader;
using MEngine.Core.ModuleSystems.EventBusSystems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fel59GameLauncher
{
    public class Game0 : Game
    {

        private SpriteBatch batch;

        public Game0()
        {
            GraphicsDeviceManager gdm = new GraphicsDeviceManager(this);

            // Typically you would load a config here...
            gdm.PreferredBackBufferWidth = 1000;
            gdm.PreferredBackBufferHeight = 600;
            gdm.IsFullScreen = false;
            gdm.SynchronizeWithVerticalRetrace = true;
            this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            /* This is a nice place to start up the engine, after
             * loading configuration stuff in the constructor
             */ /*
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Load textures, sounds, and so on in here...
            base.LoadContent();

            // Create the batch...
            batch = new SpriteBatch(GraphicsDevice);

            new EventBus().setAsInstance();

            TextureManeger.Content = Content;

            TextureManeger.loadTexture("FNATexture", "Content/FNATexture.png");
            TextureManeger.loadTexture("BlankButtonPressed", "Content/BlankButtonPressed.png");
            TextureManeger.loadTexture("BlankButtonDefault", "Content/BlankButtonDefault.png");

            TextureManeger.loadTexture("DownloadButtonDefault", "Content/DownloadButtonDefault.png");
            TextureManeger.loadTexture("DownloadButtonPressed", "Content/DownloadButtonPressed.png");

            TextureManeger.loadTexture("PlayButtonDefault", "Content/PlayButtonDefault.png");
            TextureManeger.loadTexture("PlayButtonPressed", "Content/PlayButtonPressed.png");


            // ui
            ButtonElement button0 = new ButtonElement();
           // button0.setEvent(Data => { DownloaderGoogleDrive.PlayButton_Click(); });
            button0.PressedButton = "PlayButtonPressed";
            button0.DefaultButton = "PlayButtonDefault";
            button0.position = new Vector2(500, 550);
            button0.Size = new Vector2(150, 60);
            Ui.Elements.Add(button0);
        }

        protected override void UnloadContent()
        {
            // Clean up after yourself!
            base.UnloadContent();

            batch.Dispose();
            TextureManeger.Dispose();
        }

        protected override void Update(GameTime gameTime)
        {
            // Run game logic in here. Do NOT render anything here!
            base.Update(gameTime);
            MouseInput.Update();
            Ui.Update();
        }

        protected override void Draw(GameTime gameTime)
        {
            // Render stuff in here. Do NOT run game logic in here!
            GraphicsDevice.Clear(Color.DarkSlateGray);
            base.Draw(gameTime);

            // Draw the texture to the corner of the screen
            batch.Begin();
            //batch.Draw(TextureManeger.Textures["FNATexture"], Vector2.Zero, Color.White);
            Ui.Draw(batch);
            batch.End();

            base.Draw(gameTime);
        }
    }
}

*/