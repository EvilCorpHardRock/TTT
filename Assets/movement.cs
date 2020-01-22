﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D m_Rigidbody2D;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.touchCount == 0)
        {
            m_Rigidbody2D.velocity = new Vector2(0, 0);
        }
        else {
            Vector2 touchposition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
           
           
            touchposition.x = touchposition.x - m_Rigidbody2D.position.x;
            touchposition.y = touchposition.y - m_Rigidbody2D.position.y;
            
            touchposition = touchposition.normalized*speed;
            

            m_Rigidbody2D.velocity = touchposition;
            


        }
    }
}
