using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ErstesProjekt
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	internal  class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		public InputComponent Input
		{
			get;
			private set;
		}
		public SceneComponent Scene
		{
			get;
			private set;
		}
		public Simulation Simulation
		{
			get;
			private set;
		}
		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

			Input = new InputComponent (this);
			Input.UpdateOrder = 0;
			Components.Add(Input);

			Scene = new SceneComponent(this);
			Scene.UpdateOrder = 1;
			Scene.DrawOrder = 0;
			Components.Add(Scene);
			Simulation = new Simulation(this);
			Simulation.UpdateOrder = 2;
			Components.Add(Simulation);
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{ //
		}

	
		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
	}
}
