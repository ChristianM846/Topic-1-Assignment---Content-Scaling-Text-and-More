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

        Texture2D sunflowerTecture;
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
            peashooterRect = new Rectangle(225, 240, 60, 70);
            wallnutRect = new Rectangle(325, 240, 60, 70);
            zombieRect = new Rectangle(425, 240, 60, 70);



            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundTexture = Content.Load<Texture2D>("Images/Frontyard");



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
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(backgroundTexture, backgroundRect, Color.White);
            _spriteBatch.Draw(backgroundTexture, sunflowerRect, Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
