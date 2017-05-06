using System;
namespace GameEngine
{
	public class AIComponent
	{
		public AIComponent(GameEntity entity)
		{
			m_entity = entity;
		}

		public void Update(float dt)
		{
			m_entity.Physics.ApplyLinearImpulse(new Vector(0, 0));
		}

		private GameEntity m_entity;
	}
}
