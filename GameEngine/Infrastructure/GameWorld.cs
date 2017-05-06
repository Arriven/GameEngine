using System;
namespace GameEngine
{
	public class GameWorld
	{
		public GameWorld()
		{
		}

		void Update(float dt)
		{
			m_physics.Update(dt);
		}

		private PhysicsWorld m_physics;
	}
}
