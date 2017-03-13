using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ErstesProjekt
{
	internal class InputComponent : GameComponent
	{
		public Vector2 Direction
		{
			get;
			private set;
		}
		public InputComponent(Game1 game) : base(game)
		{
		}
		public override void Update(GameTime gameTime)
		{
			if (Keyboard.GetState().IsKeyDown(Keys.Left))
				Direction = new Vector2(-1f, 0f);
			if (Keyboard.GetState().IsKeyDown(Keys.Right))
				Direction = new Vector2(+1f, 0f);
			if (Keyboard.GetState().IsKeyDown(Keys.Up))
				Direction = new Vector2(0f, -1f);
			if (Keyboard.GetState().IsKeyDown(Keys.Down))
				Direction = new Vector2(0f, +1f);
			base.Update(gameTime);


}
	}
}
