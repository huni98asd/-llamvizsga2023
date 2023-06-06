using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{					
	[SerializeField] private float m_firstPositionX = 180f;	
	[SerializeField] private float m_firstPositionY = 100f;	
	[SerializeField] private float m_movmentX = 100f;
	[SerializeField] private float m_movmentY = 100f;
	[SerializeField] private bool m_AirControl = false;							
	[SerializeField] private LayerMask m_WhatIsGround;							
	[SerializeField] private Transform m_GroundCheck;							
	[SerializeField] private Transform m_CeilingCheck;							
	[SerializeField] private Collider2D m_CrouchDisableCollider;				

	const float k_GroundedRadius = .2f;
	private bool m_Grounded;           
	const float k_CeilingRadius = .2f; 
	private Rigidbody2D m_Rigidbody2D;
	private bool m_FacingRight = true;  
	


	[Header("Events")]
	[Space]

	public UnityEvent OnLandEvent;

	[System.Serializable]
	public class BoolEvent : UnityEvent<bool> { }

	public BoolEvent OnCrouchEvent;
	private bool m_wasCrouching = false;

	private void Awake()
	{
		m_Rigidbody2D = GetComponent<Rigidbody2D>();

		if (OnLandEvent == null)
			OnLandEvent = new UnityEvent();

		if (OnCrouchEvent == null)
			OnCrouchEvent = new BoolEvent();
	}

	private void FixedUpdate()
	{
		bool wasGrounded = m_Grounded;
		m_Grounded = false;

		Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
			{
				m_Grounded = true;
				if (!wasGrounded)
					OnLandEvent.Invoke();
			}
		}
	}

	
	public void Move(bool right, bool down, bool jump)
	{
		if (!down)
		{
			if (Physics2D.OverlapCircle(m_CeilingCheck.position, k_CeilingRadius, m_WhatIsGround))
			{
				down = true;
			}
		}

		if (m_Grounded || m_AirControl)
		{

			if (down)
			{
				if (!m_wasCrouching)
				{
					m_wasCrouching = true;
					OnCrouchEvent.Invoke(true);
				}

				

				if (m_CrouchDisableCollider != null)
					m_CrouchDisableCollider.enabled = false;
			} else
			{
				if (m_CrouchDisableCollider != null)
					m_CrouchDisableCollider.enabled = true;

				if (m_wasCrouching)
				{
					m_wasCrouching = false;
					OnCrouchEvent.Invoke(false);
				}
			}
		
			//Vector3 targetVelocity = new Vector2(move * 100f, m_Rigidbody2D.velocity.y);
			
			if (right == true)
			{
				m_firstPositionX = m_firstPositionX + m_movmentX;
				m_Rigidbody2D.position = new Vector2(m_firstPositionX, m_firstPositionY);
				
			};

			if (jump == true)
			{
				m_firstPositionX = m_firstPositionX + m_movmentX;
				m_firstPositionY = m_firstPositionY + m_movmentY;
				m_Rigidbody2D.position = new Vector2(m_firstPositionX, m_firstPositionY);
				
			};

			if (down == true)
			{
				m_firstPositionX = m_firstPositionX + m_movmentX;
				m_firstPositionY = m_firstPositionY - m_movmentY;
				m_Rigidbody2D.position = new Vector2(m_firstPositionX, m_firstPositionY);
				
			};

			if (right == true && !m_FacingRight)
			{
				Flip();
			}
			
			
		}
		
		if (m_Grounded && jump)
		{
			m_Grounded = false;
			//m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
			//m_Rigidbody2D.position = new Vector2(m_firstPositionX, m_firstPositionY);
			//m_firstPositionY = m_firstPositionY + m_movmentY;
		}
	}


	private void Flip()
	{
		m_FacingRight = !m_FacingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}