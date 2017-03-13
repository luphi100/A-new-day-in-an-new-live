using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ErstesProjekt
{
	internal class SceneComponent : DrawableGameComponent
	{
		private Texture2D star;
		private SpriteBatch spriteBatch;
		private Game1 game;
		public SceneComponent(Game1 game):base(game)
		{
			this.game = game;
		}
		protected override void LoadContent()
		{spriteBatch = new SpriteBatch(GraphicsDevice);
			star = Game.Content.Load<Texture2D>("starGold");
			base.LoadContent();
		}
		public override void Draw(GameTime gameTime)
		{GraphicsDevice.Clear(Color.CornflowerBlue);
			spriteBatch.Begin();
			spriteBatch.Draw(star, game.Simulation.Position, Color.White);
			spriteBatch.End();
			base.Draw(gameTime);
		}
	}
}
