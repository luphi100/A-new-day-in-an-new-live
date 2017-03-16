using System;
using Microsoft.Xna.Framework;

namespace ErstesProjekt
{
	internal class Simulation : GameComponent
	{
		private Game1 game;
		private Vector2 ballVelocity = new Vector2(0.3f, 0.2f);
		public Vector2 BallPosition
		{
			get;
			private set;
		}
		public float PlayerPosition
		{
			get;
			private set;
		}
		public float PlayerSize
		{
			get;
			set;
		}
		public Simulation(Game1 game) : base(game)
		{
			this.game = game;
			BallPosition = new Vector2(0.3f, 0.2f);
			PlayerPosition = game.Input.Direction.Y * 0.1f;
			PlayerSize = 0.2f;
		}
		public override void Update(GameTime gameTime)
		{
			BallPosition += ballVelocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
			if (BallPosition.X > 1f)
			{
				ballVelocity *= new Vector2(-1f, 1f);
				BallPosition = new Vector2(1f, BallPosition.Y);
			}
			if (BallPosition.X < 0f)
			{
				ballVelocity *= new Vector2(-1f, 1f);
				BallPosition = new Vector2(0f, BallPosition.Y);
			}
			if (BallPosition.Y > 1f)
			{
				ballVelocity *= new Vector2(1f, -1f);
				BallPosition = new Vector2(BallPosition.X, 1f);
			}
			if (BallPosition.Y < 0f)
			{
				ballVelocity *= new Vector2(1f, -1f);
				BallPosition = new Vector2(BallPosition.X, 0f);
			}
				base.Update(gameTime);
			}
		}
	}

