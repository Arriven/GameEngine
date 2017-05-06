using System;
namespace GameEngine
{
	public class GameEntity
	{
		public GameEntity()
		{
		}

		public PhysicsComponent Physics
		{
			get
			{
				return m_physics;
			}
			set
			{
				m_physics = value;
			}
		}

		public RenderComponent Render
		{
			get
			{
				return m_render;
			}
			set
			{
				m_render = value;
			}
		}

		public AIComponent AI
		{
			get
			{
				return m_AI;
			}
			set
			{
				m_AI = value;
			}
		}

		private PhysicsComponent m_physics;
		private RenderComponent m_render;
		private AIComponent m_AI;
	}
}
