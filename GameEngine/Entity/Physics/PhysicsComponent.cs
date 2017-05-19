using System;
namespace GameEngine
{
	public class PhysicsComponent : Component
	{
		public PhysicsComponent()
		{
		}

		public void Update(float dt)
		{
			m_position += m_impulse / m_mass * dt;
			m_hitbox.SetPosition(m_position);
		}

		public void ApplyLinearImpulse(Vector impulse)
		{
			m_impulse += impulse;
		}

		public HitBox HitBox
		{
			get
			{
				return m_hitbox;
			}
			set
			{
				m_hitbox = value;
			}
		}

		public Vector Position
		{
			get
			{
				return m_position;
			}
		}

		private float m_mass = 0;
		private Vector m_impulse;
		private Vector m_position;
		private HitBox m_hitbox;
	}
}