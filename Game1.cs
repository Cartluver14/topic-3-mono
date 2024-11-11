using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace topic_3_mono
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D greyTribbleTexture;
        Rectangle greytexturerect;
        Vector2 greytribbleSpeed;

        Texture2D brownTribbleTexture;
        Rectangle browntexturerect;
        Vector2 browntribbleSpeed;

        Texture2D creamTribbleTexture;
        Rectangle creamtexturerect;
        Vector2 creamtribbleSpeed;









        Rectangle window;


        public Game1()
        {

            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            greytexturerect = new Rectangle (0,0,100,200);
            window = new Rectangle(0, 0, 800, 600);
            greytribbleSpeed = new Vector2(2, 2);

            browntexturerect = new Rectangle(0, 0, 100, 200);
            window = new Rectangle(0, 0, 500, 300);
            browntribbleSpeed = new Vector2(0, 5);



            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            greyTribbleTexture = Content.Load<Texture2D>("tribbleGrey");

            brownTribbleTexture = Content.Load<Texture2D>("tribbleBrown");


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            greytexturerect.X += (int)greytribbleSpeed.X;
            greytexturerect.Y += (int)greytribbleSpeed.Y;
            if (greytexturerect.Right > window.Width || greytexturerect.Left < 0) 
                greytribbleSpeed.X *= -1;

            if (greytexturerect.Bottom > window.Height || greytexturerect.Top < 0)
                greytribbleSpeed.Y *= -1;

            browntexturerect.X += (int)browntribbleSpeed.X;
            browntexturerect.Y += (int)browntribbleSpeed.Y;
            if (browntexturerect.Right > window.Width || browntexturerect.Left < 0)
                browntribbleSpeed.X *= -1;

            if (browntexturerect.Bottom > window.Height || browntexturerect.Top < 0)
                browntribbleSpeed.Y *= -1;





            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(greyTribbleTexture,greytexturerect, Color.White);
            _spriteBatch.Draw(brownTribbleTexture, browntexturerect, Color.White);
            _spriteBatch.End(); 

            base.Draw(gameTime);
        }
    }
}
