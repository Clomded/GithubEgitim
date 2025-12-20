using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;
    public float inputx,inputy,speed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        inputy = Input.GetAxis("Vertical") * speed;
        inputx = Input.GetAxis("Horizontal") * speed;
        Vector2 dir = new Vector2(inputx,inputy);
        dir = dir.normalized;

        rb.linearVelocity =  dir * speed;
    }

}
