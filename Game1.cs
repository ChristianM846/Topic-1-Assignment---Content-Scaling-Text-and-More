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
            zombieRect = new Rectangle(455, 230, 77, 90);



            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
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
            _spriteBatch.Draw(wallnutTexture, wallnutRect, Color.White);
            _spriteBatch.Draw(zombieTexture, zombieRect, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
