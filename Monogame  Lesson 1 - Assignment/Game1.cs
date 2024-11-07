using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame__Lesson_1___Assignment
{
    public class Game1 : Game
    {
        
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D backTexture, yippeeTexture, grimaceTexture, pianoTexture, pipeTexture;
        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            yippeeTexture = Content.Load<Texture2D>("yippee");
            grimaceTexture = Content.Load<Texture2D>("GrimaceShake");
            pianoTexture = Content.Load<Texture2D>("Piano");
            pipeTexture = Content.Load<Texture2D>("MetalPipe");
            backTexture = Content.Load<Texture2D>("Background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(yippeeTexture, new Vector2(200, 100), Color.White);
            _spriteBatch.Draw(pianoTexture, new Vector2(250, 150), Color.White);
            _spriteBatch.Draw(pipeTexture, new Vector2(320, 200), Color.White);
            _spriteBatch.Draw(grimaceTexture, new Vector2(500, 200), Color.White);


            
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
