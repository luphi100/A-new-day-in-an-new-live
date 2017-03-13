using System;
using Microsoft.Xna.Framework;

namespace ErstesProjekt
{
	internal class Simulation : GameComponent
	{
		private Game1 game;
		public Vector2 Position
		{
			get;
			private set;
		}
		public Simulation(Game1 game):base(game)
		{
			this.game = game;
		}
		public override void Update(GameTime gameTime)
		{
			Position += game.Input.Direction;
			base.Update(gameTime);
		}
	}
}
