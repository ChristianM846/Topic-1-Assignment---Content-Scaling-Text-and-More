using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_1_Assignment___Content__Scaling__Text__and_More
{
    //Christian Moyes
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        SpriteFont speechFont;

        Texture2D backgroundTexture;
        Rectangle backgroundRect;

        Texture2D sunflowerTexture;
        Rectangle sunflowerRect;

        Texture2D peashooterTexture;
        Rectangle peashooterRect;

        Texture2D wallnutTexture;
        Rectangle wallnutRect;

        Texture2D zombieTexture;
        Rectangle zombieRect;
        Rectangle zombieRect2;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Window.Title = "Soon";
            backgroundRect = new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);
            sunflowerRect = new Rectangle(175, 240, 60, 70);
            peashooterRect = new Rectangle(245, 240, 60, 70);
            wallnutRect = new Rectangle(390, 240, 60, 70);
            zombieRect = new Rectangle(635, 200, 95, 120);
            zombieRect2 = new Rectangle(585, 250, 95, 120);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            speechFont = Content.Load<SpriteFont>("Fonts/SpeechFont");
            backgroundTexture = Content.Load<Texture2D>("Images/Frontyard");
            sunflowerTexture = Content.Load<Texture2D>("Images/SunflowerSprite");
            peashooterTexture = Content.Load<Texture2D>("Images/PeashooterSprite");
            wallnutTexture = Content.Load<Texture2D>("Images/WallnutSprite");
            zombieTexture = Content.Load<Texture2D>("Images/BrownCoatSprite");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();



            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(backgroundTexture, backgroundRect, Color.White);
            _spriteBatch.Draw(sunflowerTexture, sunflowerRect, Color.White);
            _spriteBatch.Draw(peashooterTexture, peashooterRect, Color.White);
            _spriteBatch.Draw(wallnutTexture, wallnutRect, null, Color.White, 0f, new Vector2(0, 0), SpriteEffects.FlipVertically, 1f);
            _spriteBatch.Draw(zombieTexture, zombieRect, Color.White);
            _spriteBatch.Draw(zombieTexture, zombieRect2, null, Color.White * 0.5f, 1.57f, new Vector2(0,0), SpriteEffects.None, 1f);
            _spriteBatch.DrawString(speechFont, "Why is he on his head?", new Vector2(150, 210), Color.Black);
            _spriteBatch.DrawString(speechFont, "Gymnastics.", new Vector2(240, 325), Color.Black);
            _spriteBatch.DrawString(speechFont, "(Killed by the awesome power of the headstanding wallnut).", new Vector2(350, 330), Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
