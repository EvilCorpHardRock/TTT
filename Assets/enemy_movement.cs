using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    Rigidbody2D m_Rigidbody2D;
    public float speed = 1;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


            Vector2 touchposition = Target.position;


            touchposition.x = touchposition.x - m_Rigidbody2D.position.x;
            touchposition.y = touchposition.y - m_Rigidbody2D.position.y;

            touchposition = touchposition.normalized * speed;


            m_Rigidbody2D.velocity = touchposition;



    }
}
