using UnityEngine;

public class ZombieCharacterControl : MonoBehaviour
{
    [SerializeField] private float m_moveSpeed = 2;
    [SerializeField] private float m_turnSpeed = 200;
    [SerializeField] private Animator m_animator = null;
    [SerializeField] private Rigidbody m_rigidBody = null;
    

    private readonly float m_interpolation = 10;
    private Vector3 m_currentDirection = Vector3.zero;

    private enum ControlMode
    {
        Tank,
        Direct
    }

    private void Awake()
    {
        if (!m_animator) { m_animator = GetComponent<Animator>(); }
        if (!m_rigidBody) { m_rigidBody = GetComponent<Rigidbody>(); }
    }

    private void FixedUpdate()
    {

    }

}
