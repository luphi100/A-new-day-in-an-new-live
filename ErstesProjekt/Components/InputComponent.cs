using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ErstesProjekt
{
	internal class InputComponent : GameComponent
	{
		public Vector2 Direction;

		public InputComponent(Game1 game) : base(game)
		{
		}
		public override void Update(GameTime gameTime)
		{
			if (Keyboard.GetState().IsKeyDown(Keys.Up))
				Direction.Y += 5;
			if (Keyboard.GetState().IsKeyDown(Keys.Down))
				Direction.Y -= 5;
			base.Update(gameTime);


}
	}
}
