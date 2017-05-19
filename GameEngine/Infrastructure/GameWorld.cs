using System;
using System.Collections.Generic;
namespace GameEngine
{
	public class GameWorld
	{
		public GameWorld()
		{
		}

		public void Update(float dt)
		{
			foreach (var ai in m_AIs)
			{
				ai.Update(dt);
			}
			m_physics.Update(dt);
		}

		public PhysicsWorld Physics
		{
			get
			{
				return m_physics;
			}
		}

		public void AddAI(AIComponent ai)
		{
			m_AIs.Add(ai);
		}

		public void AddRenderable(RenderComponent renderable)
		{
			m_renderables.Add(renderable);
		}

		public void Render(ICanvas canvas)
		{
			foreach (RenderComponent renderable in m_renderables)
			{
				renderable.Render(canvas);
			}
		}

		private void CleanUp()
		{
			m_physics.CleanUp();
			m_AIs.RemoveAll((AIComponent obj) => obj.ShouldBeDestroyed);
			m_renderables.RemoveAll((RenderComponent obj) => obj.ShouldBeDestroyed);
		}

		private PhysicsWorld m_physics;
		private List<AIComponent> m_AIs;
		private List<RenderComponent> m_renderables;
	}
}
