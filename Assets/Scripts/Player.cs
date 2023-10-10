using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D m_rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Jump(){
        if (!GameManager.Ins) return;
        if (!m_rb || m_rb.velocity.y > 0) return;
        m_rb.velocity = new Vector2(m_rb.velocity.x, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Jump();
    }
}
