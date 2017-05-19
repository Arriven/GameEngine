using System;
using System.Collections.Generic;

namespace GameEngine
{
	public class PhysicsWorld
	{
		public PhysicsWorld()
		{
			m_physicsBodies = new List<PhysicsComponent>();
		}

		public void Update(float dt)
		{
			m_timer += dt;
			while (m_timer >= m_step)
			{
				m_timer -= m_step;
				MakeStep();
			}
		}

		public List<PhysicsComponent> Bodies
		{
			get
			{
				return m_physicsBodies;
			}
		}

		public void CleanUp()
		{
			m_physicsBodies.RemoveAll((PhysicsComponent obj) => obj.ShouldBeDestroyed);
		}

		public void AddBody(PhysicsComponent body)
		{
			m_physicsBodies.Add(body);
		}

		private void MakeStep()
		{
			foreach (var physicsBody in m_physicsBodies)
			{
				physicsBody.Update(m_step);
			}
		}

		private List<PhysicsComponent> m_physicsBodies;
		private float m_timer = 0;
		private const float m_step = 1 / 30.0f;
	}
}
