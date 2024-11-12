using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

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

        Texture2D orangeTribbleTexture;
        Rectangle orangetexturerect;
        Vector2 orangetribbleSpeed;

        Color backColor;

        Random rand = new Random();









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
            window = new Rectangle(0, 0, 800, 600);
            browntribbleSpeed = new Vector2(5, 2);

            creamtexturerect = new Rectangle(0, 0, 100, 200);
            window = new Rectangle(0, 0, 800, 600);
            creamtribbleSpeed = new Vector2(7, 2);

            orangetexturerect = new Rectangle(0, 0, 100, 200);
            window = new Rectangle(0, 0, 800, 600);
            orangetribbleSpeed = new Vector2(2, 10);



            backColor = Color.Aqua;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            greyTribbleTexture = Content.Load<Texture2D>("tribbleGrey");

            brownTribbleTexture = Content.Load<Texture2D>("tribbleBrown");

            creamTribbleTexture = Content.Load<Texture2D>("tribbleCream");

            orangeTribbleTexture = Content.Load<Texture2D>("tribbleOrange");




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
            {
                greytribbleSpeed.X *= -1;
               backColor = Color.Red;

            }

            if (greytexturerect.Bottom > window.Height || greytexturerect.Top < 0)
                greytribbleSpeed.Y *= -1;

            browntexturerect.X += (int)browntribbleSpeed.X;
            browntexturerect.Y += (int)browntribbleSpeed.Y;
            if (browntexturerect.Right > window.Width || browntexturerect.Left < 0)
                browntribbleSpeed.X *= -1;

            if (browntexturerect.Bottom > window.Height || browntexturerect.Top < 0)
                browntribbleSpeed.Y *= -1;



            creamtexturerect.X += (int)creamtribbleSpeed.X;
            creamtexturerect.Y += (int)creamtribbleSpeed.Y;
            if (creamtexturerect.Right > window.Width || creamtexturerect.Left < 0)
                creamtribbleSpeed.X *= -1;

            if (creamtexturerect.Bottom > window.Height || creamtexturerect.Top < 0)
                creamtribbleSpeed.Y *= -1;



            orangetexturerect.X += (int)orangetribbleSpeed.X;
            orangetexturerect.Y += (int)orangetribbleSpeed.Y;
            if (orangetexturerect.Right > window.Width || orangetexturerect.Left < 0)
                orangetribbleSpeed.X *= -1;

            if (orangetexturerect.Bottom > window.Height || orangetexturerect.Top < 0)
                orangetribbleSpeed.Y *= -1;








            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backColor);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(greyTribbleTexture,greytexturerect, Color.White);
            _spriteBatch.Draw(brownTribbleTexture, browntexturerect, Color.White);
            _spriteBatch.Draw(creamTribbleTexture, creamtexturerect, Color.White);
            _spriteBatch.Draw(orangeTribbleTexture, orangetexturerect, Color.White);

            _spriteBatch.End(); 

            base.Draw(gameTime);
        }
    }
}
